namespace jvm4csharp.Arrays
{
    [JavaProxy(InternalClassName)]
    public sealed class IntArray : PrimitiveArray<int>
    {
        internal const string InternalClassName = "[I";

        public IntArray(int length) : base(length)
        {
        }

        public IntArray(int[] elements) : base(elements)
        {
        }


        public static implicit operator int[] (IntArray array)
        {
            return array?.GetElements();
        }

        public static implicit operator IntArray(int[] array)
        {
            return array == null ? null : new IntArray(array);
        }
    }
}
