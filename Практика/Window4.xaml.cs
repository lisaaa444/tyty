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

namespace Практика
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window8 window8 = new Window8();
            window8.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window11 window11 = new Window11();
            window11.Show();
            this.Hide();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window14 window14 = new Window14();
            window14.Show();
            this.Hide();
        }
    }
}
