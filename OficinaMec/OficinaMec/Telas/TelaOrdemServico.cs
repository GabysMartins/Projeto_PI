using OficinaMec.Arquivos;
using OficinaMec.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
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

        private void button3_Click(object sender, EventArgs e)
        {

            ExibeOS eos = new ExibeOS(textBox3.Text);
            ExibePecasOS epo = new ExibePecasOS(textBox3.Text);

            string sql = $"select QTTD_PECA,COD_PECA from Consulta_Banco where NUM_ORC={textBox3.Text}";
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conexao.conectar());
                SqlDataReader leitor = cmd.ExecuteReader();

                while (leitor.Read())
                {
                    textBox1.Text = (leitor[0].ToString() + ", " + leitor[1].ToString());
                    // textBox2.Text = (leitor[1].ToString());

                }
                conexao.desconectar();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao Buscar Itens!!";
                // Console.WriteLine(e);
            }

            //listBox1.ValueMember = ("QTTD_PECA");
            //listBox2.ValueMember = ("COD_PECA");
            //listBox1.DisplayMember = (epo.ExibeDesc);
            //listBox2.DisplayMember = (epo.ExibePreco);
            TODescritivo.Text = eos.ExibeDescricao;
            TOCPF.Text = eos.ExibeCPF;
            TOPlaca.Text = eos.ExibePlaca;
            TONome.Text = eos.ExibeNome;
            TOTelefone.Text = eos.ExibeTel;
            TOANO.Text = eos.ExibeAno;
            TOModelo.Text = eos.ExibeModelo;
            TOKM.Text = eos.ExibeKM;
            textBox2.Text = eos.ExibeValorPec;
            TOMao.Text = eos.ExibeValorMao;
            textBox4.Text = eos.ExibeValorTotal;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            TOCPF.Enabled = true;
            TOPlaca.Enabled = true;
            TONome.Enabled = true;
            TOTelefone.Enabled = true;
            TOANO.Enabled = true;
            TOModelo.Enabled = true;
            TOKM.Enabled = true;
            textBox1.Enabled = true;
            TODescritivo.Enabled = true;
            textBox2.Enabled = true;
            TOMao.Enabled = true;
            textBox4.Enabled = true;
        }

        private void BOSair_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            this.Hide();
            telaInicial.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            PrintDocument printDocument = new PrintDocument();

            shot = GetScreenShot();

            printDocument.DocumentName = this.Name;
            printDocument1.DefaultPageSettings.Landscape = false;


            printDocument.PrintPage += new PrintPageEventHandler(this.PrintPage);
            previewDialog.Document = printDocument;
            previewDialog.ShowDialog();

        }
        private Image GetScreenShot()
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(new Point(this.Left, this.Top), Point.Empty, this.Size);
            return bmp;
        }

        Bitmap memoryImage;

        Image shot;

        private void PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(shot, 0, 0, shot.Width, shot.Height);
            e.HasMorePages = false;
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

