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
    public partial class TelaRemoverUsuario : Form
    {
        public TelaRemoverUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaCadUsuario telaCadUsuario = new TelaCadUsuario();
            this.Hide();
            telaCadUsuario.ShowDialog();

        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            RemoveUsu removeUsu = new RemoveUsu(textBox1.Text);
            MessageBox.Show(removeUsu.mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
