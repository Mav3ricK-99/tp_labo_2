using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<EClases> clasesDelDia;
        static Random random;
        public Profesor() {
            this.clasesDelDia = new Queue<EClases>();
        }
        public Profesor(int id, string nombreProfesor, string apellidoProfesor, string dniProfesor, ENacionalidad nacionalidad) : base(id, nombreProfesor, apellidoProfesor, dniProfesor, nacionalidad)
        {
            this.clasesDelDia = new Queue<EClases>();
            Profesor.random = new Random();
            this._randomClases();
        }
        //Mismo nombre que se muestra en el PDF
        private void _randomClases()
        {
            for (int i = 0; i < 2; i++)
            {
                this.clasesDelDia.Enqueue((EClases)Profesor.random.Next(0,3));
            }
            
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder strClases = new StringBuilder();
            strClases.AppendLine($"Clases del dia");
            foreach (var clase in this.clasesDelDia)
            {
                strClases.AppendLine(clase.ToString());
                
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
