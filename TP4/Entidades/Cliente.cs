using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data.SqlClient;

namespace Entidades {
    public class Cliente : Usuario, IDb {

        private string passUsuario;
        private DateTime fechaAlta;
        private Compra ultimaCompra;
        private Carrito carritoCliente;

        public Cliente() : base() {

            this.carritoCliente = new Carrito();
        }
        public Cliente(string nombreUsuario, string apellidoUsuario, int dniUsuario, string passUsuario) : base(nombreUsuario, apellidoUsuario, dniUsuario) {

            this.passUsuario = HashAlgorithm.CreateMD5(passUsuario);
            this.fechaAlta = DateTime.Now;
            this.carritoCliente = new Carrito();
        }
        internal Compra UltimaCompra { get => ultimaCompra; set => ultimaCompra = value; }
        public override string UltimaCompraPretty() {

            string ultimaCompraStr = string.Empty;
            if (this.UltimaCompra == null) {
                ultimaCompraStr += "No hubo compras.\n";
            }
            else {
                ultimaCompraStr += $"Ultima Compra \n{this.UltimaCompra.FacturaCompra.ToStringPretty()}\n";
            }

            return ultimaCompraStr;
        }

        public override string PassUsuario() => passUsuario;
        public override Carrito CarritoCliente() => carritoCliente;

        public override bool Comprar(EMetodoPago metodoPago, string cuentaPago) {

            bool rtrnCompra = false;
            Compra nuevaCompra = new Compra(this, metodoPago, cuentaPago);
            Negocio.InvNegocio.AgregarVendidos(this.carritoCliente);
            this.carritoCliente.DiccionarioProductos.Clear();
            if (nuevaCompra != null && nuevaCompra.FacturaCompra != null) {
                this.ultimaCompra = nuevaCompra;
                Negocio.ListaCompras.Add(nuevaCompra);
                rtrnCompra = true;
            }
            Negocio.GuardarCompras();
            
            return rtrnCompra;
        }

        public override string ToString() {

            string strCliente = base.ToString();
            strCliente += $"Usuario Cliente\nFecha de alta - {this.fechaAlta.ToString()}\n";
            
            return strCliente;
        }

        public void Object_To_DB(ref SqlCommand command)
        {
            string sql =
                "INSERT INTO Usuarios(NombreUsuario, ApellidoUsuario, DniUsuario)" +
                "VALUES(@NombreUsuario, @ApellidoUsuario, @DniUsuario) " +
                "INSERT INTO Clientes(PassCliente, FechaAlta, UsuarioID)" +
                "VALUES(@PassCliente, @FechaAlta, @@IDENTITY)";

            //"INSERT INTO Usuarios(NombreUsuario, ApellidoUsuario, DniUsuario) values(@NombreUsuario)";
            command.CommandText = sql;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@NombreUsuario", this.NombreUsuario);
            command.Parameters.AddWithValue("@ApellidoUsuario", this.ApellidoUsuario);
            command.Parameters.AddWithValue("@DniUsuario", this.DniUsuario);
            command.Parameters.AddWithValue("@PassCliente", this.passUsuario);
            command.Parameters.AddWithValue("@FechaAlta", this.fechaAlta);


        }
        //select users.id , Users.UserName, Users.PersonId,Personas.Apellido, Personas.DNI, Personas.Nombre from Users inner join Personas on users.PersonId = Personas.Id where  username = @usuario and password = @password

        public void DB_Select_Query(ref SqlCommand command)
        {
            string sql = "SELECT * FROM Clientes INNER JOIN Usuarios on Clientes.UsuarioID = Usuarios.IdUsuario";
            command.CommandText = sql;

        }
        public object DB_GetObjectFromRegistro(SqlDataReader reader)
        {
            Cliente newCustomer = new Cliente();
            try
            {
                newCustomer.IdUsuario = int.Parse(reader["IdUsuario"].ToString());
                newCustomer.NombreUsuario = reader["NombreUsuario"].ToString();
                newCustomer.ApellidoUsuario = reader["ApellidoUsuario"].ToString();
                newCustomer.DniUsuario = int.Parse(reader["DniUsuario"].ToString());
                newCustomer.passUsuario = reader["PassCliente"].ToString();
                newCustomer.fechaAlta = DateTime.Parse(reader["FechaAlta"].ToString());
                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            return newCustomer;
        }

        public void DB_UpdateObject(ref SqlCommand command)
        {
            string sql = "UPDATE Clientes SET " +
                "NombreUsuario = @NombreUsu" +
                "ApellidoUsuario = @ApellidoUsu" +
                "DniUsuario = @DniUsu" +
                "PassCliente = @PassCli" +
                " WHERE IdCliente = @IdCliente; ";
            command.CommandText = sql;
            command.Parameters.AddWithValue("@IdCliente", this.IdUsuario);
            command.Parameters.AddWithValue("@NombreUsu", this.NombreUsuario);
            command.Parameters.AddWithValue("@ApellidoUsu", this.ApellidoUsuario);
            command.Parameters.AddWithValue("@DniUsu", this.DniUsuario);
            command.Parameters.AddWithValue("@PassCli", this.PassUsuario());

        }

        public void DB_Delete_Reg(ref SqlCommand command)
        {
            string sql = $"DELETE FROM Clientes where IdCliente = {this.IdUsuario}"+
                         $"DELETE FROM Usuarios where IdUsuario = {this.IdUsuario};";
            command.CommandText = sql;
        }
    }
}
