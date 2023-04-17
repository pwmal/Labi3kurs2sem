using System;
using System.Collections;
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
    public partial class Form6 : Form
    {
        List<string> list = new List<string>();
        public Form6()
        {
            InitializeComponent();
            list.AddRange(new string[] { "Мандарин", "Груша", "Ананас", "Яблоко", "Банан" });

            foreach (string i in list)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && list.Contains(textBox1.Text) == false)
            {
                list.Add(textBox1.Text);

                listBox1.Items.Clear();
                foreach (string i in list)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string s = listBox1.SelectedItem.ToString();
                list.Remove(s);

                listBox1.Items.Clear();
                foreach (string i in list)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                textBox2.Text = Convert.ToString(list.IndexOf(textBox3.Text)+1);
            }
        }
    }
}
