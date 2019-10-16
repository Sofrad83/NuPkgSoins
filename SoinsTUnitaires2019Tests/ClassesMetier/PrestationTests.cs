using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetier.Tests
{
    [TestClass()]
    public class PrestationTests
    {
        [TestMethod()]
        public void PrestationTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void CompareToTest()
        {
            Prestation unePresta = new Prestation("oulou", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("oulou", "oula"));
            Prestation uneautrePresta = new Prestation("oulou", new DateTime(2015, 9, 11, 12, 0, 0), new Intervenant("oulou", "oula"));
            Assert.AreEqual(-1, unePresta.CompareTo(uneautrePresta), "Erreur : valeur attendue -1.");
        }

        [TestMethod()]
        public void CompareToTestV2()
        {
            Prestation unePresta = new Prestation("oulou", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("oulou", "oula"));
            Prestation uneautrePresta = new Prestation("oulou", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("oulou", "oula"));
            Assert.AreEqual(0, unePresta.CompareTo(uneautrePresta), "Erreur : valeur attendue 0.");
        }

        [TestMethod()]
        public void CompareToTestV3()
        {
            Prestation unePresta = new Prestation("oulou", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("oulou", "oula"));
            Prestation uneautrePresta = new Prestation("oulou", new DateTime(2015, 9, 9, 12, 0, 0), new Intervenant("oulou", "oula"));
            Assert.AreEqual(1, unePresta.CompareTo(uneautrePresta), "Erreur : valeur attendue 1.");
        }

        [TestMethod()]
        public void ToStringTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void SommePourRienTest()
        {
            int a = 3;
            int b = 5;
            Prestation unePrestation = new Prestation("XX", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.AreEqual(9, unePrestation.SommePourRien(a, b), "La somme doit être égale à 8");
        }
    }
}