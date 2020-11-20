namespace NegocioForms {
    partial class RegisterForm {
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
            this.lblRegistroLink = new System.Windows.Forms.LinkLabel();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtBoxApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtBoxDNI = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.lblRepetPass = new System.Windows.Forms.Label();
            this.txtBoxRepetirPass = new System.Windows.Forms.TextBox();
            this.lblExpecion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRegistroLink
            // 
            this.lblRegistroLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistroLink.AutoSize = true;
            this.lblRegistroLink.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroLink.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lblRegistroLink.Location = new System.Drawing.Point(151, 475);
            this.lblRegistroLink.Name = "lblRegistroLink";
            this.lblRegistroLink.Size = new System.Drawing.Size(50, 16);
            this.lblRegistroLink.TabIndex = 13;
            this.lblRegistroLink.TabStop = true;
            this.lblRegistroLink.Text = "Ingresar";
            this.lblRegistroLink.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.lblRegistroLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRegistroLink_LinkClicked);
            // 
            // lblRegistro
            // 
            this.lblRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.Black;
            this.lblRegistro.Location = new System.Drawing.Point(37, 475);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(114, 16);
            this.lblRegistro.TabIndex = 12;
            this.lblRegistro.Text = "¿Tienes una cuenta?";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReg
            // 
            this.btnReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReg.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReg.Enabled = false;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReg.Location = new System.Drawing.Point(40, 413);
            this.btnReg.Name = "btnReg";
            this.btnReg.Padding = new System.Windows.Forms.Padding(5);
            this.btnReg.Size = new System.Drawing.Size(113, 44);
            this.btnReg.TabIndex = 11;
            this.btnReg.TabStop = false;
            this.btnReg.Text = "Registrarse";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Usuario";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(37, 148);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(50, 14);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxApellido
            // 
            this.txtBoxApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxApellido.Location = new System.Drawing.Point(40, 166);
            this.txtBoxApellido.Multiline = true;
            this.txtBoxApellido.Name = "txtBoxApellido";
            this.txtBoxApellido.Size = new System.Drawing.Size(235, 28);
            this.txtBoxApellido.TabIndex = 4;
            this.txtBoxApellido.TextChanged += new System.EventHandler(this.txtBoxApellido_TextChanged);
            this.txtBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxApellido_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(37, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 14);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre completo";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxNombre.Location = new System.Drawing.Point(40, 98);
            this.txtBoxNombre.MaxLength = 30;
            this.txtBoxNombre.Multiline = true;
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(235, 28);
            this.txtBoxNombre.TabIndex = 2;
            this.txtBoxNombre.TextChanged += new System.EventHandler(this.txtBoxNombre_TextChanged);
            this.txtBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNombre_KeyPress);
            this.txtBoxNombre.Leave += new System.EventHandler(this.txtBoxNombre_Leave);
            // 
            // lblDNI
            // 
            this.lblDNI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(37, 212);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 14);
            this.lblDNI.TabIndex = 5;
            this.lblDNI.Text = "DNI";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxDNI
            // 
            this.txtBoxDNI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxDNI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxDNI.Location = new System.Drawing.Point(40, 231);
            this.txtBoxDNI.MaxLength = 8;
            this.txtBoxDNI.Multiline = true;
            this.txtBoxDNI.Name = "txtBoxDNI";
            this.txtBoxDNI.Size = new System.Drawing.Size(150, 27);
            this.txtBoxDNI.TabIndex = 6;
            this.txtBoxDNI.TextChanged += new System.EventHandler(this.txtBoxDNI_TextChanged);
            this.txtBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxDNI_KeyPress);
            // 
            // lblPass
            // 
            this.lblPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(38, 278);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(260, 14);
            this.lblPass.TabIndex = 7;
            this.lblPass.Text = "Contraseña (Debe contener almenos 6 caracteres)";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxPass.Location = new System.Drawing.Point(41, 296);
            this.txtBoxPass.Multiline = true;
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '*';
            this.txtBoxPass.Size = new System.Drawing.Size(150, 27);
            this.txtBoxPass.TabIndex = 8;
            this.txtBoxPass.TextChanged += new System.EventHandler(this.txtBoxPass_TextChanged);
            // 
            // lblRepetPass
            // 
            this.lblRepetPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRepetPass.AutoSize = true;
            this.lblRepetPass.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetPass.Location = new System.Drawing.Point(37, 343);
            this.lblRepetPass.Name = "lblRepetPass";
            this.lblRepetPass.Size = new System.Drawing.Size(104, 14);
            this.lblRepetPass.TabIndex = 9;
            this.lblRepetPass.Text = "Repetir contraseña";
            this.lblRepetPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxRepetirPass
            // 
            this.txtBoxRepetirPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxRepetirPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxRepetirPass.Location = new System.Drawing.Point(40, 361);
            this.txtBoxRepetirPass.Multiline = true;
            this.txtBoxRepetirPass.Name = "txtBoxRepetirPass";
            this.txtBoxRepetirPass.PasswordChar = '*';
            this.txtBoxRepetirPass.Size = new System.Drawing.Size(150, 27);
            this.txtBoxRepetirPass.TabIndex = 10;
            this.txtBoxRepetirPass.TextChanged += new System.EventHandler(this.txtBoxRepetirPass_TextChanged);
            // 
            // lblExpecion
            // 
            this.lblExpecion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExpecion.AutoSize = true;
            this.lblExpecion.ForeColor = System.Drawing.Color.Firebrick;
            this.lblExpecion.Location = new System.Drawing.Point(38, 395);
            this.lblExpecion.Name = "lblExpecion";
            this.lblExpecion.Size = new System.Drawing.Size(0, 14);
            this.lblExpecion.TabIndex = 23;
            this.lblExpecion.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(317, 534);
            this.Controls.Add(this.lblExpecion);
            this.Controls.Add(this.lblRepetPass);
            this.Controls.Add(this.txtBoxRepetirPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtBoxDNI);
            this.Controls.Add(this.lblRegistroLink);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtBoxApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtBoxNombre);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Registro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblRegistroLink;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtBoxApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtBoxDNI;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label lblRepetPass;
        private System.Windows.Forms.TextBox txtBoxRepetirPass;
        private System.Windows.Forms.Label lblExpecion;
    }
}