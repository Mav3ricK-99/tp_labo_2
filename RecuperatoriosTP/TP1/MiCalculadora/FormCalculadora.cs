﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora {
    public partial class FormCalculadora : Form {

        public FormCalculadora() {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) {

            this.lblResultado.Text = "";
            this.cmboxOperador.Text = "";
            this.txtNum1.Text = "";
            this.txtNum2.Text = "";
        }

        private void btnOperar_Click(object sender, EventArgs e) {

            Numero num1 = new Numero(this.txtNum1.Text);
            Numero num2 = new Numero(this.txtNum2.Text);

            this.lblResultado.Text = FormCalculadora.Operar(num1, num2, this.cmboxOperador.Text).ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnToBinary_Click(object sender, EventArgs e) {
            
            if(this.lblResultado.Text != "") {
                Numero numResultado = new Numero(this.lblResultado.Text);
                this.lblResultado.Text = numResultado.DecimalBinario(this.lblResultado.Text);
            }
        }

        private void btnToDecimal_Click(object sender, EventArgs e) {
            
            if (this.lblResultado.Text != "") {
                Numero numResultado = new Numero(this.lblResultado.Text);
                this.lblResultado.Text = numResultado.BinarioDecimal(this.lblResultado.Text);
            }
        }
        private static double Operar(Numero num1, Numero num2, string operador) {

            return Calculadora.Operar(num1, num2, operador);
        }
    }
}