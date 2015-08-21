namespace jvm4csharp.java.lang
{
    public partial class Boolean
    {
        public static implicit operator bool (Boolean value)
        {
            return value.booleanValue();
        }

        public static implicit operator Boolean(bool value)
        {
            return new Boolean(value);
        }
    }
}
