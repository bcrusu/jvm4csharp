namespace jvm4csharp.ArrayUtils
{
    [JavaProxy(InternalClassName)]
    public sealed class ByteArray : PrimitiveArray<byte>
    {
        internal const string InternalClassName = "[B";

        public ByteArray(int length) : base(length)
        {
        }

        public ByteArray(byte[] elements) : base(elements)
        {
        }

        public static implicit operator byte[] (ByteArray array)
        {
            return array?.GetElements();
        }

        public static implicit operator ByteArray(byte[] array)
        {
            return array == null ? null : new ByteArray(array);
        }
    }
}
