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
    public partial class TelaAgendamento : Form
    {
        public TelaAgendamento()
        {
            InitializeComponent();
        }

        private void BACancelar_Click(object sender, EventArgs e)
        {
            TelaMenu telaMenu = new TelaMenu();
            this.Hide();
            telaMenu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
