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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void BIEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string per = "";
            if (radioButton1.Checked)
            {
                per = "Administrador";
            }else if (radioButton2.Checked)
            {
                per = "Secretaria";
            }else if(radioButton3.Checked){
                per = "Mecanico";
            }else if (radioButton4.Checked)
            {
                per = "Estoquista";
            }
            controle.acessar(TIUsuario.Text,TISenha.Text,per);
            if (controle.tem)
            {
                MessageBox.Show("Logado com sucesso!","Entrando",MessageBoxButtons.OK,MessageBoxIcon.Information);
                TelaMenu telaMenu = new TelaMenu();
                telaMenu.Propriedade = per;
                telaMenu.PropriedadeUsu = TIUsuario.Text;
                this.Hide();
                telaMenu.ShowDialog();
                
                
            }
            else {
                MessageBox.Show("Login, senha ou permissão incorreta!","Erro!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void TIUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
