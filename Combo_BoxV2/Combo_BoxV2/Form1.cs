using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_BoxV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            if (textBoxNome.TextLength == 0) { 
                MessageBox.Show("Preencha o campo Nome!", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                textBoxNome.Focus();
            }

            else
            {
                comboBoxInserir.Items.Add(textBoxNome.Text);
                textBoxNome.Clear();
            }

                   
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (comboBoxInserir.SelectedIndex != -1 || comboBoxInserir.SelectedIndex ==0)
            {
                comboBoxInserir.Items.RemoveAt(comboBoxInserir.SelectedIndex);
                comboBoxInserir.ResetText();    
            }

            else
            {
                MessageBox.Show("Selecione um item para remover", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
