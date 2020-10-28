using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_42;

namespace MiTest
{
    [TestClass]
    public class MiClaseTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            bool n = false;

            try
            {
                new MiClase(10);
            }
            catch(UnaExcepcion ex)
            {
                n = true;
            }
            Assert.IsTrue(n);
        }
    }
}
