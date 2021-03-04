using System;

namespace Algoritmiek
{
    class Program
    {
        static void Main(string[] args)
        {
            int calculatedNumber3 = 0;
            int startingNumber3 = 0;
            int calculatedNumber5 = 0;
            int startingNumber5 = 0;
            while (startingNumber3 <= 1000)
            {
                startingNumber3 += 3;
                calculatedNumber3 += startingNumber3;    
            }
            while(startingNumber5 <= 1000)
            {
                startingNumber5 += 5;
                calculatedNumber5 += startingNumber5;
            }
            calculatedNumber5 -= 1005;
            calculatedNumber3 -= 1002;

            int result = calculatedNumber3 + calculatedNumber5;
            Console.WriteLine(result);

        }

    }
}
