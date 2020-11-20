using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegocioForms {
    public partial class CartForm : Form {

        Usuario usuarioIngresado;
        public CartForm(Usuario usuarioIngresado) {
            this.usuarioIngresado = usuarioIngresado;
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e) {

            this.CargarCarrito();
            this.lblPrecio.Text = String.Format("${0:C}", this.usuarioIngresado.CarritoCliente().PrecioTotal.ToString());

        }

        private void dtaGridViewCartItems_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            //Castea a Int para luego buscarlo por ID en Inventario.
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {

                int idProducto = Convert.ToInt32(this.dtaGridViewCartItems.Rows[e.RowIndex].Cells[0].Value);
                Producto productoAgregado = Negocio.InvNegocio.BuscarEnInventario(idProducto);
                this.CambiarCantidad(e, productoAgregado);
            }
        }

        private void CargarCarrito() {

            this.dtaGridViewCartItems.Rows.Clear();
            this.dtaGridViewCartItems.Refresh();
            foreach (var item in this.usuarioIngresado.CarritoCliente().DiccionarioProductos) {

                Producto productoCarrito = item.Key;

                this.dtaGridViewCartItems.Rows.Add(new object[] {
                                $"{productoCarrito.IdProducto}",
                                $"{productoCarrito.NombreProducto}",
                                $"{productoCarrito.PrecioProducto}",
                                $"{productoCarrito.CategoriaProducto}",
                                $"{item.Value}"});
            }
        }

        private void CambiarCantidad(DataGridViewCellEventArgs e, Producto productoAgregado) {

            switch (e.ColumnIndex) {
                case 5: { if (!this.usuarioIngresado.CarritoCliente().AgregarAlCarrito(productoAgregado)) { MessageBox.Show("No queda mas Stock para este Producto."); } } break;
                case 6: { this.usuarioIngresado.CarritoCliente().RestarCantidadDelCarrito(productoAgregado); } break;
            }
            this.CargarCarrito();
            if (this.dtaGridViewCartItems.Rows.Count == 0)
                this.btnComprar.Enabled = false;

            this.lblPrecio.Text = String.Format("${0:C}", this.usuarioIngresado.CarritoCliente().PrecioTotal.ToString());
        }

        private void btnComprar_Click(object sender, EventArgs e) {

            CompraForm nuevaCompra = new CompraForm(this.usuarioIngresado);
            this.Hide();
            nuevaCompra.ShowDialog();
            this.Close();

        }

    }
}
