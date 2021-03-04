using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i, j, n, max_n = 0;

            for (i = 100; i <= 999; i++)
            {
                for (j = 100; j <= 999; j++)
                {
                    n = i * j;
                    if (n > max_n && IsPalendrome(n))
                    {
                        max_n = n;
                    }
                }
            }


            //Your code goes here
            Console.WriteLine("The solution is: " + max_n);
        }

        public static bool IsPalendrome(int n)
        {
            string forward_string, reverse_string;

            forward_string = n.ToString();
            reverse_string = new string(forward_string.ToCharArray().Reverse().ToArray());

            return forward_string == reverse_string ? true : false;

        }

    }
}