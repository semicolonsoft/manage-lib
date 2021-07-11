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

namespace LIBRARY
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public void Window_Loaded()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_modir(object sender, RoutedEventArgs e)
        {
            Window2 win = new Window2("Modir"); this.Hide();
            win.Show();
        }

        private void Button_Click_karmand(object sender, RoutedEventArgs e)
        {
            Window2 win = new Window2("Admin"); this.Hide();
            win.Show();
        }

        private void Button_Click_member(object sender, RoutedEventArgs e)
        {
            Window2 win = new Window2("Member");
            win.Show();
        }
    }
}
