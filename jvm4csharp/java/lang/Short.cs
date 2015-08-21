namespace jvm4csharp.java.lang
{
    public partial class Short
    {
        public static implicit operator short (Short value)
        {
            return value.shortValue();
        }

        public static implicit operator Short(short value)
        {
            return new Short(value);
        }
    }
}
