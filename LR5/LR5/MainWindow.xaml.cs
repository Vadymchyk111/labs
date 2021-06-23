using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LR5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public int item = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            СomboBox.Items.Add(TextBox.Text);
            TextBox.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            СomboBox.Items.RemoveAt(СomboBox.Items.Count - 1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (item == Convert.ToInt32((sender as Button).Content) - 1)
            {
                (sender as Button).Visibility = Visibility.Hidden;
                item = Convert.ToInt32((sender as Button).Content);
            }
            else
            {
                IEnumerable<Button> collection = TabPage2.Children.OfType<Button>();
                foreach (Button button in collection)
                {
                    button.Visibility = Visibility.Visible;
                }
                item = 0;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (item == Convert.ToInt32((sender as Button).Content) - 1)
            {
                (sender as Button).Visibility = Visibility.Hidden;
                item = Convert.ToInt32((sender as Button).Content);
            }
            else
            {
                IEnumerable<Button> collection = TabPage2.Children.OfType<Button>();
                foreach (Button button in collection)
                {
                    button.Visibility = Visibility.Visible;
                }
                item = 0;
            }
            if ((sender as Button).Visibility == Visibility.Hidden)
            {
                TextBox2.Text = "Молодець!!!";
            }
        }
    }
}
