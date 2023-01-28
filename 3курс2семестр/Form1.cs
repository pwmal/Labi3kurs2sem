using System;
using System.Diagnostics;
using System.IO;
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
    public partial class Form1 : Form
    {
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        static void CocktailSort(int[] inArray)
        {
            int left = 0,
                 right = inArray.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (inArray[i] > inArray[i + 1])
                        Swap(inArray, i, i + 1);
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (inArray[i - 1] > inArray[i])
                        Swap(inArray, i - 1, i);
                }
                left++;
            }
        }

        public Form1()
        {
            InitializeComponent();
            textBox1.MaxLength =  19;
            textBox2.MaxLength = 19;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(0,10);
            }
            String s = String.Join(";", nums);
            textBox1.Text = s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String path = textBox4.Text;
            if(File.Exists(path))
            {
                FileStream f = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader r = new StreamReader(f);
                string s = r.ReadToEnd();
                textBox1.Text = s;
                r.Close();
                f.Close();
            }    
            else
            {
                MessageBox.Show("Путь к файлу введён неправильно");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var stopwatch = Stopwatch.StartNew();
            String[] s2 = new String[10];
            s2 = textBox1.Text.Split(new char[] { ';' });
            int[] nums = new int[10];
            for (int i = 0; i < s2.Length; i++)
            {
                nums[i] = Convert.ToInt32(s2[i]);
            }
            
            CocktailSort(nums);
            String s = String.Join(";", nums);
            textBox2.Text = s;
            stopwatch.Stop();
            textBox3.Text = Convert.ToString(stopwatch.ElapsedTicks);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
