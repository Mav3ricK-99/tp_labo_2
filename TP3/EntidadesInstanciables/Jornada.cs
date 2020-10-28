using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
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

        public string Leer()
        {
            return "xd";
        }

        public bool Guardar(Jornada jornada)
        {
            return true;
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
            strJornada.AppendLine("Jornada:");
            strJornada.AppendLine($"Clase de {this.clase} {this.instructor.ToString()}");
            strJornada.AppendLine($"Alumnos: ");
            foreach (Alumno a in this.Alumnos)
            {
                strJornada.AppendLine($"{this.alumnos.ToString()}");
            }

            strJornada.AppendLine("<------------------------------------------------------>");

            return strJornada.ToString();
        }
    }

}
