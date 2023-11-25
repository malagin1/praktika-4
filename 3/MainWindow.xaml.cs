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
using static System.Math;

namespace _3
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Text3.Clear();
            double x = 0, r = 0, d = 0, l = 0, s = 0;
            if (!double.TryParse(NumberA.Text, out double a))
            {
                MessageBox.Show("Введите число!");
            }
            if (!double.TryParse(NumberB.Text, out double b))
            {
                MessageBox.Show("Введите число!");
            }
            switch (a)
            {
                case 1:
                    r = b;
                    d = 2 * r;
                    l = 2 * 3.14 * r;
                    s = 3.14 * Sqrt(r);
                    Text3.Text += $"{d:f2}\n{l:f2}\n{s:f2}\n";
                    break;
                case 2:
                    r = b / 2;
                    d = b;
                    l = 2 * 3.14 * r;
                    s = 3.14 * Sqrt(r);
                    Text3.Text += $"{d:f2}\n{l:f2}\n{s:f2}\n";
                    break;
                case 3:
                    r = b / 2 * 3.14;
                    d = 2 * r;
                    l = b;
                    s = 3.14 * Sqrt(r);
                    Text3.Text += $"{d:f2}\n{l:f2}\n{s:f2}\n";
                    break;
                case 4:
                    r = Sqrt(b / 3.14);
                    d = 2 * r;
                    l = 2 * 3.14 * r;
                    s = b;
                    Text3.Text += $"{d:f2}\n{l:f2}\n{s:f2}\n";
                    break;
            }
        }
    }
}