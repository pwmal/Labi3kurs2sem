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
    public partial class Form6_3 : Form
    {
        public Form6_3()
        {
            InitializeComponent();
        }

        Hashtable hashtable = new Hashtable();

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(keyTextBox.Text) && !string.IsNullOrEmpty(valueTextBox.Text))
            {
                try
                {
                    hashtable.Add(keyTextBox.Text, valueTextBox.Text);
                    keyTextBox.Clear();
                    valueTextBox.Clear();
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Элемент с этим ключом уже существует в хэш-таблице");
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(keyTextBox.Text))
            {
                if (hashtable.ContainsKey(keyTextBox.Text))
                {
                    hashtable.Remove(keyTextBox.Text);
                    keyTextBox.Clear();
                    valueTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Элемента с этим ключом не существует в хэш-таблице");
                }
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(keyTextBox.Text))
            {
                if (hashtable.ContainsKey(keyTextBox.Text))
                {
                    valueTextBox.Text = (string)hashtable[keyTextBox.Text];
                }
                else
                {
                    MessageBox.Show("Элемента с этим ключом не существует в хэш-таблице");
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hashtable.Clear();
            keyTextBox.Clear();
            valueTextBox.Clear();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            if (hashtable.Count > 0)
            {
                string output = "";
                foreach (DictionaryEntry entry in hashtable)
                {
                    output += entry.Key + " = " + entry.Value + "\n";
                }
                MessageBox.Show(output);
            }
            else
            {
                MessageBox.Show("Хэш-таблица пуста");
            }
        }
    }
}
