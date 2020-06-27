using OficinaMec.Arquivos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OficinaMec.Telas
{
    public partial class ExcluirCarro : Form
    {
        public ExcluirCarro()
        {
            InitializeComponent();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            ExcluiCarro ec = new ExcluiCarro(textBox1.Text);
            MessageBox.Show(ec.mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            TelaCadastro tc = new TelaCadastro();
            this.Hide();
            tc.Show();
        }
    }
}
