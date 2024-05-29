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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        int[,] niz = new int[4, 2];
        string o;
        private void gen_Click(object sender, RoutedEventArgs e)
        {
            if (op1.Text != "+" && op1.Text != "-" && op1.Text != "/" && op1.Text != "*")
            {
                MessageBox.Show("Niste izabrali operaciju!");
            }
            else
            {
                o = op1.Text;
                Random r = new Random();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        niz[i, j] = r.Next(1, 20);
                        if (op1.Text == "/" && j == 1)
                        {
                            while (niz[i, j] == 0 || niz[i, 0] % niz[i, j]!=0)
                                niz[i, j] = r.Next(1, 20);
                        }
                    }
                }
                for (int i = 0; i < 4; i++)
                {
                    if (i == 0)
                    {
                        a1.Text = niz[i, 0].ToString();
                        b1.Text = niz[i, 1].ToString();
                    }
                    else if (i == 1)
                    {
                        a2.Text = niz[i, 0].ToString();
                        b2.Text = niz[i, 1].ToString();
                    }
                    else if (i == 2)
                    {
                        a3.Text = niz[i, 0].ToString();
                        b3.Text = niz[i, 1].ToString();
                    }
                    else if (i == 3)
                    {
                        a4.Text = niz[i, 0].ToString();
                        b4.Text = niz[i, 1].ToString();
                    }
                    operacija.Visibility = Visibility.Hidden;
                    prov.Visibility = Visibility.Visible;
                    gen.Visibility = Visibility.Hidden;
                }
            }
        }

        private void prov_Click(object sender, RoutedEventArgs e)
        {
            double tp=0,rez;
            int a, b, c, d;
            a = int.Parse(rez1.Text);
            b = int.Parse(rez2.Text);
            c = int.Parse(rez3.Text);
            d = int.Parse(rez4.Text);
            if (o == "+")
            {
                if (niz[0, 0] + niz[0, 1] == a)
                {
                    rez1.Background = Brushes.Green;
                    tp++;
                }
                else
                {
                    rez1.Background = Brushes.Red;
                }
                if (niz[1, 0] + niz[1, 1] == b)
                {
                    rez2.Background = Brushes.Green;
                    tp++;
                }
                else
                {
                    rez2.Background = Brushes.Red;
                }
                if (niz[2, 0] + niz[2, 1] == c)
                {
                    rez3.Background = Brushes.Green;
                    tp++;
                }
                else
                {
                    rez3.Background = Brushes.Red;
                }
                if (niz[3, 0] + niz[3, 1] == d)
                {
                    rez4.Background = Brushes.Green;
                    tp++;
                }
                else
                {
                    rez4.Background = Brushes.Red;
                }
            }
            else if(o=="-")
            {
                if (niz[0, 0] - niz[0, 1] == a)
                {
                    rez1.Background = Brushes.Green;
                    tp++;
                }
                else
                {
                    rez1.Background = Brushes.Red;
                }
                if (niz[1, 0] - niz[1, 1] == b)
                {
                    rez2.Background = Brushes.Green;
                    tp++;
                }
                else
                {
                    rez2.Background = Brushes.Red;
                }
                if (niz[2, 0] - niz[2, 1] == c)
                {
                    rez3.Background = Brushes.Green;
                    tp++;
                }
                else
                {
                    rez3.Background = Brushes.Red;
                }
                if (niz[3, 0] - niz[3, 1] == d)
                {
                    rez4.Background = Brushes.Green;
                    tp++;
                }
                else
                {
                    rez4.Background = Brushes.Red;
                }
            }
            else if(o=="/")
            {
                    if (niz[0, 0] / niz[0, 1] == a)
                    {
                        rez1.Background = Brushes.Green;
                        tp++;
                    }
                    else
                    {
                        rez1.Background = Brushes.Red;
                    }
                    if (niz[1, 0] / niz[1, 1] == b)
                    {
                        rez2.Background = Brushes.Green;
                        tp++;
                    }
                    else
                    {
                        rez2.Background = Brushes.Red;
                    }
                    if (niz[2, 0] / niz[2, 1] == c)
                    {
                        rez3.Background = Brushes.Green;
                        tp++;
                    }
                    else
                    {
                        rez3.Background = Brushes.Red;
                    }
                    if (niz[3, 0] / niz[3, 1] == d)
                    {
                        rez4.Background = Brushes.Green;
                        tp++;
                    }
                    else
                    {
                        rez4.Background = Brushes.Red;
                    }
            }
            else if(o=="*")
            {
                if (niz[0, 0] * niz[0, 1] == a)
                {
                    rez1.Background = Brushes.Green;
                    tp++;
                }
                else
                {
                    rez1.Background = Brushes.Red;
                }
                if (niz[1, 0] * niz[1, 1] == b)
                {
                    rez2.Background = Brushes.Green;
                    tp++;
                }
                else
                {
                    rez2.Background = Brushes.Red;
                }
                if (niz[2, 0] * niz[2, 1] == c)
                {
                    rez3.Background = Brushes.Green;
                    tp++;
                }
                else
                {
                    rez3.Background = Brushes.Red;
                }
                if (niz[3, 0] * niz[3, 1] == d)
                {
                    rez4.Background = Brushes.Green;
                    tp++;
                }
                else
                {
                    rez4.Background = Brushes.Red;
                }
            }
            rez = tp / 4*100;
            prov.Visibility = Visibility.Hidden;
            rezultat.Text = "Vaš procenat tačnosti je " + rez + "%";
            rezultat.Visibility = Visibility.Visible;
            pocetna.Visibility = Visibility.Visible;
        }

        private void pocetna_Click(object sender, RoutedEventArgs e)
        {
            Window pocetak = new MainWindow();
            this.Close();
            pocetak.Show();
        }
    }
}
