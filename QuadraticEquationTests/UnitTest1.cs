using System;
using Xunit;
using QuadraticEquationSolver;

namespace QuadraticEquationTests
{
    public class QuadraticEquationTests
    {
        [Theory]
        [InlineData(1, -3, 2, 1, 2)] // 1 root
        [InlineData(1, -4, 4, 2, 2)] // 1 root
        [InlineData(1, -5, 6, 2, 3)] // 2 roots
        [InlineData(1, 1, 1, 0, 0)]   // no real roots
        public void Solve_ShouldReturnCorrectRoots(double a, double b, double c, double expectedRoot1, double expectedRoot2)
        {
            var result = QuadraticEquation.Solve(a, b, c);
            Assert.Equal(expectedRoot1, result.Item1, 6); // 6 decimal places precision
            Assert.Equal(expectedRoot2, result.Item2, 6);
        }
    }
}
