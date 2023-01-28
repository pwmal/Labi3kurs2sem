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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Visible)
                button1.Visible = false;
            else
                button1.Visible = true;
            if (button2.Visible)
                button2.Visible = false;
            else
                button2.Visible = true;
            if (button4.Visible)
                button4.Visible = false;
            else
                button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Visible)
                button1.Visible = false;
            else
                button1.Visible = true;
            if (button2.Visible)
                button2.Visible = false;
            else
                button2.Visible = true;
            if (button3.Visible)
                button3.Visible = false;
            else
                button3.Visible = true;
            if (button5.Visible)
                button5.Visible = false;
            else
                button5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button2.Visible)
                button2.Visible = false;
            else
                button2.Visible = true;
            if (button3.Visible)
                button3.Visible = false;
            else
                button3.Visible = true;
            if (button6.Visible)
                button6.Visible = false;
            else
                button6.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (button1.Visible)
                button1.Visible = false;
            else
                button1.Visible = true;
            if (button4.Visible)
                button4.Visible = false;
            else
                button4.Visible = true;
            if (button5.Visible)
                button5.Visible = false;
            else
                button5.Visible = true;
            if (button7.Visible)
                button7.Visible = false;
            else
                button7.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            if (!button1.Visible && !button2.Visible && !button3.Visible && !button4.Visible && !button6.Visible && !button7.Visible && !button8.Visible && !button9.Visible)
            {
                button5.Visible = false;
            }
            else
            {
                if (button2.Visible)
                    button2.Visible = false;
                else
                    button2.Visible = true;
                if (button4.Visible)
                    button4.Visible = false;
                else
                    button4.Visible = true;
                if (button5.Visible)
                    button5.Visible = false;
                else
                    button5.Visible = true;
                if (button6.Visible)
                    button6.Visible = false;
                else
                    button6.Visible = true;
                if (button8.Visible)
                    button8.Visible = false;
                else
                    button8.Visible = true;
            }
            if (!button1.Visible && !button2.Visible && !button3.Visible && !button4.Visible && !button5.Visible && !button6.Visible && !button7.Visible && !button8.Visible && !button9.Visible)
            {
                pictureBox1.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button3.Visible)
                button3.Visible = false;
            else
                button3.Visible = true;
            if (button5.Visible)
                button5.Visible = false;
            else
                button5.Visible = true;
            if (button6.Visible)
                button6.Visible = false;
            else
                button6.Visible = true;
            if (button9.Visible)
                button9.Visible = false;
            else
                button9.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button4.Visible)
                button4.Visible = false;
            else
                button4.Visible = true;
            if (button7.Visible)
                button7.Visible = false;
            else
                button7.Visible = true;
            if (button8.Visible)
                button8.Visible = false;
            else
                button8.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button5.Visible)
                button5.Visible = false;
            else
                button5.Visible = true;
            if (button7.Visible)
                button7.Visible = false;
            else
                button7.Visible = true;
            if (button8.Visible)
                button8.Visible = false;
            else
                button8.Visible = true;
            if (button9.Visible)
                button9.Visible = false;
            else
                button9.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button6.Visible)
                button6.Visible = false;
            else
                button6.Visible = true;
            if (button8.Visible)
                button8.Visible = false;
            else
                button8.Visible = true;
            if (button9.Visible)
                button9.Visible = false;
            else
                button9.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }
    }
}
