using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LIBRARY
{
    /// <summary>
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }

        private void Btnupdate_Click_add(object sender, RoutedEventArgs e)
        {
            Window3 win = new Window3("Modir"); this.Hide();
            win.Show();
        }

        private void Btnupdate_Click_hoghoogh(object sender, RoutedEventArgs e)
        {
            Mojudi moj = new Mojudi();
            moj.PardakhtHoghugh();
        }

        private void Btndelete_Click_delete(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            String strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30";
            var select = "SELECT * FROM Admin";
            var c = new SqlConnection(strConnection); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);

            datagrid_datakarmand.ItemsSource = ds.DefaultViewManager;
            c.Close(); dataAdapter.Dispose();
        }
    }
}
