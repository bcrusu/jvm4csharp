namespace jvm4csharp.ArrayUtils
{
    [JavaProxy(InternalClassName)]
    public sealed class LongArray : PrimitiveArray<long>
    {
        internal const string InternalClassName = "[J";

        public LongArray(int length) : base(length)
        {
        }

        public LongArray(long[] elements) : base(elements)
        {
        }

        public static implicit operator long[] (LongArray array)
        {
            return array?.GetElements();
        }

        public static implicit operator LongArray(long[] array)
        {
            return array == null ? null : new LongArray(array);
        }
    }
}
