using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBæltBilletLibrary;

namespace Tests
{
    [TestClass]
    public class BilWeekendUnitTest
    {
        [TestMethod]
        public void TestMethodPrisBilWeekend()
        {
            BilWeekend bw = new BilWeekend {Brobizz = false, Dato = new DateTime(2018, 09, 16)};
            double actualResult = (double) bw.Pris();

            double expectedResult = 192;
            
            Assert.AreEqual(expectedResult, actualResult, 0.5,
                "Test failed! The actual result is not the same as the expected result");
        }
        
        [TestMethod]
        public void TestMethodPrisBilWeekendBrobizz()
        {
            BilWeekend bw = new BilWeekend {Brobizz = true, Dato = new DateTime(2018, 09, 16)};
            double actualResult = (double) bw.Pris();

            double expectedResult = 182.4;
            
            Assert.AreEqual(expectedResult, actualResult, 0.5,
                "Test failed! The actual result is not the same as the expected result");
        }
    }
}
