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
using System.Windows.Shapes;

namespace простые_программы
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            Window4 w4 = new Window4();
            if(check.IsChecked==true)
            {
                w4.ShowDialog();
                this.Hide();
            }
            else
            {
                w4.Show();
                this.Hide();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window3 w3 = new Window3();
            if (check.IsChecked == true)
            {
                w3.ShowDialog();
                this.Hide();
            }
            else
            {
                w3.Show();
                this.Hide();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            if (check.IsChecked == true)
            {
                w2.ShowDialog();
                this.Hide();
            }
            else
            {
                w2.Show();
                this.Hide();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            навигация n = new навигация();
            n.Show();
            this.Hide();
        }
    }
}
