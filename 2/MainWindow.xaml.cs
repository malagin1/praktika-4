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

namespace _2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Text2.Clear();
            if (Int32.TryParse(NumberA.Text, out int a))
            {
                switch (a / 10)
                {
                    case 2: Text2.Text = "двадцать"; break;
                    case 3: Text2.Text = "тридцать"; break;
                    case 4: Text2.Text = "сорок"; break;
                    case 5: Text2.Text = "пятьдесят"; break;
                    case 6: Text2.Text = "шестьдесят"; break;
                }
                switch (a % 10)
                {
                    case 1: Text2.Text += " один год"; break;
                    case 2: Text2.Text += " два года"; break;
                    case 3: Text2.Text += " три года"; break;
                    case 4: Text2.Text += " четыре года"; break;
                    case 5: Text2.Text += " пять лет"; break;
                    case 6: Text2.Text += " шесть лет"; break;
                    case 7: Text2.Text += " семь лет"; break;
                    case 8: Text2.Text += " восемь лет"; break;
                    case 9: Text2.Text += " девять лет"; break;
                }
                }
            }
        }   
}
