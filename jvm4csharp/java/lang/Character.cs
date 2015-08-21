namespace jvm4csharp.java.lang
{
    public partial class Character
    {
        public static implicit operator char (Character value)
        {
            return value.charValue();
        }

        public static implicit operator Character(char value)
        {
            return new Character(value);
        }
    }
}
