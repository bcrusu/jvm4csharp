namespace jvm4csharp.ArrayUtils
{
    [JavaProxy(InternalClassName)]
    public sealed class FloatArray : PrimitiveArray<float>
    {
        internal const string InternalClassName = "[F";

        public FloatArray(int length) : base(length)
        {
        }

        public FloatArray(float[] elements) : base(elements)
        {
        }

        public static implicit operator float[] (FloatArray array)
        {
            return array?.GetElements();
        }

        public static implicit operator FloatArray(float[] array)
        {
            return array == null ? null : new FloatArray(array);
        }
    }
}
