using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static partial class Algorithms
    {
        public static int[] Fibonacci(this int n)
        {
            if (n <= 1)
                throw new ArgumentException("You don't want a sequence do you?", nameof(n));
            if (n == 2)
                return new[] { 0, 1 }; // just return a base sequence

            // declare the first value in the fibonacci sequence (always zero)
            int first = 0;
            // declare the second value in the fibonacci sequence (always one)
            int second = 1;
            // declare a variable to hold the next value in the fibonacci sequence
            int next;
            // create an array the length of the sequence
            var seq = new int[n];


            seq[0] = 0;
            seq[1] = 1;
            // only calculate a sequence if n > 2 (otherwise the sequence is 0 .. 1)
            // iterate the length of the sequence
            for (int i = 2; i < n; i++)
            {
                // the next number = first + second
                next = first + second;
                // assign the next number to the array
                seq[i] = next;
                // the second then becomes the first
                first = second;
                // the second then becomes the next
                second = next;
            }

            // return the sequence
            return seq;
        }
    }
}
