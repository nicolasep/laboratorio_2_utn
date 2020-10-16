using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace MiTestUnitario
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ValidarEdadEmpleado()
        {
            // Arrange
            short edad = 21;
            Empleado empleado = this.CrearEmpleado(edad);
            //Act
            bool esValido = empleado.Validar();
            //Assert
            Assert.IsTrue(esValido);
        }
        [TestMethod]
        public void EdadEmpleado()
        {
            // Arrange
            short edad = 25;
            Empleado empleado = this.CrearEmpleado(edad);
            //Act
            bool esValido = empleado.Validar();
            //Assert
            Assert.AreEqual(edad, empleado.Edad);
        }
        private Empleado CrearEmpleado(short edad)
        {
            return new Empleado("Juan", edad);
        }
    }
}
