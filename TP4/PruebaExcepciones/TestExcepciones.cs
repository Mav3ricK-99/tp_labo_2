using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Entidades;
using System;

namespace PruebaExcepciones
{
    [TestClass]
    public class ExcepcionesTest
    {

        [TestMethod]
        [ExpectedException(typeof(InvalidNameException))]
        public void InvalidNameExceptionTest()
        {
            Cliente c = new Cliente("___", "Guti", 42000844, "ffef");
            Assert.IsNotNull(c);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidDniException))]
        public void InvalidDniException()
        {
            Cliente c = new Cliente("Federico", "Guti", 4200044, "ffef");
            Assert.IsNotNull(c);
        }

    }

}
