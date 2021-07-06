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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            this.Close();
            Window2 a = new Window2();
            a.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window4 d = new Window4();
            d.Show();
        }

        private void Button_name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Telephon_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_email(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1_password(object sender, TextChangedEventArgs e)
        {

        }

        private void Datagrid_Data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_pardakht(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_hazf(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_edit(object sender, RoutedEventArgs e)
        {

        }

        private void button_Click_add(object sender, RoutedEventArgs e)
        {

        }
    }
}
