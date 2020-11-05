using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using EClases = EntidadesInstanciables.Universidad.EClases;

namespace EntidadesInstanciables
{

    public sealed class Alumno : Universitario
    {
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        private EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        public Alumno()
        {

        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        
        protected override string ParticiparEnClase()
        {
            StringBuilder strClases = new StringBuilder();
            strClases.AppendLine($"Clase que toma: {this.claseQueToma}");

            return strClases.ToString();
        }

        public static bool operator !=(Alumno a, EClases clase)
        {
            bool rtrn = false;
            if (a.claseQueToma != clase)
            {
                rtrn = true;
            }

            return rtrn;
        }
        public static bool operator ==(Alumno a, EClases clase) {

            bool rtrn = false;
            if(a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                rtrn = true;
            }

            return rtrn;
        }

        protected override string MostrarDatos()
        {

            StringBuilder strAlumno = new StringBuilder(base.MostrarDatos());
            strAlumno.AppendLine($"Estado de cuenta: {this.estadoCuenta}");
            strAlumno.AppendLine(this.ParticiparEnClase());

            return strAlumno.ToString();
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
