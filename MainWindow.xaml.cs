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
using static System.Windows.Media.Animation.Timeline;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zadaca_IV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            video.Play();
        }
        
        private void video_Ended(object sender, EventArgs e)
        {
            video.Position = TimeSpan.Zero;
            video.Play();
        }

        private void muzika_1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            muzika_1.Visibility = Visibility.Hidden;
            muzika_2.Visibility = Visibility.Visible;
            video.Pause();
        }

        private void tabla_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window Izbornik = new Window1();
            this.Close();
            Izbornik.Show();
        }

        private void muzika_2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            muzika_2.Visibility = Visibility.Hidden;
            muzika_1.Visibility = Visibility.Visible;
            video.Play();
        }

        private void tabla1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window vicevi = new Window8();
            this.Close();
            vicevi.Show();
        }

        private void strvideo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window vidi = new Window9();
            this.Close();
            vidi.Show();
        }

        private void tabla1_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Window tablica = new Window8();
            this.Close();
            tablica.Show();
        }

        private void hehe_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window iz = new Window5();
            this.Close();
            iz.Show();
        }
    }
}
