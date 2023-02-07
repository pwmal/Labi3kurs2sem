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
    public partial class Form4 : Form
    {
        List<Button> list = new List<Button>();
        List<TextBox> list2 = new List<TextBox>();
        List<Label> list3 = new List<Label>();
        List<MaskedTextBox> list4 = new List<MaskedTextBox>();
        List<CheckBox> list5 = new List<CheckBox>();
        public Form4()
        {
            InitializeComponent();
            panel1.BackColor = Color.Aqua;
            comboBox1.Items.AddRange(new string[] { "Button", "TextBox", "Label", "MaskedTextBox", "CheckBox" });
        }
        Random random = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            try 
            { 
                int k = random.Next(1,6);
                switch (k)
                {
                    case 1:
                        list.Add(new Button());
                        list[list.Count - 1].BackColor = Color.Purple;
                        list[list.Count - 1].Text = $"№{list.Count}";
                        list[list.Count - 1].Parent = this;
                        list[list.Count - 1].Location = new Point(random.Next(50, 400), random.Next(100, 520));
                        if (random.Next(0, 100) > 50)
                        {
                            panel1.Controls.Add(list[list.Count - 1]);
                        }
                        break;

                    case 2:
                        list2.Add(new TextBox());
                        list2[list2.Count - 1].BackColor = Color.Lime;
                        list2[list2.Count - 1].Text = $"№{list2.Count}";
                        list2[list2.Count - 1].Parent = this;
                        list2[list2.Count - 1].Location = new Point(random.Next(50, 400), random.Next(100, 520));
                        if (random.Next(0, 100) > 50)
                        {
                            panel1.Controls.Add(list2[list2.Count - 1]);
                        }
                        break;

                    case 3:
                        list3.Add(new Label());
                        list3[list3.Count - 1].BackColor = Color.Green;
                        list3[list3.Count - 1].Text = $"№{list3.Count}";
                        list3[list3.Count - 1].Parent = this;
                        list3[list3.Count - 1].Location = new Point(random.Next(50, 400), random.Next(100, 520));
                        if (random.Next(0, 100) > 50)
                        {
                            panel1.Controls.Add(list3[list3.Count - 1]);
                        }
                        break;

                    case 4:
                        list4.Add(new MaskedTextBox());
                        list4[list4.Count - 1].BackColor = Color.Red;
                        list4[list4.Count - 1].Text = $"№{list4.Count}";
                        list4[list4.Count - 1].Parent = this;
                        list4[list4.Count - 1].Location = new Point(random.Next(50, 400), random.Next(100, 520));
                        if (random.Next(0, 100) > 50)
                        {
                            panel1.Controls.Add(list4[list4.Count - 1]);
                        }
                        break;

                    case 5:
                        list5.Add(new CheckBox());
                        list5[list5.Count - 1].BackColor = Color.Pink;
                        list5[list5.Count - 1].Text = $"№{list5.Count}";
                        list5[list5.Count - 1].Parent = this;
                        list5[list5.Count - 1].Location = new Point(random.Next(50, 400), random.Next(100, 520));
                        if (random.Next(0, 100) > 50)
                        {
                            panel1.Controls.Add(list5[list5.Count - 1]);
                        }
                        break;
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
                switch (comboBox1.Text)
                {
                    case "Button":
                        textBox1.Text = $"Количество элементов типа {comboBox1.Text} = {list.Count}(Purple)";
                        break;

                    case "TextBox":
                        textBox1.Text = $"Количество элементов типа {comboBox1.Text} = {list2.Count}(Lime)";
                        break;

                    case "Label":
                        textBox1.Text = $"Количество элементов типа {comboBox1.Text} = {list3.Count}(Green)";
                        break;

                    case "MaskedTextBox":
                        textBox1.Text = $"Количество элементов типа {comboBox1.Text} = {list4.Count}(Red)";
                        break;

                    case "CheckBox":
                        textBox1.Text = $"Количество элементов типа {comboBox1.Text} = {list5.Count}(Pink)";
                        break;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
