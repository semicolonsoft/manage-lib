using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LIBRARY
{
    /// <summary>
    /// Interaction logic for Window16.xaml
    /// </summary>
    public partial class Window16 : Window
    {
        string Name;
        public Window16(string name)
        {
            Name = name;
            InitializeComponent();
        }

        private void Btnupdate_Click_search(object sender, RoutedEventArgs e)
        {

        }

        private void Btnupdate_Click_amanateketab(object sender, RoutedEventArgs e)
        {

        }

        private void Data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            String strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = E:\manage - lib - sql(1)\manage - lib - sql\manage - lib.mdf; Integrated Security = True; Connect Timeout = 30";
            var select = "SELECT * FROM Book";
            var c = new SqlConnection(strConnection);
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);

            data.ItemsSource = ds.DefaultViewManager;
            c.Close(); dataAdapter.Dispose();
        }
    }
}
