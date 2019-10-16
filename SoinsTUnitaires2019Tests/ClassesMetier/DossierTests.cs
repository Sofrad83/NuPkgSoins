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
    public class DossierTests
    {
        private Dossier InitialiseDossier()
        {
            Dossier unDossier = new Dossier("Robert", "Jean", new DateTime(1980, 12, 3));
            unDossier.AjoutePrestation("Libelle P3", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            unDossier.AjoutePrestation("Libelle P3", new DateTime(2015, 9, 1, 12, 0, 0), new IntervenantExterne("Dupont", "Jean", "Cardiologue", "Toulon", "0202020202020"));
            unDossier.AjoutePrestation("Libelle P3", new DateTime(2015, 9, 13, 12, 0, 0), new IntervenantExterne("Dupont", "Jean", "Radiologue", "Toulon", "0202330202020"));
            unDossier.AjoutePrestation("Libelle P3", new DateTime(2015, 9, 19, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            unDossier.AjoutePrestation("Libelle P3", new DateTime(2015, 9, 12, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            unDossier.AjoutePrestation("Libelle P3", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));

            return unDossier;

        }

        [TestMethod()]
        public void DossierTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void DossierTest1()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void DossierTest2()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void AjoutePrestationTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void GetNbPrestationsExternesTest()
        {
            Dossier unDossier = InitialiseDossier();
            Assert.AreEqual(2, unDossier.GetNbPrestationsExternes(), "Erreur !");
        }

        [TestMethod()]
        public void GetNbJoursSoinsTest()
        {
            Dossier unDossier = InitialiseDossier();
            Assert.AreEqual(5, unDossier.GetNbJoursSoins(), "Erreur !");
        }

        [TestMethod()]
        public void GetNbJoursSoinsV2Test()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void GetNbJoursSoinsV3Test()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void ToStringTest()
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void DernierePrestationTest()
        {
            Dossier unDossier = InitialiseDossier();
            Prestation unePrestation = new Prestation("Libelle P3", new DateTime(2015, 9, 10, 12, 0, 0), new Intervenant("Dupont", "Jean"));
            Assert.AreEqual(unePrestation.ToString(), unDossier.DernierePrestation().ToString(), "Erreur !!!!");
        }
    }
}