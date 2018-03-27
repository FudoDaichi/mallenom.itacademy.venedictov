using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Venediktov.Framework;

namespace practice.linq
{
    /// <summary>/// </summary>
    public partial class MyForm : Form
    {
        List<int> list;
        Random random;
        int sum = 0;
        long mul = 1;
        /// <summary>/// </summary>
        public MyForm()
        {
            InitializeComponent();
            this.Font = SystemFonts.MessageBoxFont;
            button1.Image = Image.FromFile("..\\..\\..\\image\\1.png");
            
        }
        /// <summary>/// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            MinimumSize = Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            random = new Random();
            list = new List<int>(Convert.ToInt32(numericUpDown1.Value));
            for(int i = 0;i< list.Capacity; i++)
            {
                list.Add(random.Next(list.Capacity));

            }
            listBox1.Items.Clear();
            foreach(int i in list)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count > 0)
            {
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                sum = 0;
                mul = 1;
                foreach (int i in new LinqConv().Convert(list))
                {
                    listBox2.Items.Add(i);
                    mul *= i;
                    sum += i;
                }
                foreach (int i in new MyConv().Convert(list))
                {
                    listBox3.Items.Add(i);
                    mul *= i;
                    sum += i;
                }
                MessageBox.Show("Сумма чисел = " + sum + "\nПроизведение чисел = " + mul);
            }
        }
    }
}
