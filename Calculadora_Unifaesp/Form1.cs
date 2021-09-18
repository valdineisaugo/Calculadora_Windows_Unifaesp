using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Unifaesp
{
    public partial class Form1 : Form
    {
        //Variáveis globais
        double entrada01;
        double entrada02;
        char operacao;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "1";//Concatenar número 1
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            if (visor.Text == "0")
                visor.Text = "";
            visor.Text += "2";//Concatenar número 2
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (visor.Text != "0")
                visor.Text += "0";//Concatenar número 0
        }

        private void btnSete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            visor.Text = "0";
            entrada01 = 0;
            entrada02 = 0;
            
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            operacao = '+';
            entrada01 = double.Parse(visor.Text);
            visor.Text = "0";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            entrada02 = double.Parse(visor.Text);
            switch (operacao)
            {
                case '+'://soma
                    double soma = entrada01 + entrada02;
                    visor.Text = soma.ToString();
                    break;
                case '-':
                    break;
                case 'x':
                    break;
                case '/':
                    break;
                default:
                    break;
                    
            }
        }
    }
}
