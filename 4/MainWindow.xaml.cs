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

namespace _4
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Text1.Clear();
            if (!int.TryParse(NumberA.Text, out int a))
            {
                MessageBox.Show("Введите число!");
            }
            int k = 1;
            while (Pow(k, 2) <= a)
            {
                k++;
            }
            Text1.Text += $"Ответ: {k--}";
        }
        }
}
