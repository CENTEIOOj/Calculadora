using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora
{
    public partial class Form1 : Form


    { 
        public decimal Resultado { get; set; }
        public decimal valor { get; set; }
        private operacoes oprecaoeslecionadas { get; set; }
        private enum operacoes
        {
            adicao,
            subtracao,
            multiplicacao,
            divisao,
            divisaozero
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnponto_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            txtResultado.Text += ",";
        }

        private void btnequal_Click(object sender, EventArgs e)

        {
            switch (oprecaoeslecionadas)
            {
                case operacoes.adicao:
                    Resultado = valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case operacoes.subtracao:
                    Resultado = valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case operacoes.multiplicacao:
                    Resultado = valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case operacoes.divisao:
                    Resultado = valor / Convert.ToDecimal(txtResultado.Text);
                    break;
                case operacoes.divisaozero:
                    Resultado = valor % Convert.ToDecimal(txtResultado.Text);
                    break;
            }

            txtResultado.Text = Convert.ToString(Resultado);
           // label2.Text = "=";
            

        
        }

        private void btnPLUS_Click(object sender, EventArgs e)
        {

            
            oprecaoeslecionadas = operacoes.adicao;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            // label2.Text = "+";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btmLess_Click(object sender, EventArgs e)
        {
            oprecaoeslecionadas = operacoes.subtracao;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            // label2.Text = "-";

        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            
            valor = Convert.ToDecimal(txtResultado.Text);
            oprecaoeslecionadas = operacoes.multiplicacao;
            txtResultado.Text = "";
            // label2.Text = "x";


        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            
            valor = Convert.ToDecimal(txtResultado.Text);
            oprecaoeslecionadas = operacoes.divisao;
            txtResultado.Text = "";
           // label2.Text = "/";


        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            int lenght = txtResultado.TextLength - 1;
            string text = txtResultado.Text;  // MessageBox.Show(lenght.ToString());
            txtResultado.Clear();
            for (int i = 0; i < lenght; i++)
                txtResultado.Text = txtResultado.Text + text[i];
        }

        private void btndiv0_Click(object sender, EventArgs e)
        {
            valor = Convert.ToDecimal(txtResultado.Text);
            oprecaoeslecionadas = operacoes.divisaozero;
            txtResultado.Text = "";
            // label2.Text = "%";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
