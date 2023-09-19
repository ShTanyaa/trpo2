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
    /// Логика взаимодействия для навигация.xaml
    /// </summary>
    public partial class навигация : Window
    {
        public навигация()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registration r = new Registration();
            r.ShowDialog();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Cats c = new Cats();
            c.ShowDialog();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void GoogleButton_Click(object sender, RoutedEventArgs e)
        {
            Uri google = new Uri("https://google.com");
            MainFrame.Navigate(google);
        }
    }
}
