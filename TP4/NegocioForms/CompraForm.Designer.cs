namespace NegocioForms {
    partial class CompraForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnEfectuar = new System.Windows.Forms.Button();
            this.richTxtBoxListado = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidadProds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.cmboxMetodoPago = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxDatoPago = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblInfoPago = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEfectuar
            // 
            this.btnEfectuar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEfectuar.Enabled = false;
            this.btnEfectuar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEfectuar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfectuar.ForeColor = System.Drawing.Color.White;
            this.btnEfectuar.Location = new System.Drawing.Point(142, 362);
            this.btnEfectuar.Name = "btnEfectuar";
            this.btnEfectuar.Size = new System.Drawing.Size(126, 39);
            this.btnEfectuar.TabIndex = 12;
            this.btnEfectuar.Text = "Efectuar compra";
            this.btnEfectuar.UseVisualStyleBackColor = false;
            this.btnEfectuar.Click += new System.EventHandler(this.btnEfectuar_Click);
            // 
            // richTxtBoxListado
            // 
            this.richTxtBoxListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtBoxListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtBoxListado.Location = new System.Drawing.Point(12, 13);
            this.richTxtBoxListado.Name = "richTxtBoxListado";
            this.richTxtBoxListado.ReadOnly = true;
            this.richTxtBoxListado.Size = new System.Drawing.Size(261, 112);
            this.richTxtBoxListado.TabIndex = 100;
            this.richTxtBoxListado.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(9, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total cantidad de productos";
            // 
            // lblCantidadProds
            // 
            this.lblCantidadProds.AutoSize = true;
            this.lblCantidadProds.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCantidadProds.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProds.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblCantidadProds.Location = new System.Drawing.Point(216, 142);
            this.lblCantidadProds.Name = "lblCantidadProds";
            this.lblCantidadProds.Size = new System.Drawing.Size(0, 16);
            this.lblCantidadProds.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(9, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total final a Pagar";
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPago.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTotalPago.Location = new System.Drawing.Point(208, 179);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(0, 16);
            this.lblTotalPago.TabIndex = 5;
            // 
            // cmboxMetodoPago
            // 
            this.cmboxMetodoPago.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmboxMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxMetodoPago.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cmboxMetodoPago.FormattingEnabled = true;
            this.cmboxMetodoPago.Location = new System.Drawing.Point(147, 204);
            this.cmboxMetodoPago.Name = "cmboxMetodoPago";
            this.cmboxMetodoPago.Size = new System.Drawing.Size(121, 23);
            this.cmboxMetodoPago.TabIndex = 7;
            this.cmboxMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cmboxMetodoPago_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(10, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Metodo de Pago";
            // 
            // txtBoxDatoPago
            // 
            this.txtBoxDatoPago.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxDatoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDatoPago.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtBoxDatoPago.Location = new System.Drawing.Point(14, 267);
            this.txtBoxDatoPago.MaxLength = 19;
            this.txtBoxDatoPago.Multiline = true;
            this.txtBoxDatoPago.Name = "txtBoxDatoPago";
            this.txtBoxDatoPago.Size = new System.Drawing.Size(156, 28);
            this.txtBoxDatoPago.TabIndex = 9;
            this.txtBoxDatoPago.TextChanged += new System.EventHandler(this.txtBoxDatoPago_TextChanged);
            this.txtBoxDatoPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDatoPago_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblNombre.Location = new System.Drawing.Point(11, 320);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 16);
            this.lblNombre.TabIndex = 10;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblDNI.Location = new System.Drawing.Point(141, 320);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(0, 16);
            this.lblDNI.TabIndex = 11;
            // 
            // lblInfoPago
            // 
            this.lblInfoPago.AutoSize = true;
            this.lblInfoPago.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPago.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblInfoPago.Location = new System.Drawing.Point(11, 240);
            this.lblInfoPago.Name = "lblInfoPago";
            this.lblInfoPago.Size = new System.Drawing.Size(0, 16);
            this.lblInfoPago.TabIndex = 108;
            // 
            // CompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(285, 409);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblInfoPago);
            this.Controls.Add(this.txtBoxDatoPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmboxMetodoPago);
            this.Controls.Add(this.lblTotalPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCantidadProds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTxtBoxListado);
            this.Controls.Add(this.btnEfectuar);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra de Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CompraForm_FormClosing);
            this.Load += new System.EventHandler(this.CompraForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEfectuar;
        private System.Windows.Forms.RichTextBox richTxtBoxListado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidadProds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.ComboBox cmboxMetodoPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxDatoPago;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblInfoPago;
    }
}