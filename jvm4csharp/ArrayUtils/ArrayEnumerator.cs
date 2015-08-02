using System.Collections;
using System.Collections.Generic;

namespace jvm4csharp.ArrayUtils
{
    internal class ArrayEnumerator<TElement> : IEnumerator<TElement>
    {
        private readonly ArrayBase<TElement> _array;
        private int _currentIndex;

        public ArrayEnumerator(ArrayBase<TElement> array)
        {
            _array = array;
        }

        public void Dispose()
        {
           Reset();
        }

        public bool MoveNext()
        {
            if (_currentIndex < _array.Length)
            {
                _currentIndex++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _currentIndex = 0;
        }

        public TElement Current
        {
            get { return _array[_currentIndex]; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }
    }
}
