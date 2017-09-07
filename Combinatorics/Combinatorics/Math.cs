namespace Combinatorics
{
    using System.Collections.Generic;
    public class Math
    {
        /// <summary>
        ///  Calculates greatest common divisor using Euclidean algorithm.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static ulong GreatesCommonDivisor(ulong x, ulong y)
        {
            ulong tmp;
            while (y != 0)
            {
                tmp = y;
                y = x % y;
                x = tmp;
            }
            return x;
        }

        /// <summary>
        ///  Calculates binomial coefficient.
        ///  The number of k-combinations from a given set S of n elements
        ///  Set S = {0,1,2,...,n-1}
        /// </summary>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static ulong Choose(ulong n, ulong k)
        {
            if (n < k) return 0;
            ulong r = 1;
            ulong g;
            ulong t;
            for (ulong d = 1; d <= k; ++d, --n)
            {
                g = GreatesCommonDivisor(r, d);
                r /= g;
                t = n / (d / g);
                r *= t;
            }
            return r;
        }

        /// <summary>
        /// Return the n-th lexicographic element of combination C(n,k)
        /// </summary>
        /// <param name="positon"></param>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static ICollection<uint> CombinationAt(ulong positon, uint n, uint k)
        {
            uint[] ans = new uint[k];

            uint a = n;
            uint b = k;
            ulong x = (Choose(n, k) - 1) - positon; // x is the "dual" of m

            for (long i = 0; i < k; ++i)
            {
                ans[i] = LargestV(a, b, x); // largest value v, where v &lt; a and vCb &lt; x    
                x = x - Choose(ans[i], b);
                a = ans[i];
                b = b - 1;
            }

            for (long i = 0; i < k; ++i)
            {
                ans[i] = (n - 1) - ans[i];
            }

            var set = new uint[k];
            for (uint i = 0; i < ans.Length; ++i)
                set[i] = ans[i];

            return set;
        }

        /// <summary>
        /// Finds largest value v where v &lt; a and  Choose(v,b) &lt;= x
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        private static uint LargestV(uint a, uint b, ulong x)
        {
            uint v = a - 1;
            while (Choose(v, b) > x)
                --v;
            return v;
        }
    }
}
