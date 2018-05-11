using System;
using System.Collections.Generic;

/*
Summation of primes
Problem 10 

The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
Find the sum of all the primes below two million.
 */

namespace Euler10
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;
            int n = 2000000;
            List<int> primes = new List<int>();
            primes = GetPrimes(n);
            foreach (int value in primes)
            {
                sum += value;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        static List<int> GetPrimes(int n)
        {
            List<int> primeList = new List<int>();
            primeList.Add(2);
            for (int i = 3; i < n; i += 2)
                primeList.Add(i);
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                if (primeList.Contains(i))
                {
                    for (int j = 3; i * j <= n; j += 2)
                    {
                        primeList.Remove(i * j);
                    }
                }
            }
            return primeList;
        }
    }
}
