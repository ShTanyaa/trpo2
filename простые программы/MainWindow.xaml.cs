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

namespace простые_программы
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
        double x1, x2;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
              w1.Show();
              this.Hide();
        }

        private void SolveClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(text1.Text);
                double b = double.Parse(text2.Text);
                double c = double.Parse(text3.Text);

                var D = Math.Pow(b, 2) - 4 * a * c;
                if (D < 0)
                {
                    rez.Content = "корней нет";
                }
                else
                {
                    if (D == 0)
                    {
                        x1 = -b / (2 * a);
                        x2 = x1;
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(D)) / (2 * a);
                        x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    }
                    rez.Content = $"x1={x1};x2={x2}";
                }
            }
            catch
            {
                MessageBox.Show("введены некорректные данные", "Error");
            }
        }
    }
}
