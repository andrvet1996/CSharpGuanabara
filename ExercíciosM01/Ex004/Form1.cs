using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            float num = 0;
            float.TryParse(txtNum.Text, out num);
            int n1 = (int) num;
            int n2 = Convert.ToInt16(num);
            lblMsg1.Text = $"Você digitou o valor {num:N}.";
            lblMsg2.Text = $"A parte inteira é {n1:D}.";
            lblMsg3.Text = $"Arredondando temos {n2:D}.";

            panResultado.Visible = true;
        }
    }
}
