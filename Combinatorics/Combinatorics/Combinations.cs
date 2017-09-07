namespace Combinatorics
{
    using Combinatorics.Helpers;
    using System.Collections;
    using System.Collections.Generic;

    public class Combinations : IEnumerable<uint[]>
    {
        /// <summary>
        /// Number of sample points in set
        /// </summary>
        public uint N => _n;
        private static uint _n;

        /// <summary>
        /// Number of sample points in each combination
        /// </summary>
        public uint K => _k;
        private static uint _k;

        /// <summary>
        /// Number of combinations
        /// </summary>
        public ulong Count => (_count > 0 ? _count : (_count = Math.Choose(_n, _k)));
        private ulong _count;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        public Combinations(uint n, uint k)
        {
            _n = n;
            _k = k;
        }

        public CombinationsEnumerator GetEnumerator()
        {
            return new CombinationsEnumerator(_n, _k);
        }

        IEnumerator<uint[]> IEnumerable<uint[]>.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        ///  Return the n-th lexicographic element of combination
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public ICollection<uint> ElementAt(ulong position)
        {
            return Math.CombinationAt(position, _n, _k);
        }
    }
}
