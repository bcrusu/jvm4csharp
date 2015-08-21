namespace jvm4csharp.java.lang
{
    public partial class Long
    {
        public static implicit operator long (Long value)
        {
            return value.longValue();
        }

        public static implicit operator Long(long value)
        {
            return new Long(value);
        }
    }
}
