using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircusTrein;
using System.Collections.Generic;

namespace UnitTest__CircusTrein
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Wagon_ZijnErTweeVleeseters_True_TweeVleeseters()
        {
            var result = false;
            List <Dier> dieren = new List<Dier>();
            dieren.Add(new Dier {  DierSoort = "Haai", Voeding = Dier.VoedingTypen.Vleeseter });
            dieren.Add(new Dier {  DierSoort = "Tijger", Voeding = Dier.VoedingTypen.Vleeseter });

            CircusTrein.Wagon wagon = new Wagon();
            foreach(Dier dier in dieren)
            {
                result = wagon.ZijnErTweeVleeseters(dier);
            }
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Wagon_IsVleeseterGroterDanElkAnderDier_False_VleeseterKleinerDan()
        {
            var result = true;
            List<Dier> dieren = new List<Dier>();
            dieren.Add(new Dier { Voeding = Dier.VoedingTypen.PlantenEter, GrootteDier = Dier.Grootte.Groot });
            dieren.Add(new Dier { Voeding = Dier.VoedingTypen.Vleeseter, GrootteDier = Dier.Grootte.Middelgroot });
            dieren.Add(new Dier { Voeding = Dier.VoedingTypen.PlantenEter, GrootteDier = Dier.Grootte.Middelgroot });

            Wagon wagon = new Wagon();
            foreach(Dier dier in dieren)
            {
                result = wagon.IsVleeseterGroterDanElkAnderDier(dier);
            }
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Wagon_IsPlanteneterGroter_Of_GelijkAanVleeseter_False_PlanteneterIsKleiner()
        {
            var result = true;
            List<Dier> dieren = new List<Dier>();
            dieren.Add(new Dier { GrootteDier = Dier.Grootte.Klein, Voeding = Dier.VoedingTypen.PlantenEter });
            dieren.Add(new Dier { GrootteDier = Dier.Grootte.Groot, Voeding = Dier.VoedingTypen.Vleeseter });

            Wagon wagon = new Wagon();
            foreach(Dier dier in dieren)
            {
                result = wagon.IsPlanteneterGroter_Of_GelijkAanVleeseter(dier);
            }
            Assert.IsFalse(result);
        }
    }
}
