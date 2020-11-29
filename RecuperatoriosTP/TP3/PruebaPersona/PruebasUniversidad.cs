using EntidadesAbstractas;
using EntidadesInstanciables;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUniversidad
{
    [TestClass]
    public class PruebasUniversidad
    {
        [TestMethod]
        public void ListaUniversidadTest()
        {
            Universidad uni = new Universidad();
            
            Assert.IsNotNull(uni.ListaInscriptos);
        }
    }
}
