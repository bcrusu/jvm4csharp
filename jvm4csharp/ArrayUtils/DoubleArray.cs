namespace jvm4csharp.ArrayUtils
{
    [JavaProxy(InternalClassName)]
    public sealed class DoubleArray : PrimitiveArray<double>
    {
        internal const string InternalClassName = "[D";

        public DoubleArray(int length) : base(length)
        {
        }

        public DoubleArray(double[] elements) : base(elements)
        {
        }

        public static implicit operator double[] (DoubleArray array)
        {
            return array?.GetElements();
        }

        public static implicit operator DoubleArray(double[] array)
        {
            return array == null ? null : new DoubleArray(array);
        }
    }
}
