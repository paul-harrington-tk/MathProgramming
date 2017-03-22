using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    using System.Collections;

    public static partial class Algorithms
    {
        /// <summary>
        /// Finds the Binary gap for a given integer.
        /// </summary>
        /// <param name="N">The n.</param>
        /// <returns></returns>
        public static int BinaryGap(int N)
        {
            // declare a variable to hold the maximum gap
            var maxGap = 0;
            var currentGap = -1;
            
            // convert the integer to a bit array
            var bitArray = new BitArray(N);
            // iterate through the bit array
            for (var i = 0; i < bitArray.Length; i++)
            {
                // if the current value is zero keep iterating
                if (!bitArray[i])
                    continue;
                // if we have started a gap
                if (currentGap != -1)
                {
                    // the number of zeros between the last index the number of hops and excluding the current bit
                    int count = i - currentGap - 1;
                    // if this value is greater than the previous gap then allocate it
                    if (count > maxGap)
                        maxGap = count;
                }
                currentGap = i;
            }
            return maxGap;
        }
    }
}
