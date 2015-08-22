namespace jvm4csharp.java.nio.channels.spi
{
    public partial class AbstractInterruptibleChannel
    {
        public void Dispose()
        {
            close();
        }
    }
}
