using System.Collections;
using System.Collections.Generic;
using jvm4csharp.java.lang;

namespace jvm4csharp.java.util
{
    public partial class ServiceLoader<S>
    {
        public IEnumerator<S> GetEnumerator()
        {
            return new IterableEnumerator<S>(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
