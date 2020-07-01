using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaMec.Telas
{
    public partial class OsGeral : Form
    {
        public OsGeral()
        {
            InitializeComponent();
        }
        Conexao conexao = new Conexao();
        public String mensagem = "";
        int i;

        private void orcamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orcamentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oficinaMecDataSet);

        }

        private void OsGeral_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oficinaMecDataSet.Orcamento'. Você pode movê-la ou removê-la conforme necessário.
            this.orcamentosTableAdapter.Fill(this.oficinaMecDataSet.Orcamentos);

        }

        private void BOSair_Click(object sender, EventArgs e)
        {
            TelaOrdemServico TO = new TelaOrdemServico();
            this.Hide();
            TO.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Text = "";
            string sql = $"SELECT NUM_ORC,DATA_AG FROM Agendamento where DATA_AG between'{TAData.Text}' and '{textbox2.Text}' Order by DATA_AG ASC";

            SqlCommand cmd = new SqlCommand(sql, conexao.conectar());
            SqlDataReader leitor = cmd.ExecuteReader();

            try
            {
                while (leitor.Read())
                {

                    listBox1.Items.Add(" - Numero OS: " + leitor[0].ToString() + " - Data: " + leitor[1].ToString());
                    i++;
                }
                conexao.desconectar();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao Cadastrar!!";
                // Console.WriteLine(e);
            }

        }

        private void TAData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listBox1.Text = "";
            string sql = $"SELECT NOME_ORC,DESC_ORC,PLACA_ORC,VALOR_TOTAL_ORC FROM Orcamentos where CPF_ORC = '{maskedTextBox1.Text}'";

            SqlCommand cmd = new SqlCommand(sql, conexao.conectar());
            SqlDataReader leitor = cmd.ExecuteReader();

            try
            {
                while (leitor.Read())
                {

                    listBox1.Items.Add(" - Nome: " + leitor[0].ToString() + " - Placa: " + leitor[2].ToString() + " - Valor: " + leitor[3].ToString() + " - Descricao: " + leitor[1].ToString());
                    i++;
                }
                conexao.desconectar();
            }
            catch (SqlException exx)
            {
                this.mensagem = "Erro ao Cadastrar!!";
                Console.WriteLine(exx);
            }

        }

    }
}
