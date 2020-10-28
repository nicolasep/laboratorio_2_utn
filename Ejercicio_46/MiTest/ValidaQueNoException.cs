using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace MiTest
{
    [TestClass]
    public class ValidaQueNoException
    {
        [TestMethod]
        public void TestMethod1()
        {
            Competencia n = new Competencia(20, 2, Competencia.TipoCompetencia.MotoCross);
            MotoCross f1 = new MotoCross(2, "prueba");

            bool res = true;
            try
            {
                bool k = n + f1;
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                res = false;
            }
            Assert.IsTrue(res);
        }
    }
}
