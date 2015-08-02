using System;
using System.Runtime.InteropServices;

namespace jvm4csharp.JniApi
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public struct JniValue
    {
        [FieldOffset(0)]
        public byte Bool;

        [FieldOffset(0)]
        public byte Byte;

        [FieldOffset(0)]
        public char Char;

        [FieldOffset(0)]
        public short Short;

        [FieldOffset(0)]
        public int Int;

        [FieldOffset(0)]
        public long Long;

        [FieldOffset(0)]
        public float Float;

        [FieldOffset(0)]
        public double Double;

        [FieldOffset(0)]
        public IntPtr Object;
    }
}
