using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        #region Métodos


        private static string ValidarOperador(string operador)
        {
            string resultado = "+";

            if (operador == "+" || operador == "-" || operador == "*" || operador == "/")
            {
                resultado = operador;
            }

            return resultado;
        }



        public double Operar(Numero num1, Numero num2, string operador)
        {
            string operacion = Calculadora.ValidarOperador(operador);
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;

                case "-":
                    resultado = num1 - num2;
                    break;

                case "*":
                    resultado = num1 * num2;
                    break;

                case "/":
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }
        #endregion
    }
}
