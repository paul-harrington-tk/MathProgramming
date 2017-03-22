using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static partial class Algorithms
    {
        public static int TapeEquilibrium(this int[] A)
        {
            // declare an array to hold the differences
            long[] diffs = new long[A.Length];
            // declare the left side sum value
            long left = 0;
            // sum up the entire array
            long sum = A.Sum();
            // iterate through the array
            for (int i = 0; i < A.Length; i++)
            {
                // add the current index to the left value of the array
                left += A[i];
                // determine the current absolute total of the left minus the sum of the array subtracting minus the left side
                var diff = Math.Abs((sum - left) - left);
                // allocate the val to the diffs array
                diffs[i] = (diff);
            }
            // return the smallest value from the diffs array
            return Convert.ToInt32(diffs.Min());
        }
    }
}
