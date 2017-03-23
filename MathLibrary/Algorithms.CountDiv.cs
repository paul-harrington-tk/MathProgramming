using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static partial class Algorithms
    {
        /// <summary>
        /// Counts the divs.
        /// </summary>
        /// <param name="A">a.</param>
        /// <param name="B">The b.</param>
        /// <param name="K">The k.</param>
        /// <returns></returns>
        /// <example>
        /// let A = 2
        /// let B = 25
        /// let K = 4
        /// A = 101, B = 123M+, K = 10K
        /// A = 0, B = MAXINT, K in {1,MAXINT}
        /// 
        /// </example>
        public static int CountDivs(this int A, int B, int K)
        {
            var diffs = B/K - A/K;
            diffs += A%K == 0 ? 1 : 0;
            return diffs;
        }
    }
}
