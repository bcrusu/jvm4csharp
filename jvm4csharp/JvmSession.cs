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

        public bool IsAttached
        {
            get { return JvmThread.IsAttached; }
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
            CheckIsAlive();
            return await JvmThread.Run(func);
        }

        public async Task Run(Action action)
        {
            CheckIsAlive();
            await JvmThread.Run(action);
        }

        private void CheckIsAlive()
        {
            if (_disposed == 1)
                throw new ObjectDisposedException("The JVM session was disposed.");

            if (!IsAttached)
                throw new InvalidOperationException("The JVM session is not attached.");
        }

        private void Dispose(bool disposing)
        {
            var disposed = Interlocked.CompareExchange(ref _disposed, 1, 0);
            if (disposed == 1)
                return;

            JvmThread.Detach().Wait();

            if (disposing)
                GC.SuppressFinalize(this);
        }
    }
}
