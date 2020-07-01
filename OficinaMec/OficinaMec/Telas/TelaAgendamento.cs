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

namespace OficinaMec
{
    public partial class TelaAgendamento : Form
    {
        public TelaAgendamento()
        {
            InitializeComponent();
        }

        private void BACancelar_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            this.Hide();
            telaInicial.ShowDialog();
        }

        private void BALimpar_Click(object sender, EventArgs e)
        {
            TADescritivo.Text = "";
            TACPF.Text = "";
            TAPlaca.Text = "";
            TANome.Text = "";
            TATelefone.Text = "";
            TAANO.Text = "";
            TAModelo.Text = "";
            listBox1.Items.Clear();
            TAData.Text = "";
            textbox2.Text = "";
            TAHorario.Text = "";
            textBox1.Text = "";
        }

        private void BAAgendar_Click(object sender, EventArgs e)
        {
            if (TAHorario.Text != "")
            {
                if (TAData.Text != "")
                {
                    InsereAgendamento ia = new InsereAgendamento(textBox1.Text, textBox1.Text, TADescritivo.Text, TACPF.Text, TAPlaca.Text, TANome.Text, TATelefone.Text, TAANO.Text, TAModelo.Text, TAData.Text, TAHorario.Text);
                    MessageBox.Show(ia.mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Insira a data", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Insira o horário", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExibeOS eos = new ExibeOS(textBox1.Text);

            TADescritivo.Text = eos.ExibeDescricao;
            TACPF.Text = eos.ExibeCPF;
            TAPlaca.Text = eos.ExibePlaca;
            TANome.Text = eos.ExibeNome;
            TATelefone.Text = eos.ExibeTel;
            TAANO.Text = eos.ExibeAno;
            TAModelo.Text = eos.ExibeModelo;


        }

        private void agendamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.oficinaMecDataSet);

        }

        private void TelaAgendamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oficinaMecDataSet.Agendamento'. Você pode movê-la ou removê-la conforme necessário.
            //this.agendamentoTableAdapter.Fill(this.oficinaMecDataSet.Agendamento);

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        Conexao conexao = new Conexao();
        public String mensagem = "";

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = $"SELECT DATA_AG, HORA_AG,NUM_ORC FROM Agendamento where DATA_AG='{textbox2.Text}' Order by HORA_AG ASC";

            SqlCommand cmd = new SqlCommand(sql, conexao.conectar());
            SqlDataReader leitor = cmd.ExecuteReader();

            try
            {
                while (leitor.Read())
                {
                    listBox1.Items.Add("Horário: " + leitor[1].ToString() + " - Numero OS: " + leitor[2].ToString() + " - Data: " + leitor[0].ToString());
                }
                conexao.desconectar();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao Cadastrar!!";
                // Console.WriteLine(e);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

    

