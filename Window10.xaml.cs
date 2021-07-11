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
    /// Interaction logic for Window10.xaml
    /// </summary>
    public partial class Window10 : Window
    {
        string Name;
        public Window10(string name)
        {
            Name = name;
            InitializeComponent();
        }


        private void Button_Click_books(object sender, RoutedEventArgs e)
        {
            Window11 win = new Window11(Name); win.Show();
        }

        private void Button_Click_members(object sender, RoutedEventArgs e)
        {
            Window12 win = new Window12(Name); win.Show();
        }

        private void Button_Click_editdata(object sender, RoutedEventArgs e)
        {
            Window14 win = new Window14(Name);
        }

        private void Button_Click_kifepool(object sender, RoutedEventArgs e)
        {
            Window13 win = new Window13(Name);
            win.Show();
        }

        private void Label_DragLeave(object sender, DragEventArgs e)
        {
            Window1 win = new Window1(); this.Hide(); win.Show();
        }
    }
}
