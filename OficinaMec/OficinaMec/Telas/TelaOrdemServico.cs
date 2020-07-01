using OficinaMec.Arquivos;
using OficinaMec.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
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


        private void TelaOrdemServico_Load(object sender, EventArgs e)
        {


        }
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem = "";
        int i;
        private void button3_Click(object sender, EventArgs e)
        {

            ExibeOS eos = new ExibeOS(textBox3.Text);
            ExibePecasOS epo = new ExibePecasOS(textBox3.Text);


            string sql = $"select QTTD_PECA,COD_PECA from Consulta_Banco where NUM_ORC={textBox3.Text}";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conexao.conectar());
                SqlDataReader leitor = cmd.ExecuteReader();
                textBox1.Text += ("---------------------PEÇAS---------------------" + System.Environment.NewLine);

                while (leitor.Read())
                {
                    textBox1.Text += "Peça: " + leitor[0].ToString() + ", Valor: R$ " + leitor[1].ToString() + System.Environment.NewLine;
                    //Console.WriteLine("Peça: " + leitor[0].ToString() + ", Valor: R$ " + leitor[1].ToString() + System.Environment.NewLine);
                    i++;
                }
                textBox1.Text += "-----------------------------------------------" + System.Environment.NewLine + System.Environment.NewLine;
                conexao.desconectar();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao Buscar Itens!!";
                // Console.WriteLine(e);
            }

            string sql1 = $"select * from Orcamentos where NUM_ORC={textBox3.Text}";
            try
            {
                SqlCommand cmd = new SqlCommand(sql1, conexao.conectar());
                SqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    textBox1.Text += ("---------------------ORDEM DE SERVIÇO---------------------" + System.Environment.NewLine+ System.Environment.NewLine+
                        "Numero OS: " + leitor[0].ToString() + System.Environment.NewLine +
                        "Descrição OS: " + leitor[1].ToString() + System.Environment.NewLine +
                        "CPF: " + leitor[2].ToString() + System.Environment.NewLine +
                        "Placa: " + leitor[3].ToString() + System.Environment.NewLine +
                        "Nome: " + leitor[4].ToString() + System.Environment.NewLine +
                        "Telefone: " + leitor[5].ToString() + System.Environment.NewLine +
                        "Ano de Fabricação: " + leitor[6].ToString() + System.Environment.NewLine +
                        "Kilometragem: " + leitor[8].ToString() + System.Environment.NewLine +
                        "Modelo: " + leitor[7].ToString() + System.Environment.NewLine +
                        "Valor Peças: " + leitor[9].ToString() + System.Environment.NewLine +
                        "Valor Mão de Obra: " + leitor[10].ToString()+ System.Environment.NewLine+ 
                        "Valor Total: " + leitor[11].ToString() + System.Environment.NewLine+ System.Environment.NewLine +
                        "----------------------------------------------------------"+ System.Environment.NewLine + System.Environment.NewLine +
                        "OFICINA ABELHA");
                    // textBox2.Text = (leitor[1].ToString());

                }
                conexao.desconectar();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao Buscar Itens!!";
                // Console.WriteLine(e);
            }


            //TODescritivo.Text = eos.ExibeDescricao;
            //TOCPF.Text = eos.ExibeCPF;
            //TOPlaca.Text = eos.ExibePlaca;
            //TONome.Text = eos.ExibeNome;
            //TOTelefone.Text = eos.ExibeTel;
            //TOANO.Text = eos.ExibeAno;
            //TOModelo.Text = eos.ExibeModelo;
            //TOKM.Text = eos.ExibeKM;
            //textBox2.Text = eos.ExibeValorPec;
            //TOMao.Text = eos.ExibeValorMao;
            //textBox4.Text = eos.ExibeValorTotal;

        }


        private void BOSair_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            this.Hide();
            telaInicial.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sFileD = new SaveFileDialog();
            sFileD.Filter = "Arquivo (*.txt)|*.txt";
            if (sFileD.ShowDialog() == DialogResult.OK)
            {
                StreamWriter strW = new StreamWriter(sFileD.FileName);

                strW.Write(textBox1.Text);
                
                
                strW.Close();
            }

        }
       
       

        private void TOMao_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TOKM_TextChanged(object sender, EventArgs e)
        {

        }

        private void TOTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void TOModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TOANO_TextChanged(object sender, EventArgs e)
        {

        }

        private void TOCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void TONome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TOPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void Informacoes_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TODescritivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OsGeral og = new OsGeral();
            this.Hide();
            og.Show();
        }
    }
    }

