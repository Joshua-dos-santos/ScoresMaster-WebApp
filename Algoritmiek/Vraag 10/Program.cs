using System;
using System.Collections.Generic;

namespace Vraag_10
{
    public class Program
    {

        static long max_n = 2000000;
        static List<long> primes = new List<long>();

        public static void Main(string[] args)
        {
            long n = 2, sum_of_primes = 0;

            primes.Add(n);
            sum_of_primes += n;
            n++;

            do
            {
                if (IsPrime(n))
                {
                    primes.Add(n);
                    sum_of_primes += n;
                }
                n += 2;

            } while (n < max_n);

            Console.WriteLine("The solution is: " + sum_of_primes);
        }

        public static bool IsPrime(long n)
        {

            // Console.WriteLine("Testing: " + n);

            foreach (long prime in primes)
            {
                if (prime * prime > n)
                {
                    break;
                }
                else if (n % prime == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}