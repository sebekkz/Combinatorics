namespace Combinatorics.Runner
{
    using System;
    using Combinatorics;
    using Combinatorics.Generic;

    public class Program
    {
        static void Main(string[] args)
        {
            const uint k = 2;
            const uint n = 9;
            const uint elementAt = 20;

            Console.WriteLine($"Combination of {k} elements from {n} qualf {Combinatorics.Math.Choose(n,k)}.");
            Console.WriteLine();

            var combinations = new Combinations(n, k);
            var i = 0u;
            foreach(var combination in combinations)
            {
                Console.Write($"{i}: ");
                foreach (var value in combination)
                {
                    Console.Write($"{value} ");
                }
                Console.WriteLine();
                i++;
            }

            foreach (var value in combinations.ElementAt(elementAt))
            {
                Console.Write($"{value} ");
            }

            Console.ReadKey();

            Console.WriteLine($"Combination of {k} elements from {n} qualf {Combinatorics.Math.Choose(n, k)}.");
            Console.WriteLine();

            var combinationsG = new Combinations<string>(new string[]{ "a", "b", "c", "d" ,"e","f","g","h","i" }, k);
            i = 0u;
            foreach (var combination in combinationsG)
            {
                Console.Write($"{i}: ");
                foreach (var value in combination)
                {
                    Console.Write($"{value} ");
                }
                Console.WriteLine();
                i++;
            }

            foreach (var value in combinationsG.ElementAt(elementAt))
            {
                Console.Write($"{value} ");
            }

            Console.ReadKey();
        }
    }
}