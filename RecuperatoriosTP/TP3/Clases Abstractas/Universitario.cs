using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        protected int legajoUni;

        public Universitario()
        {

        }
        public Universitario(int legajo, string nombreUni, string apellidoUni, string dniUni, ENacionalidad nacionalidad) : base(nombreUni, apellidoUni, nacionalidad, dniUni)
        {
            this.legajoUni = legajo;
        }
        protected abstract string ParticiparEnClase();
        protected virtual string MostrarDatos()
        {
            StringBuilder strUni = new StringBuilder(base.ToString());
            strUni.AppendLine($"Legajo: {this.legajoUni}");

            return strUni.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Universitario universitario && (legajoUni == universitario.legajoUni || this.DniPersona == universitario.DniPersona);
        }

        public static bool operator !=(Universitario pg1, Universitario pg2) {

            return !(pg1 == pg2);
        }
        public static bool operator ==(Universitario pg1, Universitario pg2) {

            bool rtrn = false;
            if (pg1.Equals(pg2))
            {
                rtrn = true;
            }
            return rtrn;
        }

    }
}
