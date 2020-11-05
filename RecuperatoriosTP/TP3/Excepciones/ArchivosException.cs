using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        public ArchivosException() : base("Al parecer, Hubo un problema al Guardar/leer el archivo")
        {

        }
        public ArchivosException(string msgExcption) : base(msgExcption)
        {

        }
    }
}
