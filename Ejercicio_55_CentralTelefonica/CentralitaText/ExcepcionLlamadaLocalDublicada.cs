using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace CentralitaText
{
    [TestClass]
    public class ExcepcionLlamadaLocalDublicada
    {
        [TestMethod]
        public void TestMethod1()
        {
            Centralita centralita = new Centralita("prueva");
            Llamada llamada = new Local("1111",2,"2222",5);
            centralita += llamada;
            bool res = false;
            try
            {
                centralita += llamada;
            }
            catch(CentralitaException)
            {
                res = true;
            }

            Assert.IsTrue(res);
        }
    }
}
