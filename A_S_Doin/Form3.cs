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
    public partial class Form3 : Form
    {
        int[,] Y = new int[10, 10];
        Random rnd = new Random();

        public Form3()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 10;
            dataGridView1.RowCount = 10;
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[0].Cells[0].Value != null)
                {
                    textBox1.Text = "";
                    int count = 0;
                    int sum = 0;
                    for (int i = 0; i < Y.GetLength(0); i++)
                    {
                        if (Y[i, 9] < 0)
                        {
                            count++;
                        }
                    }
                    textBox1.Text = "Количество отрицательных элементов последнего столбца матрицы Y: " + count;
                    if (count >= 2)
                    {
                        textBox1.Text += $"{Environment.NewLine}Отрицательные элементы: ";
                        for (int i = 0; i < Y.GetLength(0); i++)
                        {
                            for (int k = 0; k < Y.GetLength(1); k++)
                            {
                                if (Y[i, k] < 0)
                                {
                                    textBox1.Text += Y[i, k] + "; ";
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < Y.GetLength(0); i++)
                        {
                            for (int k = 0; k < Y.GetLength(1); k++)
                            {
                                if (i == k)
                                {
                                    sum += Y[i, k];
                                }
                            }
                        }
                        textBox1.Text += $"{Environment.NewLine}Сумма чисел главной диагонали матрицы Y = " + sum;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 9; i++)
            {
                for (int k = 0; k <= 9; k++)
                {
                    Y[i, k] = rnd.Next(-10, 11);
                    dataGridView1.Rows[i].Cells[k].Value = Y[i, k].ToString();
                }
            }
        }
    }
}
