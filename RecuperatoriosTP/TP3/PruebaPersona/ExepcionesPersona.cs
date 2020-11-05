using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesAbstractas;
using EntidadesInstanciables;
using Excepciones;

namespace PruebaPersona
{
    [TestClass]
    public class ExepcionesPersona
    {
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void DNIInvalidoTest()
        {
            Profesor p = new Profesor(0, "Federico", "Gutierrez", "420008449", EntidadesAbstractas.Persona.ENacionalidad.Argentino);
            Assert.IsNotNull(p);
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void NacionalidadInvalidaTest()
        {
            Profesor p = new Profesor(0, "Federico", "Gutierrez", "99999999", EntidadesAbstractas.Persona.ENacionalidad.Argentino);
            Assert.IsNotNull(p);
        }
    }
}
