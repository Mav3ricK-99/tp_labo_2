using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public enum ENacionalidad
    {
        Argentino,
        Extranjero
    }

    public abstract class Persona
    {
        
        protected string nombrePersona, apellidoPersona;
        protected ENacionalidad nacionalidadPersona;
        protected int dniPersona;

        public string NombrePersona { 
            get => nombrePersona;
            set { nombrePersona = this.ValidarNombreApellido(value); }
            }
        public string ApellidoPersona { 
            get => apellidoPersona;
            set { apellidoPersona = this.ValidarNombreApellido(value); }
        }
        public ENacionalidad NacionalidadPersona { get => nacionalidadPersona; set => nacionalidadPersona = value; }
        public int DniPersona { 
            get => dniPersona;
            set { dniPersona = this.ValidarDNI(this.nacionalidadPersona, value); } }
        public string StringToDNI
        {
            set
            {
                dniPersona = this.ValidarDNI(this.nacionalidadPersona, value);
            }
        }
        public Persona()
        {

        }
        public Persona(string nombrePersona, string apellidoPersona, ENacionalidad nacionalidad)
        {
            this.NombrePersona = nombrePersona;
            this.ApellidoPersona = apellidoPersona;
            this.NacionalidadPersona = nacionalidad;
        }

        public Persona(string nombrePersona, string apellidoPersona, ENacionalidad nacionalidad, int dniPersona) : this(nombrePersona, apellidoPersona, nacionalidad)
        {
            this.DniPersona = dniPersona;
        }

        public Persona(string nombrePersona, string apellidoPersona, ENacionalidad nacionalidad, string dniPersona) : this(nombrePersona, apellidoPersona, nacionalidad)
        {
            this.StringToDNI = dniPersona;
        }

        private int ValidarDNI(ENacionalidad nacionalidad, int dato)
        {
            switch (nacionalidad)
            {
                case ENacionalidad.Argentino: { if (dato < 1 || dato >= 99999999) { throw new NacionalidadInvalidaException("Se ha Ingresado mal el Numero DNI teniendo en cuenta la nacionalidad (Argentino)");  } };break;
                case ENacionalidad.Extranjero: { if (dato < 90000000 || dato > 99999999) { throw new NacionalidadInvalidaException("Se ha Ingresado mal el Numero DNI teniendo en cuenta la nacionalidad (Extranjero)"); } }; break;
                default: { throw new NacionalidadInvalidaException("Nacionalidad Incorrecta"); }
            }
           
            return dato;
        }
        private int ValidarDNI(ENacionalidad nacionalidad, string dato)
        {
            for (int i = 0; i < dato.Length; i++)
            {
                if(!char.IsDigit(dato[i]) || dato.Length > 8)
                {
                    throw new DniInvalidoException("Se a ingresado un DNI con formato Invalido.");
                }
            }
            int dniPersona = int.Parse(dato);
            this.ValidarDNI(nacionalidad, dniPersona);

            return dniPersona;
        }

        private string ValidarNombreApellido(string dato)
        {
            for (int i = 0; i < dato.Length; i++)
            {
                if (char.IsDigit(dato[i]) || dato.Length <= 2)
                {
                    return string.Empty;
                }
            }
            
            return dato;
        }

        public override string ToString()
        {
            StringBuilder strPersona = new StringBuilder();
            strPersona.AppendLine($"Nombre completo: {this.ApellidoPersona}, {this.NombrePersona}");
            strPersona.AppendLine($"Nacionalidad: {this.NacionalidadPersona}");
        
            return strPersona.ToString();
        }

    }
}
