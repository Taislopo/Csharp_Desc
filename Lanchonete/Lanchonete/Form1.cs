using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) //Ao iniciar o form, o painel vai ficar invisivel e esses itens seraõ adicionados ao comboBox
        {
            panelEntrega.Visible = false;

            comboBoxSelecao.Items.Add("X-buguer");
            comboBoxSelecao.Items.Add("X-salada");
            comboBoxSelecao.Items.Add("X-tudo");
            comboBoxSelecao.Items.Add("X-frango");
            comboBoxSelecao.Items.Add("X-egg");
            comboBoxSelecao.Items.Add("X-bacon");



        }

        private void radioButtonEntrega_CheckedChanged(object sender, EventArgs e)
        {
            panelEntrega.Visible = true;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelEntrega_Paint(object sender, PaintEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lanche = comboBoxSelecao.SelectedItem.ToString();
            double valor = 0;

            switch (lanche)
            {
                case "X-burguer":
                    valor = 10.00;
                    break;
                case "X-salada":
                    valor = 12.00;
                    break;
                case "X-tudo":
                    valor = 15.00;
                    break;
                case "X-frango":
                    valor = 13.00;
                    break;
                case "X-egg":
                    valor = 11.00;
                    break;
                case "X-bacon":
                    valor = 14.00;
                    break;
                default:
                    MessageBox.Show("Selecione um lanche.");
                    return;
            }
            labelPreco.Text = "R$" + valor.ToString("F2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                double total = 0;
            
            
            if (comboBoxSelecao.SelectedItem != null) // se o combobox não estiver vazio então 
            {
                string lanche = comboBoxSelecao.SelectedItem.ToString(); // pega o texto do lanche que foi selecionado
                double valor = 0;

                switch (lanche)
                {

                    case "X-burguer":
                        valor = 10.00;
                        break;
                    case "X-salada":
                        valor = 12.00;
                        break;
                    case "X-tudo":
                        valor = 15.00;
                        break;
                    case "X-frango":
                        valor = 13.00;
                        break;
                    case "X-egg":
                        valor = 11.00;
                        break;
                    case "X-bacon":
                        valor = 14.00;
                        break;

                }

                listBoxListaPedidos.Items.Add(lanche); //adiociona os lanches na lista
                listBoxListaValor.Items.Add(valor.ToString("F2"));

                total = total + valor;
                labelResult.Text = "R$" + total.ToString("F2");

            }


            else
            {
                MessageBox.Show("Selecione um item", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

            if (comboBoxSelecao.SelectedIndex != -1 || comboBoxSelecao.SelectedIndex == 0)
            {
                comboBoxSelecao.Items.RemoveAt(comboBoxSelecao.SelectedIndex);
                comboBoxSelecao.ResetText();
            }

            else
            {
                MessageBox.Show("Selecione um item para remover", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
