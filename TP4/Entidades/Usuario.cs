using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades {
    public abstract class Usuario {

        protected static int idClaseUsuario;
        private int idUsuario = idClaseUsuario++;
        protected string nombreUsuario = string.Empty;
        protected string apellidoUsuario = string.Empty;
        protected int dniUsuario;

        protected Usuario() { }

        public Usuario(string nombreUsuario, int dniUsuario) {

            this.idUsuario = idClaseUsuario;
            this.NombreUsuario = nombreUsuario;
            this.DniUsuario = dniUsuario;
        }

        public Usuario(string nombreUsuario, string apellidoUsuario, int dniUsuario): this(nombreUsuario, dniUsuario) {

            this.ApellidoUsuario = apellidoUsuario;
        }

        public string NombreUsuario {
            get {
                return this.nombreUsuario;
            }
            set {
                if (Validaciones.EsNombre(value)) {
                    Validaciones.LimpiarNombre(ref value);
                    this.nombreUsuario = value;
                }
                else
                {
                    throw new InvalidNameException();
                }
            }
        }
        public string ApellidoUsuario {
            get {
                return this.apellidoUsuario;
            }
            set {
                if (Validaciones.EsNombre(value)) {
                    Validaciones.LimpiarNombre(ref value);
                    this.apellidoUsuario = value;
                }
                else
                {
                    throw new InvalidNameException();
                }
            }
        }
        public string NombreCompleto {
            get {
                return $"{this.nombreUsuario} {this.apellidoUsuario}";
            }
        }
        public int DniUsuario { 
            get => dniUsuario;
            set {
                if (Validaciones.EsDNI(value)) {
                    dniUsuario = value;
                }
                else
                {
                    throw new InvalidDniException();
                }
            }
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        public abstract string UltimaCompraPretty();
        public abstract Carrito CarritoCliente();
        public abstract string PassUsuario();
        public abstract Boolean Comprar(EMetodoPago metodoPago, string cuentaPago);
        
        public override string ToString() {

            string strUsuario = string.Empty;
            strUsuario = $"{this.NombreCompleto}\nDNI - {this.DniUsuario}\n";

            return strUsuario;
        }

    }
}
