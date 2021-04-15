using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein
{
    class Trein
    {
        public List<Wagon> Wagons { get; set; } = new List<Wagon>();

        public List<Wagon> AlleWagons() => Wagons;

        Wagon wagon = new Wagon();
        public bool ZitWagonVol(Dier dier)
        {
            foreach(Wagon wagon in Wagons)
            {
                if (wagon.KloppenAlleEisen(dier))
                {
                    return true;
                }
            }
            return false;
        }
        public void PutAnimalsInWagons(List<Dier> AlleDieren)
        {
            foreach (Dier dier in AlleDieren)
            {
                if (!ZitWagonVol(dier))
                {
                    Wagon wagon = new Wagon();
                    Wagons.Add(wagon);
                    wagon.KloppenAlleEisen(dier);
                }
            }
        }
    }
}
