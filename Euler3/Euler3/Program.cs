using System;
using System.Collections.Generic;
/*
Largest prime factor
Problem 3 

The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143 ?
 */

namespace Euler3
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = 600851475143;
            List<double> primes = new List<double>();
            for(double test = 3.0; test <= Math.Sqrt(num); test += 2.0)
            {
                if (IsPrime(test) == true && num % test == 0)
                    primes.Add(test);
                double prod = 1;
                foreach (double item in primes)
                    prod *= item;
                if (prod == num)
                    break;
            }
            Console.WriteLine(primes[primes.Count - 1]);
        }

        static bool IsPrime(double test)
        {
            bool prime = true;
            List<double> primeList = new List<double>();
            for(double i = 3; i <= test; i += 2)
                primeList.Add(i);
            if (primeList.Contains(Math.Sqrt(test)))
                prime = false;
            return prime;
        }
    }
}
