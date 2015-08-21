using System.Collections;
using System.Collections.Generic;
using jvm4csharp.java.lang;

namespace jvm4csharp.Arrays
{
    public abstract class ArrayBase<TElement> : Object, IEnumerable<TElement>
    {
        private int? _length;

        protected ArrayBase(int length) : base(ProxyCtor.I)
        {
            var tmpArray = JvmContext.Current.JniEnv.Arrays.NewArray<TElement>(length);
            ProxyState = tmpArray.ProxyState;
            _length = length;
        }

        public int Length
        {
            get
            {
                if (!_length.HasValue)
                    _length = JvmContext.Current.JniEnv.Arrays.GetArrayLength(this);
                return _length.Value;
            }
        }

        public abstract TElement this[int index] { get; set; }

        public virtual IEnumerator<TElement> GetEnumerator()
        {
            return new ArrayEnumerator<TElement>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
