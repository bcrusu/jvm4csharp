using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using jvm4csharp.JniApiWrappers;

namespace jvm4csharp.Session
{
    internal class PooledThread : IJvmThread
    {
        private readonly IJvmThreadProvider _jvmThreadProvider;
        private readonly int _id;
        private readonly SemaphoreSlim _lock = new SemaphoreSlim(1);

        private Thread _thread;
        private CancellationTokenSource _threadCancellationTokenSource;
        private CancellationToken _threadCancellationToken;
        private readonly BlockingCollection<Action> _actionQueue;
        private JavaVmWrapper _javaVm;

        public PooledThread(IJvmThreadProvider jvmThreadProvider, int id)
        {
            Debug.Assert(jvmThreadProvider != null);
            Debug.Assert(id > 0);

            _jvmThreadProvider = jvmThreadProvider;
            _id = id;
            _actionQueue = new BlockingCollection<Action>(new ConcurrentQueue<Action>());
        }

        public bool IsAttached { get; private set; }

        public Task<JvmSession> Attach(JavaVmWrapper javaVm)
        {
            Debug.Assert(javaVm != null);

            try
            {
                _lock.Wait();

                if (IsAttached)
                    throw new InvalidOperationException("Already attached.");

                EnsureThreadCreated();

                var tsc = new TaskCompletionSource<JvmSession>();
                Action action = () =>
                {
                    try
                    {
                        var result = AttachActionBody(javaVm);
                        tsc.SetResult(result);
                    }
                    catch (Exception e)
                    {
                        tsc.SetException(e);
                    }
                };

                _actionQueue.Add(action, _threadCancellationToken);
                return tsc.Task;
            }
            finally
            {
                _lock.Release();
            }
        }

        public Task Detach()
        {
            try
            {
                _lock.Wait();

                if (!IsAttached)
                    throw new InvalidOperationException("Thread not attached.");

                var tsc = new TaskCompletionSource<int>();
                Action action = () =>
                {
                    try
                    {
                        DetachActionBody();
                        tsc.SetResult(0);
                    }
                    catch (Exception e)
                    {
                        tsc.SetException(e);
                    }
                };

                _actionQueue.Add(action, _threadCancellationToken);
                return tsc.Task;
            }
            finally
            {
                _lock.Release();
            }
        }

        public async Task<T> Run<T>(Func<T> func)
        {
            return await RunInternal(func);
        }

        public async Task Run(Action action)
        {
            await RunInternal(() =>
            {
                action();
                return 0;
            });
        }

        private JvmSession AttachActionBody(JavaVmWrapper javaVm)
        {
            _javaVm = javaVm;

            var jniEnvWrapper = javaVm.AttachCurrentThread();

            var session = new JvmSession(jniEnvWrapper, this);
            JvmContext.SetCurrentContext(session.JvmContext);
            IsAttached = true;
            return session;
        }

        private void DetachActionBody()
        {
            JvmContext.SetCurrentContext(null);

            _javaVm.DetachCurrentThread();
            _javaVm = null;
            IsAttached = false;

            _jvmThreadProvider.ReturnThread(this);
        }

        private Task<T> RunInternal<T>(Func<T> func)
        {
            try
            {
                _lock.Wait();

                if (!IsAttached)
                    throw new InvalidOperationException("Thread not attached.");

                var tsc = new TaskCompletionSource<T>();
                Action action = () =>
                {
                    try
                    {
                        var result = func();
                        tsc.SetResult(result);
                    }
                    catch (Exception e)
                    {
                        tsc.SetException(e);
                    }
                };

                _actionQueue.Add(action, _threadCancellationToken);
                return tsc.Task;
            }
            finally
            {
                _lock.Release();
            }
        }

        private void EnsureThreadCreated()
        {
            if (_thread != null)
                return;

            _threadCancellationTokenSource = new CancellationTokenSource();
            _threadCancellationToken = _threadCancellationTokenSource.Token;

            _thread = new Thread(ThreadBody);
            _thread.Name = "JVM PooledThread #" + _id;
            _thread.IsBackground = true;

            var currentThread = Thread.CurrentThread;
            _thread.CurrentCulture = currentThread.CurrentCulture;
            _thread.CurrentUICulture = currentThread.CurrentUICulture;
            _thread.Priority = currentThread.Priority;

            _thread.Start();
        }

        private void ThreadBody()
        {
            try
            {
                Thread.BeginThreadAffinity();

                while (true)
                {
                    if (_threadCancellationToken.IsCancellationRequested)
                        break;

                    try
                    {
                        var action = _actionQueue.Take(_threadCancellationToken);
                        action();
                    }
                    catch (OperationCanceledException)
                    {
                        break;
                    }
                }
            }
            finally
            {
                Thread.EndThreadAffinity();
            }
        }

        public void Dispose()
        {
            if (IsAttached)
                throw new InvalidOperationException("Cannot dispose attached thread.");

            _threadCancellationTokenSource.Cancel();
        }
    }
}
