using System;
using System.Collections.Generic;
using System.Text;

namespace CircusTrein
{
    class Dier
    {
        public VoedingTypen Voeding { get; set; }
        public Grootte GrootteDier { get; set; }
        public string DierSoort { get; set; }


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

 
        public static List<Dier> Voeg_Dieren()
        {
            Dier Leeuw = new Dier { DierSoort = "Leeuw", GrootteDier = Grootte.Groot, Voeding = VoedingTypen.Vleeseter };
            Dier Muis = new Dier { DierSoort = "Muis",GrootteDier = Grootte.Klein, Voeding = VoedingTypen.PlantenEter };
            Dier Aap = new Dier { DierSoort = "Aap", GrootteDier = Grootte.Middelgroot, Voeding = VoedingTypen.PlantenEter };
            Dier Giraffe = new Dier { DierSoort = "Giraffe", GrootteDier = Grootte.Groot, Voeding = VoedingTypen.PlantenEter };
            Dier Tijger = new Dier { DierSoort = "Tijger", GrootteDier = Grootte.Middelgroot, Voeding = VoedingTypen.Vleeseter };
            Dier Cavia = new Dier { DierSoort = "Cavia", GrootteDier = Grootte.Klein, Voeding = VoedingTypen.PlantenEter };
            Dier Luipaard = new Dier { DierSoort = "Luipaard", GrootteDier = Grootte.Groot, Voeding = VoedingTypen.Vleeseter };
            Dier Beer = new Dier { DierSoort = "Beer", GrootteDier = Grootte.Groot, Voeding = VoedingTypen.Vleeseter };
            Dier Geit = new Dier { DierSoort = "Geit", GrootteDier = Grootte.Middelgroot, Voeding = VoedingTypen.PlantenEter };
            Dier slang = new Dier { DierSoort = "Slang", GrootteDier = Grootte.Klein, Voeding = VoedingTypen.Vleeseter };
            List<Dier> AlleDieren = new List<Dier> { Leeuw, Muis, Aap, Giraffe, Tijger, Cavia, Luipaard, Beer, Geit, slang };
            return AlleDieren;
        }
    }
}
