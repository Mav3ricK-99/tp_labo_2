using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades {
    [Serializable]
    public class Compra {

        private Factura facturaCompra;
        private static int idClaseCompra;
        private int idCompra;
        private DateTime fechaAlta;

        public Compra() { }
        public Compra(Usuario usuarioCompra, EMetodoPago metodoPago, string cuentaPago) {

            this.fechaAlta = DateTime.Now;
            this.idCompra = idClaseCompra;
            this.facturaCompra = new Factura(metodoPago, cuentaPago, usuarioCompra.CarritoCliente(), usuarioCompra.NombreCompleto, usuarioCompra.DniUsuario);
            
        }
        public int IdCompra { get => idCompra; set => idCompra = value; }
        public Factura FacturaCompra { get => facturaCompra; set => facturaCompra = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
    }
}
