using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int item = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.RemoveAt(comboBox1.Items.Count - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (item == Convert.ToInt32((sender as Button).Text) - 1)
            {
                (sender as Button).Visible = false;
                item = Convert.ToInt32((sender as Button).Text);
            }
            else
            {
                foreach (Button button in tabPage2.Controls.OfType<Button>())
                {
                    button.Visible = true;
                }
                item = 0;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (item == Convert.ToInt32((sender as Button).Text) - 1)
            {
                (sender as Button).Visible = false;
                item = Convert.ToInt32((sender as Button).Text);
            }
            else
            {
                foreach (Button button in tabPage2.Controls.OfType<Button>())
                {
                    button.Visible = true;
                }
                item = 0;
            }
            if ((sender as Button).Visible == false)
            {
                textBox2.Text = "Молодець!!!";
            }
        }
    }
}
