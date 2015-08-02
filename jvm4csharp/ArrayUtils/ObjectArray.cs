namespace jvm4csharp.ArrayUtils
{
    public sealed class ObjectArray<TElement> : ArrayBase<TElement>
        where TElement : IJavaObject
    {
        public ObjectArray(int length) : base(length)
        {
        }
        
        public override TElement this[int index]
        {
            get { return JvmContext.Current.JniEnvWrapper.Arrays.GetObjectArrayElement<TElement>(this, index); }
            set { JvmContext.Current.JniEnvWrapper.Arrays.SetObjectArrayElement(this, index, value); }
        }
    }
}
