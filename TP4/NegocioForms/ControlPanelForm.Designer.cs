using Entidades;

namespace NegocioForms {
    partial class ControlPanelForm {
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
        /// 
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanelForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dtaGridMainInfo = new System.Windows.Forms.DataGridView();
            this.txtBoxBusqueda = new System.Windows.Forms.TextBox();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnIrCarrito = new System.Windows.Forms.Button();
            this.lblStockTotal = new System.Windows.Forms.Label();
            this.lblUltimaCompra = new System.Windows.Forms.Label();
            this.inventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carritoColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridMainInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(658, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.Visible = false;
            // 
            // dtaGridMainInfo
            // 
            this.dtaGridMainInfo.AllowUserToAddRows = false;
            this.dtaGridMainInfo.AllowUserToDeleteRows = false;
            this.dtaGridMainInfo.AllowUserToResizeColumns = false;
            this.dtaGridMainInfo.AllowUserToResizeRows = false;
            this.dtaGridMainInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtaGridMainInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtaGridMainInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtaGridMainInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtaGridMainInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtaGridMainInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridMainInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtaGridMainInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtaGridMainInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carritoColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtaGridMainInfo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtaGridMainInfo.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtaGridMainInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtaGridMainInfo.Location = new System.Drawing.Point(12, 218);
            this.dtaGridMainInfo.Name = "dtaGridMainInfo";
            this.dtaGridMainInfo.ReadOnly = true;
            this.dtaGridMainInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaGridMainInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtaGridMainInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DodgerBlue;
            this.dtaGridMainInfo.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtaGridMainInfo.RowTemplate.ReadOnly = true;
            this.dtaGridMainInfo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtaGridMainInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtaGridMainInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtaGridMainInfo.ShowCellToolTips = false;
            this.dtaGridMainInfo.ShowEditingIcon = false;
            this.dtaGridMainInfo.ShowRowErrors = false;
            this.dtaGridMainInfo.Size = new System.Drawing.Size(677, 294);
            this.dtaGridMainInfo.TabIndex = 5;
            this.dtaGridMainInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaGridMainInfo_CellContentClick);
            // 
            // txtBoxBusqueda
            // 
            this.txtBoxBusqueda.Location = new System.Drawing.Point(12, 184);
            this.txtBoxBusqueda.Name = "txtBoxBusqueda";
            this.txtBoxBusqueda.Size = new System.Drawing.Size(143, 21);
            this.txtBoxBusqueda.TabIndex = 3;
            this.txtBoxBusqueda.TextChanged += new System.EventHandler(this.txtBoxBusqueda_TextChanged);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBusqueda.Location = new System.Drawing.Point(10, 165);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(110, 17);
            this.lblBusqueda.TabIndex = 2;
            this.lblBusqueda.Text = "Buscar Productos";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblWelcome.Location = new System.Drawing.Point(17, 33);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 19);
            this.lblWelcome.TabIndex = 1;
            // 
            // btnIrCarrito
            // 
            this.btnIrCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIrCarrito.BackColor = System.Drawing.Color.LimeGreen;
            this.btnIrCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrCarrito.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIrCarrito.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIrCarrito.Location = new System.Drawing.Point(606, 176);
            this.btnIrCarrito.Name = "btnIrCarrito";
            this.btnIrCarrito.Size = new System.Drawing.Size(83, 38);
            this.btnIrCarrito.TabIndex = 7;
            this.btnIrCarrito.Text = "Ir al Carrito";
            this.btnIrCarrito.UseVisualStyleBackColor = false;
            this.btnIrCarrito.Visible = false;
            this.btnIrCarrito.Click += new System.EventHandler(this.btnIrCarrito_Click);
            // 
            // lblStockTotal
            // 
            this.lblStockTotal.AutoSize = true;
            this.lblStockTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockTotal.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblStockTotal.Location = new System.Drawing.Point(170, 184);
            this.lblStockTotal.Name = "lblStockTotal";
            this.lblStockTotal.Size = new System.Drawing.Size(158, 19);
            this.lblStockTotal.TabIndex = 4;
            this.lblStockTotal.Text = "Cantidad total de Stock ";
            // 
            // lblUltimaCompra
            // 
            this.lblUltimaCompra.AutoSize = true;
            this.lblUltimaCompra.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimaCompra.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblUltimaCompra.Location = new System.Drawing.Point(375, 33);
            this.lblUltimaCompra.Name = "lblUltimaCompra";
            this.lblUltimaCompra.Size = new System.Drawing.Size(0, 19);
            this.lblUltimaCompra.TabIndex = 8;
            // 
            // inventarioBindingSource
            // 
            //this.inventarioBindingSource.DataSource = typeof(Entidades.Inventario);
            // 
            // carritoColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.NullValue = "Al carrito";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DodgerBlue;
            this.carritoColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.carritoColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carritoColumn.HeaderText = "Carrito";
            this.carritoColumn.Name = "carritoColumn";
            this.carritoColumn.ReadOnly = true;
            this.carritoColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.carritoColumn.Text = "Agregar";
           
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.NullValue = "Agregar Stock";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DodgerBlue;
            // 
            // ControlPanelForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(701, 524);
            this.Controls.Add(this.lblUltimaCompra);
            this.Controls.Add(this.lblStockTotal);
            this.Controls.Add(this.btnIrCarrito);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.txtBoxBusqueda);
            this.Controls.Add(this.dtaGridMainInfo);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlPanelForm_FormClosing);
            this.Load += new System.EventHandler(this.ControlPanelForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ControlPanelForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridMainInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void CargarVista() {


            if (this.usuarioIngresado is Cliente) {
                Cliente cliente = (Cliente)this.usuarioIngresado;
                this.lblUltimaCompra.Visible = true;
                this.lblUltimaCompra.Text = cliente.UltimaCompraPretty();
                this.GenerarVistaCliente();
                this.MostrarCierreSesion();
            }
        }
        private void GenerarVistaCliente() {

            this.lblStockTotal.Visible = false;
            this.dtaGridMainInfo.Columns[0].DisplayIndex = 6;
            this.dtaGridMainInfo.Columns["carritoColumn"].Visible = true;
            this.lblStockTotal.Visible = true;
            this.lblStockTotal.Text = $"Cantidad total de Stock {Negocio.InvNegocio.TotalStockProductos().ToString()}";

            System.Windows.Forms.ToolStripMenuItem menuOpciones = new System.Windows.Forms.ToolStripMenuItem("Opciones");

            System.Windows.Forms.ToolStripMenuItem subMenuOpcionesListado = new System.Windows.Forms.ToolStripMenuItem("Ver listado");
            System.Windows.Forms.ToolStripMenuItem subMenuProductos = new System.Windows.Forms.ToolStripMenuItem("Productos");
            System.Windows.Forms.ToolStripMenuItem subMenuUsuarios = new System.Windows.Forms.ToolStripMenuItem("Usuarios");
            System.Windows.Forms.ToolStripMenuItem subMenuCompras = new System.Windows.Forms.ToolStripMenuItem("Compras");
            System.Windows.Forms.ToolStripMenuItem subMenuAgregarProducto = new System.Windows.Forms.ToolStripMenuItem("Agregar Producto");
       
            subMenuAgregarProducto.Click += new System.EventHandler(SubMenuAgregarProductoToolStripMenuItem_Click);
            subMenuProductos.Click += new System.EventHandler(SubMenuProductosToolStripMenuItem_Click);
            subMenuUsuarios.Click += new System.EventHandler(SubMenuUsuariosToolStripMenuItem_Click);
            subMenuCompras.Click += new System.EventHandler(SubMenuComprasToolStripMenuItem_Click);

            System.Windows.Forms.ToolStripItem[] itemSubMenuOpciones = { subMenuOpcionesListado, subMenuAgregarProducto };
            System.Windows.Forms.ToolStripItem[] itemSubMenuOpcionesLista = { subMenuProductos, subMenuUsuarios, subMenuCompras };

            menuOpciones.DropDownItems.AddRange(itemSubMenuOpciones);
            subMenuOpcionesListado.DropDownItems.AddRange(itemSubMenuOpcionesLista);
            this.menuStrip.Items.Add(menuOpciones);
        }
     
        private void MostrarCierreSesion() {

            System.Windows.Forms.ToolStripMenuItem cierreSesion = new System.Windows.Forms.ToolStripMenuItem("Cerrar sesion");
            cierreSesion.Click += new System.EventHandler(CierreSesionToolStripMenuItem_Click);
            this.menuStrip.Items.Add(cierreSesion);
        }
        private void MostrarLoginYRegistro() {

            System.Windows.Forms.ToolStripMenuItem menuCuenta = new System.Windows.Forms.ToolStripMenuItem("Cuenta");
            System.Windows.Forms.ToolStripMenuItem subMenuIngreso = new System.Windows.Forms.ToolStripMenuItem("Ingresar");
            System.Windows.Forms.ToolStripMenuItem subMenuRegistro = new System.Windows.Forms.ToolStripMenuItem("Registrarse");

            subMenuIngreso.Click += new System.EventHandler(CierreSesionToolStripMenuItem_Click);
            subMenuRegistro.Click += new System.EventHandler(RegistroToolStripMenuItem_Click);

            System.Windows.Forms.ToolStripItem[] itemCuenta = { subMenuIngreso, subMenuRegistro };
            menuCuenta.DropDownItems.AddRange(itemCuenta);

            this.menuStrip.Items.Add(menuCuenta);
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.DataGridView dtaGridMainInfo;
        private System.Windows.Forms.BindingSource inventarioBindingSource;
        private System.Windows.Forms.TextBox txtBoxBusqueda;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnIrCarrito;
        private System.Windows.Forms.Label lblStockTotal;
        private System.Windows.Forms.Label lblUltimaCompra;
        private System.Windows.Forms.DataGridViewButtonColumn carritoColumn;
    }
}