using System;
using QuadraticEquationSolver;

namespace QuadraticEquationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage of the QuadraticEquation class
            double a = 1;
            double b = -3;
            double c = 2;

            try
            {
                var result = QuadraticEquation.Solve(a, b, c);
                Console.WriteLine($"Root 1: {result.Item1}");
                Console.WriteLine($"Root 2: {result.Item2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
