using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal v1,v2;
        string opcao;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            v1 = decimal.Parse(caixa.Text, CultureInfo.InvariantCulture);
            resultado.Text = caixa.Text.ToString() + "/";
            caixa.Text = "";
            opcao = "divi";
        }

        private void n0_Click(object sender, EventArgs e)
        {
            caixa.Text += "0";
            resultado.Text += "0";
        }

        private void n1_Click(object sender, EventArgs e)
        {
            caixa.Text += "1";
            resultado.Text += "1";
        }

        private void n2_Click(object sender, EventArgs e)
        {
            caixa.Text += "2";
            resultado.Text += "2";
        }

        private void n3_Click(object sender, EventArgs e)
        {
            caixa.Text += "3";
            resultado.Text += "3";
        }

        private void n4_Click(object sender, EventArgs e)
        {
            caixa.Text += "4";
            resultado.Text += "4";
        }

        private void n5_Click(object sender, EventArgs e)
        {
            caixa.Text += "5";
            resultado.Text += "5";
        }

        private void n6_Click(object sender, EventArgs e)
        {
            caixa.Text += "6";
            resultado.Text += "6";
        }

        private void n7_Click(object sender, EventArgs e)
        {
            caixa.Text += "7";
            resultado.Text += "7";
        }

        private void n8_Click(object sender, EventArgs e)
        {
            caixa.Text += "8";
            resultado.Text += "8";
        }

        private void n9_Click(object sender, EventArgs e)
        {
            caixa.Text += "9";
            resultado.Text += "9";
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            v1 = decimal.Parse(caixa.Text, CultureInfo.InvariantCulture);
            resultado.Text = caixa.Text.ToString() + "x";
            caixa.Text = "";
            opcao = "mult";
        }

        private void add_Click(object sender, EventArgs e)
        {
            v1 = decimal.Parse(caixa.Text, CultureInfo.InvariantCulture);
            resultado.Text = caixa.Text.ToString() + "+";
            caixa.Text = "";
            opcao = "soma";
        }

        private void menos_Click(object sender, EventArgs e)
        {
            v1 = decimal.Parse(caixa.Text, CultureInfo.InvariantCulture);
            resultado.Text = caixa.Text.ToString() + "-";
            caixa.Text = "";
            opcao = "sub";
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            caixa.Text = "";
            resultado.Text = "";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            v2 = decimal.Parse(caixa.Text, CultureInfo.InvariantCulture);
           
            if (opcao == "soma")
            {
                 caixa.Text = Convert.ToString(v1 + v2);
                 resultado.Text = "";
            }
            else if (opcao == "sub")
            {
                caixa.Text = Convert.ToString(v1 - v2);
                resultado.Text = "";
            }
            else if (opcao == "mult")
            {
                caixa.Text = Convert.ToString(v1 * v2);
                resultado.Text = "";
            }
            else if (opcao == "divi")
            {
                caixa.Text = Convert.ToString(v1 / v2);
                resultado.Text = "";
            }
        }

            
        }
    }

