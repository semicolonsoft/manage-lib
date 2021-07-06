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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 x = new Window3();
            x.Show();
        }

        private void Textbox2_TextChanged_password(object sender, TextChangedEventArgs e)
        {

        }

        private void Textbox1_TextChanged_username(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_vorood(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_sabtenam(object sender, RoutedEventArgs e)
        {

        }
    }
}
