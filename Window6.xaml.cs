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
    /// Interaction logic for Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        public Window6()
        {
            InitializeComponent();
        }
        string[] pitanja = new string[16] {"Lebron James","Stephen Curry","Nikola Jokić","Džanan Musa","Lionel Messi",
            "Cristiano Ronaldo","Edin Džeko","Zlatan Ibrahimović","Luka Modrić","Nikola Karabatić","Mikkel Hansen",
            "Sander Sagosen","Roger Federer","Rafael Nadal","Serena Williams","Novak Đoković"};
        Boolean p1=false, p2=false, p3=false, p4=false;
        int k=0;
        int z1, z2, z3, z4;

        private void prov_Click(object sender, RoutedEventArgs e)
        {
            double tp=0,rez;
            if (a0 <= 3 && reza.Text == "K")
                p1 = true;
            else if (a0 > 3 && a0 <= 8 && reza.Text == "N")
                p1 = true;
            else if (a0 > 8 && a0 <= 11 && reza.Text == "R")
                p1 = true;
            else if (a0 > 11 && reza.Text == "T")
                p1 = true;

            if (b0 <= 3 && rezb.Text == "K")
                p2 = true;
            else if (b0 > 3 && b0 <= 8 && rezb.Text == "N")
                p2 = true;
            else if (b0 > 8 && b0 <= 11 && rezb.Text == "R")
                p2 = true;
            else if (b0 > 11 && rezb.Text == "T")
                p2 = true;

            if (c0 <= 3 && rezc.Text == "K")
                p3 = true;
            else if (c0 > 3 && c0 <= 8 && rezc.Text == "N")
                p3 = true;
            else if (c0 > 8 && c0 <= 11 && rezc.Text == "R")
                p3 = true;
            else if (c0 > 11 && rezc.Text == "T")
                p3 = true;

            if (d0 <= 3 && rezd.Text == "K")
                p4 = true;
            else if (d0 > 3 && d0 <= 8 && rezd.Text == "N")
                p4 = true;
            else if (d0 > 8 && d0 <= 11 && rezd.Text == "R")
                p4 = true;
            else if (d0 > 11 && rezd.Text == "T")
                p4 = true;

            if (p1 == false)
                reza.Background = Brushes.Red;
            else
                tp++;
            if (p2 == false)
                rezb.Background = Brushes.Red;
            else
                tp++;
            if (p3 == false)
                rezc.Background = Brushes.Red;
            else
                tp++;
            if (p4 == false)
                rezd.Background = Brushes.Red;
            else
                tp++;
            rez = tp / 4 * 100;
            rezultat.Text = "Vaš procenat tačnosti je " + rez + "%";
            prov.Visibility = Visibility.Hidden;
            rezultat.Visibility = Visibility.Visible;
            pocetna.Visibility = Visibility.Visible;
        }

        private void pocetna_Click(object sender, RoutedEventArgs e)
        {
            Window pocetak = new MainWindow();
            this.Close();
            pocetak.Show();
        }

        private void tenis_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;
            DataObject dataObject = new DataObject(tb.Text);
            DragDrop.DoDragDrop(tb, dataObject, DragDropEffects.Move);
        }

        private void ruk_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;
            DataObject dataObject = new DataObject(tb.Text);
            DragDrop.DoDragDrop(tb, dataObject, DragDropEffects.Move);
        }

        private void nog_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;
            DataObject dataObject = new DataObject(tb.Text);
            DragDrop.DoDragDrop(tb, dataObject, DragDropEffects.Move);
        }

        private void kos_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;
            DataObject dataObject = new DataObject(tb.Text);
            DragDrop.DoDragDrop(tb, dataObject, DragDropEffects.Move);
        }

        

        int a1, b1, c1, d1,x1,x2,x3,x4,a0,b0,c0,d0;
        private void gen_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            a1 = r.Next(0, 16);
            b1 = r.Next(0, 16);
            while (b1 == a1)
                b1 = r.Next(0, 16);
            c1 = r.Next(0, 16);
            while (c1 == a1 || c1==b1)
                c1 = r.Next(0, 16);
            d1 = r.Next(0, 16);
            while (d1 == a1 || d1==b1 || d1==c1)
                d1 = r.Next(0, 16);
            x1 = r.Next(1, 5);
            if (x1 == 1)
            {
                a.Text = pitanja[a1];
                a0 = a1;
            }
            else if (x1 == 2)
            {
                b.Text = pitanja[a1];
                b0 = a1;
            }
            else if (x1 == 3)
            {
                c.Text = pitanja[a1];
                c0 = a1;
            }
            else if (x1 == 4)
            {
                d.Text = pitanja[a1];
                d0 = a1;
            }
            x2 = r.Next(1, 5);
            while (x2 == x1)
                x2 = r.Next(1, 5);
            if (x2 == 1)
            {
                a.Text = pitanja[b1];
                a0 = b1;
            }
            else if (x2 == 2)
            {
                b.Text = pitanja[b1];
                b0 = b1;
            }
            else if (x2 == 3)
            {
                c.Text = pitanja[b1];
                c0 = b1;
            }
            else if (x2 == 4)
            {
                d.Text = pitanja[b1];
                d0 = b1;
            }
            x3 = r.Next(1, 5);
            while (x3 == x1 || x3==x2)
                x3 = r.Next(1, 5);
            if (x3 == 1)
            {
                a.Text = pitanja[c1];
                a0 = c1;
            }
            else if (x3 == 2)
            {
                b.Text = pitanja[c1];
                b0 = c1;
            }
            else if (x3 == 3)
            {
                c.Text = pitanja[c1];
                c0 = c1;
            }
            else if (x3 == 4)
            {
                d.Text = pitanja[c1];
                d0 = c1;
            }
            x4 = r.Next(1, 5);
            while (x4 == x1 || x4==x2 || x4==x3)
                x4 = r.Next(1, 5);
            if (x4 == 1)
            {
                a.Text = pitanja[d1];
                a0 = d1;
            }
            else if (x4 == 2)
            {
                
                b.Text = pitanja[d1];
                b0 = d1;
                
            }
            else if (x4 == 3)
            {
                c.Text = pitanja[d1];
                c0 = d1;
            }
            else if (x4 == 4)
            {
                d.Text = pitanja[d1];
                d0 = d1;
            }
            gen.Visibility = Visibility.Hidden;
            prov.Visibility = Visibility.Visible;
        }
    }
}
