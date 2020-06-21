using OficinaMec.Arquivos;
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
    public partial class TelaOrdemServico : Form
    {


        public TelaOrdemServico()
        {
            InitializeComponent();
        }


        private void TelaOrdemServico_Load(object sender, EventArgs e)
        {

       }

        private void button3_Click(object sender, EventArgs e)
        {

            ExibeOS eos = new ExibeOS(textBox3.Text);
            ExibePecasOS epo = new ExibePecasOS(textBox3.Text);
            listBox1.Items.Add(""+Convert.ToString(epo.desc));
            listBox2.Items.Add(""+ Convert.ToString(epo.quant));

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
    }
}
