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

        private void TONome_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void TOCPF_TextChanged(object sender, EventArgs e)
        {


        }

        private void TelaOrcamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oficinaMecDataSet.Orcamento'. Você pode movê-la ou removê-la conforme necessário.
            //this.orcamentoTableAdapter.Fill(this.oficinaMecDataSet.Orcamento);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExibirCliente ec = new ExibirCliente(TOCPF.Text);
            ExibirCarro ecar = new ExibirCarro(TOPlaca.Text);

            TONome.Text = ec.ExibNome;
            TOTelefone.Text = ec.ExibTelefone;
            TOANO.Text = ecar.ExibAno;
            TOModelo.Text = ecar.ExibModelo;



        }

       void somar(int x, int y) {
            TOPecas.Text = Convert.ToString(x + y);
        }
        
        
        private void BOAcrescentar_Click(object sender, EventArgs e)
        {
            AdicionarPecaOrcamento apo = new AdicionarPecaOrcamento(textBox1.Text);
            listBox1.Items.Add(""+apo.ExibeDescricao+" - Preço:"+apo.ExibePreco+"."); 
            int a = Convert.ToInt16(apo.ExibePreco);
            int b = Convert.ToInt32(TOPecas.Text);
            somar(a, b);


        }
    }
}
