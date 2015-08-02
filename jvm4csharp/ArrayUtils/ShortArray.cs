namespace jvm4csharp.ArrayUtils
{
    [JavaProxy(InternalClassName)]
    public sealed class ShortArray : PrimitiveArray<short>
    {
        internal const string InternalClassName = "[S";

        public ShortArray(int length) : base(length)
        {
        }

        public ShortArray(short[] elements) : base(elements)
        {
        }

        public static implicit operator short[] (ShortArray array)
        {
            return array?.GetElements();
        }

        public static implicit operator ShortArray(short[] array)
        {
            return array == null ? null : new ShortArray(array);
        }
    }
}
