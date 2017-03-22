using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    using System.Text.RegularExpressions;

    public static partial class Algorithms
    {
        private const string RegexBinarayGapString = @"(?<=1)(0+)(?=1)";
        public static int BinaryGapRegex(this int i)

        {
            var binaryString = Convert.ToString(i, 2);
            var regexp = new Regex(RegexBinarayGapString);
            return
                regexp.Matches(binaryString)
                    .Cast<Match>()
                    .Select(m => m.Value)
                    .DefaultIfEmpty(string.Empty)
                    .Max(s => s.Length);
        }
    }
}
