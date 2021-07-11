using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LIBRARY
{
    /// <summary>
    /// Interaction logic for Window19.xaml
    /// </summary>
    public partial class Window19 : Window
    {
        string Name;
        public Window19(string name)
        {
            Name = name;
            InitializeComponent();
        }

        private void Btnupdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            String strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30";
            var select = "SELECT * FROM Admin where name=" + Name;
            var c = new SqlConnection(strConnection);
            c.Open();
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);

            data.ItemsSource = ds.DefaultViewManager;
            c.Close(); dataAdapter.Dispose();
        }
    }
}
