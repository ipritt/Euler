using System;

/*
Smallest multiple
Problem 5 

2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 */

namespace Euler5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            bool found = false;
            int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int max = 2520;
            while (!found)
            {
                for (i = 0; i < ints.Length; i++)
                {
                    if (max % ints[i] != 0)
                    {
                        break;
                    }
                }
                if (i == 20)
                    found = true;
                else
                    max++;
            }
            Console.WriteLine(max);
        }
    }
}
