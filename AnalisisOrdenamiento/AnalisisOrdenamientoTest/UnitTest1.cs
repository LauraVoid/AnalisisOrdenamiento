using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalisisOrdenamiento;

namespace AnalisisOrdenamientoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Ordenamiento or = new Ordenamiento();
            int result = or.suma(50,60);
            Assert.AreEqual(110, result);

        }
    }
}
