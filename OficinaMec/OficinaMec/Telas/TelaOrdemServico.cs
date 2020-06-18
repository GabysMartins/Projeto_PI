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
    public partial class TelaOrdemServico : Form
    {
        public TelaOrdemServico()
        {
            InitializeComponent();
        }

        private void BSFinalizar_Click(object sender, EventArgs e)
        {
            TelaOrcamento telaOrcamento = new TelaOrcamento();
            this.Hide();
            telaOrcamento.ShowDialog();
        }

        private void BSSair_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            this.Hide();
            telaInicial.ShowDialog();
        }

        private void BSEstoque_Click(object sender, EventArgs e)
        {
            TelaEstoque telaEstoque = new TelaEstoque();
            this.Hide();
            telaEstoque.ShowDialog();
        }
    }
}
