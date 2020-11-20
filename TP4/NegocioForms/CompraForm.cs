using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NegocioForms {
    public partial class CompraForm : Form {
        Usuario usuarioIngresado;
        Boolean mostrarMsgSalida = true;
        private Usuario UsuarioIngresado { get => usuarioIngresado; set => usuarioIngresado = value; }

        public CompraForm(Usuario usuarioIngresado) {
            InitializeComponent();
            this.usuarioIngresado = usuarioIngresado;
        }

        private void CompraForm_Load(object sender, EventArgs e) {

            this.CargarDatosCompra();
        }
        private void CargarDatosCompra() {

            this.richTxtBoxListado.Text = UsuarioIngresado.CarritoCliente().ToString();
            this.lblCantidadProds.Text = UsuarioIngresado.CarritoCliente().CantidadTotalProductosCarrito().ToString();
            this.lblTotalPago.Text = "$" + UsuarioIngresado.CarritoCliente().PrecioTotal.ToString();
            this.cmboxMetodoPago.DataSource = Enum.GetValues(typeof(EMetodoPago));
            this.lblNombre.Text = UsuarioIngresado.NombreCompleto;
            this.lblDNI.Text = UsuarioIngresado.DniUsuario.ToString();

        }

        private void cmboxMetodoPago_SelectedIndexChanged(object sender, EventArgs e) {
            this.HabilitarCompra();
            this.lblInfoPago.Text = this.InfoPago();
        }

        private string InfoPago() {

            string strInfo = string.Empty;
            this.txtBoxDatoPago.Enabled = true;
            this.txtBoxDatoPago.Visible = true;
            this.lblNombre.Location = new Point(11, 320);
            this.lblDNI.Location = new Point(141, 320);
            switch (this.cmboxMetodoPago.SelectedItem) {
                case EMetodoPago.Efectivo: {
                        strInfo += "Paga por caja.";
                        this.txtBoxDatoPago.Enabled = false;
                        this.btnEfectuar.Enabled = true;
                    }; break;
                case EMetodoPago.TarjetaDebito: { strInfo += "Ingrese el numero de la tarjeta."; }; break;
                case EMetodoPago.TarjetaCredito: { strInfo += "Ingrese el numero de la tarjeta de Credito."; }; break;
                case EMetodoPago.BTC: {
                        strInfo += "19xGfn56cFb9YEvpFojGyM5WzMxVXJUtR5";
                        this.txtBoxDatoPago.Enabled = false;
                        this.txtBoxDatoPago.Visible = false;
                        this.lblNombre.Location = new Point(11, 290);
                        this.lblDNI.Location = new Point(141, 290);
                    }; break;
            }

            return strInfo;
        }

        private void btnEfectuar_Click(object sender, EventArgs e) {

            if (UsuarioIngresado.Comprar((EMetodoPago)this.cmboxMetodoPago.SelectedItem, this.txtBoxDatoPago.Text)) {
                
                this.btnEfectuar.Enabled = false;
                this.mostrarMsgSalida = false;
                this.Close();
            }
        }
        private void CompraForm_FormClosing(object sender, FormClosingEventArgs e) {

            if (this.mostrarMsgSalida) {
                DialogResult mensajeSalida = MessageBox.Show("¿Continuar con la compra?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (mensajeSalida == DialogResult.Yes) { e.Cancel = true; }
            }
        }

        private void txtBoxDatoPago_KeyPress(object sender, KeyPressEventArgs e) {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
        private void HabilitarCompra() {
            if(this.txtBoxDatoPago.TextLength > 9) {
                this.btnEfectuar.Enabled = true;
            }
            else {
                this.btnEfectuar.Enabled = false;
            }
        }
        private void txtBoxDatoPago_TextChanged(object sender, EventArgs e) {
            this.HabilitarCompra();
        }
    }
}
