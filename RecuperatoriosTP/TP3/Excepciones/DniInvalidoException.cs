﻿using System;
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
        public DniInvalidoException(string msgExcption) : base(msgExcption)
        {

        }
        
    }
}
