using System;

namespace Vraag_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Algoritmiek = new Program();
            Console.WriteLine(Algoritmiek.Kwadraten());
            Console.WriteLine(Algoritmiek.Som());
            int Answer = Algoritmiek.Som() - Algoritmiek.Kwadraten();
            Console.WriteLine(Answer);
        }

        public int Kwadraten()
        {
            int answer = 0;
            for (int i = 0; i <= 100; i++)
            {
                int number = i * i;
                answer += number;
            }
            return answer;
        }

        public int Som()
        {
            int number = 0;
            for (int i = 0; i <= 100; i++)
            {
                number += i;
            }
            int answer = number * number;
            return answer;
        }
    }
}
