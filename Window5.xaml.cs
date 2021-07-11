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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void Button_Click_karmand(object sender, System.EventArgs e)
        {
            Window6 win = new Window6(); this.Hide();
            win.Show();
        }

        private void Button_Click_bankpool(object sender, System.EventArgs e)
        {
            Window8 win = new Window8(); this.Hide();
            win.Show();
        }

        private void Button_Click_book(object sender, System.EventArgs e)
        {
            Window7 win = new Window7(); this.Hide();
            win.Show();
        }
    }
}
