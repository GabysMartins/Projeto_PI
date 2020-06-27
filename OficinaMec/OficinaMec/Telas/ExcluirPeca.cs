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
    public partial class ExcluirPeca : Form
    {
        public ExcluirPeca()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            TelaInicial telaEstoque = new TelaInicial();
            this.Hide();
            telaEstoque.ShowDialog();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            ExcluiPeca exp = new ExcluiPeca(textBox1.Text);
            MessageBox.Show(exp.mensagem, "" ,MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
