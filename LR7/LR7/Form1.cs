using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LR7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Vadim\Desktop\c#";
            for (int i = 0; i < 100; i++)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path + i);
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Vadim\Desktop\c#";
            for (int i = 0; i < 100; i++)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path + i);
                if (dirInfo.Exists)
                {
                    dirInfo.Delete(true);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Vadim\Desktop\";
            for (int i = 0; i < 100; i++)
            {
                if (Convert.ToString(path + @"\Folder_" + i).Length < 248)
                {
                    path += @"\Folder_" + Convert.ToString(i);
                    DirectoryInfo dirInfo = new DirectoryInfo(path);
                    if (!dirInfo.Exists)
                    {
                        dirInfo.Create();
                    }
                }
                else
                {
                    label1.Text = $"Найбільша папка: {path.Substring(path.Length - 9)}";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string path = @"Путь к рабочему столу\Disc";
            string file = textBox1.Text;
            using (FileStream fstream = File.OpenRead($@"{path}\{file}.txt"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                label2.Text = $"Текст з файлу: {textFromFile}";
            }
        }
    }
}
