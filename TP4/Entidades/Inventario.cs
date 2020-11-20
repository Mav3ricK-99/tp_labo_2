using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
     public sealed class Inventario {

        private static Inventario instancia = null;
        private List<Producto> listaProductosInv;


        public static Inventario Instancia {
            get {
                if (instancia == null) {
                    instancia = new Inventario();
                }
                return instancia;
            }
        }
        private Inventario() {
            this.listaProductosInv = new List<Producto>(0);
        }
        public List<Producto> ListaProductosInv { get => listaProductosInv; set => listaProductosInv = value; }

        public void AgregarProducto(Producto prod) {

            try { 
            this.listaProductosInv.Add(prod);
            DB.Insert<Producto>(prod);
            this.TotalStockProductos();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public Boolean CambiarStockInventario(Producto producto, int cantidad) {

            bool rtrn = false;
            if(producto.StockProducto > 0) {
                producto.StockProducto += cantidad;
                rtrn = true;
            }  
            return rtrn;
        }
        public int TotalStockProductos() {

            int totalStock = 0;
            foreach (Producto prod in listaProductosInv) {
                totalStock += prod.StockProducto;
            }

            return totalStock;
        }

        public Producto BuscarEnInventario(int idProducto) {

            foreach (Producto producto in listaProductosInv) {

                if (producto.IdProducto == idProducto)
                    return producto;
            }

            return null;
        }

        public static Boolean operator +(Inventario inv, Producto prod) {

            bool rtrn = false;
            try {
                prod.IdProducto--;
                if (!inv.ExisteEnInventario(prod)) {
                    inv.AgregarProducto(prod);
                    rtrn = true;
                }
            }catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
            return rtrn;
        }

        public List<Producto> ProductosConStock(int stock) {

            List<Producto> listaProdsConStock = new List<Producto>(0);
            foreach (var producto in Negocio.InvNegocio.ListaProductosInv) {

                if(stock < 0) {
                    if (producto.StockProducto < (stock*-1)) {
                        listaProdsConStock.Add(producto);
                    }
                }
                else {
                    if (producto.StockProducto > stock) {
                        listaProdsConStock.Add(producto);
                    }
                }
                
            }
            return listaProdsConStock;
        }

        public bool ExisteEnInventario(Producto prod) {

            bool rtrn = false;
            foreach (Producto productosLista in Negocio.InvNegocio.ListaProductosInv) {

                if (productosLista.NombreProducto == prod.NombreProducto && productosLista.CategoriaProducto == prod.CategoriaProducto) {
                    rtrn = true;
                    break;
                }
            }

            return rtrn;
        }

        public void AgregarVendidos(Carrito carrito) {

            foreach (var prod in carrito.DiccionarioProductos) {

                this.listaProductosInv.Find(x => x.IdProducto == prod.Key.IdProducto).CantVendidos += prod.Value;
                DB.Update<Producto>((Producto)prod.Key);
            }

        }
    }
}
