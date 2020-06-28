using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        private void orcamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orcamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oficinaMecDataSet);

        }

        private void OsGeral_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oficinaMecDataSet.Orcamento'. Você pode movê-la ou removê-la conforme necessário.
            this.orcamentoTableAdapter.Fill(this.oficinaMecDataSet.Orcamento);

        }

        private void BOSair_Click(object sender, EventArgs e)
        {
            TelaOrdemServico TO = new TelaOrdemServico();
            this.Hide();
                TO.Show();
        }
        Conexao conexao = new Conexao();
        public String mensagem = "";
        int i;

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"SELECT NUM_ORC,DATA_AG FROM Agendamento where data between'{TAData.Text}' and '{textbox2.Text}' Order by DATA_AG ASC";

            SqlCommand cmd = new SqlCommand(sql, conexao.conectar());
            SqlDataReader leitor = cmd.ExecuteReader();
            
            try
            {
                while (leitor.Read())
                {
                    i++;
                    listBox1.Items.Add(" - Numero OS: " + leitor[0].ToString() + " - Data: " + leitor[1].ToString());
                }
                conexao.desconectar();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao Cadastrar!!";
                // Console.WriteLine(e);
            }
            i = int.Parse(label2.Text);
        }

        private void TAData_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
