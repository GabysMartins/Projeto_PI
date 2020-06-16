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
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void BMAgendamento_Click(object sender, EventArgs e)
        {
            TelaAgendamento telaAgendamento = new TelaAgendamento();
            this.Hide();
            telaAgendamento.ShowDialog();
            
        }

        private void BMOrcamento_Click(object sender, EventArgs e)
        {
            TelaOrcamento telaOrcamento = new TelaOrcamento();
            this.Hide();
            telaOrcamento.ShowDialog();
        }

        private void BMCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            this.Hide();
            telaCadastro.ShowDialog();
        }

        private void BMEstoque_Click(object sender, EventArgs e)
        {
            TelaEstoque telaEstoque = new TelaEstoque();
            this.Hide();
            telaEstoque.ShowDialog();
        }

        private void BMUsuario_Click(object sender, EventArgs e)
        {
            TelaCadUsuario telaCadUsuario = new TelaCadUsuario();
            this.Hide();
            telaCadUsuario.ShowDialog();
        }

        private void BMConsulta_Click(object sender, EventArgs e)
        {
            TelaConsulta telaConsulta = new TelaConsulta();
            this.Hide();
            telaConsulta.ShowDialog();
        }

        private void BMSair_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            this.Hide();
            telaInicial.ShowDialog();
        }
    }
}
