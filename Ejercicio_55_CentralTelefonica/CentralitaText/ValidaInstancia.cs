using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace CentralitaText
{
    [TestClass]
    public class ValidaInstancia
    {
        [TestMethod]
        public void TestMethod1()
        {
            Centralita centralita = new Centralita("prueba");

            bool respuesta = false;
            if(!(centralita.Llamadas is null))
            {
                respuesta = true;
            }
            Assert.IsTrue(respuesta);
        }
    }
}
