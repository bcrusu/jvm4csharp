using System.Runtime.InteropServices;

namespace jvm4csharp.JniApi
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct JavaVmInitArgs
    {
        public int version;

        public int nOptions;

        public unsafe JavaVmOption* options;

        public byte ignoreUnrecognized;
    }
}
