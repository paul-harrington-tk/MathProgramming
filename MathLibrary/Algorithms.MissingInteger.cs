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
        /// Finds the missing the integer.
        /// </summary>
        /// <param name="A">a.</param>
        /// <returns></returns>
        public static int MissingInteger(this int[] A)
        {
            // declare a return value and set it to 1
            int r = 1;
            // sort the array
            Array.Sort(A);
            // declare an external counter
            int i = 0;
            // iterate past all integers less than 1
            while (i < A.Length && A[i] < 1) i++;

            // iterate through the array whilst finding the lowest matching integer
            while (i < A.Length && r == A[i])
            {
                // iterate past duplicate values
                while (i < A.Length - 1 && A[i] == A[i + 1]) i++;
                // increment the iterator
                i++;
                // increment the return value
                r++;
            }
            return r;
        }
    }
}
