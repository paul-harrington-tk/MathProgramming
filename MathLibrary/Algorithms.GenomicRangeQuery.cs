using System;

namespace MathLibrary
{
    public static partial class Algorithms
    {
        private static int[] ToImpactArray(this string genomeString)
        {
            var n = genomeString.Length;
            var iString = genomeString.Replace('A', '1').Replace('C', '2').Replace('G', '3').Replace('T', '4');
            var res = new int[n];

            for (var i = 0; i < n; i++)
            {
                res[i] = (int)char.GetNumericValue(iString[i]);
            }
            
            return res;
        }

        public static int[] GenomicRangeQuery(this string S, int[] P, int[] Q)
        {
            if (string.IsNullOrEmpty(S))
                throw new ArgumentException("No genome string provided", nameof(S));
            if (P.Length != Q.Length)
                throw new ArgumentException("Range Mismatch", nameof(P));
            int m = P.Length;

            var res = new int[m];
            for (int i = 0; i < res.Length; i++)
                res[i] = 4;
            var impactRange = S.ToImpactArray();

            for (var i = 0; i < m; i++)
            {
                var start = Math.Min(P[i], Q[i]);
                var end = Math.Max(P[i], Q[i]);
                for (int j = start; j <= end; j++)
                {
                    if (res[i] > impactRange[j])
                        res[i] = impactRange[j];
                }
            }

            return res;
        }
    }
}
