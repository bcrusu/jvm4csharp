namespace jvm4csharp.Arrays
{
    [JavaProxy(InternalClassName)]
    public sealed class CharArray : PrimitiveArray<char>
    {
        internal const string InternalClassName = "[C";

        public CharArray(int length) : base(length)
        {
        }

        public CharArray(char[] elements) : base(elements)
        {
        }

        public static implicit operator char[] (CharArray array)
        {
            return array?.GetElements();
        }

        public static implicit operator CharArray (char[] array)
        {
            return array == null ? null : new CharArray(array);
        }
    }
}
