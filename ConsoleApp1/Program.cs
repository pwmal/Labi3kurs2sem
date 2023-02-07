using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace WindowsFormsApplication5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Counter.SetBorder(0, 500);
            Counter cn = new Counter(200);
            cn.ShowCount();
            cn.CountUp();
            cn.ShowCount();
            cn = new Counter(800);//выход за пределы
            cn.ShowCount();
            cn.CountDown();
            cn.ShowCount();
            Console.ReadKey();
        }
    }

    class Counter
    {
        private int count;
        private static int i_border, y_borfer;

        public static void SetBorder(int i, int y)
        {
            if (i >= 0 && y > 1)
            {
                i_border = i;
                y_borfer = y;
            }
            else
            {
                i_border = 0;
                y_borfer = 100;
            }
        }
        public Counter()
        {
            count = 125;
        }
        public Counter(int count)
        {
            if (count > i_border && count <= y_borfer)
                this.count = count;

            else this.count = -1;
        }
        private int Count
        {
            get { return count; }
        }

        public void CountDown()
        {
            count--;
        }
        public void CountUp()
        {
            count++;
        }
        public void ShowCount()
        {
            Console.WriteLine("Текущее значение счетчика: " + Convert.ToString(Count, 16));
        }
    }
}