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
    public partial class Form6_2 : Form
    {
        List<Motorcycle> list = new List<Motorcycle>();

        public Form6_2()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { "Yes", "No" });
            list.Add(new Motorcycle("Suzuki", "E-92", 2007, 1200, false));
            list.Add(new Motorcycle("H-D", "B-17", 1980, 800, false));

            foreach (Motorcycle i in list)
            {
                listBox1.Items.Add($"{i.Brand}, {i.Model}, {i.Year}, {i.EngineVolume}, {i.IsSportBike}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                bool contains = false;

                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.SelectedItem != null)
                {
                    foreach (Motorcycle i in list)
                    {
                        if (textBox1.Text == i.Brand && textBox2.Text == i.Model && Convert.ToInt32(textBox3.Text) == i.Year && Convert.ToInt32(textBox4.Text) == i.EngineVolume)
                        {
                            contains = true;
                        }
                    }
                }

                if (contains == false && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && comboBox1.SelectedItem != null)
                {
                    bool type;

                    if (comboBox1.SelectedItem.ToString() == "Yes")
                    {
                        type = true;
                    }
                    else
                    {
                        type = false;
                    }

                    list.Add(new Motorcycle(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), type));

                    listBox1.Items.Clear();
                    foreach (Motorcycle i in list)
                    {
                        listBox1.Items.Add($"{i.Brand}, {i.Model}, {i.Year}, {i.EngineVolume}, {i.IsSportBike}");
                    }
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    comboBox1.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                list.RemoveAt(listBox1.SelectedIndex);

                listBox1.Items.Clear();
                foreach (Motorcycle i in list)
                {
                    listBox1.Items.Add($"{i.Brand}, {i.Model}, {i.Year}, {i.EngineVolume}, {i.IsSportBike}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Motorcycle tmp = new Motorcycle();
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        if (list[i].Year < list[j].Year)
                        {
                            tmp = list[j];
                            list[j] = list[i];
                            list[i] = tmp;
                        }
                    }
                }
                listBox1.Items.Clear();
                foreach (Motorcycle i in list)
                {
                    listBox1.Items.Add($"{i.Brand}, {i.Model}, {i.Year}, {i.EngineVolume}, {i.IsSportBike}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Motorcycle tmp = new Motorcycle();
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        if (list[i].Year > list[j].Year)
                        {
                            tmp = list[j];
                            list[j] = list[i];
                            list[i] = tmp;
                        }
                    }
                }
                listBox1.Items.Clear();
                foreach (Motorcycle i in list)
                {
                    listBox1.Items.Add($"{i.Brand}, {i.Model}, {i.Year}, {i.EngineVolume}, {i.IsSportBike}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class Motorcycle
    {
        // Поля класса
        private string brand;
        private string model;
        private int year;
        private int engineVolume; // В кубических см
        private bool isSportBike;

        // Конструктор класса
        public Motorcycle(string brand, string model, int year, int engineVolume, bool isSportBike)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.engineVolume = engineVolume;
            this.isSportBike = isSportBike;
        }

        public Motorcycle()
        {
           
        }

        // Свойства класса
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int EngineVolume
        {
            get { return engineVolume; }
            set { engineVolume = value; }
        }

        public bool IsSportBike
        {
            get { return isSportBike; }
            set { isSportBike = value; }
        }
    }
}
