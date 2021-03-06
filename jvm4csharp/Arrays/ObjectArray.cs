﻿namespace jvm4csharp.Arrays
{
    public sealed class ObjectArray<TElement> : ArrayBase<TElement>
        where TElement : IJavaObject
    {
        public ObjectArray(int length) : base(length)
        {
        }
        
        public override TElement this[int index]
        {
            get { return JvmContext.Current.JniEnv.Arrays.GetObjectArrayElement<TElement>(this, index); }
            set { JvmContext.Current.JniEnv.Arrays.SetObjectArrayElement(this, index, value); }
        }
    }
}
