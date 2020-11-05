using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        public NacionalidadInvalidaException() : base("Al parecer,  la nacionalidad ingresada no se encuentra en nuestro sistema.")
        {

        }
        public NacionalidadInvalidaException(string msgExcption) : base(msgExcption)
        {

        }
    }
}
