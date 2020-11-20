using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class UsuarioRepetidoException : Exception
    {
        public UsuarioRepetidoException() : base("Ya hay un Usuario registrado con ese DNI.")
        { 
        }

        public UsuarioRepetidoException(string exceptionStr) : base(exceptionStr)
        {
        }

        public UsuarioRepetidoException(string exceptionStr, Exception innerException) : base(exceptionStr, innerException)
        {
        }
    }
}
