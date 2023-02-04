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
    public partial class Form8 : Form
    {
        List<Dog> list = new List<Dog>();
        public Form8()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Боксер", "Терьер", "Такса", "Пудель", "Доберман", "Овчарка" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = textBox1.Text;
                bool a = false;
                for(int i = 0; i < listBox1.Items.Count; i++)
                {
                    if(listBox1.Items[i].ToString() == s)
                    {
                        a = true;
                    }
                }
                if(a == false)
                {
                    list.Add(new Dog(textBox1.Text, comboBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));
                    listBox1.Items.Add(textBox1.Text);
                }
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
                if (listBox1.SelectedItem != null)
                {
                    Dog temp = new Dog();
                    foreach (Dog dog in list)
                    {
                        if (dog.name == listBox1.SelectedItem.ToString())
                        {
                            temp = dog;
                        }
                    }
                    textBox4.Text = $"Имя выбранной собаки: {temp.name}{Environment.NewLine}Порода: {temp.breed}{Environment.NewLine}Возраст: {temp.age}{Environment.NewLine}Высота в холке: {temp.withers_height}";
                }
            }
            catch(Exception ex)
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
                    textBox5.Text = $"Собаки, подходящие под описание:";
                    Dog temp = new Dog();
                    foreach (Dog dog in list)
                    {
                        if (dog.breed == "Боксер" && dog.age == 2 && dog.withers_height >= 55)
                        {
                            temp = dog;
                            textBox5.Text += $"{Environment.NewLine}Имя: {temp.name}; Порода: {temp.breed}; Возраст: {temp.age}; Высота в холке: {temp.withers_height}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }

    public class Dog
    {
        public string name { get; set; }
        public string breed { get; set; }
        public int age { get; set; }
        public int withers_height { get; set; }

        public Dog(string Name, string Breed, int Age, int Withers_height)
        {
            name = Name;
            breed = Breed;
            age = Age;
            withers_height = Withers_height;
        }
        public Dog()
        {
            
        }
    }
}
