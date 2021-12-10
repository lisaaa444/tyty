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
using System.Windows.Shapes;

namespace Практика
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
            Window6 window6 = new Window6();
            window6.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window7 window7 = new Window7();
            window7.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
            this.Hide();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window8 window8 = new Window8();
            window8.Show();
            this.Hide();
        }
    }
}
