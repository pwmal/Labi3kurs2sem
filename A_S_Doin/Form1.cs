using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_S_Doin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            if(s == "button1")
                label1.Visible = true;
            if (s == "button2")
                label2.Visible = true;
            if (s == "button3")
                label3.Visible = true;
            if (s == "button4")
                label4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
    }
}
