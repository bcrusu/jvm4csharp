using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using jvm4csharp.JniApiWrappers;

namespace jvm4csharp.Session
{
    internal class CurrentThread : IJvmThread
    {
        private readonly IJvmThreadProvider _jvmThreadProvider;
        private readonly SemaphoreSlim _lock = new SemaphoreSlim(1);
        private int _nativeThreadId;
        private JavaVmWrapper _javaVm;

        public CurrentThread(IJvmThreadProvider jvmThreadProvider)
        {
            Debug.Assert(jvmThreadProvider != null);
            _jvmThreadProvider = jvmThreadProvider;
        }

        public bool IsAttached { get; private set; }

        public Task<JvmSession> Attach(JavaVmWrapper javaVm)
        {
            Debug.Assert(javaVm != null);

            if (JvmContext.GetCurrentContext(false) != null)
                throw new InvalidOperationException("Current thread is already attached.");

            try
            {
                _lock.Wait();
                Thread.BeginThreadAffinity();

                if (IsAttached)
                    throw new InvalidOperationException("Already attached.");

                _javaVm = javaVm;
                _nativeThreadId = Win32Api.GetCurrentThreadId();

                var jniEnvWrapper = javaVm.AttachCurrentThread();

                var session = new JvmSession(jniEnvWrapper, this);
                JvmContext.SetCurrentContext(session.JvmContext);
                IsAttached = true;
                return Task.FromResult(session);
            }
            finally
            {
                Thread.EndThreadAffinity();
                _lock.Release();
            }
        }

        public Task Detach()
        {
            if (JvmContext.GetCurrentContext(false) == null)
                throw new InvalidOperationException("Current thread is not attached.");

            try
            {
                _lock.Wait();
                Thread.BeginThreadAffinity();

                if (!IsAttached)
                    throw new InvalidOperationException("Thread not attached.");

                var nativeThreadId = Win32Api.GetCurrentThreadId();
                if (nativeThreadId != _nativeThreadId)
                    throw new InvalidOperationException("Cannot detach current thread. 'Detach' must be called on the same OS thread as 'Attach' was called.");

                JvmContext.SetCurrentContext(null);

                _javaVm.DetachCurrentThread();
                _javaVm = null;
                IsAttached = false;

                _jvmThreadProvider.ReturnThread(this);
                return Task.FromResult(0);
            }
            finally
            {
                Thread.EndThreadAffinity();
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

        private Task<T> RunInternal<T>(Func<T> func)
        {
            try
            {
                _lock.Wait();
                Thread.BeginThreadAffinity();

                if (!IsAttached)
                    throw new InvalidOperationException("Thread not attached.");

                var nativeThreadId = Win32Api.GetCurrentThreadId();
                if (nativeThreadId != _nativeThreadId)
                    throw new InvalidOperationException("Cannot run on the current thread. 'Run' must be called on the same OS thread as 'Attach' was called.");

                var tsc = new TaskCompletionSource<T>();
                try
                {
                    var result = func();
                    tsc.SetResult(result);
                }
                catch (Exception e)
                {
                    tsc.SetException(e);
                }

                return tsc.Task;
            }
            finally
            {
                Thread.EndThreadAffinity();
                _lock.Release();
            }
        }

        public void Dispose()
        {
        }
    }
}
