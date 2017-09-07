namespace Combinatorics.Helpers
{
    using System.Collections;
    using System.Collections.Generic;

    public class CombinationsGenericEnumerator<T> : IEnumerator<T[]>
    {

        private static CombinationsEnumerator _enumarator;

        private static T[] _set;

        public T[] Current => Convert(_enumarator.Current);

        object IEnumerator.Current => Convert(_enumarator.Current);

        public CombinationsGenericEnumerator(T[] set, uint k)
        {
            _enumarator = new CombinationsEnumerator((uint)set.Length, k);
            _set = set;
        }

        private T[] Convert(uint[] positions)
        {
            T[] returnSet = new T[positions.Length];
            for(var i = 0; i < positions.Length; i++)
            {
                returnSet[i] = _set[positions[i]];
            }
            return returnSet;
        }

        public void Dispose()
        {
            _enumarator.Dispose();
        }

        public bool MoveNext()
        {
            return _enumarator.MoveNext();
        }

        public void Reset()
        {
            _enumarator.Reset();
        }
    }
}
