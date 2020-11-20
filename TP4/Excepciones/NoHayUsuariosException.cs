using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoHayUsuariosException : Exception
    {
        public NoHayUsuariosException() : base("No hay usuarios Registrados.")
        { 
        }

        public NoHayUsuariosException(string exceptionStr) : base(exceptionStr)
        {
        }

        public NoHayUsuariosException(string exceptionStr, Exception innerException) : base(exceptionStr, innerException)
        {
        }
    }
}
