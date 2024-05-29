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

namespace Zadaca_IV
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void bos_Click(object sender, RoutedEventArgs e)
        {
            Window bos = new Window2();
            this.Close();
            bos.Show();
        }

        private void mat_Click(object sender, RoutedEventArgs e)
        {
            Window mat = new Window3();
            this.Close();
            mat.Show();
        }

        private void geo_Click(object sender, RoutedEventArgs e)
        {
            Window geo = new Window4();
            this.Close();
            geo.Show();
        }

        private void sport_Click(object sender, RoutedEventArgs e)
        {
            Window sport = new Window6();
            this.Close();
            sport.Show();
        }
    }
}
