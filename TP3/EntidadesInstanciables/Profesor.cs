using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<EClases> clasesDelDia;
        static Random random;

        private Profesor()
        {
            this.clasesDelDia = new Queue<EClases>();
            Profesor.random = new Random();
            this._randomClases();
        }


        public Profesor(int id, string nombreProfesor, string apellidoProfesor, string dniProfesor, ENacionalidad nacionalidad) : base(0, nombreProfesor, apellidoProfesor, dniProfesor, nacionalidad)
        {
            
        }
        //Mismo nombre que se muestra en el PDF
        private void _randomClases()
        {
            for (int i = 0; i < 2; i++)
            {
                this.clasesDelDia.Enqueue((EClases)Profesor.random.Next(0, 3));
            }
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder strClases = new StringBuilder();
            strClases.AppendLine($"Clases del dia");
            foreach (EClases clase in this.clasesDelDia)
            {
                strClases.AppendLine($"{clase}");
            }

            return strClases.ToString();
        }
        public static bool operator ==(Profesor i, EClases clase) {

            bool rtrn = false;
            if (i.clasesDelDia.Contains(clase))
            {
                rtrn = true;
            }

            return rtrn;
        }
        public static bool operator !=(Profesor i, EClases clase) {
            return !(i == clase);
        }

        protected override string MostrarDatos()
        {
            StringBuilder strProfesor = new StringBuilder(base.MostrarDatos());
            strProfesor.AppendLine(this.ParticiparEnClase());

            return strProfesor.ToString();
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
            return this.MostrarDatos();
        }

    }


}
