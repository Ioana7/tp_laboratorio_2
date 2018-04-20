using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Calculadora
{
    class Calculadora
    {

        /// <summary>
        /// Realiza operaciones con dos numeros pasados por parametro según el operador ingresado.
        /// </summary>
        /// <param name="num1">Primer operando.</param>
        /// <param name="num2">Segundo operando.</param>
        /// <param name="operador">Operación a realizar.</param>
        /// <param name="resultado">Resultado a devolver en el return.</param>
        /// <returns>Retorna el resultado si se realizo bien y si no devuelve 0.</returns>

        public static double operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;

            switch (Calculadora.ValidarOperador(operador))
            {
                case "+":
                    resultado = num1.getNumero() + num2.getNumero();
                    break;

                case "-":
                    resultado = num1.getNumero() - num2.getNumero();
                    break;

                case "*":
                    resultado = num1.getNumero() * num2.getNumero();
                    break;

                case "/":
                    if (num2.getNumero() != 0)
                    {
                        resultado = num1.getNumero() / num2.getNumero();
                    }
                  
                    break;
            }

            return resultado;
 
        }

        /// <summary>
        /// Comprueba que el operador sea correcto y lo devuelve, sino devuelve el operador "+".
        /// </summary>
        /// <param name="operador">Operador a verificar.</param>
        /// <returns>Devuelve el opearador o "+" si da de error.</returns>

        public static string ValidarOperador(string operador)
        {
            if (!(operador == "+" || operador == "-" || operador == "*" || operador == "/"))
            {
                operador = "+";
            }

            return operador;
        }

    }
}
