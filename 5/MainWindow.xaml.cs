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

namespace _5
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Text1.Clear();
            if (!double.TryParse(NumberA.Text, out double a))
            {
                MessageBox.Show("Введите число!");
            }

            int k = 1;
            double summa = 1000;

            if (0 < a && a <= 25)
            {
                while (summa <= 1100)
                {
                    ++k;
                    summa += summa * a / 100;
                }
            }
            else
            {
                MessageBox.Show("Нужно от 0 до 25");
            }
            Text1.Text += $"{summa:f3}";
        }
        }
}
