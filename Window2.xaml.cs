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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        string[,] pitanja = new string[16,2] {{"Miroslav Krleža", "Gospoda Glembajevi" } , { "Hermann Hesse", "Stepski vuk" },{"Albert Camus ","Stranac"},
        {"Ivo Andrić","Prokleta avlija"},{"Meša Selimović","Tvrđava"},{"Henrik Ibsen","Nora"},{"Dostojevski","Zločin i kazna"},{"Tolstoj","Ana Karenjina"},
        {"Borisav Stanković","Nečista krv"},{"Charles Baudelaire","Cvjetovi zla"},{"Radoje Domanović","Vođa"},{"Ante Kovačić","U registraturi"},{"Hamza Humo","Grozdanin Kikot"},
        {"Gogolj","Kabanica"},{"Paulo Coelho","Alhemičar"},{"Miguel de Cervantes","Don Quijote"} };
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
            a0= z1;
            b0= z2;
            c0= z3;
            d0= z4;
        }
        int br=0,a1=0,b1=0,c1=0,d1=0;

        private void pocetna_Click(object sender, RoutedEventArgs e)
        {
            Window pocetna = new MainWindow();
            this.Close();
            pocetna.Show();
        }

        private void window8_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.A)
            {
                switch(br)
                {
                    case 0:
                        a.Background = Brushes.Blue;
                        a1 = 1;
                        break;
                    case 1:
                        a.Background = Brushes.Red;
                        a1 = 2;
                        break;
                    case 2:
                        a.Background = Brushes.Green;
                        a1 = 3;
                        break;
                    case 3:
                        a.Background = Brushes.Yellow;
                        a1 = 4;
                        break;

                }
            }
            else if(e.Key==Key.B)
            {
                switch (br)
                {
                    case 0:
                        b.Background = Brushes.Blue;
                        b1 = 1;
                        break;
                    case 1:
                        b.Background = Brushes.Red;
                        b1 = 2;
                        break;
                    case 2:
                        b.Background = Brushes.Green;
                        b1 = 3;
                        break;
                    case 3:
                        b.Background = Brushes.Yellow;
                        b1 = 4;
                        break;

                }
            }
            else if (e.Key == Key.C)
            {
                switch (br)
                {
                    case 0:
                        c.Background = Brushes.Blue;
                        c1 = 1;
                        break;
                    case 1:
                        c.Background = Brushes.Red;
                        c1 = 2;
                        break;
                    case 2:
                        c.Background = Brushes.Green;
                        c1 = 3;
                        break;
                    case 3:
                        c.Background = Brushes.Yellow;
                        c1 = 4;
                        break;

                }
            }
            else if (e.Key == Key.D)
            {
                switch (br)
                {
                    case 0:
                        d.Background = Brushes.Blue;
                        d1 = 1;
                        break;
                    case 1:
                        d.Background = Brushes.Red;
                        d1 = 2;
                        break;
                    case 2:
                        d.Background = Brushes.Green;
                        d1 = 3;
                        break;
                    case 3:
                        d.Background = Brushes.Yellow;
                        d1 = 4;
                        break;

                }
            }
            if (br == 3)
                br = 0;
            else
                br++;
        }

        private void prov_Click(object sender, RoutedEventArgs e)
        {
            double rez,tp=0;
            if(a0==1)
            {
                if (a1==1)
                {
                    tp++;
                    jedan.Background = Brushes.Green;
                    dva.Background = Brushes.Green;
                }
                else
                {
                    jedan.Background = Brushes.Red;
                    dva.Background = Brushes.Red;
                }
            }
            else if (a0== 2)
            {
                if (b1==1)
                {
                    tp++;
                    jedan.Background = Brushes.Green;
                    cetiri.Background = Brushes.Green;
                }
                else
                {
                    jedan.Background = Brushes.Red;
                    cetiri.Background = Brushes.Red;
                }
            }
            else if (a0==3)
            {
                if (c1==1)
                {
                    tp++;
                    jedan.Background = Brushes.Green;
                    sest.Background = Brushes.Green;
                }
                else
                {
                    jedan.Background = Brushes.Red;
                    sest.Background = Brushes.Red;
                }
            }
            else if (a0 == 4)
            {
                if (d1==1)
                {
                    tp++;
                    jedan.Background = Brushes.Green;
                    osam.Background = Brushes.Green;
                }
                else
                {
                    jedan.Background = Brushes.Red;
                    osam.Background = Brushes.Red;
                }
            }

            if (b0 == 1)
            {
                if (a1 == 2)
                {
                    tp++;
                    tri.Background = Brushes.Green;
                    dva.Background = Brushes.Green;
                }
                else
                {
                    tri.Background = Brushes.Red;
                    dva.Background = Brushes.Red;
                }
            }
            else if (b0 == 2)
            {
                if (b1 == 2)
                {
                    tp++;
                    tri.Background = Brushes.Green;
                    cetiri.Background = Brushes.Green;
                }
                else
                {
                    tri.Background = Brushes.Red;
                    cetiri.Background = Brushes.Red;
                }
            }
            else if (b0 == 3)
            {
                if (c1 == 2)
                {
                    tp++;
                    tri.Background = Brushes.Green;
                    sest.Background = Brushes.Green;
                }
                else
                {
                    tri.Background = Brushes.Red;
                    sest.Background = Brushes.Red;
                }
            }
            else if (b0 == 4)
            {
                if (d1 == 2)
                {
                    tp++;
                    tri.Background = Brushes.Green;
                    osam.Background = Brushes.Green;
                }
                else
                {
                    tri.Background = Brushes.Red;
                    osam.Background = Brushes.Red;
                }
            }

            if (c0 == 1)
            {
                if (a1 == 3)
                {
                    tp++;
                    pet.Background = Brushes.Green;
                    dva.Background = Brushes.Green;
                }
                else
                {
                    pet.Background = Brushes.Red;
                    dva.Background = Brushes.Red;
                }
            }
            else if (c0 == 2)
            {
                if (b1 == 3)
                {
                    tp++;
                    pet.Background = Brushes.Green;
                    cetiri.Background = Brushes.Green;
                }
                else
                {
                    pet.Background = Brushes.Red;
                    cetiri.Background = Brushes.Red;
                }
            }
            else if (c0 == 3)
            {
                if (c1 == 3)
                {
                    tp++;
                    pet.Background = Brushes.Green;
                    sest.Background = Brushes.Green;
                }
                else
                {
                    pet.Background = Brushes.Red;
                    sest.Background = Brushes.Red;
                }
            }
            else if (c0 == 4)
            {
                if (d1 == 3)
                {
                    tp++;
                    pet.Background = Brushes.Green;
                    osam.Background = Brushes.Green;
                }
                else
                {
                    pet.Background = Brushes.Red;
                    osam.Background = Brushes.Red;
                }
            }
            if (d0 == 1)
            {
                if (a1 == 4)
                {
                    tp++;
                    sedam.Background = Brushes.Green;
                    dva.Background = Brushes.Green;
                }
                else
                {
                    sedam.Background = Brushes.Red;
                    dva.Background = Brushes.Red;
                }
            }
            else if (d0 == 2)
            {
                if (b1 == 4)
                {
                    tp++;
                    sedam.Background = Brushes.Green;
                    cetiri.Background = Brushes.Green;
                }
                else
                {
                    sedam.Background = Brushes.Red;
                    cetiri.Background = Brushes.Red;
                }
            }
            else if (d0 == 3)
            {
                if (c1 == 4)
                {
                    tp++;
                    sedam.Background = Brushes.Green;
                    sest.Background = Brushes.Green;
                }
                else
                {
                    sedam.Background = Brushes.Red;
                    sest.Background = Brushes.Red;
                }
            }
            else if (d0 == 4)
            {
                if (d1 == 4)
                {
                    tp++;
                    sedam.Background = Brushes.Green;
                    osam.Background = Brushes.Green;
                }
                else
                {
                    sedam.Background = Brushes.Red;
                    osam.Background = Brushes.Red;
                }
            }
            rez = tp / 4 * 100;
            rezultat.Text = "Vaš procenat tačnosti je " + rez+"%";
            prov.Visibility = Visibility.Hidden;
            pocetna.Visibility = Visibility.Visible;
        }

    }
}
