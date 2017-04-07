using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mendoza.Gabriel.Calculadora;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("/");
            cmbOperador.Items.Add("*");
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numero1 = this.txtNumero1.Text;
            string numero2 = this.txtNumero2.Text;
            string operadorAux = this.cmbOperador.Text;
            string operador = "";
            double resultado = 0;

            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            CalculadoraTP calcular = new CalculadoraTP();

            operador = calcular.ValidarOperador(operadorAux);

            resultado = calcular.Operar(num1, num2, operador);

            lblResultado.Text = Convert.ToString(resultado);
    
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.txtNumero2.Text = "";
            this.txtNumero1.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "";
        }
    }
}
