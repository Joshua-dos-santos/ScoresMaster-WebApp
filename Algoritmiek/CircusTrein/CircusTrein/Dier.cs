using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein
{
    class Dier
    {
        public VoedingTypen Voeding { get; set; }
        public Grootte GrootteDier { get; set; }


        public enum VoedingTypen
        {
            Vleeseter,
            PlantenEter
        }

        public enum Grootte
        {
            Klein = 1,
            Middelgroot = 3,
            Groot = 5
        }
        public List<Dier> Voeg_Dieren()
        {
            Dier Leeuw = new Dier { GrootteDier = Grootte.Groot, Voeding = VoedingTypen.Vleeseter };
            Dier Muis = new Dier { GrootteDier = Grootte.Klein, Voeding = VoedingTypen.PlantenEter };
            Dier Aap = new Dier { GrootteDier = Grootte.Middelgroot, Voeding = VoedingTypen.PlantenEter };
            List<Dier> AlleDieren = new List<Dier> { Leeuw, Muis, Aap };
            return AlleDieren;
        }
    }
}
