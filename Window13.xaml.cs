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
    /// Interaction logic for Window13.xaml
    /// </summary>
    public partial class Window13 : Window
    {
        string name;
        public Window13(string n)
        {
            name = n;
            InitializeComponent();
        }

        private void Btnupdate_Click_kifepool(object sender, RoutedEventArgs e)
        {
            Mojudi m = new Mojudi();
            text_mojoodi = new TextBox();
            text_mojoodi.Text = m.MojudiKarmand(name).ToString();
        }

        private void Label_DragEnter(object sender, DragEventArgs e)
        {
            Window10 win = new Window10(name); this.Hide();
            win.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
