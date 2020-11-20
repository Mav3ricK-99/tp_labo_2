using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Entidades;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("El Siguiente Programa simula el Registro de un Usuario, el Ingreso ");
            Console.Write("del mismo a la DB y la autenticacion. La Lista de productos");
            Console.WriteLine("traida desde la Base de datos, la compra de un Producto.");
            Console.Write("El registro de esa compra en la serializacion de la misma en un archivo XML");
            Console.Write("Y el agregado de un producto.\n\n");

            Console.WriteLine("--- Inicio de programA ---");
            Console.WriteLine("Traemos los Usuarios y los productos de la Base de datos");
            Console.WriteLine("como asi tambien las compras.xml y le asignamos la ultima compra a cada Usuario");
            Console.WriteLine("(Presione una tecla para Iniciar el Programa)");
            Console.ReadKey();

            Negocio.IniciarNegocio();
            Thread.Sleep(1000);

            Console.WriteLine("\nUsuarios");
            foreach (Cliente cli in Negocio.ListaUsuarios)
            {
                
                Console.WriteLine($"/// - {cli.NombreCompleto} - ///");
                Console.WriteLine($"\n{cli.UltimaCompraPretty()}\n");
            }

            Console.WriteLine("\nProductos");
            foreach (Producto pro in Negocio.InvNegocio.ListaProductosInv)
            {
                Console.WriteLine($"{pro.NombreProducto} | Vendidos - {pro.CantVendidos}");
            }

            Console.WriteLine("(Presione una tecla para Continuar)");
            Console.ReadKey();

            Console.WriteLine("\nVamos a Registrar a un Usuario");
            Console.WriteLine("Nombre: pepe");
            Console.WriteLine("Apellido: peposo");
            Console.WriteLine("DNI: 35214515");
            Console.WriteLine("Pass: TP4TP4");

            Console.WriteLine("(Presione una tecla para Registrar al Usuario)");
            Console.ReadKey();

            Negocio.AgregarCliente("pepe", "peposo", 35214515, "TP4TP4");
            Console.WriteLine("\n"+Negocio.ListaUsuarios.Last().NombreCompleto + " agregado correctamente.\n");

            Console.WriteLine("(Presione una tecla para Continuar)");
            Console.ReadKey();

            Console.WriteLine("\nVamos a Registrar un nuevo Producto");
            Console.WriteLine("Nombre: Cepita multifruta");
            Console.WriteLine("Precio: 40");
            Console.WriteLine($"Categoria: {ECategorias.Bebidas.ToString()}");
            Console.WriteLine("Stock: 20");

            Console.WriteLine("(Presione una tecla para Ingresar el Producto)");
            Console.ReadKey();

            Producto nuevoProd = new Producto("Cepita multifruta", 40, ECategorias.Bebidas, 20);
            Negocio.InvNegocio.AgregarProducto(nuevoProd);
            Console.WriteLine("\n" + Negocio.InvNegocio.ListaProductosInv.Last().NombreProducto + " agregado correctamente.\n");

            Console.WriteLine("(Presione una tecla para Continuar)");
            Console.ReadKey();

            Console.WriteLine("\nComo podemos ver en la lista de Compras traidas no se encuentra la que vamos a hacer ahora");
            Console.WriteLine($"Fecha -      {DateTime.Now}      ");

            Console.WriteLine("\nVamos a comprar 10 unidades de Jabones con Efectivo");

            Console.WriteLine("(Presione una tecla para Continuar)\n\n");
            Console.ReadKey();

            for(int i = 0; i < 10; i++)
            {
                Negocio.ListaUsuarios.Last().CarritoCliente().AgregarAlCarrito(Negocio.InvNegocio.ListaProductosInv.ElementAt(12));
            }

            Console.WriteLine("\n\n" + Negocio.ListaUsuarios.Last().CarritoCliente().ToString());
            Console.WriteLine("\n\nLos Jabones se agregaron al Carrito\n");

            Console.WriteLine("(Presione una tecla para Comprar)");
            Console.ReadKey();

            Negocio.ListaUsuarios.Last().Comprar(EMetodoPago.Efectivo, "0");

            Console.WriteLine("\n"+Negocio.ListaCompras.Last().FacturaCompra.ToStringPretty());

            Console.WriteLine("\nSe realizo la compra.");
            Console.WriteLine("(Presione una tecla para Comprar)");
            Console.ReadKey();

            Console.WriteLine("\n\n\n_________________________________________________________________");
            Console.WriteLine("Ahora Borramos todo dato del Negocio y volvemos a traer de la DB\n");
            Negocio.ListaUsuarios.Clear();
            Negocio.InvNegocio.ListaProductosInv.Clear();
            Negocio.ListaCompras.Clear();
            Console.WriteLine($"Usuarios - {Negocio.ListaUsuarios.Count}");
            Console.WriteLine($"Productos - {Negocio.InvNegocio.ListaProductosInv.Count}");
            Console.WriteLine($"Compras - {Negocio.ListaCompras.Count}");

            Console.WriteLine("(Presione una tecla para Continuar)");
            Console.ReadKey();

            Negocio.IniciarNegocio();
            Thread.Sleep(1000);

            Console.WriteLine("\nUltimo Usuario Registrado");
            
            Console.WriteLine($"/// - {Negocio.ListaUsuarios.Last().NombreCompleto} - ///");
            Console.WriteLine($"\n{Negocio.ListaUsuarios.Last().UltimaCompraPretty()}");
            
            Console.WriteLine("Producto");
            Console.WriteLine($"Cantidades vendidas de Jabones {Negocio.InvNegocio.ListaProductosInv.ElementAt(12).CantVendidos}");

            Console.WriteLine("\n\nCargamos los datos de la DB y vemos que");
            Console.WriteLine(">El usuario Pepe existe y tiene una UltimaCompra");
            Console.WriteLine(">El producto Jabones aumento sus cantidades vendidas");
            Console.WriteLine(">La ultima compra fue la de los Jabones.");

            Console.WriteLine(">Ahora se eliminara pepe peposo de la DB. Y la compra");
            DB.Delete<Cliente>(Negocio.ListaUsuarios.Last());
            Negocio.ListaCompras.Remove(Negocio.ListaCompras.Last());
            Negocio.GuardarCompras();

            Console.ReadKey();

        }
    }
}
