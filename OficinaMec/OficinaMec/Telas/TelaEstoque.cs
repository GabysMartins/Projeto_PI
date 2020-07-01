using OficinaMec.Telas;
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

        private void BESair_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            this.Hide();
            telaInicial.ShowDialog();
        }

        private void TelaEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oficinaMecDataSet.Pecas_estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.pecas_estoqueTableAdapter.Fill(this.oficinaMecDataSet.Pecas_estoque);

        }

        private void BEAcrescentar_Click(object sender, EventArgs e)
        {
            InserirPeca inserirPeca = new InserirPeca();
            this.Hide();
            inserirPeca.ShowDialog();
        }

        private void BEExcluir_Click(object sender, EventArgs e)
        {
            ExcluirPeca ex = new ExcluirPeca();
            this.Hide();
            ex.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaixaEstoque be = new BaixaEstoque();
            this.Hide();
            be.ShowDialog();

        }
    }
}
