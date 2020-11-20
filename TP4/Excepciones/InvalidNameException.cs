using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException() : base("Error al Ingresar el nombre")
        { 
        }

        public InvalidNameException(string exceptionStr) : base(exceptionStr)
        {
        }

        public InvalidNameException(string exceptionStr, Exception innerException) : base(exceptionStr, innerException)
        {
        }
    }
}
