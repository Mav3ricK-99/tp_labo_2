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
    public partial class AddProdForm : Form {

        public delegate void RefreshStockTotal();

        public event RefreshStockTotal enviarRefresh;
        public AddProdForm() {
            InitializeComponent();
        }
        private void AddProdForm_Load(object sender, EventArgs e) {

            this.cmBoxCategoria.DataSource = Enum.GetValues(typeof(ECategorias));
            this.lblIDProd.Text += (Negocio.InvNegocio.ListaProductosInv.LastOrDefault().IdProducto + 1).ToString();
        }
        private void btnAgregar_Click(object sender, EventArgs e) {

            string nombreProd = this.txtBoxNombre.Text;
            ECategorias categoria = (ECategorias)this.cmBoxCategoria.SelectedItem;
            float precioProd;
            int stockProd;
            if (float.TryParse(this.txtBoxPrecio.Text, out precioProd) && int.TryParse(this.txtBoxStock.Text, out stockProd)) {

                try { 
                Producto nuevoProducto = new Producto(nombreProd, precioProd, categoria, stockProd);
                if (Negocio.InvNegocio + nuevoProducto) {
                    MessageBox.Show($"Producto agregado al inventario |ID - {nuevoProducto.IdProducto}|", "Agregado!");
                    this.Close();
                }
                else {
                    MessageBox.Show($"Ya hay un producto con el mismo nombre y con la misma Categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }catch(Exception excep) 
                {
                    MessageBox.Show(excep.InnerException.Message + "\n Hubo un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("Verifique los datos Ingresados", "Error al cargar el producto");
            }
        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e) {
            this.HabilitarAgregar();
        }

        private void txtBoxPrecio_TextChanged(object sender, EventArgs e) {
            this.HabilitarAgregar();
        }
        private void txtBoxStock_TextChanged(object sender, EventArgs e) {
            this.HabilitarAgregar();
        }

        private void txtBoxPrecio_KeyPress(object sender, KeyPressEventArgs e) {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }

        }
        private void txtBoxStock_KeyPress(object sender, KeyPressEventArgs e) {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void HabilitarAgregar() {

            int.TryParse(this.txtBoxStock.Text, out int stock);
            if (this.txtBoxNombre.TextLength > 2 && stock > 0) {
                this.btnAgregar.Enabled = true;
            }
            else {
                this.btnAgregar.Enabled = false;
            }

        }
        private void AddProdForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            enviarRefresh?.Invoke();
        }
    }
}
