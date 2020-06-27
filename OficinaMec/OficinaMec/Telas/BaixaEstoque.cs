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
    public partial class BaixaEstoque : Form
    {
        public BaixaEstoque()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            TelaEstoque est = new TelaEstoque();
            this.Hide();
            est.ShowDialog();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            BaixaPecas bp = new BaixaPecas(textBox1.Text, Convert.ToInt32(textBox2.Text));
            MessageBox.Show(bp.mensagem, "" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
