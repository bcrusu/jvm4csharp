namespace jvm4csharp
{
    public sealed class ProxyCtor
    {
        private ProxyCtor() { }

        public static readonly ProxyCtor I = new ProxyCtor();
    }
}
