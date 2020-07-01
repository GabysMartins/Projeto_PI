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
            if (TOKM.Text == "")
            {
                MessageBox.Show("Existem campos que precisam ser preenchidos!");

            }
            else
            {
                if (label3.Text != "0")
                {
                    Salva_OS so = new Salva_OS(label3.Text, TODescritivo.Text, TOCPF.Text, TOPlaca.Text, TONome.Text, TOTelefone.Text, TOANO.Text, TOModelo.Text, TOKM.Text, label2.Text, TOMao.Text, ValorServico.Text);
                    MessageBox.Show("Ordem de Serviço gerada!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TelaOrdemServico telaOrdemServico = new TelaOrdemServico();
                    this.Hide();
                    telaOrdemServico.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Gere um número de Ordem de serviço primeiro!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
        float TotalProdutos, TotalTudo;

        private void button2_Click(object sender, EventArgs e)
        {
            TotalTudo = (float.Parse(label2.Text) + float.Parse(TOMao.Text));
            ValorServico.Text = Convert.ToString(TotalTudo);
        }

        private void BOEliminar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (label3.Text != "0")
                {
                    AdicionarPecaOrcamento apo = new AdicionarPecaOrcamento(textBox1.Text);
                    RemOS_Peca remos = new RemOS_Peca(apo.ExibeDescricao);
                    listBox1.Items.Remove("Item: " + apo.ExibeDescricao + " - Preço:" + apo.ExibePreco + ".");
                    TotalProdutos -= float.Parse(apo.ExibePreco);
                    label2.Text = Convert.ToString(TotalProdutos);
                }
                else
                {
                    MessageBox.Show("Gere um numero de OS primeiro!");
                }
            }
            else
            {
                MessageBox.Show("Insira o código do produto primeiro!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
        

        private void button3_Click(object sender, EventArgs e)
        {
            Random aleatorio = new Random();
            int OS = aleatorio.Next(1, 1000000);
            label3.Text = Convert.ToString(OS);
        }

        private void BOCancelar_Click(object sender, EventArgs e)
        {
            TelaOrdemServico telaOrdemServico = new TelaOrdemServico();
            this.Hide();
            telaOrdemServico.ShowDialog();
        }

        private void BOAcrescentar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (label3.Text != "0")
                {
                    AdicionarPecaOrcamento apo = new AdicionarPecaOrcamento(textBox1.Text);
                    AddOS_Peca aop = new AddOS_Peca(apo.ExibeDescricao, label3.Text, apo.ExibePreco);
                    listBox1.Items.Add("Item: " + apo.ExibeDescricao + " - Preço:" + apo.ExibePreco + ".");
                    TotalProdutos += float.Parse(apo.ExibePreco);
                    label2.Text = Convert.ToString(TotalProdutos);

                }
                else
                {
                    MessageBox.Show("Gere um numero de OS primeiro!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Insira o código do produto primeiro!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }
    }


