using System;

namespace jvm4csharp.Session
{
    internal interface IJvmThreadProvider : IDisposable
    {
        IJvmThread GetThread();

        void ReturnThread(IJvmThread thread);
    }
}
