using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Clases_Instanciables
{
    public enum EClases
    {
        Programacion,
        Laboratorio,
        Legislacion,
        SPD
    }
    public class Universidad
    {
        private List<Alumno> listaInscriptos;
        private List<Profesor> listaProfesores;
        private List<Jornada> jornadas;

        public List<Alumno> ListaInscriptos { get => listaInscriptos; set => listaInscriptos = value; }
        public List<Profesor> ListaProfesores { get => listaProfesores; set => listaProfesores = value; }
        public List<Jornada> Jornadas { get => jornadas; set => jornadas = value; }
        public Jornada this[int i] { get => jornadas[i]; set => jornadas[i] = value; }

        public Universidad() { }

        public static bool operator !=(Universidad g, Alumno a) {
            return !(g == a);
        }
        public static bool operator ==(Universidad g, Alumno a) {

            bool rtrn = false;
            if (g.ListaInscriptos.Contains(a))
            {
                rtrn = true;
            }

            return rtrn;
        }

        public static bool operator !=(Universidad g, Profesor i) {
            return !(g == i);
        }
        public static bool operator ==(Universidad g, Profesor i) {

            bool rtrn = false;
            if (g.ListaProfesores.Contains(i))
            {
                rtrn = true;
            }

            return rtrn;
        }

        public static Profesor operator !=(Universidad u, EClases clase) {

            return u.ListaProfesores.First(x => (x != clase));
            
        }
        public static Profesor operator ==(Universidad u, EClases clase) {

            Profesor prof = u.ListaProfesores.First(x => (x == clase));
            if (prof == null)
            {
                throw new SinProfesorException("No hay profesor para esta clase");
            }

            return prof;
        }

        public static Universidad operator +(Universidad g, EClases clase) 
        {
            Profesor prof = (g == clase);
            List<Alumno> listaAlumnosTomanClase = new List<Alumno>(0);
            foreach (Alumno a in g.ListaInscriptos)
            {
                if(a == clase)
                {
                    listaAlumnosTomanClase.Add(a);
                }
            }
            Jornada nuevaJornada = new Jornada(clase, prof);
            nuevaJornada.Alumnos = listaAlumnosTomanClase;
            g.Jornadas.Add(nuevaJornada);
            
            return g; 
        }
        public static Universidad operator +(Universidad g, Alumno a) {

            foreach (Alumno al in g.ListaInscriptos)
            {
                if(al == a)
                {
                    throw new AlumnoRepetidoException("Hay un alumno ingresado con el mismo Legajo o DNI");
                }
            }
            g.ListaInscriptos.Add(a);

            return g;
        }
        public static Universidad operator +(Universidad g, Profesor i) {

            foreach (Profesor prof in g.ListaProfesores)
            {
                if (prof == i)
                {
                    return g;
                }
            }
            g.ListaProfesores.Add(i);

            return g;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        public override bool Equals(object o)
        {
            return base.Equals(o);
        }
    }
}
