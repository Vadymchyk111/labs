﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LR8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string path = @"C:\Users\Vadym\Desktop\Lab8.txt";

        public void Write()
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine($"TextBox1.Text = {textBox1.Text}");
                sw.WriteLine($"CheckBox1.Checked = {checkBox1.Checked}");
                sw.WriteLine($"CheckBox2.Checked = {checkBox2.Checked}");
                sw.WriteLine($"Form1.Width = {this.Size.Width}");
                sw.WriteLine($"Form1.Height = {this.Size.Height}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Write();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Write();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Write();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Write();
        }
    }
}
