using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using jvm4csharp.JniApiWrappers;
using jvm4csharp.Session;

namespace jvm4csharp
{
    public class JvmSession : IDisposable
    {
        internal readonly JniEnvWrapper JniEnvWrapper;
        internal readonly IJvmThread JvmThread;
        internal readonly JvmContext JvmContext;
        private int _disposed;

        internal JvmSession(JniEnvWrapper jniEnvWrapper, IJvmThread jvmThread)
        {
            Debug.Assert(jniEnvWrapper != null);
            Debug.Assert(jvmThread != null);

            JniEnvWrapper = jniEnvWrapper;
            JvmThread = jvmThread;
            JvmContext = new JvmContext(jniEnvWrapper);
        }

        ~JvmSession()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public void Close()
        {
            Dispose();
        }

        public async Task<T> Run<T>(Func<T> func)
        {
            CheckDisposed();
            return await JvmThread.Run(func);
        }

        public async Task Run(Action action)
        {
            CheckDisposed();
            await JvmThread.Run(action);
        }
        
        private void CheckDisposed()
        {
            if (_disposed == 1)
                throw new ObjectDisposedException("The JVM session was disposed.");
        }

        private void Dispose(bool disposing)
        {
            var disposed = Interlocked.CompareExchange(ref _disposed, 1, 0);
            if (disposed == 1)
                return;

            if (disposing)
            {
                JvmThread.Detach().Wait();
                GC.SuppressFinalize(this);
            }
            else
            {
                //TODO: on finalizer thread use timeout; destory VM if cannot dispose?
                JvmThread.Detach().Wait();
            }
        }
    }
}
