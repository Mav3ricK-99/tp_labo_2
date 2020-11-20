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

namespace NegocioForms {

     public partial class ControlPanelForm : Form {

        Boolean msgSalida = true;
        Timer tiempoSesion;
        Usuario usuarioIngresado;

        public Usuario UsuarioIngresado {
            get => usuarioIngresado;
            set {
                usuarioIngresado = value;
                this.menuStrip.Items.Clear();
                ControlPanelForm_Load(null, EventArgs.Empty);
            }
        }

        public ControlPanelForm(Usuario usuarioIngr) {
            
            InitializeComponent();
            this.tiempoSesion = new Timer();
            this.usuarioIngresado = usuarioIngr;

        }

        private void ControlPanelForm_Load(object sender, EventArgs e) {

            this.dtaGridMainInfo.DataSource = Negocio.InvNegocio.ListaProductosInv;
            this.ShowDatosUsuario();
            this.CargarVista();
            this.ActivarTimerInactividad();
            
        }
        private void dtaGridMainInfo_CellContentClick(object sender, DataGridViewCellEventArgs e) {


            if (e.ColumnIndex == dtaGridMainInfo.Columns["carritoColumn"].Index && e.RowIndex >= 0) {
                Producto productoAgregado = (Producto)this.dtaGridMainInfo.Rows[e.RowIndex].DataBoundItem;
                if (this.AgregarAlCarrito(productoAgregado))
                    this.btnIrCarrito.Visible = true;

            }
         
            this.dtaGridMainInfo.Refresh();

        }

        private void txtBoxBusqueda_TextChanged(object sender, EventArgs e) {

            this.dtaGridMainInfo.DataSource = this.FiltroProducto();
            if (this.txtBoxBusqueda.Text == "") {
                this.dtaGridMainInfo.DataSource = Negocio.InvNegocio.ListaProductosInv;
            }
        }
        private List<Producto> FiltroProducto() {

            List<Producto> listaProductosFiltrados = new List<Producto>(0);
            foreach (var producto in Negocio.InvNegocio.ListaProductosInv) {

                //Si existe el prod con ese nombre.
                if (producto.NombreProducto.ToLower().Contains(this.txtBoxBusqueda.Text) ||
                   producto.CategoriaProducto.ToString().ToLower().Contains(this.txtBoxBusqueda.Text)) {
                    listaProductosFiltrados.Add(producto);
                }
            }

            return listaProductosFiltrados;

        }
        private void ControlPanelForm_FormClosing(object sender, FormClosingEventArgs e) {

            Form loginForm = Application.OpenForms["loginForm"];
            
            if (this.msgSalida == true) {
                DialogResult mensajeSalida = MessageBox.Show("¿Desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mensajeSalida == DialogResult.Yes) {
                    loginForm.Close();
                }
                else if (mensajeSalida == DialogResult.No) {
                    e.Cancel = true;
                }
            }else {
                loginForm.Close();
            }

        }
        private void ShowDatosUsuario() {

            this.lblWelcome.Text = $"Bienvenido denuevo {this.usuarioIngresado.ToString()}";
        }

        private void btnIrCarrito_Click(object sender, EventArgs e) {

            CartForm formularioCarrito = new CartForm(this.usuarioIngresado);
            formularioCarrito.ShowDialog();
            if (usuarioIngresado.CarritoCliente().DiccionarioProductos.Count == 0) { 
                this.btnIrCarrito.Visible = false;
                this.lblWelcome.Text = this.usuarioIngresado.ToString();
                this.lblUltimaCompra.Visible = true;
                this.lblUltimaCompra.Text = this.usuarioIngresado.UltimaCompraPretty();
            }
            this.dtaGridMainInfo.Refresh();
        }

        private Boolean AgregarAlCarrito(Producto productoAgregado) {

            bool rtrn = false;
            if (this.usuarioIngresado.CarritoCliente().AgregarAlCarrito(productoAgregado)) {
                rtrn = true;
                MessageBox.Show($"Se agrego el producto {productoAgregado.NombreProducto} al carrito", "Producto", MessageBoxButtons.OK);
            }
            else {
                MessageBox.Show($"Lo sentimos no queda mas Stock del producto", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return rtrn;
        }

        private void ControlPanelForm_MouseMove(object sender, MouseEventArgs e) {

            this.tiempoSesion.Stop();
            this.tiempoSesion.Start();
            if (e.Y <= 20) {
                this.menuStrip.Visible = true;
            }
            else {
                this.menuStrip.Visible = false;
            }
        }

        private void SubMenuProductosToolStripMenuItem_Click(object sender, EventArgs e) {

            this.lblBusqueda.Visible = true;
            this.txtBoxBusqueda.Visible = true;
            this.lblStockTotal.Visible = true;
            this.dtaGridMainInfo.DataSource = Negocio.InvNegocio.ListaProductosInv;
            this.dtaGridMainInfo.Columns[0].DisplayIndex = 6;
            this.dtaGridMainInfo.Columns["carritoColumn"].Visible = true;

        }
    
        private void SubMenuUsuariosToolStripMenuItem_Click(object sender, EventArgs e) {

            this.dtaGridMainInfo.DataSource = Negocio.ListaUsuarios;

            this.lblBusqueda.Visible = false;
            this.txtBoxBusqueda.Visible = false;
            this.lblStockTotal.Visible = false;
            this.dtaGridMainInfo.Columns["NombreCompleto"].Visible = false;
            this.dtaGridMainInfo.Columns["carritoColumn"].Visible = false;

        }
        private void SubMenuComprasToolStripMenuItem_Click(object sender, EventArgs e) {

            this.dtaGridMainInfo.DataSource = Negocio.ListaCompras;
            this.dtaGridMainInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dtaGridMainInfo.Columns[0].Width = 2;
            this.dtaGridMainInfo.Columns["carritoColumn"].Visible = false;

            this.lblBusqueda.Visible = false;
            this.txtBoxBusqueda.Visible = false;
            this.lblStockTotal.Visible = false;
        }
        private void RefreshLabelStockTotal()
        {
            this.lblStockTotal.Text = $"Cantidad total de Stock {Negocio.InvNegocio.TotalStockProductos()}";
        }
        
        private void SubMenuAgregarProductoToolStripMenuItem_Click(object sender, EventArgs e) {

            AddProdForm addProdForm = new AddProdForm();
            addProdForm.enviarRefresh += this.RefreshLabelStockTotal;
            addProdForm.ShowDialog();
            this.dtaGridMainInfo.Refresh();
            this.dtaGridMainInfo.DataSource = null;
            this.dtaGridMainInfo.DataSource = Negocio.InvNegocio.ListaProductosInv;
            this.dtaGridMainInfo.Columns[0].DisplayIndex = 6;
        }
        private void CierreSesionToolStripMenuItem_Click(object sender, EventArgs e) {

            this.usuarioIngresado = null;
            this.Hide();
            Form loginForm = Application.OpenForms["loginForm"];
            loginForm.Show();

        }
        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e) {

            this.usuarioIngresado = null;
            this.Hide();
            RegisterForm registro = new RegisterForm();
            registro.ShowDialog();

        }

        private void ActivarTimerInactividad() {

            this.tiempoSesion.Tick += new EventHandler(TimerEventProcessor);
            tiempoSesion.Interval = 300000; //5 minutos
            tiempoSesion.Start();
           
        }
        private void TimerEventProcessor(Object timer, EventArgs myEventArgs) {
            Timer tiempoSesion = (Timer)timer;
            this.msgSalida = false;
            tiempoSesion.Stop();
            this.Close();
        }
    }
}
