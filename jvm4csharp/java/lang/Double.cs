namespace jvm4csharp.java.lang
{
    public partial class Double
    {
        public static implicit operator double (Double value)
        {
            return value.doubleValue();
        }

        public static implicit operator Double(double value)
        {
            return new Double(value);
        }
    }
}
