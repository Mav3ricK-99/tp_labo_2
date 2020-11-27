using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public static class Calculadora {

        /// <summary>
        /// Validara si el string ingresado por parametro es un operador matematico basico +-*/
        /// </summary>
        /// <param name="operador">El operador en tipo de dato String</param>
        /// <returns>Devuelve '+' si no es ningun operador mamematico basico, si no devolvera el correspondiente.</returns>
        static private string ValidarOperador(char operador) {

            if (operador != '+' && operador != '-' && operador != '*' && operador != '/') {
                operador = '+';

            }

            return operador.ToString();
        }

        /// <summary>
        /// Se encarga de realizar la operacion matematica correspondiente.
        /// </summary>
        /// <param name="num1">Un objeto Numero</param>
        /// <param name="num2">Un objeto Numero</param>
        /// <param name="operador">Un operador en tipo de dato String</param>
        /// <returns></returns>
        static public double Operar(Numero num1, Numero num2, char operador) {
            
            double resultadoOp = 0;
            string strOperador = Calculadora.ValidarOperador(operador);
            switch (strOperador) {
                case "+": { resultadoOp = num1 + num2; };break;
                case "-": { resultadoOp = num1 - num2; }; break;
                case "*": { resultadoOp = num1 * num2; }; break;
                case "/": { resultadoOp = num1 / num2; }; break;
            }
            return resultadoOp;

        }
    }
}
