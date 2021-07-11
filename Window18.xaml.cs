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
    /// Interaction logic for Window18.xaml
    /// </summary>
    public partial class Window18 : Window
    {
        string Nam;
        public Window18(string name)
        {
            Nam = name;
            InitializeComponent();
            Mojudi moj = new Mojudi();
            mojoodikifepool.Text = moj.mojudiMember(Nam).ToString();
        }


        private void Btnupdate_Click_afzayeshemojoodi(object sender, RoutedEventArgs e)
        {
            Window4 win = new Window4("Member", Nam); win.Show(); this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
