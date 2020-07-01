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
    public partial class TelaCadUsuario : Form
    {
        public TelaCadUsuario()
        {
            InitializeComponent();
        }

        private void BCUSair_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            this.Hide();
            telaInicial.ShowDialog();
        }

        private void BCUSalvar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                CadastroUsu cad = new CadastroUsu(textBox1.Text, TCUCPF.Text, TCUNome.Text, TCUEmail.Text, TCUSenha.Text, "Administrador");
                MessageBox.Show(cad.mensagem, "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton2.Checked)
            {
                CadastroUsu cad = new CadastroUsu(textBox1.Text, TCUCPF.Text, TCUNome.Text, TCUEmail.Text, TCUSenha.Text, "Secretaria");
                MessageBox.Show(cad.mensagem, "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (radioButton3.Checked)
            {
                CadastroUsu cad = new CadastroUsu(textBox1.Text, TCUCPF.Text, TCUNome.Text, TCUEmail.Text, TCUSenha.Text, "Mecanico");
                MessageBox.Show(cad.mensagem, "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (radioButton4.Checked)
            {
                CadastroUsu cad = new CadastroUsu(textBox1.Text, TCUCPF.Text, TCUNome.Text, TCUEmail.Text, TCUSenha.Text, "Estoquista");
                MessageBox.Show(cad.mensagem, "Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Selecione uma permissão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TCUEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TelaCadUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oficinaMecDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            //this.funcionarioTableAdapter.Fill(this.oficinaMecDataSet.Funcionario);

        }

        private void pERMIS_FUNCListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BCURemover_Click(object sender, EventArgs e)
        {
            TelaRemoverUsuario TelaRemoverUsu = new TelaRemoverUsuario();
            this.Hide();
            TelaRemoverUsu.ShowDialog();
        }
    }
}
