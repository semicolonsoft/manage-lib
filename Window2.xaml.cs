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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        string E;
        public Window2(string sd)
        {
            E = sd;
            InitializeComponent();

        }

        public void Window_Loaded()
        {

        }

        private void Button_Click_vorood(object sender, RoutedEventArgs e)
        {
            string Name;
            if (textbox_password.Text != null && textbox_username.Text != null)
            {
                Name = textbox_username.Text;
                Login S = new Login();


                if (E == "Member")
                {


                    bool D = S.LogMember(textbox_username.Text, textbox_password.Text);
                    if (D == true)
                    {
                        Window15 win = new Window15(Name);
                        win.Show();
                    }
                    else
                    {
                        textbox_password.Text = textbox_username.Text = "Wrong name or password";
                    }
                }


                else if (E == "Admin")
                {
                    bool D = S.LogAdmin(textbox_username.Text, textbox_password.Text);
                    if (D == true)
                    {
                        Window10 win = new Window10(Name);
                        win.Show();
                    }
                    else
                    {
                        textbox_password.Text = textbox_username.Text = "Wrong name or password";
                    }
                }


                else if (E == "Modir")
                {
                    Sabtenam s = new Sabtenam();
                    s.SabtManager("admin", "Admin123");
                    bool D = S.LogManager(textbox_username.Text, textbox_password.Text);
                    if (D == true)
                    {
                        Window5 win = new Window5(); this.Hide();
                        win.Show();
                    }
                    else
                    {
                        textbox_password.Text = textbox_username.Text = "Wrong name or password";
                    }
                }
            }


            else
            {
                textbox_password.Text = textbox_username.Text = "Enter name and pass";
            }
        }

        private void Button_Click_sabtenam(object sender, RoutedEventArgs e)
        {
            if (E != "Admin")
            {
                if (E == "Member")
                {
                    Window3 win = new Window3(E);
                    win.Show(); this.Hide();
                }
                else if (E == "Modir")
                {
                    Window3 win = new Window3(E); this.Hide(); win.Show();
                }
            }

        }
    }
}
