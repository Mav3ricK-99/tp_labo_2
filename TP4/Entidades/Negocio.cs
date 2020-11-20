using Archivos;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{
    public static class Negocio
    {

        private static Inventario invNegocio;
        private static string nombreNegocio;
        private static List<Cliente> listaUsuarios;
        private static List<Compra> listaCompras;

        static Negocio()
        {
            invNegocio = Inventario.Instancia;
            nombreNegocio = "NombreNegocio";
            listaUsuarios = new List<Cliente>(0);
            listaCompras = new List<Compra>(0);
        }
        public static string NombreNegocio { get => nombreNegocio; set => nombreNegocio = value; }
        public static Inventario InvNegocio { get => invNegocio; set => invNegocio = value; }
        public static List<Cliente> ListaUsuarios { get => listaUsuarios; set => listaUsuarios = value; }
        public static List<Compra> ListaCompras { get => listaCompras; set => listaCompras = value; }

        public static void AgregarCliente(string nombreUsuario, string apellidoUsuario, int dniUsuario, string contraseñaCliente)
        {
            try
            {
                Negocio.ExisteUsuario(dniUsuario);
                Cliente nuevoCliente = new Cliente(nombreUsuario, apellidoUsuario, dniUsuario, contraseñaCliente);
                listaUsuarios.Add(nuevoCliente);
                DB.Insert<Cliente>(nuevoCliente);
            }
            catch (UsuarioRepetidoException ex) {
                throw new UsuarioRepetidoException(ex.Message, ex.InnerException); 
            }
            catch (InvalidNameException e)
            {
                throw new InvalidNameException(e.Message, e.InnerException);
            }
            catch (InvalidDniException e)
            {
                throw new InvalidDniException(e.Message, e.InnerException);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }
        public static Usuario IngresoUsuario(string nombreUsuario, string passUsuario)
        {
            Usuario rtrnUsuario = null;
            foreach (var usuario in listaUsuarios)
            {

                if (usuario.NombreUsuario.ToLower() == nombreUsuario.ToLower() && usuario.PassUsuario() == HashAlgorithm.CreateMD5(passUsuario))
                {
                    rtrnUsuario = usuario;
                }

            }

            return rtrnUsuario;
        }
        public static bool GuardarCompras()
        {
            bool rtrn = true;
            Xml<Compra> archivoXml = new Xml<Compra>();

            StringBuilder rutaStr = new StringBuilder(AppDomain.CurrentDomain.BaseDirectory);
            string nombreArchivo = "Compras.xml";
            rutaStr.Append(nombreArchivo);

            if (!archivoXml.Guardar(rutaStr.ToString(), Negocio.ListaCompras))
            {
                rtrn = false;

            }
            return rtrn;
        }
        public static void LeerCompras()
        {
            List<Compra> listaCompras;
            Xml<Compra> archivoXml = new Xml<Compra>();

            try
            {
                StringBuilder rutaStr = new StringBuilder(AppDomain.CurrentDomain.BaseDirectory);
                string nombreArchivo = "Compras.xml";
                rutaStr.Append(nombreArchivo);
                archivoXml.Leer(rutaStr.ToString(), out listaCompras);
                Negocio.ListaCompras = listaCompras;
            }
            catch (Exception e)
            {
                throw new LeerComprasException(e.Message, e.InnerException);
            }
        }
        /// <summary>
        /// Recorre la lista de Compras y para saber la ultima compra de los usuarios, se usa la extencion
        /// de buscar por dni para luego asignarle la ultima compra con la compra con dni correspondiente.
        /// </summary>
        public static void CargarCompras()
        {
            try
            {
                LeerCompras();
                foreach (Compra compra in listaCompras)
                {
                    listaUsuarios.BuscarPorDNI(compra.FacturaCompra.DniComprador).UltimaCompra = compra;
                }
            }
            catch (GetListaException getListaException)
            {
                throw new GetListaException(getListaException.Message, getListaException.InnerException);
            }
            catch (NoHayUsuariosException)
            { //No hay usuarios, no muestra mensaje (inecesario)
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }
        public static void CargarProductos()
        {
            Negocio.InvNegocio.ListaProductosInv = DB.GetLista<Producto>();
        }
        public static void CargarUsuarios()
        {
            try
            {
                Negocio.listaUsuarios = DB.GetLista<Cliente>();
            }
            catch (GetListaException getListaException)
            {
                throw new Exception(getListaException.Message, getListaException.InnerException);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }
        public static void IniciarNegocio()
        {
            List<Thread> listaHilos = new List<Thread>();
            listaHilos.Add(new Thread(CargarUsuarios));
            listaHilos.Add(new Thread(CargarProductos));
            listaHilos.Add(new Thread(CargarCompras));

            try
            {
                foreach (Thread item in listaHilos)
                {
                    Thread.Sleep(500);
                    item.Start();
                }
            }
            catch (GetListaException getListaException)
            {
                throw new GetListaException(getListaException.Message, getListaException.InnerException);
            }
            catch (LeerComprasException leerCompraException)
            {
                throw new Exception(leerCompraException.Message, leerCompraException.InnerException);
            }         
            catch (Exception e)
            {
                throw new Exception(e.Message, e.InnerException);
            }
        }
        private static void ExisteUsuario(int dniUsuario)
        {

            foreach (var usuario in listaUsuarios)
            {

                if (usuario.DniUsuario == dniUsuario)
                {
                    throw new UsuarioRepetidoException($"Ya hay un Usuario registrado con el DNI {dniUsuario}");
                }
            }
        }

    }
}
