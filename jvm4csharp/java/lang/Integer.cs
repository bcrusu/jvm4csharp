namespace jvm4csharp.java.lang
{
    public partial class Integer
    {
        public static implicit operator int (Integer value)
        {
            return value.intValue();
        }

        public static implicit operator Integer(int value)
        {
            return new Integer(value);
        }
    }
}
