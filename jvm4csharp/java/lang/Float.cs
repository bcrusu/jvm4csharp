namespace jvm4csharp.java.lang
{
    public partial class Float
    {
        public static implicit operator float (Float value)
        {
            return value.floatValue();
        }

        public static implicit operator Float(float value)
        {
            return new Float(value);
        }
    }
}
