using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3курс2семестр
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int Factorial(int n)
        {
            if (n == 1) return 1;

            return n * Factorial(n - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = Convert.ToString(Factorial(Convert.ToInt32(textBox1.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
