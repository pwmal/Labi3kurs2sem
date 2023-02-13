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
    public partial class Form6 : Form
    {
        int index;
        public Form6()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Сумма", "Разность", "Скалярное произведение", "Косинус угла", "Длина вектора"});
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            if (comboBox1.SelectedIndex == 4)
            {
                textBox2.Enabled = false;
            }
            index = comboBox1.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] s1 = new string[3];
                s1 = textBox1.Text.Split(new char[] { ',' });
                string[] s2 = new string[3];
                s2 = textBox2.Text.Split(new char[] { ',' });
                switch (index)
                {
                    case 0:
                        Vector vectorC01 = new Vector(Convert.ToDouble(s1[0]), Convert.ToDouble(s1[1]), Convert.ToDouble(s1[2]));
                        Vector vectorC02 = new Vector(Convert.ToDouble(s2[0]), Convert.ToDouble(s2[1]), Convert.ToDouble(s2[2]));
                        Vector result = new Vector();
                        result = vectorC01 + vectorC02;
                        textBox3.Text = $"X:{result.X} Y:{result.Y} Z:{result.Z}";
                        break;

                    case 1:
                        Vector vectorC11 = new Vector(Convert.ToDouble(s1[0]), Convert.ToDouble(s1[1]), Convert.ToDouble(s1[2]));
                        Vector vectorC12 = new Vector(Convert.ToDouble(s2[0]), Convert.ToDouble(s2[1]), Convert.ToDouble(s2[2]));
                        Vector result2 = vectorC11 - vectorC12;
                        textBox3.Text = $"X:{result2.X} Y:{result2.Y} Z:{result2.Z}";
                        break;

                    case 2:
                        Vector vectorC21 = new Vector(Convert.ToDouble(s1[0]), Convert.ToDouble(s1[1]), Convert.ToDouble(s1[2]));
                        Vector vectorC22 = new Vector(Convert.ToDouble(s2[0]), Convert.ToDouble(s2[1]), Convert.ToDouble(s2[2]));
                        double result3 = vectorC21 * vectorC22;
                        textBox3.Text = $"Результат произведения = {result3}";
                        break;

                    case 3:
                        Vector vectorC31 = new Vector(Convert.ToDouble(s1[0]), Convert.ToDouble(s1[1]), Convert.ToDouble(s1[2]));
                        Vector vectorC32 = new Vector(Convert.ToDouble(s2[0]), Convert.ToDouble(s2[1]), Convert.ToDouble(s2[2]));
                        double result4 = Vector.Cos(vectorC31, vectorC32);
                        textBox3.Text = $"Косинус угла между векторами = {result4}";
                        break;

                    case 4:
                        Vector vectorC41 = new Vector(Convert.ToDouble(s1[0]), Convert.ToDouble(s1[1]), Convert.ToDouble(s1[2]));
                        double result5 = vectorC41.GetLength();
                        textBox3.Text = $"Длина вектора = {result5}";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    public class Vector
    {
        public double X;
        public double Y;
        public double Z;

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector()
        {
          
        }

        public double GetLength()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public static Vector operator +(Vector l, Vector r)
        {
            return new Vector(l.X + r.X, l.Y + r.Y, l.Z + r.Z);
        }

        public static Vector operator -(Vector l, Vector r)
        {
            return new Vector(l.X - r.X, l.Y - r.Y, l.Z - r.Z);
        }

        public static double operator *(Vector l, Vector r)
        {
            return (l.X * r.X + l.Y * r.Y + l.Z * r.Z);
        }

        public static double Cos(Vector l, Vector r)
        {
            return (l * r) / (l.GetLength() * r.GetLength());
        }
    }
}
