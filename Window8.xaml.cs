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
    /// Interaction logic for Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            text_mojoodi = new TextBox();
            text_mojoodi.Text = "E";
            Mojudi moj = new Mojudi();
            text_mojoodi.Text = moj.mojudiBank();
            InitializeComponent();
        }


        private void Btnupdate_Click_pardakht(object sender, System.EventArgs e)
        {
            Window4 a = new Window4("Modir", "nope"); this.Hide();
            a.Show();
        }

        private void datagrid_variz_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
