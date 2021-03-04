using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Vraag_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = 600851475143;
            var factors = new List<long>();
            var maxFactor = 0;

            Console.WriteLine("Factoring {0}", subject);

            while (subject > 1)
            {
                var nextFactor = 2;
                if (subject % nextFactor > 0)
                {
                    nextFactor = 3;
                    do
                    {
                        if (subject % nextFactor == 0)
                        {
                            break;
                        }

                        nextFactor += 2;
                    } while (nextFactor < subject);
                }

                subject /= nextFactor;
                factors.Add(nextFactor);
                if (nextFactor > maxFactor)
                {
                    maxFactor = nextFactor;
                }
            }

            var factorAnswer = 1L;
            factors.ForEach(f => factorAnswer *= f);

            Console.WriteLine("Factors: {0} = {1}",
                string.Join(" * ",
                    factors.Select(i => i.ToString()).ToArray()),
                factorAnswer);
            Console.WriteLine("Max Factor: {0}", maxFactor);
        }
    }
}
