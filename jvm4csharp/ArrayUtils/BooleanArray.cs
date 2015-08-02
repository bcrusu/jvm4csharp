namespace jvm4csharp.ArrayUtils
{
    [JavaProxy(InternalClassName)]
    public sealed class BooleanArray : PrimitiveArray<bool>
    {
        internal const string InternalClassName = "[Z";

        public BooleanArray(int length) : base(length)
        {
        }

        public BooleanArray(bool[] elements) : base(elements)
        {
        }

        public static implicit operator bool[] (BooleanArray array)
        {
            return array?.GetElements();
        }

        public static implicit operator BooleanArray(bool[] array)
        {
            return array == null ? null : new BooleanArray(array);
        }
    }
}
