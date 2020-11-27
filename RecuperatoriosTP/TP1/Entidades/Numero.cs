using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Numero {

        private double valor;

        public Numero(double numero) {
            this.valor = numero;
        }
        public Numero(string strNumero) {
            this.SetValor = strNumero;
        }
        /// <summary>
        /// Setea el valor de la propiedad Valor del Numero.
        /// </summary>
        private string SetValor {
            set { this.valor = this.ValidarNumero(value); }
        }

        /// <summary>
        /// Validara un numero, tomara un numero (string) y devolvera en valor en double
        /// </summary>
        /// <param name="strNumero">El ingreso del numero en String</param>
        /// <returns>0 si no pudo parsear de string a double</returns>
        public double ValidarNumero(string strNumero) {

            double doubleNum = 0;
            double.TryParse(strNumero, out doubleNum);

            return doubleNum;
        }

        /// <summary>
        /// Verifica si el numero ingresado (string) es binario o no.
        /// </summary>
        /// <param name="strNumero">Un numero en tipo de dato string</param>
        /// <returns>Verdadero si es Binario. Falso si no lo es.</returns>
        private bool EsBinario(string strNumero) {

            bool rtrn = true;
            for (int i = 0; i < strNumero.Length; i++) {

                if(strNumero[i] != '0' && strNumero[i] != '1') {
                    rtrn = false;
                    break;
                }
                
            }
            return rtrn;
        }

        /// <summary>
        /// Tomara un numero binario(string), verificara si es binario y lo convertira a Decimal
        /// </summary>
        /// <param name="strNumero">Un numero binario en tipo de dato String</param>
        /// <returns>Un string con el numero convertido a decimal</returns>
        public string BinarioDecimal(string strNumero) {

            string resultado = "Valor Inválido.";
            if (this.EsBinario(strNumero)) {

                resultado = Convert.ToInt32(strNumero, 2).ToString();
            }

            return resultado;
        }

        /// <summary>
        /// Tomara un numero decimal y lo convertira a binario
        /// </summary>
        /// <param name="strNumero">Un numero como tipo de dato String</param>
        /// <returns></returns>
        public string DecimalBinario(string strNumero) {

            string resultado = "Valor Inválido.";
            double resultadoDecimal = 0;
            
            if (double.TryParse(strNumero, out resultadoDecimal) && resultadoDecimal > 0) {

                resultado = this.DecimalBinario(resultadoDecimal);

            }
             return resultado;
        }

        /// <summary>
        /// Tomara un numero decimal y lo convertira a binario
        /// </summary>
        /// <param name="doubleNumero">Un numero como tipo de dato Double</param>
        /// <returns></returns>
        public string DecimalBinario(double doubleNumero) {

            string resultado = "Valor Inválido.";
            int resultadoDecimal = (int)doubleNumero;

            if (resultadoDecimal > 0) {

                resultado = "";
                while (resultadoDecimal > 0) {
                    if (resultadoDecimal % 2 == 0) {
                        resultado = "0" + resultado;
                    }
                    else {
                        resultado = "1" + resultado;
                    }
                    resultadoDecimal = (int)(resultadoDecimal / 2);
                }
                
            }
            return resultado;
        }

        public static double operator + (Numero num1, Numero num2) {
            return num1.valor + num2.valor;
        }
        public static double operator -(Numero num1, Numero num2) {
            return num1.valor - num2.valor;
        }
        public static double operator *(Numero num1, Numero num2) {
            return num1.valor * num2.valor;
        }
        public static double operator / (Numero num1, Numero num2) {

            double resultado;
            if(num2.valor == 0) {
                resultado = double.MinValue;
            }
            resultado = num1.valor / num2.valor;

            return resultado;

        }


    }
}
