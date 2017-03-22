using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    using System.Runtime.CompilerServices;

    public static partial class Algorithms
    {
        public static int FrogJump(int X, int Y, int D)
        {
            // calculate the required jump distance
            int distance = Y - X;

            // if there is no remainder between the required distance and the jump distance return d/JD
            // else return the requiredDistance + JD / jump Distance
            return (distance % D == 0) ? distance / D : (distance + D) / D;
        }
    }
}
