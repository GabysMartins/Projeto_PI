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
            TelaMenu telaMenu = new TelaMenu();
            this.Hide();
            telaMenu.ShowDialog();
        }

        private void BCUSalvar_Click(object sender, EventArgs e)
        {

        CadastroUsu cad = new CadastroUsu(textBox1.Text, TCUCPF.Text, TCUNome.Text, TCUEmail.Text, TCUSenha.Text,TCUPermissao.Text); 
            MessageBox.Show(cad.mensagem);
         
        }

        private void TCUEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TelaCadUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'oficinaMecDataSet.Funcionario'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioTableAdapter.Fill(this.oficinaMecDataSet.Funcionario);

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
    }
}
