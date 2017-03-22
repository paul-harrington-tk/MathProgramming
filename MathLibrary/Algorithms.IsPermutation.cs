using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static partial class Algorithms
    {
        public static int IsPermutation(this int[] A)
        {
            // declare a zero val for the maximum value in the array
            var max = 0;
            // create a hashset to hold the unique numbers in the array
            var set = new HashSet<int>();
            // add every value in the array to the hashset
            foreach (var i in A)
            {
                set.Add(i);
                // if the value is greater than the highest value in the set we have found a new ceiling value
                if (i > max)
                {
                    max = i;
                }
            }

            // if the set is not the same size as the array somebody call houghston because we have a problem
            if (set.Count != A.Length) return 0;
            // iterate to the highest number found in the array
            for (int i = 0; i < max; i++)
            {
                // if the index + 1 is not in the set we do not have a permutation
                if (!set.Contains(i + 1)) return 0;
            }

            // tararaaaa boom deee aaay!!!
            return 1;
        }
    }
}
