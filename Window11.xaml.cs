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
    /// Interaction logic for Window11.xaml
    /// </summary>
    public partial class Window11 : Window
    {
        string Name;
        public Window11(string name)
        {
            Name = name;
            InitializeComponent();
        }
        private void Data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Btnupdate_Click_ketab(object sender, RoutedEventArgs e)
        {

            String strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30";
            var select = "SELECT * FROM Book";
            var c = new SqlConnection(strConnection);
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);

            data.ItemsSource = ds.DefaultViewManager;
            c.Close(); dataAdapter.Dispose();
        }

        private void Btnupdate_Click_BooksofMembers(object sender, RoutedEventArgs e)
        {
            String strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30";
            var select = "SELECT * FROM Borrowed";
            var c = new SqlConnection(strConnection);
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);

            data.ItemsSource = ds.DefaultViewManager;
            c.Close(); dataAdapter.Dispose();
        }

        private void Btnupdate_Click_booksofLibrary(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void data_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
