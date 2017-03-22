namespace MathProgramming
{
    using System;
    using System.Globalization;
    using MathLibrary;

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            var val = Console.ReadLine();
            int intVal;
            if (!int.TryParse(val, NumberStyles.Integer, CultureInfo.InvariantCulture, out intVal))
            {
                Console.WriteLine("Read the instructions");
            }
            else
            {

                var fib = intVal.Fibonacci();
                if (fib.Length < 10)
                {
                    Console.WriteLine("The fibonacci sequence is");
                    for (int i = 0; i < fib.Length; i++)
                    {
                        Console.Write($"{fib[i]}, ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"The binary gap is {intVal.BinaryGapRegex()}");

                Console.WriteLine("Preparing random list if integers");
                var n = new int[10];
                var randomizer = new Random(intVal);
                for (int i = 0; i < 10; i++)
                {
                    n[i] = randomizer.Next(-9, 9);
                    Console.Write($"{n[i]}, ");
                }

                Console.WriteLine("Calculation equilibrium index");
                Console.WriteLine($"Equilibrium index is {n.EquilibriumIndex()}");
            }

            Console.ReadKey();
        }
    }
}
