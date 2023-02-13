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
            list.Add("Мандарин");
            list.Add("Груша");
            list.Add("Ананас");
            list.Add("Яблоко");
            list.Add("Банан");

            for(int i = 0; i < list.Count; i++) 
            {
                listBox1.Items.Add(list[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && list.Contains(textBox1.Text) == false)
            {
                list.Add(textBox1.Text);
                listBox1.Items.Add(list[list.Count - 1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string s = listBox1.SelectedItem.ToString();
                list.Remove(s);
                listBox1.Items.Remove(s);
            }
        }
    }
}
