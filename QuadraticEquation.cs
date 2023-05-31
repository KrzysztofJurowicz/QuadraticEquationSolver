using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationSolver
{
    public class QuadraticEquation
    {
        public static Tuple<double, double> Solve(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            if (delta < 0)
                throw new Exception("No real roots");

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            return Tuple.Create(x1, x2);
        }
    }
}

