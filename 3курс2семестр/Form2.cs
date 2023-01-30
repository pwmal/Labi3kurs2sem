using System;
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
    public partial class Form2 : Form
    {
        static int BinarySearch(int[] array, int searchedValue, int left, int right)
        {
            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (searchedValue == array[middle])
                {
                    return middle;
                }
                else if (searchedValue < array[middle])
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return -1;
        }
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
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(0, 101);
            }
            String s = String.Join(";", nums);
            textBox1.Text = s;
        }

        string sfile;
        private void button2_Click(object sender, EventArgs e)
        {
            String path = textBox4.Text;
            if (File.Exists(path))
            {
                FileStream f = new FileStream(path, FileMode.Open, FileAccess.Read);
                StreamReader r = new StreamReader(f);
                sfile = r.ReadToEnd();
                textBox1.Text = sfile;
                r.Close();
                f.Close();
            }
            else
            {
                MessageBox.Show("Путь к файлу введён неправильно");
            }
        }
        public void file1(string a, int index, int m)
        {
            string path = textBox6.Text;
            using (FileStream file = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter w = new StreamWriter(file))
                {
                    if (sfile == textBox1.Text)
                    {
                        if (a == "Максимальное")
                        {
                            w.Write($"Максимальное число массива находится в {index + 1} позиции и равно " + Convert.ToString(m));
                        }
                        else if(a == "Минимальное")
                        {
                            w.Write(path, $"Минимальное число массива находится в {index + 1} позиции и равно " + Convert.ToString(m));
                        }
                    }
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Text == "Максимальное")
                {
                    string[] s2 = new string[10];
                    s2 = textBox1.Text.Split(new char[] { ';' });
                    int max = Convert.ToInt32(s2[0]);
                    int index = 0;
                    for (int i = 0; i < s2.Length; i++)
                    {
                        if (Convert.ToInt32(s2[i]) > max)
                        {
                            max = Convert.ToInt32(s2[i]);
                            index = i;
                        }
                    }
                    file1("Максимальное", index, max);
                    textBox3.Text = $"Максимальное число массива находится в {index + 1} позиции и равно " + Convert.ToString(max);
                }
                else
                {
                    string[] s2 = new string[10];
                    s2 = textBox1.Text.Split(new char[] { ';' });
                    int min = Convert.ToInt32(s2[0]);
                    int index = 0;
                    for (int i = 0; i < s2.Length; i++)
                    {
                        if (Convert.ToInt32(s2[i]) < min)
                        {
                            min = Convert.ToInt32(s2[i]);
                            index = i;
                        }
                    }
                    file1("Минимальное", index, min);
                    textBox3.Text = $"Минимальное число массива находится в {index + 1} позиции и равно " + Convert.ToString(min);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Text == "Поиск")
                {
                    string[] s2 = new string[10];
                    s2 = textBox1.Text.Split(new char[] { ';' });
                    int index = 0;
                    int number = 0;
                    for (int i = 0; i < s2.Length; i++)
                    {
                        if (s2[i] == textBox2.Text)
                        {
                            number = Convert.ToInt32(s2[i]);
                            index = i;
                            textBox3.Text = $"Выбранное Вами число массива находится в {index + 1} позиции";
                            break;
                        }
                    }

                    if (number == 0)
                        textBox3.Text = "В данном массиве такого числа нет, попробуйте еще раз!";

                }
                else
                {
                    string[] s2 = new string[10];
                    s2 = textBox1.Text.Split(new char[] { ';' });
                    int[] nums = new int[10];
                    for (int i = 0; i < s2.Length; i++)
                    {
                        nums[i] = Convert.ToInt32(s2[i]);
                    }
                    CocktailSort(nums);
                    String s = String.Join(";", nums);
                    textBox5.Text = s;
                    int l = 0, r = nums.Length;
                    int number = Convert.ToInt32(textBox2.Text);
                    int result = BinarySearch(nums, number, l, r);
                    if (result == -1)
                        textBox3.Text = "В данном массиве такого числа нет, попробуйте еще раз!";
                    else
                        textBox3.Text = $"Выбранное Вами число массива находится в {result + 1} позиции" ;
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
