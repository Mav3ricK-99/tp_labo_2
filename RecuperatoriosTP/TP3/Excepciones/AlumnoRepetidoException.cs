using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AlumnoRepetidoException : Exception
    {
        public AlumnoRepetidoException() : base("Al parecer, el alumno ya esta en la lista")
        {

        }

        public AlumnoRepetidoException(string msgExcption) : base(msgExcption)
        {

        }
    }
}
