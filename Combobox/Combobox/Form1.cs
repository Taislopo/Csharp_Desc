using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch( Convert.ToInt32(comboBoxeEscolha.SelectedItem))
            {
                case 1:
                    labelResposta.Text = "Você escolheu a opção 1 - Janeiro";
                    break;
                case 2:
                    labelResposta.Text = "Você escolheu a opção 2 - Fevereiro";
                    break;
                case 3:
                    labelResposta.Text = "Você escolheu a opção 3 - Março";
                    break;
                case 4:
                    labelResposta.Text = "Você escolheu a opção 4 - Abril";
                    break;
                case 5:
                    labelResposta.Text = "Você escolheu a opção 5 - Maio";
                    break;
                case 6:
                    labelResposta.Text = "Você escolheu a opção 6 - Junho";
                    break;
                case 7:
                    labelResposta.Text = "Você escolheu a opção 7 - Julho";
                    break;
                case 8:
                    labelResposta.Text = "Você escolheu a opção 8 - Agosto";
                    break;
                case 9:
                    labelResposta.Text = "Você escolheu a opção 9 - Setembro";
                    break;
                case 10:
                    labelResposta.Text = "Você escolheu a opção 10 - Outubro";
                    break;
                case 11:
                    labelResposta.Text = "Você escolheu a opção 11 - Novembro";
                    break;
                case 12:
                    labelResposta.Text = "Você escolheu a opção 12 - Dezembro";
                    break;
                default: 
                    labelResposta.Text = "Você não escolheu uma opção válida";
                    break;



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
