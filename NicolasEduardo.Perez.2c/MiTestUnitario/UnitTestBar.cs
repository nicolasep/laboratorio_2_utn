using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace MiTestUnitario
{
    [TestClass]
    public class UnitTestBar
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arranque
            // Act
            Bar bar = Bar.GetBar();
            // Assert
            Assert.IsNotNull(bar);
        }

    }
}
