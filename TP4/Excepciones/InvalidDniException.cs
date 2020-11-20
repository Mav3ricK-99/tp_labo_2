using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class InvalidDniException : Exception
    {
        public InvalidDniException() : base("Error al Ingresar el DNI.")
        { 
        }

        public InvalidDniException(string exceptionStr) : base(exceptionStr)
        {
        }

        public InvalidDniException(string exceptionStr, Exception innerException) : base(exceptionStr, innerException)
        {
        }
    }
}
