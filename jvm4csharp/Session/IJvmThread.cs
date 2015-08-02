using System;
using System.Threading.Tasks;
using jvm4csharp.JniApiWrappers;

namespace jvm4csharp.Session
{
    internal interface IJvmThread : IDisposable
    {
        bool IsAttached { get; }

        Task<JvmSession> Attach(JavaVmWrapper javaVm);

        Task Detach();

        Task<T> Run<T>(Func<T> func);

        Task Run(Action action);
    }
}
