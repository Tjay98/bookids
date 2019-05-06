using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            ClientesForm c = new ClientesForm();
            c.Show();
        }

        private void btnEscola_Click(object sender, EventArgs e)
        {
            EscolasForm es = new EscolasForm();
            es.Show();
        }

        private void btnAnimadores_Click(object sender, EventArgs e)
        {
            AnimadoresForm a = new AnimadoresForm();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
