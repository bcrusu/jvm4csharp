using System.Runtime.InteropServices;

namespace jvm4csharp.Session
{
    internal static class Win32Api
    {
        [DllImport("kernel32.dll")]
        public static extern int GetCurrentThreadId();
    }
}
