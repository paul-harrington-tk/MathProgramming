using System.Linq;

namespace MathLibrary
{
    public static partial class Algorithms
    {
        public static int EquilibriumIndex(this int[] a)
        {
            // initialize the lower half as zero
            var lower = 0;
            // sum the upper half of the array
            var upper = a.Sum();
            var aLen = a.Length;
            // iterate through the array
            for (var j = 0; j < aLen; j++)
            {
                // subtract the current value from the upper value
                upper -= a[j];
                // compare it to the lower half
                if (lower == upper)
                {
                    // return the equilbrium index
                    return j;
                }
                
                // add the current value to the lower half
                lower += a[j];
            }

            // return -1 for not found
            return -1;
        }
    }
}
