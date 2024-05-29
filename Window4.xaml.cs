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
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }
        string[,] pitanja = new string[16, 2] { { "Argentina","Buenos Aires" }, { "Brazil", "Brasilia" }, { "Bugarska", "Sofija" }, { "Kipar","Nikozija" },
            { "Danska", "Kopenhagen" },{"Finska","Helsinki" }, {"Njemačka","Berlin"}, {"Mađarska","Budimpešta"}, {"Italija","Rim"},
            {"Azerbejdžan","Baku"},{"Bjelorusija","Minsk"},{"Indija","New Delhi"},{"Indonezija","Jakarta"},{"Irak","Bagdad"},{"Japan","Tokio"},{"Sjeverna Koreja","Pjongjang"}};
        int a0;
        int b0;
        int c0;
        int d0;

        private void gen_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            int t1, t2, t3, t4;
            t1 = r.Next(0, 16);
            t2 = r.Next(0, 16);
            while (t2 == t1)
                t2 = r.Next(0, 16);
            t3 = r.Next(0, 16);
            while (t3 == t1 || t3 == t2)
                t3 = r.Next(0, 16);
            t4 = r.Next(0, 16);
            while (t4 == t1 || t4 == t2 || t4 == t3)
                t4 = r.Next(0, 16);
            int z1, z2, z3, z4;
            z1 = r.Next(1, 5);
            z2 = r.Next(1, 5);
            while (z2 == z1)
                z2 = r.Next(1, 5);
            z3 = r.Next(1, 5);
            while (z3 == z1 || z3 == z2)
                z3 = r.Next(1, 5);
            z4 = r.Next(1, 5);
            while (z4 == z1 || z4 == z2 || z4 == z3)
                z4 = r.Next(1, 5);
            jedan.Text = pitanja[t1, 0];
            tri.Text = pitanja[t2, 0];
            pet.Text = pitanja[t3, 0];
            sedam.Text = pitanja[t4, 0];
            if (z1 == 1)
                dva.Text = pitanja[t1, 1];
            else if (z1 == 2)
                cetiri.Text = pitanja[t1, 1];
            else if (z1 == 3)
                sest.Text = pitanja[t1, 1];
            else if (z1 == 4)
                osam.Text = pitanja[t1, 1];
            if (z2 == 1)
                dva.Text = pitanja[t2, 1];
            else if (z2 == 2)
                cetiri.Text = pitanja[t2, 1];
            else if (z2 == 3)
                sest.Text = pitanja[t2, 1];
            else if (z2 == 4)
                osam.Text = pitanja[t2, 1];
            if (z3 == 1)
                dva.Text = pitanja[t3, 1];
            else if (z3 == 2)
                cetiri.Text = pitanja[t3, 1];
            else if (z3 == 3)
                sest.Text = pitanja[t3, 1];
            else if (z3 == 4)
                osam.Text = pitanja[t3, 1];
            if (z4 == 1)
                dva.Text = pitanja[t4, 1];
            else if (z4 == 2)
                cetiri.Text = pitanja[t4, 1];
            else if (z4 == 3)
                sest.Text = pitanja[t4, 1];
            else if (z4 == 4)
                osam.Text = pitanja[t4, 1];
            prov.Visibility = Visibility.Visible;
            gen.Visibility = Visibility.Hidden;
            a0 = z1;
            b0 = z2;
            c0 = z3;
            d0 = z4;
        }
        double tp = 0,rez;
        private void prov_Click(object sender, RoutedEventArgs e)
        {
            if (a1 == a0)
                tp++;
            if (b1 == b0)
                tp++;
            if (c1 == c0)
                tp++;
            if (d1 == d0)
                tp++;
            rez = tp / 4 * 100;
            rezultat.Text = "Vaš procenat tačnosti je " + rez + "%";
            rezultat.Visibility = Visibility.Visible;
            prov.Visibility = Visibility.Hidden;
            pocetna.Visibility = Visibility.Visible;
        }
        int i = 0,p1=0,p2=0,p3=0,p4=0,a1,b1,c1,d1;
        private void jedan_MouseEnter(object sender, MouseEventArgs e)
        {
            jedan.Foreground = Brushes.Blue;
        }

        private void jedan_MouseLeave(object sender, MouseEventArgs e)
        {
            if(p1==0)
            jedan.Foreground = Brushes.Black;
        }
        private void jedan_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            jedan.Foreground = Brushes.Blue;
            i = 1;
            p1 = 1;
        }

        private void tri_MouseEnter(object sender, MouseEventArgs e)
        {
            tri.Foreground = Brushes.Red;
        }

        private void tri_MouseLeave(object sender, MouseEventArgs e)
        {
            if(p2==0)
            tri.Foreground = Brushes.Black;
        }

        private void tri_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tri.Foreground = Brushes.Red;
            i = 2;
            p2 = 1;
        }

        private void pet_MouseEnter(object sender, MouseEventArgs e)
        {
            pet.Foreground = Brushes.Orange;
        }

        private void pocetna_Click(object sender, RoutedEventArgs e)
        {
            Window pocetak = new MainWindow();
            this.Close();
            pocetak.Show();
        }

        private void pet_MouseLeave(object sender, MouseEventArgs e)
        {
            if(p3==0)
            pet.Foreground = Brushes.Black;
        }

        private void dva_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (i == 1)
            {
                dva.Foreground = Brushes.Blue;
                a1 = 1;
            }
            else if (i == 2)
            {
                dva.Foreground = Brushes.Red;
                b1 = 1;
            }
            else if (i == 3)
            {
                dva.Foreground = Brushes.Orange;
                c1 = 1;
            }
            else if (i == 4)
            {
                dva.Foreground = Brushes.Purple;
                d1 = 1;
            }
        }

        private void cetiri_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (i == 1)
            {
                cetiri.Foreground = Brushes.Blue;
                a1 = 2;
            }
            else if (i == 2)
            {
                cetiri.Foreground = Brushes.Red;
                b1 = 2;
            }
            else if (i == 3)
            {
                cetiri.Foreground = Brushes.Orange;
                c1 = 2;
            }
            else if (i == 4)
            {
                cetiri.Foreground = Brushes.Purple;
                d1 = 2;
            }
        }

        private void sest_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (i == 1)
            {
                sest.Foreground = Brushes.Blue;
                a1 = 3;
            }
            else if (i == 2)
            {
                sest.Foreground = Brushes.Red;
                b1 = 3;
            }
            else if (i == 3)
            {
                sest.Foreground = Brushes.Orange;
                c1 = 3;
            }
            else if (i == 4)
            {
                sest.Foreground = Brushes.Purple;
                d1 = 3;
            }
        }

        private void osam_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (i == 1)
            {
                osam.Foreground = Brushes.Blue;
                a1 = 4;
            }
            else if (i == 2)
            {
                osam.Foreground = Brushes.Red;
                b1 = 4;
            }
            else if (i == 3)
            {
                osam.Foreground = Brushes.Orange;
                c1 = 4;
            }
            else if (i == 4)
            {
                osam.Foreground = Brushes.Purple;
                d1 = 4;
            }
        }

        private void pet_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            pet.Foreground = Brushes.Orange;
            i = 3;
            p3 = 1;
        }

        private void sedam_MouseEnter(object sender, MouseEventArgs e)
        {
            sedam.Foreground = Brushes.Purple;
        }

        private void sedam_MouseLeave(object sender, MouseEventArgs e)
        {
            if(p4==0)
            sedam.Foreground = Brushes.Black;
        }

        private void sedam_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            sedam.Foreground = Brushes.Purple;
            i = 4;
            p4 = 1;
        }
    }
}
