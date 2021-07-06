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
    /// Interaction logic for Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
        }

        private void Btnupdate_Click_add(object sender, RoutedEventArgs e)
        {
            Window9 a = new Window9();
            a.Show();
            this.Hide();
        }

        private void Datagrid_DataBook_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
