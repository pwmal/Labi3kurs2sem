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
    public partial class Form9 : Form
    {
        List<Basa> list1 = new List<Basa>();
        List<Basa2> list2 = new List<Basa2>();
        public Form9()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Окружность", "Треугольник", "Прямоугольник" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Basa temp = new Basa();
                bool a = false;
                for (int i = 0; i < list1.Count; i++)
                {
                    temp = list1[i];
                    if (temp.type == comboBox1.Text && temp.width == Convert.ToDouble(textBox2.Text) && temp.height == Convert.ToDouble(textBox3.Text))
                    {
                        a = true;
                    }
                }
                if (a == false)
                {
                    if (comboBox1.Text == "Окружность" || comboBox1.Text == "Треугольник" || comboBox1.Text == "Прямоугольник")
                    {
                        list1.Add(new Basa(comboBox1.Text, Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text)));
                        listBox1.Items.Add(comboBox1.Text + $":{textBox2.Text};{textBox3.Text}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox2.Enabled = true;
            if (comboBox1.Text == "Окружность")
            {
                textBox2.Text = "0";
                textBox2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null)
                {
                    string[] s = listBox1.SelectedItem.ToString().Split(new char[] {':',';'}, StringSplitOptions.RemoveEmptyEntries);
                    Basa temp = new Basa();
                    foreach (Basa basa in list1)
                    {
                        if (basa.type == s[0] && basa.width == Convert.ToDouble(s[1]) && basa.height == Convert.ToDouble(s[2]))
                        {
                            temp = basa;
                        }
                    }
                    textBox1.Text = $"Тип выбранной фигуры: {temp.type}{Environment.NewLine}Ширина: {temp.width}{Environment.NewLine}Высота: {temp.height}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null)
                {
                    string[] s = listBox1.SelectedItem.ToString().Split(new char[] { ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    Basa temp = new Basa();
                    foreach (Basa basa in list1)
                    {
                        if (basa.type == s[0] && basa.width == Convert.ToDouble(s[1]) && basa.height == Convert.ToDouble(s[2]))
                        {
                            temp = basa;
                        }
                    }
                    textBox1.Text = $"Площадь выбранной фигуры: {Basa.Area(temp)}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null)
                {
                    Basa2 temp = new Basa2();
                    bool a = false;
                    string[] s = listBox1.SelectedItem.ToString().Split(new char[] { ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < list2.Count; i++)
                    {
                        temp = list2[i];
                        if (temp.type == s[0] && temp.width == Convert.ToDouble(s[1]) && temp.height == Convert.ToDouble(s[2]) && temp.name == textBox6.Text && temp.length == Convert.ToDouble(textBox4.Text))
                        {
                            a = true;
                        }
                    }
                    if (a == false)
                    {
                        if (textBox6.Text == "Сфера")
                        {
                            Basa temp2 = new Basa();
                            foreach (Basa basa in list1)
                            {
                                if (basa.type == s[0] && basa.width == Convert.ToDouble(s[1]) && basa.height == Convert.ToDouble(s[2]))
                                {
                                    temp2 = basa;
                                }
                            }
                            list2.Add(new Basa2("Окружность", 0, temp2.height, textBox6.Text, 0));
                            listBox2.Items.Add(textBox6.Text + $":{temp2.width};{temp2.height};0");
                        }
                        if (textBox6.Text == "Пирамида")
                        {
                            Basa temp2 = new Basa();
                            foreach (Basa basa in list1)
                            {
                                if (basa.type == s[0] && basa.width == Convert.ToDouble(s[1]) && basa.height == Convert.ToDouble(s[2]))
                                {
                                    temp2 = basa;
                                }
                            }
                            list2.Add(new Basa2("Треугольник", temp2.width, temp2.height, textBox6.Text, Convert.ToDouble(textBox4.Text)));
                            listBox2.Items.Add(textBox6.Text + $":{temp2.width};{temp2.height};{textBox4.Text}");
                        }
                        if (textBox6.Text == "Параллелепипед")
                        {
                            Basa temp2 = new Basa();
                            foreach (Basa basa in list1)
                            {
                                if (basa.type == s[0] && basa.width == Convert.ToDouble(s[1]) && basa.height == Convert.ToDouble(s[2]))
                                {
                                    temp2 = basa;
                                }
                            }
                            list2.Add(new Basa2("Прямоугольник", temp2.width, temp2.height, textBox6.Text, Convert.ToDouble(textBox4.Text)));
                            listBox2.Items.Add(textBox6.Text + $":{temp2.width};{temp2.height};{textBox4.Text}");
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Enabled = true;
            if (listBox1.SelectedItem.ToString() == "Окружность")
            {
                textBox4.Text = "0";
                textBox4.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null)
                {
                    string[] s = listBox1.SelectedItem.ToString().Split(new char[] { ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    textBox4.Enabled = true;
                    textBox4.Text = "";
                    if (s[0] == "Окружность")
                    {
                        textBox4.Enabled = false;
                        textBox4.Text = "0";
                        textBox6.Text = "Сфера";
                    }
                    if (s[0] == "Треугольник")
                    {
                        textBox6.Text = "Пирамида";
                    }
                    if (s[0] == "Прямоугольник")
                    {
                        textBox6.Text = "Параллелепипед";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox2.SelectedItem != null)
                {
                    string[] s = listBox2.SelectedItem.ToString().Split(new char[] { ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    Basa2 temp = new Basa2();
                    foreach (Basa2 basa2 in list2)
                    {
                        if (basa2.name == s[0] && basa2.width == Convert.ToDouble(s[1]) && basa2.height == Convert.ToDouble(s[2]) && basa2.length == Convert.ToDouble(s[3]))
                        {
                            temp = basa2;
                        }
                    }
                    textBox5.Text = $"Тип выбранной фигуры: {temp.name}{Environment.NewLine}Ширина: {temp.width}{Environment.NewLine}Высота: {temp.height}{Environment.NewLine}Длинна: {temp.length}";
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
                if (listBox2.SelectedItem != null)
                {
                    string[] s = listBox2.SelectedItem.ToString().Split(new char[] { ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
                    Basa2 temp = new Basa2();
                    foreach (Basa2 basa2 in list2)
                    {
                        if (basa2.name == s[0] && basa2.width == Convert.ToDouble(s[1]) && basa2.height == Convert.ToDouble(s[2]) && basa2.length == Convert.ToDouble(s[3]))
                        {
                            temp = basa2;
                        }
                    }
                    textBox5.Text = $"Объем выбранной фигуры: {Environment.NewLine}{Basa2.Volume(temp)}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    public class Basa
    {
        public string type;
        public double width;
        public double height;

        public Basa()
        {

        }

        public Basa(string Type, double Width, double Height)
        {
            type = Type;
            width = Width;
            height = Height;
        }

        public Basa(string Type, double Height)
        {
            type = Type;
            height = Height;
        }

        static public double Area(Basa b)
        {
            double s;
            if(b.type == "Окружность")
            {
                s = Math.PI * Math.Pow(b.height, 2);
                return s;
            }
            else
            if (b.type == "Треугольник")
            {
                s = 0.5 * b.width * b.height;
                return s;
            }
            else
            if (b.type == "Прямоугольник")
            {
                s = b.width * b.height;
                return s;
            }
            else
            {
                return -1;
            }    
        }
    }
    public class Basa2 : Basa
    {
        public string name;
        public double length;

        public Basa2()
        {

        }

        public Basa2(string Type, double Width, double Height, string Name, double Length)
        {
            type = Type;
            width = Width;
            height = Height;
            name = Name;
            length = Length;
        }

        static public double Volume(Basa2 b)
        {
            if(b.type == "Прямоугольник")
            {
                double v = b.length * b.width * b.height;
                return v;
            }
            else
            if (b.type == "Треугольник")
            {
                double v = (1.0/3.0) * (b.length * b.width * b.height);
                return v;
            }
            else
            if (b.type == "Окружность")
            {
                double v = (4.0 / 3.0) * (Math.PI * Math.Pow(b.height,3));
                return v;
            }
            else
            {
                return -1;
            }    
        }
    }
}
