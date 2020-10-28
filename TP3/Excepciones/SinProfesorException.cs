using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorException : Exception
    {
        public SinProfesorException() : base("Al parecer, no se encontro un profesor.")
        {

        }
        public SinProfesorException(string msgExcption) : base(msgExcption)
        {

        }
    }
}
