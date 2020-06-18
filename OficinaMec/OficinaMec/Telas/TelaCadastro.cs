using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaMec
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void BCadAdicionar_Click(object sender, EventArgs e)
        {
            TelaCarro telaCarro = new TelaCarro();
            this.Hide();
            telaCarro.ShowDialog();
        }

        private void BCadSair_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            this.Hide();
            telaInicial.ShowDialog();
        }

        private void BCadSalvar_Click(object sender, EventArgs e)
        {
            AddCarro ac = new AddCarro(textbox2.Text,textbox1.Text,textbox3.Text,textbox4.Text,textbox5.Text,textbox6.Text);
            MessageBox.Show(ac.mensagem);
        }

        private void BCadLimpar_Click(object sender, EventArgs e)
        {
            textbox1.Text = "";
            textbox2.Text = "";
            textbox3.Text = "";
            textbox4.Text = "";
            textbox5.Text = "";
            textbox6.Text = "";
        }
    }
}
