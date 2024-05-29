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
    /// Interaction logic for Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (t.Text == "Književnost")
                tb.Text = "Gospoda Glembajevi - Miroslav Krleža Stepski vuk - Hermann Hesse Stranac - Albert Camus Prokleta avlija - Ivo Andrić Tvrđava - Meša Selimović Nora - Henrik Ibsen Zločin i kazna - Fjodor Mihajlovič Dostojevski Ana Karenjina - Lav Nikolajevič Tolstoj Nečista krv - Borisav Stanković Cvjetovi zla - Charles Baudelaire Vođa - Radoje Domanović U registraturi - Ante Kovačić Grozdanin kikot - Hamza Humo Kabanica - Nikolaj Vasiljevič Gogolj Alhemičar - Paulo Coelho Don Quijote - Miguel de Cervantes";
            else if (t.Text == "Sport")
                tb.Text = "Lebron James - košarka Stephen Curry - košarka Nikola Jokić - košarka Lionel Messi - nogomet Cristiano Ronaldo - nogomet Edin Džeko - nogomet Zlatan Ibrahimović - nogomet Luka Modrić - nogomet Roger Federer - tenis Serena Williams - tenis Novak Đoković - tenis Rafel Nadal - tenis Nikola Karabatić - rukomet Mikkel Hansen - rukomet Džanan Musa - košarka Sander Sagosen - rukomet";
            else if(t.Text=="Geografija")
                tb.Text = "Argentina - Buenos Aires Brazil - Brasilia Bugarska - Sofija Kipar - Nikozija Danska - Kopenhagen Finska - Helsinki Njemačka - Berlin Mađarska - Budimpešta Italija - Rim Azerbejdžan - Baku Bjelorusija - Minsk Indija - New Delhi Indonezija - Jakarta Irak - Bagdad Japan - Tokio Sjeverna Koreja - Pjongjang";
        }

        private void pocetak_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Window pocetna = new MainWindow();
            this.Close();
            pocetna.Show();
        }
    }
}
