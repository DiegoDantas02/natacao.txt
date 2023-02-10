using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace natacao.txt
{
    public partial class Natação : Form
    {
        private object txtAnoNascimento;

        public Natação()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textAnoUltimoAniversario_TextChanged(object sender, EventArgs e)
        {
            if (txtNascimento.Text.Trim().Length < 4)
                               {
                MessageBox.Show("É preciso informar o ANO DE NASCIMENTO com 4 Digitos",
                        "Atenção!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        txtNascimento.Focus();
            }
        }

        private void textNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void textAnoUltimoAniversario_Enter(object sender, EventArgs e)
        {

        }
    }
}
