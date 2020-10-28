using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace MiTest
{
    [TestClass]
    public class ValidaInstanciaListaVehiculos
    {
        [TestMethod]
        public void TestMethod1()
        {

            Competencia competencia = new Competencia(20, 30, Competencia.TipoCompetencia.F1);
           
            Assert.IsNotNull(competencia.ListaCompetencia);

        }
    }
}
