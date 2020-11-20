using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class LeerComprasException : Exception
    {
        public LeerComprasException() : base("Hubo un problema al leer las Compras.")
        { 
        }

        public LeerComprasException(string exceptionStr) : base(exceptionStr)
        {
        }

        public LeerComprasException(string exceptionStr, Exception innerException) : base(exceptionStr, innerException)
        {
        }
    }
}
