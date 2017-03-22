using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static partial class Algorithms
    {
        public static int[] MaxCounter(this int[] A)
        {
            // get the length of the array
            var N = A.Length;
            // declare a result array that is the same length as the input
            var results = new int[N];
            // initialize all values as 0
            for (var i = 0; i < results.Length; i++) results[i] = 0;
            // declare a current maximum value, initialize it as zero
            var curMax = 0;
            // declare a maximum value for the complete array
            var allMax = 0;
            // iterate through the input array
            foreach (var i in A)
            {
                // if the value itself is less than the length of the array
                if (i <= N)
                {
                    // if the result before this value is less than the all madx value
                    if (results[i - 1] < allMax)
                        results[i - 1] = allMax; // set it to the all max value
                    // increment the preceding value
                    results[i - 1]++;
                    // if the result is greater than the current maximum
                    if (results[i - 1] > curMax) curMax = results[i - 1]; // update the current maximum value
                }
                // else if the current value goes beyond the array length
                else if (i == N + 1)
                    allMax = curMax; // set the all max to the current value
            }

            // iterate through the length of the array
            for (int i = 0; i < N; i++)
                // if the value is below the all maximum value
                if (results[i] < allMax)
                    results[i] = allMax; // update it to the maximum value

            // return the results
            return results;
        }
    }
}
