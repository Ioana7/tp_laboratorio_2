using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp1_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbOperacion.Items.Add("+");
            cmbOperacion.Items.Add("-");
            cmbOperacion.Items.Add("*");
            cmbOperacion.Items.Add("/");
        }

        /// <summary>
        /// Restablece los valores del formulario.
        /// </summary>
        /// 
        private void limpiar()
        {
            this.lblResultado.Text = "0";
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperacion.Text = "";
        }

        /// <summary>
        /// Realiza la operación matemática indicada en el formulario y muestra el resultado en el lblResultado.
        /// </summary>
        private void operar()
        {
            Numero numberOne = new Numero(this.txtNumero1.Text);
            Numero numberTwo = new Numero(this.txtNumero2.Text);
            this.lblResultado.Text = Calculadora.operar(numberOne, numberTwo, this.cmbOperacion.Text).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.operar();
        }

        
    }
}
