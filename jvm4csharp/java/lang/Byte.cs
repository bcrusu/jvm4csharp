namespace jvm4csharp.java.lang
{
    public partial class Byte
    {
        public static implicit operator byte (Byte value)
        {
            return value.byteValue();
        }

        public static implicit operator Byte(byte value)
        {
            return new Byte(value);
        }
    }
}
