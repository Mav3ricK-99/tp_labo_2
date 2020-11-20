using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades {

    public enum ECategorias {

        Almacen,
        Limpieza,
        Perfumeria,
        Bebidas,
        Congelados,

    }
    public class Producto : IDb
    {

        static int idProductoClase;
        int idProducto;
        int stockProducto, cantVendidos;
        string nombreProducto;
        ECategorias categoriaProducto;
        float precioProducto;

        public Producto() {

            this.nombreProducto = "Sin nombre.";
            this.precioProducto = -1;
            this.categoriaProducto = 0;
            this.stockProducto = -1;
            this.cantVendidos = 0;
            this.idProducto = idProductoClase++;
        }
        public Producto(string nombreProducto) : this() {

            this.nombreProducto = nombreProducto;
        }

        public Producto(string nombreProducto, float precioProducto) : this(nombreProducto) {

            this.idProducto = idProductoClase++;
            this.PrecioProducto = precioProducto;
        }

        public Producto(string nombreProducto, float precioProducto, ECategorias categoriaProducto, int stockProducto) : this(nombreProducto, precioProducto) {

            this.nombreProducto = nombreProducto;
            this.PrecioProducto = precioProducto;
            this.categoriaProducto = categoriaProducto;
            this.stockProducto = stockProducto;

        }
        public Producto(string nombreProducto, float precioProducto, ECategorias categoriaProducto, int stockProducto, int cantVendidos) : this(nombreProducto, precioProducto, categoriaProducto, stockProducto) {

            this.cantVendidos = cantVendidos;

        }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public float PrecioProducto { get => precioProducto; set => this.precioProducto = value;}
        public ECategorias CategoriaProducto { get => categoriaProducto; set => categoriaProducto = value; }
        public int StockProducto { get => stockProducto; set => stockProducto = value; }
        public int CantVendidos { get => cantVendidos; set => cantVendidos = value; }


        public void Object_To_DB(ref SqlCommand command)
        {
            string sql = "INSERT INTO Productos(NombreProducto,StockProducto, CantVendidos, CategoriaProducto, PrecioProducto) values(@NombreProducto, @StockProducto, @CantVendidos, @CategoriaProducto, @PrecioProducto)";
            command.CommandText = sql;
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@NombreProducto", this.NombreProducto);
            command.Parameters.AddWithValue("@StockProducto", this.StockProducto);
            command.Parameters.AddWithValue("@CantVendidos", this.CantVendidos);
            command.Parameters.AddWithValue("@CategoriaProducto", this.CategoriaProducto.ToString());
            command.Parameters.AddWithValue("@PrecioProducto", this.PrecioProducto);

        }

        public void DB_Select_Query(ref SqlCommand command)
        {
            string sql = "SELECT * FROM Productos";
            command.CommandText = sql;
        }

        public void DB_UpdateObject(ref SqlCommand command)
        {
            string sql = "UPDATE Productos SET " +
                "NombreProducto = @NombreProd," +
                "StockProducto = @StockProd," +
                "CantVendidos = @CantidadVendidos," +
                "CategoriaProducto = @CategoProd," +
                "PrecioProducto = @PrecioProd" +
                " WHERE IdProducto = @IdProd; ";
            command.CommandText = sql;
            command.Parameters.AddWithValue("@IdProd", this.idProducto);
            command.Parameters.AddWithValue("@NombreProd", this.NombreProducto);
            command.Parameters.AddWithValue("@StockProd", this.StockProducto);
            command.Parameters.AddWithValue("@CantidadVendidos", this.CantVendidos);
            command.Parameters.AddWithValue("@CategoProd", this.CategoriaProducto.ToString());
            command.Parameters.AddWithValue("@PrecioProd", this.PrecioProducto);

        }

        public object DB_GetObjectFromRegistro(SqlDataReader reader)
        {
            Producto prod = new Producto();
            try
            {
                prod.NombreProducto = reader["NombreProducto"].ToString();
                prod.PrecioProducto = float.Parse(reader["PrecioProducto"].ToString());
                prod.StockProducto =  int.Parse(reader["StockProducto"].ToString());
                prod.CantVendidos = int.Parse(reader["CantVendidos"].ToString());
                prod.CategoriaProducto = (ECategorias)System.Enum.Parse(typeof(ECategorias), reader["CategoriaProducto"].ToString());
              
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            return prod;
        }

        public void DB_Delete_Reg(ref SqlCommand command)
        {
            string sql = $"DELETE FROM Productos where IdProducto = {this.IdProducto}";
            command.CommandText = sql;
        }
    }
}
