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
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
            
        }

        public string Propriedade { get; set; }
        public string PropriedadeUsu { get; set; }
       

        private void BMAgendamento_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Administrador")
            {
                TelaAgendamento telaAgendamento = new TelaAgendamento();
                this.Hide();
                telaAgendamento.ShowDialog();
            }else if (label2.Text == "Secretaria")
            {
                TelaAgendamento telaAgendamento = new TelaAgendamento();
                this.Hide();
                telaAgendamento.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para esta ferramenta","Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BMOrcamento_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Administrador")
            {
                TelaOrcamento telaOrcamento = new TelaOrcamento();
                this.Hide();
                telaOrcamento.ShowDialog();
            }
            else if (label2.Text == "Mecanico")
            {
            TelaOrcamento telaOrcamento = new TelaOrcamento();
            this.Hide();
            telaOrcamento.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para esta ferramenta", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BMCadastro_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Administrador")
            {
                TelaCadastro telaCadastro = new TelaCadastro();
                this.Hide();
                telaCadastro.ShowDialog();
            }
            else if (label2.Text == "Secretaria")
            {
                TelaCadastro telaCadastro = new TelaCadastro();
            this.Hide();
            telaCadastro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para esta ferramenta", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BMEstoque_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Administrador")
            {
                TelaEstoque telaEstoque = new TelaEstoque();
                this.Hide();
                telaEstoque.ShowDialog();
            }
            else if (label2.Text == "Estoquista")
            {
                TelaEstoque telaEstoque = new TelaEstoque();
                this.Hide();
                telaEstoque.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para esta ferramenta", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BMUsuario_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Administrador")
            {
                TelaCadUsuario telaCadUsuario = new TelaCadUsuario();
                this.Hide();
                telaCadUsuario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para esta ferramenta", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }


        private void BMSair_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            this.Hide();
            telaInicial.ShowDialog();
        }

      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void TelaMenu_Load(object sender, EventArgs e)
        {

                label2.Text = this.Propriedade;
                label4.Text = this.PropriedadeUsu;

            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Administrador")
            {
                OsGeral os = new OsGeral();
                this.Hide();
                os.ShowDialog();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para esta ferramenta", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}