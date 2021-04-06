using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using projetGSB_AppliFrais;

namespace UnitTestGSB
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodGetMoisPrecedent()
        {
            DateTime date = new DateTime(2021, 11, 24);
            String dateMois = GestionDate.getMoisPrecedent(date);

            Assert.AreEqual(dateMois, "10",  "La fonction de retrait de mois ne fonctionne pas correctement");
        }


        [TestMethod]
        public void TestMethodGetMoisSuivant()
        {
            DateTime date = new DateTime(2021, 11, 24);
            String dateMois = GestionDate.getMoisSuivant(date);

            Assert.AreEqual(dateMois, "12", "La fonction de retrait de mois ne fonctionne pas correctement");
        }
    }
}
