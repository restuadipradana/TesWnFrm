using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesWnFrm
{
    public partial class Coba : Form
    {
        public Coba()
        {
            InitializeComponent();
        }

        private void Coba_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            txtHello.Text = "Hellow!";
        }
    }
}
