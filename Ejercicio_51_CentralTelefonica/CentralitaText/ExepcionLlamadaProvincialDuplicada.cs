using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace CentralitaText
{
    [TestClass]
    public class ExepcionLlamadaProvincialDuplicada
    {
        [TestMethod]
        public void TestMethod1()
        {
            Centralita centralita = new Centralita("prueva");
            Llamada llamada = new Provincial("1111", Provincial.Franja.Franja_1, 5, "2222");
            centralita += llamada;
            bool res = false;
            try
            {
                centralita += llamada;
            }
            catch (CentralitaException)
            {
                res = true;
            }

            Assert.IsTrue(res);
        }
    }
}
