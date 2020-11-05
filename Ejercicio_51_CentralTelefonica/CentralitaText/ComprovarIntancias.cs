using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace CentralitaText
{
    [TestClass]
    public class ComprovarIntancias
    {
        [TestMethod]
        public void TestMethod1()
        {
          
            Local llamada = new Local("1111", 2, "2222", 5);
            Local llamada2 = new Local("1111", 2, "2222", 5);
            Provincial llamada3 = new Provincial("1111", Provincial.Franja.Franja_1, 5, "2222");
            Provincial llamada4 = new Provincial("1111", Provincial.Franja.Franja_1, 5, "2222");
            
            Assert.AreEqual(llamada, llamada2);
            Assert.AreEqual(llamada3, llamada4);
            Assert.AreNotEqual(llamada2, llamada3);
            Assert.AreNotEqual(llamada3, llamada);
           
        }
    }
}
