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

namespace _23
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string c = "";
            Text3.Clear();
            if (!int.TryParse(NumberA.Text, out int a) || (a < 1 || a > 31))
            {
                MessageBox.Show("Введите  число от 1-31");
            }
            if (!int.TryParse(NumberB.Text, out int b) || (b < 1 || b > 12))
            {
                MessageBox.Show("Введите  число от 1-12");
            }
            a = a - 1;
            if (a == 0)
            {
                b = b - 1;
            }
            if (b == 0)
            {
                b = 12;
            }
            switch (b)
            {
                case 1: a = 31; c = "Январь"; break;
                case 2: a = 28; c = "Февраль"; break;
                case 3: a = 31; c = "Март"; break;
                case 4: a = 30; c = "Апрель"; break;
                case 5: a = 31; c = "Май"; break;
                case 6: a = 30; c = "Июнь"; break;
                case 7: a = 31; c = "Июль"; break;
                case 8: a = 31; c = "Август"; break;
                case 9: a = 30; c = "Сентябрь"; break;
                case 10: a = 31; c = "Октябрь"; break;
                case 11: a = 30; c = "Ноябрь"; break;
                case 12: a = 31; c = "Декабрь"; break;
                default: c = "Такого месяца нет"; break;
            }
            Text3.Text += $"Месяц: {c}\nДень: {a}";
        }
        }
}
