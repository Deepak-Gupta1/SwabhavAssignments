using CalcConsoleApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcConsoleUnitTestApp
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddPositiveShouldReturn30ForInput10And20()
        {
            long expectResult = 30;
            Calculator calc = new Calculator();   
            long actualResult=calc.AddPositive(10, 20);
            Assert.AreEqual(expectResult, actualResult);
        }
        [TestMethod]
        public void AdditionOfNegativeShouldReturnInApplicationError()
        {
            bool isAppExceptionThrown = false;
            try
            {
                Calculator calc = new Calculator();
                calc.AddPositive(-10, -10);
            }
            catch(ApplicationException ex)
            {
                isAppExceptionThrown = true;
            }
            catch (Exception ex){   
            }
            Assert.IsTrue(isAppExceptionThrown);
        }
    }
}
