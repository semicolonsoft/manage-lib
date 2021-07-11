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
    /// Interaction logic for Window14.xaml
    /// </summary>
    public partial class Window14 : Window
    {
        string nam;
        public Window14(string name)
        {
            nam = name;
            InitializeComponent();
        }

        private void Text_name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Text_email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Text_telephon_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Text_password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Btnupdate_Click_edit(object sender, RoutedEventArgs e)
        {
            String strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30";
            var select = "update Admin set name=" + text_name.Text + ", set password=" + text_password.Text + ",set phone=" + text_name.Text + ", set Email=" + text_telephon.Text + "where name=" + nam;
            var c = new SqlConnection(strConnection);
            c.Open(); SqlCommand cm = new SqlCommand(select, c);
            SqlDataAdapter adap = new SqlDataAdapter();
            adap.UpdateCommand = new SqlCommand(select, c); adap.UpdateCommand.ExecuteNonQuery();
            c.Close(); adap.Dispose(); cm.Dispose();
        }

        private void Data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            String strConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30";
            var select = "SELECT * FROM Admin where name=" + nam;
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
