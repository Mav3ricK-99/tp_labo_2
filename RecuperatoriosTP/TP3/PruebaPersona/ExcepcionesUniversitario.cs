using EntidadesAbstractas;
using EntidadesInstanciables;
using Excepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaPersona
{
    [TestClass]
    public class PruebasUniversidad
    {
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void AlumnoRepetidoTest()
        {
            Universidad uni = new Universidad();
            Alumno al = new Alumno(0, "Federico", "Gutierrez", "42000844", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno alumno = new Alumno(1, "Federico", "Gutierrez", "42000844", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            uni += al;
            uni += alumno;
        }

        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void AlumnoIDRepetidoTest()
        {
            Universidad uni = new Universidad();
            Alumno al = new Alumno(1, "Federico", "Gutierrez", "42000844", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Alumno alumno = new Alumno(1, "Federico", "Gutierrez", "42000841", EntidadesAbstractas.Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            uni += al;
            uni += alumno;
        }
    }
}
