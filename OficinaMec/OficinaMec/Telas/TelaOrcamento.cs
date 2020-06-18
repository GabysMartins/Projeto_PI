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
            TelaInicial telaInicial = new TelaInicial();
            this.Hide();
            telaInicial.ShowDialog();
        }

        private void BOAbrir_Click(object sender, EventArgs e)
        {
            if(TOKM.Text=="")
            {
                MessageBox.Show("Existem campos que precisam ser preenchidos!");
            }
            else 
            {
                TelaOrdemServico telaOrdemServico = new TelaOrdemServico();
                this.Hide();
                telaOrdemServico.ShowDialog();
            }
        }
            
    }
}
