using System.Runtime.InteropServices;

namespace jvm4csharp.JniApi
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct JniEnv
    {
        public unsafe JniNativeInterface* functions;
    }
}
