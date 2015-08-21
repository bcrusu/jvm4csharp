using System.Collections;
using System.Collections.Generic;

namespace jvm4csharp.Arrays
{
    internal class ArrayEnumerator<TElement> : IEnumerator<TElement>
    {
        private readonly ArrayBase<TElement> _array;
        private int _currentIndex;

        public ArrayEnumerator(ArrayBase<TElement> array)
        {
            _array = array;
            _currentIndex = -1;
        }

        public void Dispose()
        {
            Reset();
        }

        public bool MoveNext()
        {
            if (_currentIndex < _array.Length - 1)
            {
                _currentIndex++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            _currentIndex = -1;
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
