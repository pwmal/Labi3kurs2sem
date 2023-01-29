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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] s2 = new string[textBox1.TextLength - 1];
                s2 = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] nums = new int[s2.Length];
                for (int i = 0; i < s2.Length; i++)
                {
                    nums[i] = Convert.ToInt32(s2[i]);
                }
                int count = 0;
                for (int k = 0; k < nums.Length; k++)
                {
                    if (nums[k] % 2 == 0)
                        count++;
                }
                textBox2.Text = $"Количество четных цифр в предоставленом массиве равно: {count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
