using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static partial class Algorithms
    {
        public static int PermMissingElement(this int[] A)
        {
            // determine the length of the array
            int count = A.Length;
            // determine the final value of the sequence expected
            int finalCount = count + 1;
            // determine the expected total of the expected sequence
            int total = finalCount * (finalCount + 1) / 2;
            // iterate the the array
            for (int i = 0; i < count; i++)
            {
                // subtract the current value from total
                total -= A[i];
            }

            // if an element is missing from the sequence it will be present in the total or else zero will be returned
            return total;
        }
    }
}
