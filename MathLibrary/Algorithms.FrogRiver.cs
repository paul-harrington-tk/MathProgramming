using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static partial class Algorithms
    {
        public static int FrogRiver(this int[] A, int X)
        {
            // move the length of the array into a local variable (avoid memory reference)
            var aLen = A.Length;
            // declare a boolean array the length of the required jumps (bool is smaller than int)
            var lFound = new bool[X];
            // declare a sum variable to count that all jumps are complete
            var sum = 0;
            // iterate through the falling leaves
            for (var i = 0; i < aLen; i++)
            {
                // find the INDEX of the current leaf in the bool array
                var curr = A[i] - 1;
                // test if a leaf is not present at that position
                if (!lFound[curr])
                {
                    // set the leaf's index to found
                    lFound[curr] = true;
                    // increment the number of found leaves
                    sum++;
                }

                // if all leaves are found return the tick at which the leaf bridge is complete
                if (sum == X) return i;
            }

            // no leaves are found, chill froggie chill
            return -1;
        }
    }
}
