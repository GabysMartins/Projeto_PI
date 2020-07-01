using OficinaMec.Arquivos;
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
    public partial class TelaCarro : Form
    {
        public TelaCarro()
        {
            InitializeComponent();
        }

        private void BCCSair_Click(object sender, EventArgs e)
        {
            TelaCadastro telaInicial = new TelaCadastro();
            this.Hide();
            telaInicial.ShowDialog();
        }

        private void BCCSalvar_Click(object sender, EventArgs e)
        {
            AddCarro ad = new AddCarro(textbox1.Text, textbox2.Text, textbox3.Text, textbox4.Text, textbox5.Text);
            MessageBox.Show(ad.mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BCCExcluir_Click(object sender, EventArgs e)
        {
            ExcluirCarro ex = new ExcluirCarro();
            this.Hide();
            ex.Show();
        }

        private void TelaCarro_Load(object sender, EventArgs e)
        {

        }
    }
}
