using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltBilletLibrary;

namespace StoreBaeltBilletLibraryTests
{
    [TestClass]
    public class BilTests
    {
        /// <summary>
        /// Tester om der er 20% rabat om s�ndagen
        /// </summary>
        [TestMethod]
        public void BilWeekendrabatTest()
        {
            //Arrange
            Bil bil = new Bil();
            //Act
            bil.Dato = new DateTime(2018, 9, 16); //En s�ndag
            decimal forventetPris = 192; //240 - 20%
            //Assert
            Assert.AreEqual(bil.TotalPris(), forventetPris);
        }

        /// <summary>
        /// Tester rabatten med brobizz oveni
        /// </summary>
        [TestMethod]
        public void BilWeekendBrobizzRabatTest()
        {
            //Arrange
            Bil bil = new Bil();
            //Act
            bil.Dato = new DateTime(2018, 9, 16); //En s�ndag
            bil.Brobizz = true;
            double forventetPris = 182.4; //240 - 20% - 5%
            //Assert
            Assert.AreEqual(Convert.ToDouble(bil.TotalPris()), forventetPris,0.01);
        }

        /// <summary>
        /// Test type p� Bil
        /// </summary>
        [TestMethod]
        public void BilK�ret�jTest()
        {
            //Arrange
            Bil bil = new Bil();
            //Act
            string k�ret�j = "Bil";
            //Assert
            Assert.AreEqual(bil.K�ret�jType(), k�ret�j);
        }
    }
}
