using System.Collections;
using System.Collections.Generic;
using jvm4csharp.java.util;

namespace jvm4csharp.java.lang
{
    internal class IterableEnumerator<T> : IEnumerator<T>
       where T : IJavaObject
    {
        private readonly Iterable<T> _iterable;
        private Iterator<T> _iterator;
        private T _next;

        public IterableEnumerator(Iterable<T> iterable)
        {
            _iterable = iterable;
        }

        public void Dispose()
        {
            Reset();
        }

        public bool MoveNext()
        {
            if (_iterator == null)
                _iterator = _iterable.iterator();

            var hasNext = _iterator.hasNext();
            if (hasNext)
                _next = _iterator.next();

            return hasNext;
        }

        public void Reset()
        {
            _iterator = null;
            _next = default(T);
        }

        public T Current
        {
            get { return _next; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
