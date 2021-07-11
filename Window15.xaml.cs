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
    /// Interaction logic for Window15.xaml
    /// </summary>
    public partial class Window15 : Window
    {
        string name;
        public Window15(string Nam)
        {
            name = Nam;
            InitializeComponent();
        }

        private void Button_Click_books(object sender, RoutedEventArgs e)
        {
            Window16 win = new Window16(name); win.Show();
        }

        private void Button_Click_Mybooks(object sender, RoutedEventArgs e)
        {
            Window17 win = new Window17(name); this.Hide(); win.Show();
        }

        private void Button_Click_eshterak(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_kifepool(object sender, RoutedEventArgs e)
        {
            Window18 win = new Window18(name); this.Hide();
            win.Show();
        }

        private void Button_Click_EditData(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
