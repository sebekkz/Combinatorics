namespace Combinatorics.Helpers
{
    using System.Collections;
    using System.Collections.Generic;

    public class CombinationsEnumerator : IEnumerator<uint[]>
    {
        private static uint[] _set;
        private static uint _n;
        private static uint _k;
        private static uint _last;
        private bool _isFirstCombination;

        public uint[] Current => _set;

        object IEnumerator.Current => _set;

        public CombinationsEnumerator(uint n, uint k)
        {
            _n = n;
            _k = k;
            _last = _n - _k;
            Reset();
        }

        public bool MoveNext()
        {
            if (_set[0] == _last) return false;
            if (_isFirstCombination)
            {
                _isFirstCombination = false;
                return true;
            }

            uint i;
            for (i = _k - 1; i > 0 && _set[i] == _last + i; --i) ;
            ++_set[i];

            for (uint j = i; j < _k - 1; ++j)
                _set[j + 1] = _set[j] + 1;

            return true;
        }

        public void Reset()
        {
            _set = new uint[_k];
            for (uint i = 0; i < _k; ++i)
                _set[i] = i;
            _isFirstCombination = true;
        }

        public void Dispose() { }
        
    }
}
