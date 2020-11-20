using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;

namespace System.Collections.Generic
{
    static class ListaExtends
    {
        public static Cliente BuscarPorDNI(this List<Cliente> listaClientes, int dni)
        {
            if (listaClientes.Count == 0 || listaClientes == null)
                throw new NoHayUsuariosException();

            foreach (Cliente cli in listaClientes)
            {
                if(cli.DniUsuario == dni)
                {
                    return cli;
                }
            }
            return null;
        }
    }
}
