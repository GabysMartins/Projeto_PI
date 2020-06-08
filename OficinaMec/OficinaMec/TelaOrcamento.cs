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
    public partial class TelaOrcamento : Form
    {
        public TelaOrcamento()
        {
            InitializeComponent();
        }

        private void BOSair_Click(object sender, EventArgs e)
        {
            TelaMenu telaMenu = new TelaMenu();
            this.Hide();
            telaMenu.ShowDialog();
        }

        private void BOAbrir_Click(object sender, EventArgs e)
        {
            TelaOrdemServico telaOrdemServico = new TelaOrdemServico();
            this.Hide();
            telaOrdemServico.ShowDialog();
        }
    }
}
