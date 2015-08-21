using System.Collections;
using System.Collections.Generic;
using jvm4csharp.java.lang;

namespace jvm4csharp.java.util.concurrent
{
    public partial class CopyOnWriteArrayList<E>
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
