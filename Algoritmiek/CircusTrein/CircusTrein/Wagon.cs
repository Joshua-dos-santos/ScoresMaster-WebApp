using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircusTrein
{
    class Wagon
    {
        public List<Dier> Dieren { get; set; }
        public int Maximale_Ruimte { get; set; }
        public int ActueleRuimte
        {
            get { return Dieren.Sum(diertje => (int)diertje.GrootteDier); }
        }
        public Wagon()
        {
            Maximale_Ruimte = 10;
            Dieren = new List<Dier>();
        }
        public List<Dier> DierenInWagon()
        {
            return Dieren;
        }
        public bool IsVleeseterGroterDanElkAnderDier(Dier diertoevoegen)
        {
            foreach(Dier dier in Dieren)
            {
                if (diertoevoegen.Voeding == Dier.VoedingTypen.Vleeseter && diertoevoegen.GrootteDier >= dier.GrootteDier)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsPlanteneterGroter_Of_GelijkAanVleeseter(Dier diertoevoegen)
        {
            foreach(Dier dier in Dieren)
            {
                if (diertoevoegen.Voeding == Dier.VoedingTypen.PlantenEter && dier.Voeding == Dier.VoedingTypen.Vleeseter && diertoevoegen.GrootteDier <= dier.GrootteDier)
                {
                    return false;
                }
            }
            return true;
        }

        public bool ZijnErTweeVleeseters(Dier diertoevoegen)
        {
            foreach(Dier dier in Dieren)
            {
                if(diertoevoegen.Voeding == Dier.VoedingTypen.Vleeseter && dier.Voeding == Dier.VoedingTypen.Vleeseter)
                {
                    return false;
                }
            }
            return true;
        }

        public bool KloppenAlleEisen(Dier diertoevoegen)
        {
            if(IsPlanteneterGroter_Of_GelijkAanVleeseter(diertoevoegen) && IsVleeseterGroterDanElkAnderDier(diertoevoegen) && ZijnErTweeVleeseters(diertoevoegen) && (int)diertoevoegen.GrootteDier + ActueleRuimte < Maximale_Ruimte)
            {
                Dieren.Add(diertoevoegen);
                return true;
            }
            return false;
        }
    }
}
