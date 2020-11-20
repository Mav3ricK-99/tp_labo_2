using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;

namespace NegocioForms {
    public partial class RegisterForm : Form {

        public RegisterForm() {
            InitializeComponent();
        }


        private void RegisterForm_Load(object sender, EventArgs e) {

        }

        private void txtBoxDNI_KeyPress(object sender, KeyPressEventArgs e) {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }

        }
        private void txtBoxPass_TextChanged(object sender, EventArgs e) {

            HabilitarRegistro();
        }
        private void txtBoxRepetirPass_TextChanged(object sender, EventArgs e) {

            HabilitarRegistro();
        }
        private void txtBoxDNI_TextChanged(object sender, EventArgs e) {
            HabilitarRegistro();
        }
        private void txtBoxNombre_TextChanged(object sender, EventArgs e) {

           HabilitarRegistro();
        }
        private void txtBoxApellido_TextChanged(object sender, EventArgs e) {
            HabilitarRegistro();
        }
        private void HabilitarRegistro() {

            if((this.txtBoxPass.Text == this.txtBoxRepetirPass.Text) &&
                this.txtBoxPass.Text.Length > 5 && 
                this.txtBoxRepetirPass.Text.Length > 5 &&
                this.txtBoxDNI.Text.Length == 8 &&
                this.txtBoxApellido.Text.Length > 1 &&
                this.txtBoxNombre.Text.Length > 1) { 
            
                this.btnReg.Enabled = true;
            }
            else {
                this.btnReg.Enabled = false;
            }
        }

        private void txtBoxNombre_Leave(object sender, EventArgs e) {

            if(this.txtBoxNombre.TextLength < 2) {
                this.lblExpecion.Visible = true;
                this.lblExpecion.Text = "El nombre debe ser mayor a un caracter";
            }
            else {
                this.lblExpecion.Visible = false;
            }

        }

        private void btnReg_Click(object sender, EventArgs e) {

            int dniUsuario;
            DialogResult closeMsg = DialogResult.No;
            if (int.TryParse(this.txtBoxDNI.Text, out dniUsuario))
            {
                try
                {
                    Negocio.AgregarCliente(this.txtBoxNombre.Text, this.txtBoxApellido.Text, dniUsuario, this.txtBoxPass.Text);
                }
                catch (UsuarioRepetidoException ex)
                {
                    closeMsg = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidNameException invalidName)
                {
                    closeMsg = MessageBox.Show(invalidName.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (InvalidDniException invalidDNI)
                {
                    closeMsg = MessageBox.Show(invalidDNI.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception t)
                {
                    closeMsg = MessageBox.Show(t.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (closeMsg == DialogResult.No)
                    this.Close();
            }
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e) {

            Form loginForm = Application.OpenForms["loginForm"];
            loginForm.Show();

        }

        private void lblRegistroLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            this.Close();
        }

        private void txtBoxNombre_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void txtBoxApellido_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}
