﻿using System;
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

namespace _6
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
            if (!int.TryParse(NumberA.Text, out int a))
            {
                MessageBox.Show("Введите число!");
            }

            while (a > 0 && a % 10 != 7)
            {
                a /= 10;
            }
            if (a > 0 && a % 10 == 7)
            {
                Text1.Text += "true";
            }
            else
            {
                Text1.Text += "false";
            }
        }
        }    
}
