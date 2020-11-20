using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class GetListaException : Exception
    {
        public GetListaException() : base("Hubo un problema al traer la lista desde la base de datos.")
        { 
        }

        public GetListaException(string exceptionStr) : base(exceptionStr)
        {
        }

        public GetListaException(string exceptionStr, Exception innerException) : base(exceptionStr, innerException)
        {
        }
    }
}
