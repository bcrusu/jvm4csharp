namespace jvm4csharp.java.lang
{
    public sealed partial class String : Object
    {
        internal const string JavaClassName = "java.lang.String";
        internal const string JavaInternalClassName = "java/lang/String";

        private string _clrString;

        internal String(JavaVoid jv) : base(jv)
        {
        }

        public static implicit operator string (String str)
        {
            return str?.ToString();
        }

        public static implicit operator String(string str)
        {
            return str == null ? null : JvmContext.Current.JniEnv.Strings.NewString(str);
        }

        public override String toString()
        {
            return this;
        }

        public override string ToString()
        {
            if (_clrString == null)
                _clrString = JvmContext.Current.JniEnv.Strings.ToClrString(this);
            return _clrString;
        }
    }
}
