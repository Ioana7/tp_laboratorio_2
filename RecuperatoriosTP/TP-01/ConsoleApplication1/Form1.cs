using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        private int _conv;

        public LaCalculadora()
        {
            InitializeComponent();
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("*");
            cmbOperador.Items.Add("/");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            LaCalculadora.ActiveForm.Close();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text != "" && txtNumero2.Text != "" && cmbOperador.Text != "")
            {
                lblResultado.Text = Convert.ToString(LaCalculadora.Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text));
                _conv = 0;
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (_conv == 0)
            {
                lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
                _conv++;
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (_conv == 1)
            {
                lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
                _conv--;
            }
        }

        /// <summary>
        /// Limpia el formulario colocando los valores por defecto donde corresponda
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "Resultado";
        }

        /// <summary>
        /// Realiza la operacion deseada y devuelve un resultado
        /// </summary>
        /// <param name="numero1">Numero correspondiente al primer textbox</param>
        /// <param name="numero2">Numero correspondiente al segundo textbox</param>
        /// <param name="operador">Operador correspondiente al combobox</param>
        /// <returns>Devuelve el resultado de la operacion realizada</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double resultado;
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            Calculadora calculadora = new Calculadora();

            resultado = calculadora.Operar(num1, num2, operador);
            return resultado;
        }

        private void LaCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
