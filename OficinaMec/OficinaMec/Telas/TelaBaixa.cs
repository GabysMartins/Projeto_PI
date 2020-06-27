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
    public partial class TelaBaixa : Form
    {
        public TelaBaixa()
        {
            InitializeComponent();
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            AlterarValorPeca avp = new AlterarValorPeca(int.Parse(textBox2.Text),textBox1.Text);
            MessageBox.Show(avp.mensagem, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExibeQttdPeca eos = new ExibeQttdPeca(textBox1.Text);
            eos.ExibeDesc = label2.Text;
        }
    }
}
