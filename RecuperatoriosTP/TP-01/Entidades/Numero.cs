using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {

        #region Atributos

        private double numero;

        #endregion

        #region Propiedades

        public string SetNumero
        {
            set
            {
                this.numero = this.ValidarNumero(value);
            }
        }

        #endregion

        #region Constructores

        public Numero()
            : this(0)
        {
        }


        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.SetNumero = strNumero;
        }

        #endregion

        #region Métodos

        private double ValidarNumero(string strNumero)
        {
            bool esNumero;
            double numero;

            esNumero = double.TryParse(strNumero, out numero);
            if (esNumero != true)
            {
                numero = 0;
            }

            return numero;
        }


        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }


        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }


        public static double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }


        public static string DecimalBinario(string numero)
        {
            int resultado;
            string rta;
            bool sePuede = int.TryParse(numero, out resultado);
            if (sePuede == true)
            {
                rta = Convert.ToString(resultado, 2);
            }
            else
            {
                rta = "Valor invalido";
            }

            return rta;
        }


        public static string DecimalBinario(double numero)
        {
            string resultado;
            resultado = Numero.DecimalBinario(numero.ToString());
            return resultado;
        }


        public static string BinarioDecimal(string binario)
        {
            int resultado;
            string rta;
            bool sePuede = int.TryParse(binario, out resultado);
            if (sePuede == true)
            {
                rta = Convert.ToInt32(binario, 2).ToString();
            }
            else
            {
                rta = "Valor invalido";
            }

            return rta;
        }



        #endregion
    }
}
