using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_42;

namespace MiTest
{
    [TestClass]
    public class MetodoEstatico
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool n = false;
            try
            {
                Ejercicio_42.MiClase.MetodoEstatico();
            }
            catch(DivideByZeroException ex)
            {
                n = true;
            }

            Assert.IsTrue(n);
        }
    }
}
