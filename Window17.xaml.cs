using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for Window17.xaml
    /// </summary>
    public partial class Window17 : Window
    {
        string Name;
        public Window17(string name)
        {
            Name = name;
            InitializeComponent();

        }

        private void Btnupdate_Click_passdadaneketab(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            String strConnection = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = E:\manage - lib - sql(1)\manage - lib - sql\manage - lib.mdf; Integrated Security = True; Connect Timeout = 30";
            var select = "SELECT * FROM Book where namef=" + Name;
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
