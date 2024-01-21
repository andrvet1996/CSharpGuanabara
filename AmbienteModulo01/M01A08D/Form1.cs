using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01A08D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtN1.Text);
            int d = n * 2;
            lblMsg.Text = "O dobro de n é " + d;
            lblMsg.Visible = true;
        }
    }
}
