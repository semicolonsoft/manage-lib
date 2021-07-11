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
    /// Interaction logic for Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        public Window9()
        {
            InitializeComponent();
        }



        private void Btn_Click_add(object sender, RoutedEventArgs e)
        {
            Addbook a = new Addbook();
            if (text_genre_book != null && text_namebook != null && name_author != null)
                a.AddBook(text_namebook.Text, name_author.Text, text_genre_book.Text);
            else
            {
                text_namebook.Text = "No Entry";
            }
            Window7 win = new Window7(); this.Hide();
            win.Show();
        }

        private void Label_DragEnter(object sender, DragEventArgs e)
        {
            Window5 win = new Window5(); this.Hide(); win.Show();
        }
    }
}
