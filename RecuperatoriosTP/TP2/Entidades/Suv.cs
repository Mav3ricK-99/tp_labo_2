﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Suv : Vehiculo {
        public Suv(EMarca marca, string chasis, ConsoleColor color) : base(chasis, marca, color) {
        }
        /// <summary>
        /// Las camionetas son grandes
        /// </summary>
        public override ETamanio Tamanio {
            set { }
            get {
                return ETamanio.Grande;
            }
        }

        public override string Mostrar() {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.ToString());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
