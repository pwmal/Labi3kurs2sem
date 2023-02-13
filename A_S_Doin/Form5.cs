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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            listBox1.Items.AddRange(new string[] { "1222 83 91", "29 84 52 2 4", " 90 0 12 3" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add(textBox1.Text);    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                string[] s = listBox1.SelectedItem.ToString().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < s.Length; i++)
                {
                    if (Convert.ToInt32(s[i]) % 2 == 0)
                    {
                        count++;
                    }
                }
                textBox2.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
