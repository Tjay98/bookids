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

        
        private void AbrirAdmin_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            Form1 f1 = new Form1();
            f1.Close();
        }
    }
}
