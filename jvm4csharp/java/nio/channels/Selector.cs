namespace jvm4csharp.java.nio.channels
{
    public abstract partial class Selector
    {
        public void Dispose()
        {
            close();
        }
    }
}
