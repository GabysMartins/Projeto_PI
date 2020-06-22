using OficinaMec.Arquivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaMec.Telas
{
    public partial class InserirPeca : Form
    {
        public InserirPeca()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BCUSair_Click(object sender, EventArgs e)
        {
            TelaEstoque telaEstoque = new TelaEstoque();
            this.Hide();
            telaEstoque.ShowDialog();
        }

        private void BCUSalvar_Click(object sender, EventArgs e)
        {
            Estoque est = new Estoque(textbox1.Text, Convert.ToInt32(textbox2.Text), textbox3.Text, textbox4.Text, textBox5.Text, textbox6.Text);
            MessageBox.Show(est.mensagem);
        }

        private void textbox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void InserirPeca_Load(object sender, EventArgs e)
        {
            
        }
    }
}
