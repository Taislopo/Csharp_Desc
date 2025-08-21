using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FormCalculadora : Form
    {
            double resultado;
            double numero;
            string operador;
             double numero2;

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button13_Click(object sender, EventArgs e)

        {

            if (textBox1.Text == "0" && textBox1.Text == null)
            {


                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void buttonN2_Click(object sender, EventArgs e)
        {
         

            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void N3_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void buttonN4_Click(object sender, EventArgs e)
        {
          

            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void buttonN5_Click(object sender, EventArgs e)
        {
         

            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void buttonN6_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void buttonN7_Click(object sender, EventArgs e)
        {
         

            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void buttonN8_Click(object sender, EventArgs e)
        {
         

            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void buttonN9_Click(object sender, EventArgs e)
        {
           

            if (textBox1.Text == "0" && textBox1.Text == null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void buttonN0_Click(object sender, EventArgs e)
        {
        
                textBox1.Text = textBox1.Text + "0";
            
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
         

            numero = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operador = "+";
        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
        

            numero = Convert.ToDouble(textBox1.Text);   
            textBox1.Text = "";
            operador = "-";
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
          

            numero = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operador = "*";

        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            numero = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operador = "/";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultado = 0;
            textBox1.Text = "0";
            numero = 0;
            numero2 = 0;
            

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            


            numero2 = Convert.ToDouble(textBox1.Text);

            if (operador == "+")
            {
                resultado = numero + numero2;
                textBox1.Text = Convert.ToString(resultado);
                numero = resultado;
            }
            if (operador == "-")
            {
                resultado = numero - numero2;
                textBox1.Text = Convert.ToString(resultado);
                numero = resultado;
            }
            if (operador == "*")
            {
                resultado = numero * numero2;
                textBox1.Text = Convert.ToString(resultado);
                numero = resultado;
            }

            if (operador == "/")
            {
                if (numero2 == 0)
                {
                    textBox1.Text = "Impossível dividir por zero";
                }
                else
                {
                    resultado = numero / numero2;
                    textBox1.Text = Convert.ToString(resultado);
                    numero = resultado;
                }


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
