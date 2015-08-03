using System;

namespace jvm4csharp.ArrayUtils
{
    public abstract class PrimitiveArray<TElement> : ArrayBase<TElement>
    {
        internal PrimitiveArray(int length) : base(length)
        {
        }

        internal PrimitiveArray(TElement[] elements) : this(elements.Length)
        {
            if (elements == null) throw new ArgumentNullException(nameof(elements));
            // ReSharper disable once DoNotCallOverridableMethodsInConstructor; all subclasses are sealed
            SetRegion(0, elements.Length, elements);
        }

        public override TElement this[int index]
        {
            get { return GetRegion(index, 1)[0]; }
            set { SetRegion(index, 1, new[] { value }); }
        }

        public TElement[] GetRegion(int startIndex, int length)
        {
            return JvmContext.Current.JniEnv.Arrays.GetArrayRegion<TElement>(this, startIndex, length);
        }

        public TElement[] GetElements()
        {
            return GetRegion(0, Length);
        }

        public void SetRegion(int startIndex, int length, TElement[] buffer)
        {
            JvmContext.Current.JniEnv.Arrays.SetArrayRegion(this, startIndex, length, buffer);
        }
    }
}
