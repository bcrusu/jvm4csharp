using System.Collections;
using System.Collections.Generic;
using jvm4csharp.java.lang;

namespace jvm4csharp.java.util
{
    public abstract partial class AbstractCollection<E>
    {
        public IEnumerator<E> GetEnumerator()
        {
            return new IterableEnumerator<E>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
