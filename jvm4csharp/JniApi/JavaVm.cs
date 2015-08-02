using System.Runtime.InteropServices;

namespace jvm4csharp.JniApi
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct JavaVm
    {
        public unsafe JniInvokeInterface* functions;
    }
}
