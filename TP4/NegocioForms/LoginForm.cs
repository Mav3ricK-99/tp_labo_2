using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Entidades;

namespace NegocioForms {
    public partial class LoginForm : Form {


        public LoginForm() {

            InitializeComponent();
        }

        private void linkLblRegistroLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            this.Hide();
            new RegisterForm().Show();

        }
        
        private void btnLogin_Click(object sender, EventArgs e) {

            Usuario usuarioIngresado = Negocio.IngresoUsuario(this.txtBoxUsername.Text, this.txtBoxPass.Text);

            ControlPanelForm controlPanel = Application.OpenForms.OfType<ControlPanelForm>().FirstOrDefault();
            if (usuarioIngresado == null) {//Excepcion
                this.txtBoxPass.Text = "";
                this.txtBoxUsername.Text = "";
                MessageBox.Show("Nombre de usuario o Contraseña mal ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                if (controlPanel != null) {
                    this.Hide();
                    controlPanel.UsuarioIngresado = usuarioIngresado;
                    controlPanel.Show();

                }
                else {
                    this.Hide();
                    new ControlPanelForm(usuarioIngresado).Show();
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e) {

            this.Text += Negocio.NombreNegocio;
        }

        private void txtBoxUsername_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                this.btnLogin_Click(sender, e);
            }
        }

        private void txtBoxPass_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.SuppressKeyPress = true;
                this.btnLogin_Click(sender, e);
            }
        }

        private Boolean HabilitarLogin() {

            if (this.txtBoxPass.Text.Length > 5 && this.txtBoxUsername.Text.Length > 1) {
                this.btnLogin.Enabled = true;
                return true;
            }
            else {
                this.btnLogin.Enabled = false;
                return false;
            }
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e) {
            this.HabilitarLogin();
        }

        private void txtBoxPass_TextChanged(object sender, EventArgs e) {
            this.HabilitarLogin();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
