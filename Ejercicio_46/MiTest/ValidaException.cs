using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace MiTest
{
    [TestClass]
    public class ValidaException
    {
        [TestMethod]
        public void TestMethod1()
        {
            Competencia n = new Competencia(20, 2, Competencia.TipoCompetencia.MotoCross);
            AutoF1 f1 = new AutoF1(2, "prueba");

            bool res = false;
            try
            {
              bool k =  n + f1;
            }
            catch(CompetenciaNoDisponibleException ex)
            {
                res = true;
            }
            Assert.IsTrue(res);
        }
    }
}
