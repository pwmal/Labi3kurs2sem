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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void math(double f)
        {
            double Verh, p, y, z, x;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);
            z = Convert.ToDouble(textBox3.Text);
            Verh = Math.Abs(Math.Min(f, y) - Math.Max(y, z));
            p = Verh / 2;
            textBox5.Text = f.ToString();
            textBox4.Text = p.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(radioButton1.Checked == true)
                {
                    double x;
                    x = Convert.ToDouble(textBox1.Text);
                    math(Math.Pow(x, x));
                }
                if (radioButton2.Checked == true)
                {
                    double x;
                    x = Convert.ToDouble(textBox1.Text);
                    math(Math.Pow(Math.E, x));
                }
                if (radioButton3.Checked == true)
                {
                    double x;
                    x = Convert.ToDouble(textBox1.Text);
                    math(Math.Sinh(x));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
