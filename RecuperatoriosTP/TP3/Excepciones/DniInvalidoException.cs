using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        public DniInvalidoException() : base("Al parecer, el DNI ingresado tiene un formato incorrecto.")
        {

        }
        public DniInvalidoException(Exception e) : base("Al parecer, el DNI ingresado tiene un formato incorrecto.",e)
        {

        }
        public DniInvalidoException(string msgExcption) : base(msgExcption)
        {

        }
        public DniInvalidoException(string msgExcption, Exception e) : base("Al parecer, el DNI ingresado tiene un formato incorrecto.", e)
        {

        }

    }
}
