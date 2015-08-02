using System;
using System.Diagnostics;

namespace jvm4csharp.Session
{
    internal class CurrentThreadProvider : IJvmThreadProvider
    {
        public IJvmThread GetThread()
        {
            return new CurrentThread(this);
        }

        public void ReturnThread(IJvmThread thread)
        {
            Debug.Assert(thread != null);

            if (thread.IsAttached)
                throw new InvalidOperationException("Invalid thread state. Cannot return attached thread.");

            thread.Dispose();
        }

        public void Dispose()
        {
        }
    }
}
