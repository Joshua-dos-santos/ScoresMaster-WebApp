using System;

namespace CircusTrein
{
    class Program
    {
        static void Main(string[] args)
        {
            Trein trein = new Trein();
            trein.DierenVerplaatsenNaarWagons(Dier.Voeg_Dieren());
            foreach (Wagon wagon in trein.AlleWagons())
            {
                Console.Write("\n\nGrootte Wagon: " + wagon.ActueleRuimte + "\nDieren: ");
                foreach (Dier dier in wagon.DierenInWagon())
                {
                    Console.Write(dier.DierSoort + ", ");
                }
            }
            Console.ReadKey();
        }
    }
}
