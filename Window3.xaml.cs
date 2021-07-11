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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        string noe;
        public Window3(string n)
        {
            noe = n;
            InitializeComponent();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {

            Window1 a = new Window1();
            a.Show();
        }

        public void Window_Loaded()
        {

        }


        private void Button_Click_pardakht(object sender, RoutedEventArgs e)
        {
            Window4 win = new Window4("Member", Name); this.Hide();
            win.Show();
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

        private void datagrid_Data_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Database\manage-lib.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from Admin";
            var dataAdapter = new SqlDataAdapter(query, con);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);

            datagrid_Data.ItemsSource = ds.DefaultViewManager;
            con.Close(); dataAdapter.Dispose();
        }
    }
}
