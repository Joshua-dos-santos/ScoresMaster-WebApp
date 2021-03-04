using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Vraag_9
{
    public class Program
    {

        public static void Main(string[] args)
        {
            int a, b, c, sum = 1000;

            for (a = 1; a <= sum - 2; a++)
            {
                for (b = a + 1; a + b <= sum - 1; b++)
                {
                    c = sum - (a + b);
                    if (a * a + b * b == c * c)
                    {
                        Console.WriteLine("{0}, {1}, {2}, {3}", a, b, c, a * b * c);
                    }
                }
            }
        }
    }
}