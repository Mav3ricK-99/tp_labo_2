using EntidadesAbstractas;
using EntidadesInstanciables;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaPersona
{
    [TestClass]
    public class ExcepcionesUniversitario
    {
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void AlumnoRepetidoTest()
        {
            Universidad uni = new Universidad();
            Alumno al = new Alumno(0, "Federico", "Gutierrez", "42000844", ENacionalidad.Argentino, EClases.Laboratorio);
            Alumno alumno = new Alumno(1, "Federico", "Gutierrez", "42000844", ENacionalidad.Argentino, EClases.Laboratorio);

            uni += al;
            uni += alumno;
        }

        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void AlumnoIDRepetidoTest()
        {
            Universidad uni = new Universidad();
            Alumno al = new Alumno(1, "Federico", "Gutierrez", "42000844", ENacionalidad.Argentino, EClases.Laboratorio);
            Alumno alumno = new Alumno(1, "Federico", "Gutierrez", "42000841", ENacionalidad.Argentino, EClases.Laboratorio);

            uni += al;
            uni += alumno;
        }
    }
}
