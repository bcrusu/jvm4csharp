namespace jvm4csharp.java.io
{
    public abstract partial class OutputStream
    {
        public void Dispose()
        {
            close();
        }
    }
}
