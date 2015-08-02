using System;

namespace jvm4csharp.JniApi
{
    internal static class JniBooleanValue
    {
        public const byte True = 1;
        public const byte False = 0;

        public static bool ToClrBool(byte value)
        {
            if (value == True)
                return true;

            if (value == False)
                return false;

            throw new ArgumentException($"Cannot convert boolean value '{value}'.");
        }

        public static bool[] ToClrBool(byte[] values)
        {
            var result = new bool[values.Length];
            for (var i = 0; i < values.Length; i++)
                result[i] = ToClrBool(values[i]);

            return result;
        }

        public static byte ToNativeBool(bool value)
        {
            return value ? True : False;
        }

        public static byte[] ToNativeBool(bool[] values)
        {
            var result = new byte[values.Length];
            for (var i = 0; i < values.Length; i++)
                result[i] = ToNativeBool(values[i]);

            return result;
        }
    }
}
