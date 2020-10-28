using Archivos;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesInstanciables
{
    public enum EClases
    {
        Programacion,
        Laboratorio,
        Legislacion,
        SPD
    }
    [Serializable]
    public class Universidad
    {
        private List<Alumno> listaInscriptos;
        private List<Profesor> listaProfesores;
        private List<Jornada> jornadas;

        public List<Alumno> ListaInscriptos { get => this.listaInscriptos; set => listaInscriptos = value; }
        public List<Profesor> ListaProfesores { get => listaProfesores; set => listaProfesores = value; }
        public List<Jornada> Jornadas { get => jornadas; set => jornadas = value; }
        public Jornada this[int i] { get => jornadas[i]; set => jornadas[i] = value; }

        public Universidad() {

            this.listaInscriptos = new List<Alumno>();
            this.listaProfesores = new List<Profesor>();
            this.jornadas = new List<Jornada>();
        }

        public static bool Guardar(Universidad uni)
        {
            bool rtrn = false;
            Xml<Universidad> archivoXml = new Xml<Universidad>();

            StringBuilder rutaStr = new StringBuilder(AppDomain.CurrentDomain.BaseDirectory);
            string nombreArchivo = "Universidad.xml";
            rutaStr.Append(nombreArchivo);

            if (archivoXml.Guardar(rutaStr.ToString(), uni))
            {
                rtrn = true;
            }
            return rtrn;

        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }
        public static bool operator ==(Universidad g, Alumno a)
        {

            bool rtrn = false;
            if (g.ListaInscriptos.Contains(a))
            {
                rtrn = true;
            }

            return rtrn;
        }

        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
        public static bool operator ==(Universidad g, Profesor i)
        {

            bool rtrn = false;
            if (g.ListaProfesores.Contains(i))
            {
                rtrn = true;
            }

            return rtrn;
        }

        public static Profesor operator !=(Universidad u, EClases clase)
        {

            return u.ListaProfesores.First(x => (x != clase));

        }
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            Profesor prof = new Profesor();
            foreach (var profesor in u.ListaProfesores)
            {
                if(profesor == clase)
                {
                    prof = profesor;
                    break;
                }
            }
            
            if (prof.DniPersona == 0)
            {
                throw new SinProfesorException("No hay profesor para esta clase");
            }

            return prof;
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor prof = g == clase;
            List<Alumno> listaAlumnosTomanClase = new List<Alumno>(0);
            foreach (Alumno a in g.ListaInscriptos)
            {
                if (a == clase)
                {
                    listaAlumnosTomanClase.Add(a);
                }
            }
            Jornada nuevaJornada = new Jornada(clase, prof);
            nuevaJornada.Alumnos = listaAlumnosTomanClase;
            g.Jornadas.Add(nuevaJornada);

            return g;
        }
        public static Universidad operator +(Universidad g, Alumno a)
        {
            foreach (Alumno al in g.ListaInscriptos)
            {
                if (al == a)
                {
                    throw new AlumnoRepetidoException("Hay un alumno ingresado con el mismo Legajo o DNI");
                }
            }
            g.ListaInscriptos.Add(a);

            return g;
        }
        public static Universidad operator +(Universidad g, Profesor i)
        {
            foreach (Profesor prof in g.ListaProfesores)
            {
                /* Si se quiere que no se repita la ID con los alumnos
                 * Se deberia comparar con la lista de alumnos tambien*/
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
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder datosStr = new StringBuilder();
            foreach (Jornada jor in uni.Jornadas)
            {
                datosStr.Append(jor.ToString());
            }
            return datosStr.ToString();
        }
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
    }
}
