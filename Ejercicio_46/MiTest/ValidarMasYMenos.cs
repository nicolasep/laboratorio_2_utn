using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace MiTest
{
    [TestClass]
    public class ValidarMasYMenos
    {
        [TestMethod]
        public void TestMethod1()
        {
            Competencia n = new Competencia(20, 2, Competencia.TipoCompetencia.MotoCross);
            MotoCross f1 = new MotoCross(2,"prueba");

            bool res = false;

            bool k = n + f1;
            
            if(n == f1)
            {
                res = true;
            }
            Assert.IsTrue(res);
            
            k = n - f1;

            if (n != f1)
            {
                res = true;
            }
            Assert.IsTrue(res);
        }
    }
}
