using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static partial class Algorithms
    {
        public static int[] LeftShift(this int[] A, int K)
        {
            // if the shift value is a negative then throw an argument exception
            if (K < 0)
                throw new ArgumentException("Shift value cannot be negative", nameof(K));

            // if the number of shifts is zero or the array has one or less elements return the array
            if (K == 0 || A.Length <= 1)
                return A;
            // ascertain the length of the array
            int len = A.Length;
            // set the number of shifts to be the remainder of the array length / shifts
            K %= len;
            // create a shift array that is the length of the remainder
            var temp = new int[K];

            // copy the tailing elements to the shifted array
            Array.Copy(A, len - K, temp, 0, K);
            // copy the remaining elements to the tail of the array
            Array.Copy(A, 0, A, K, len - K);
            // copy the shifted elements back to the original array
            Array.Copy(temp, A, K);
            return A;
        }
    }
}
