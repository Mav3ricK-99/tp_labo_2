using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Entidades;
using Excepciones;

namespace NegocioForms
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Negocio.NombreNegocio = " Negocio TP4";
            Thread thread = new Thread(Negocio.IniciarNegocio);
            
            try
            {
                thread.Start();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm());

            }
            catch (GetListaException getListaException)
            {
                MessageBox.Show(getListaException.InnerException.Message + "\n Error al traer una lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (LeerComprasException leerCompraException)
            {
                 MessageBox.Show(leerCompraException.InnerException.Message + "\n Error al leer las Compras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                 MessageBox.Show(e.InnerException.Message + "\n Hubo un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
