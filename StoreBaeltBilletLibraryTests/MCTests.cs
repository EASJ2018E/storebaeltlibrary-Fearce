﻿using System;
using StoreBaeltBilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibraryTests
{
    [TestClass]
    public class MCTests
    {
        /// <summary>
        /// Test dato på MC
        /// </summary>
        [TestMethod]
        public void MCDatoTest()
        {
            //Arrange
            MC mc = new MC();
            //Act
            mc.Dato = DateTime.Today;
            //Assert
            Assert.AreEqual(mc.Dato, DateTime.Today);
        }

        /// <summary>
        /// Test pris på MC
        /// </summary>
        [TestMethod]
        public void MCPrisTest()
        {
            //Arrange
            MC mc = new MC();
            //Act
            decimal pris = 125;
            //Assert
            Assert.AreEqual(mc.Pris(), pris);
        }

        /// <summary>
        /// Test nummerplade på MC
        /// </summary>
        [TestMethod]
        public void MCNummerpladeTest()
        {
            //Arrange
            MC mc = new MC();
            //Act
            mc.Nummerplade = "AD14562";
            //Assert
            Assert.AreEqual(mc.Nummerplade, "AD14562");
        }

        /// <summary>
        /// Test type på MC
        /// </summary>
        [TestMethod]
        public void MCKøretøjTest()
        {
            //Arrange
            MC mc = new MC();
            //Act
            string køretøj = "MC";
            //Assert
            Assert.AreEqual(mc.KøretøjType(), køretøj);
        }

        /// <summary>
        /// Test for at sikre sig at nummerpladen maks kan være 7 tegn
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MCNummerpladeMaxTest()
        {
            //Arrange
            MC mc = new MC();
            //Act
            mc.Nummerplade = "12345678";
            //Assert
            Assert.Fail();
        }

        /// <summary>
        /// Testmetode for brobizz rabat
        /// </summary>
        [TestMethod]
        public void MCBrobizzTest()
        {
            //Arrange
            MC mc = new MC();
            //Act
            mc.Brobizz = true;
            var pris = 118.75;
            //Assert - delta er den maksimale godkendte forskel fra det forventede resultat.
            Assert.AreEqual(Convert.ToDouble(mc.TotalPris()), pris,0.001);
        }

        /// <summary>
        /// Testmetode for ingen brobizz
        /// </summary>
        [TestMethod]
        public void MCIngenBrobizzTest()
        {
            //Arrange
            MC mc = new MC();
            //Act
            var pris = 125;
            //Assert - delta er den maksimale godkendte forskel fra det forventede resultat.
            Assert.AreEqual(Convert.ToDouble(mc.TotalPris()), pris, 0.001);
        }
    }
}
