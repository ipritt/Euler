using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Special Pythagorean triplet
Problem 9 

A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
asq + bsq = csq
For example, 3sq + 4sq = 9 + 16 = 25 = 5sq.
There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
 */
namespace Euler9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 400; a++)
            {
                for (int b = 1; b < 400; b++)
                {
                    double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                    double d = a + b + c;
                    if (d % 1 == 0 && d == 1000)
                        Console.WriteLine(a * b * c);
                }
            }
        }
    }
}
