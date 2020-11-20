using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    static class Validaciones {

        public static Boolean EsNombre(string nombre) {

            if (ContieneNumeros(nombre) || ContarLetras(nombre) < 3 || ContieneCaracteresEspeciales(nombre)) {
                return false;
            }

            return true;
        }

        public static Boolean ContieneCaracteresEspeciales(string str)
        {

            for (int i = 0; i < str.Length; i++)
            {

                if (!char.IsDigit(str[i]) && !char.IsLetter(str[i]))
                {
                    return true;
                }
            }

            return false;
        }

        public static Boolean ContieneNumeros(string str) {

            for(int i = 0; i < str.Length; i++) {

                if (char.IsDigit(str[i])) {
                    return true;
                }
            }

            return false;
        }

       public static short ContarLetras(string str) {

            short cantLetras = 0;
            for (int i = 0; i < str.Length; i++) {

                if (char.IsLetter(str[i])) {
                    cantLetras++;
                }
            }

            return cantLetras;
        }

        public static void LimpiarNombre(ref string strNombre) {

            strNombre.Trim();
            char.ToUpper(strNombre[0]);
            for (int i = 0; i < strNombre.Length; i++) {

                if(strNombre[i] == ' ') {
                    char.ToUpper(strNombre[i + 1]);
                }
            }
            
        }
        public static Boolean EsDNI(int dni) {

            string strDni = dni.ToString();
            if (strDni.Length != 8) {
                return false;
            }

            return true;
        }
    }
}
