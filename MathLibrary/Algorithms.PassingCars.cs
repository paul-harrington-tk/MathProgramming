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
        public static int PassingCars(this int[] A)
        {
            //// get all west bound vehicles
            //var west = A.Where(b => b == 1).Count();
            //// get all east bound vehicles
            //var east = A.Length%west;

            //// total the passing cars
            //var total = west + east;
            //// return the total if less than 1M else -1
            //return total <= 1000000 ? total : -1;
            int l = A.Length;
            int countZero = 0;
            int countPairs = 0;
            int exceed = 1000000000;


            for (int i = 0; i < l; i++)
            {
                if (A[i] == 1) countPairs += countZero;
                else countZero++;
            }

            if (countPairs > exceed || countPairs < 0) return -1;

            return countPairs;
        }
    }
}
