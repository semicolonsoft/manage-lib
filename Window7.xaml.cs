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
        }


        private void Label_DragLeave(object sender, DragEventArgs e)
        {
            Window5 win = new Window5(); this.Hide();
            win.Show();
        }

        private void datagrid_DataBook_Loaded(object sender, RoutedEventArgs e)
        {
            String strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30";
            var select = "SELECT * FROM tblEmployee";
            var c = new SqlConnection(strConnection);
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);

            datagrid_DataBook.ItemsSource = ds.DefaultViewManager;
            c.Close(); dataAdapter.Dispose();
        }
    }
}
