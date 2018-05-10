using System;
using System.Collections.Generic;

/*
Largest palindrome product
Problem 4 

A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
Find the largest palindrome made from the product of two 3-digit numbers.
 */
namespace Euler4
{
    class Program
    {
        static void Main(string[] args)
        {
            int prod;
            List<int> prods = new List<int>();
            for (int a = 999; a > 0; a--)
            {
                for (int b = 999; b > 0; b--)
                {
                    prod = a * b;
                    if (IsPalindrome(Convert.ToString(prod)))
                    {
                        prods.Add(Convert.ToInt32(prod));
                    }
                }
            }
            prod = 0;
            foreach (int item in prods)
            {
                if (item > prod)
                    prod = item;
            }
            Console.WriteLine(prod);
        }
        static bool IsPalindrome(string test)
        {
            bool isPali = true;
            int a = 0;
            int b = test.Length - 1;
            while (a < b)
            {
                if (test[a] != test[b])
                {
                    isPali = false;
                }
                a++;
                b--;
            }
            return isPali;
        }
    }
}
