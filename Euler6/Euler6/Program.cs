using System;

/*
Sum square difference
Problem 6 

The sum of the squares of the first ten natural numbers is,
1sq + 2sq + ... + 10sq = 385
The square of the sum of the first ten natural numbers is,
(1 + 2 + ... + 10)sq = 55sq = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 */
namespace Euler6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumOfSquares = 0;
            double sqaureOfSums = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += Math.Pow(i, 2);
                sqaureOfSums += i;
            }
            sqaureOfSums = Math.Pow(sqaureOfSums, 2);
            Console.WriteLine(sqaureOfSums - sumOfSquares);
        }
    }
}
