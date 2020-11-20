using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Carrito {

        private Dictionary<Producto, int> diccionarioProductos;
        private float precioTotal;

        public Carrito() {

            this.diccionarioProductos = new Dictionary<Producto, int>(0);
        }
        public Carrito(Producto nuevoProd, int cantidad) : this() {

            this.diccionarioProductos.Add(nuevoProd, cantidad);
            precioTotal = nuevoProd.PrecioProducto * cantidad;

        }

        public Dictionary<Producto, int> DiccionarioProductos { get => diccionarioProductos; set => diccionarioProductos = value; }
        public float PrecioTotal { get => precioTotal; set => precioTotal = value; }

        public void CalcularPrecioTotalCarrito() {

            this.precioTotal = 0;
            foreach (var producto in diccionarioProductos) {

                this.precioTotal += producto.Key.PrecioProducto * producto.Value;
            }
        }

        public Boolean AgregarAlCarrito(Producto productoCarrito) {

            bool rtrn = false;
            if (Negocio.InvNegocio.CambiarStockInventario(productoCarrito, -1)) {
                rtrn = true;
                if (this.ExisteEnCarrito(productoCarrito)) {
                    this.DiccionarioProductos[productoCarrito]++;
                }
                else {
                    this.DiccionarioProductos.Add(productoCarrito, 1);
                }
                this.CalcularPrecioTotalCarrito();
            }

            return rtrn;
        }
        public void RestarCantidadDelCarrito(Producto productoCarrito) {

            if (this.DiccionarioProductos[productoCarrito] > 1) {
                this.DiccionarioProductos[productoCarrito]--;
            }
            else {
                DiccionarioProductos.Keys.ToList().ForEach(key => diccionarioProductos.Remove(productoCarrito));
                
            }
            Negocio.InvNegocio.CambiarStockInventario(productoCarrito, 1);
            this.CalcularPrecioTotalCarrito();
        }

        public Boolean ExisteEnCarrito(Producto productoCarrito) {
            bool rtrn = false;
            if (this.DiccionarioProductos.ContainsKey(productoCarrito)) {
                rtrn = true;
            }
            return rtrn;
        }

        public int CantidadTotalProductosCarrito() {

            int cantProds = 0;
            foreach (var producto in DiccionarioProductos) {

                cantProds += producto.Value;
            }

            return cantProds;
        }

        public void DarDescuentoTotal(float descuento) {

            this.precioTotal = 0;
            foreach (var producto in DiccionarioProductos) {

                producto.Key.PrecioProducto -= (producto.Key.PrecioProducto * descuento) / 100;
                this.precioTotal += producto.Key.PrecioProducto;
            }

        }

        public override string ToString() {
            string rtrnString = string.Empty;
            foreach (var producto in DiccionarioProductos) {

                rtrnString += $" Nombre del producto {"-",4} {producto.Key.NombreProducto, 15}\n " +
                              $"Categoria producto {"-", 7} {producto.Key.CategoriaProducto, 15}\n" +
                              $" Precio por unidad {"-",9} {producto.Key.PrecioProducto, 15}\n " +
                              $"Cantidad a comprar {"-",6} {producto.Value, 15}\n " +
                              $"Subtotal  {"-",23} {producto.Key.PrecioProducto*producto.Value,15}\n " +
                              $"- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -\n";

            }
            rtrnString += $"TOTAL {"-",25} {"$"+this.PrecioTotal, 15}\n";

            return rtrnString;
        }

    }

}
