using System;
using System.Collections.Generic;

/*
10001st prime
Problem 7 

By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
What is the 10 001st prime number?
 */
namespace Euler7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int count = 1;
            for (i = 3; i < 1000000; i += 2)
            {
                if (IsPrime(i))
                    count++;
                if (count == 10001)
                    break;
            }
            Console.WriteLine(i);
        }

        static bool IsPrime(int test)
        {
            bool prime = true;
            List<int> primeList = new List<int>();
            for (int i = 3; i <= test; i += 2)
                primeList.Add(i);
            for(int i = 0; i < Math.Sqrt(primeList.Count); i++)
            {
                if (test % primeList[i] == 0 && test != primeList[i])
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }
    }
}
