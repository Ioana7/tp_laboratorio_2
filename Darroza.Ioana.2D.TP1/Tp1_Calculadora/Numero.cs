using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Calculadora
{
    class Numero
    {
        private double _numero;

        /// <summary>
        /// Constructor que al no recibir parametro establece el valor cero para el parametro _numero.
        /// </summary>

        public Numero():this(0)
        {
        }

        /// <summary>
        /// Constructor que recibe un string con lo que contiene del numero y si no es un numero establece cero al atributo _numero.
        /// </summary>
        /// <param name="num">String con el contenido para establecer en el atributo _numero.</param>

        public Numero(string num):this()
        {
            this.setNumero(num);
        }

        /// <summary>
        /// Recibe un numero y lo establece en el atributo _numero.
        /// </summary>
        /// <param name="num">Numero para establecer en el atributo _numero.</param>
   
        public Numero(double num)
        {
            this._numero = num;
        }

        /// <summary>
        /// Ingresa un string, valida que éste contenga un numero y lo devuelve tipo double, si no contiene un numero devuelve 0.
        /// </summary>
        /// <param name="num">String que contiene el numero que queremos validar.</param>
        /// <param name="retorno">double en el que se establecera el valor a retornar.</param>
        /// <returns>Retorna el numero ya validado o cero si no es un numero.</returns>

        private static double validarNumero(string num)
        {
            double retorno = 0;
            double.TryParse(num, out retorno);
            return retorno;
        }

        /// <summary>
        /// Establece el numero que se pasó por parámetro ya validado en el atributo _numero.
        /// </summary>
        /// <param name="num">Numero a ingresar</param>

        private void setNumero(string num)
        {
            this._numero = Numero.validarNumero(num);
        }

        /// <summary>
        /// Devuelve el numero contenido en _numero.
        /// </summary>
        /// <returns>Retorna el numero contenido en _numero .</returns>

        public double getNumero()
        {
            return this._numero;
        }

    }
}
