using System.Collections;
using System.Collections.Generic;
using jvm4csharp.java.lang;

// ReSharper disable InconsistentNaming
namespace jvm4csharp.java.util.concurrent
{
    public partial class ConcurrentHashMap_
    {
        public partial class KeySetView<K, V>
        {
            public IEnumerator<K> GetEnumerator()
            {
                return new IterableEnumerator<K>(this);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
