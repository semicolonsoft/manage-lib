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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        string noe, nam;
        public Window4(string s, string Name)
        {
            nam = Name; noe = s;
            InitializeComponent();
        }

        public void Window_Loaded()
        {

        }

        private void Button_Click_pardakht(object sender, RoutedEventArgs e)
        {
            if (text_cvv.Text != null && text_hazine.Text != null && text_shomarekart.Text != null && text_cvv.Text != null)
            {
                Mojudi m = new Mojudi();
                if (noe == "Member")
                {

                    //Problem

                    bool d = m.AfzayeshMojudiMember(Name, text_shomarekart.Text, text_cvv.Text, int.Parse(text_tarikh.Text), int.Parse(text_tarikh2.Text), int.Parse(text_hazine.Text));//
                    if (d == true)
                    {
                        text_hazine.Text = "Anjam Shod";
                        Window3 win = new Window3(Name); this.Hide();
                        win.Show();
                    }
                    else
                    {
                        text_hazine.Text = "namovafagh";
                        Window3 win = new Window3(Name);
                        win.Show();
                    }
                }
                else if (noe == "Modir")
                {
                    bool d = m.AfzayeshMojudiBank(text_shomarekart.Text, text_cvv.Text, int.Parse(text_tarikh.Text), int.Parse(text_tarikh2.Text), int.Parse(text_hazine.Text));
                    if (d == true)
                    {
                        text_hazine.Text = "Done";
                        Window5 win = new Window5();
                        win.Show();
                    }
                    else
                    {
                        text_hazine.Text = "Namovafagh";
                        Window5 win = new Window5();
                        win.Show();
                    }
                }
            }
        }
    }
}
