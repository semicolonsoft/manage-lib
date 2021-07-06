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
    /// Interaction logic for Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
        }

        private void Btnupdate_Click(object sender, RoutedEventArgs e)
        {
            Window4 a = new Window4();
            a.Show();
            this.Hide();
        }

        private void Text_mojoodi_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Text_mablagh_afzayesh_mojoodi_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Btnupdate_Click_pardakht(object sender, RoutedEventArgs e)
        {

        }

        private void Datagrid_SelectionChanged_variz(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
