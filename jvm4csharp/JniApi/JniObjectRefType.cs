namespace jvm4csharp.JniApi
{
    internal enum JniObjectRefType
    {
        InvalidRefType = 0,
        LocalRefType = 1,
        GlobalRefType = 2,
        WeakGlobalRefType = 3
    }
}