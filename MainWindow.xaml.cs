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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LIBRARY
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        System.Windows.Threading.DispatcherTimer timer2 = new System.Windows.Threading.DispatcherTimer();
        void timer2_a(object sender, EventArgs e)
        {
            progressBar.Value += 10;
            if (progressBar.Value == 100)
            {
                timer2.Stop();
                new Window2().ShowDialog();
                this.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer2.Interval = TimeSpan.FromMilliseconds(1000);
            timer2.Tick += new EventHandler(timer2_a);
            timer2.Start();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            timer2.Interval = TimeSpan.FromMilliseconds(1000);
            timer2.Tick += new EventHandler(timer2_a);
            timer2.Start();
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
