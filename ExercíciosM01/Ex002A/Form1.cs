using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex002A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task BtnIniciar_ClickAsync(object sender, EventArgs e)
        {
            //lblMsg1.Visible = true; 
            //lblMsg2.Visible = true; 
            //lblMsg3.Visible = true;
            //await Task.Delay(1000);
            lblMsg1.BackColor = Color.Blue;
            lblMsg1.ForeColor = Color.White;
            await Task.Delay(1000);
            lblMsg2.BackColor = Color.Yellow;
            lblMsg2.ForeColor = Color.Green;
            await Task.Delay(1000);
            lblMsg3.BackColor = Color.Green;
            lblMsg3.ForeColor = Color.Yellow;
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
