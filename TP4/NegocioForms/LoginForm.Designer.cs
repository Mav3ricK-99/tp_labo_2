namespace NegocioForms {
    partial class LoginForm {
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
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.linkLblRegistroLink = new System.Windows.Forms.LinkLabel();
            this.linkLblInvitado = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxUsername.Location = new System.Drawing.Point(40, 102);
            this.txtBoxUsername.Multiline = true;
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(235, 28);
            this.txtBoxUsername.TabIndex = 3;
            this.txtBoxUsername.TextChanged += new System.EventHandler(this.txtBoxUsername_TextChanged);
            this.txtBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxUsername_KeyDown);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUsername.Location = new System.Drawing.Point(37, 84);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(107, 14);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Nombre de Usuario";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPass
            // 
            this.lblPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPass.Location = new System.Drawing.Point(37, 152);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(66, 14);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Contraseña";
            this.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBoxPass.Location = new System.Drawing.Point(40, 170);
            this.txtBoxPass.Multiline = true;
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '*';
            this.txtBoxPass.Size = new System.Drawing.Size(235, 28);
            this.txtBoxPass.TabIndex = 5;
            this.txtBoxPass.TextChanged += new System.EventHandler(this.txtBoxPass_TextChanged);
            this.txtBoxPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxPass_KeyDown);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBienvenida.Location = new System.Drawing.Point(37, 38);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(185, 24);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Bienvenido denuevo";
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Enabled = false;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(40, 218);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(5);
            this.btnLogin.Size = new System.Drawing.Size(104, 42);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRegistro
            // 
            this.lblRegistro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(38, 296);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(132, 16);
            this.lblRegistro.TabIndex = 7;
            this.lblRegistro.Text = "¿No tienes una Cuenta?";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLblRegistroLink
            // 
            this.linkLblRegistroLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLblRegistroLink.AutoSize = true;
            this.linkLblRegistroLink.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblRegistroLink.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLblRegistroLink.Location = new System.Drawing.Point(170, 296);
            this.linkLblRegistroLink.Name = "linkLblRegistroLink";
            this.linkLblRegistroLink.Size = new System.Drawing.Size(60, 16);
            this.linkLblRegistroLink.TabIndex = 8;
            this.linkLblRegistroLink.TabStop = true;
            this.linkLblRegistroLink.Text = "Registrate";
            this.linkLblRegistroLink.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLblRegistroLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblRegistroLink_LinkClicked);
            // 
            // linkLblInvitado
            // 
            this.linkLblInvitado.Location = new System.Drawing.Point(0, 0);
            this.linkLblInvitado.Name = "linkLblInvitado";
            this.linkLblInvitado.Size = new System.Drawing.Size(100, 23);
            this.linkLblInvitado.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(327, 372);
            this.Controls.Add(this.linkLblInvitado);
            this.Controls.Add(this.linkLblRegistroLink);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtBoxUsername);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.LinkLabel linkLblRegistroLink;
        private System.Windows.Forms.LinkLabel linkLblInvitado;
    }
}