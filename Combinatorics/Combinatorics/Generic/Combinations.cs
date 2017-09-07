namespace Combinatorics.Generic
{
    using Combinatorics.Helpers;
    using System.Collections;
    using System.Collections.Generic;
    using Combinatorics;

    public class Combinations<T> : IEnumerable<T[]>
    {
        private Combinations _combinations;

        private T[] _set;

        /// <summary>
        /// Number of sample points in set
        /// </summary>
        public uint N => _combinations.N;

        /// <summary>
        /// Number of sample points in each combination
        /// </summary>
        public uint K => _combinations.K;

        /// <summary>
        /// Number of combinations
        /// </summary>
        public ulong Count => _combinations.Count;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        public Combinations(T[] set, uint k)
        {
            _combinations = new Combinations((uint)set.Length, k);
            _set = set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        public Combinations(ICollection<T> set, uint k)
        {
            _combinations = new Combinations((uint)set.Count, k);
            _set = new T[set.Count];
            set.CopyTo(_set, 0);
        }

        /// <summary>
        ///  Return the n-th lexicographic element of combination
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public ICollection<T> ElementAt(ulong position)
        {
            return Convert(Combinatorics.Math.CombinationAt(position, N, K));
        }

        private ICollection<T> Convert(ICollection<uint> positions)
        {
            T[] returnSet = new T[positions.Count];
            uint[] pos = new uint[positions.Count];
            positions.CopyTo(pos, 0);
            for (var i = 0; i < pos.Length; i++)
            {
                returnSet[i] = _set[pos[i]];
            }
            return returnSet;
        }

        public CombinationsGenericEnumerator<T> GetEnumerator()
        {
            return new CombinationsGenericEnumerator<T>(_set, _combinations.K);
        }

        IEnumerator<T[]> IEnumerable<T[]>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
