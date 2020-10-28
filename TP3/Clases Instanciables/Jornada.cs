using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Archivos;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace EntidadesInstanciables
{

    public class Jornada
    {
        private Profesor instructor;
        private List<Alumno> alumnos;
        private EClases clase;

        public Profesor Instructor { get => instructor; set => instructor = value; }
        public List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }
        public EClases Clase { get => clase; set => clase = value; }

        private Jornada()
        {
            this.alumnos = new List<Alumno>(0);
        }

        public Jornada(EClases clase, Profesor instructor) : this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        public static string Leer()
        {
            string datosArchivo = string.Empty;
            Texto archivoTxt = new Texto();
            StringBuilder rutaStr = new StringBuilder(AppDomain.CurrentDomain.BaseDirectory);
            string nombreArchivo = "Jornada.txt";
            rutaStr.Append(nombreArchivo);

            if (archivoTxt.Leer(rutaStr.ToString(), out datosArchivo))
            {
                return datosArchivo;
            }

            return string.Empty;
        }

        public static bool Guardar(Jornada jornada)
        {
            bool rtrn = false;
            Texto archivoTxt = new Texto();
            
            StringBuilder rutaStr = new StringBuilder(AppDomain.CurrentDomain.BaseDirectory);
            string nombreArchivo = "Jornada.txt";
            rutaStr.Append(nombreArchivo);

            if(archivoTxt.Guardar(rutaStr.ToString(), jornada.ToString()))
            {
                rtrn = true;
            }

            return rtrn;
        }

        public static bool operator !=(Jornada j, Alumno a) {
            return !(j == a);
        }
        public static bool operator ==(Jornada j, Alumno a) {

            bool rtrn = false;
            if(a == j.clase)
            {
                rtrn = true;
            }

            return rtrn;
        }
        public static Jornada operator +(Jornada j, Alumno a) {

            foreach (Universitario uni in j.Alumnos)
            {
                if (uni == a)
                    return j;
                
            }
            j.Alumnos.Add(a);
        
            return j;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        public override bool Equals(object o)
        {
            return base.Equals(o);
        }
        public override string ToString()
        {
            StringBuilder strJornada = new StringBuilder();
            strJornada.AppendLine("JORNADA:");
            strJornada.AppendLine($"Clase de {this.clase} POR {this.instructor.ToString()}");
            strJornada.AppendLine($"ALUMNOS: ");
            foreach (Alumno a in this.Alumnos)
            {
                strJornada.AppendLine($"{a.ToString()}");
            }

            strJornada.AppendLine("<------------------------------------------------------>");

            return strJornada.ToString();
        }
    }

}
