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
    public partial class TelaEstoque : Form
    {
        public TelaEstoque()
        {
            InitializeComponent();
        }

        private void BEOrdemServico_Click(object sender, EventArgs e)
        {
            TelaOrdemServico telaOrdemServico = new TelaOrdemServico();
            this.Hide();
            telaOrdemServico.ShowDialog();

        }

        private void BESair_Click(object sender, EventArgs e)
        {
            TelaMenu telaMenu = new TelaMenu();
            this.Hide();
            telaMenu.ShowDialog();
        }
    }
}
