using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace adatbázis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Diak
        {
            public string OM_Azonosito { get; set; }
            public string Neve { get; set; }
            public string ErtesitesiCime { get; set; }
            public string Email { get; set; }
            public DateTime SzuletesiDatum { get; set; }
            public int Matematika { get; set; }
            public int Magyar { get; set; }
        }

        private List<Diak> diakok;

        public MainWindow()
        {
            InitializeComponent();
            InitializeDataGrid();
            
        }

        private void InitializeDataGrid()
        {
            diakok = new List<Diak>
        {
            new Diak
            {
                OM_Azonosito = "78655218932",
                Neve = "Szabó Anna",
                ErtesitesiCime = "Budapest, Gellért tér 15.",
                Email = "anna@example.com",
                SzuletesiDatum = DateTime.Parse("1998-07-19"),
                Matematika = 14,
                Magyar = 35
            },
            new Diak
            {
                OM_Azonosito = "15963702584",
                Neve = "Nagy Zsófia",
                ErtesitesiCime = "Debrecen, Szent István utca 8.",
                Email = "zsofia@example.com",
                SzuletesiDatum = DateTime.Parse("2000-02-22"),
                Matematika = 27,
                Magyar = 4
            },
            new Diak
            {
                OM_Azonosito = "30351479261",
                Neve = "Kovács Máté",
                ErtesitesiCime = "Szeged, Erzsébet körút 45.",
                Email = "mate@example.com",
                SzuletesiDatum = DateTime.Parse("1995-11-29"),
                Matematika = 48,
                Magyar = 15
            },
            new Diak
            {
                OM_Azonosito = "97401028543",
                Neve = "Tóth Bence",
                ErtesitesiCime = "Pécs, Váci utca 33.",
                Email = "bence@example.com",
                SzuletesiDatum = DateTime.Parse("1997-03-17"),
                Matematika = 8,
                Magyar = 47
            },
            new Diak
            {
                OM_Azonosito = "88765031624",
                Neve = "Horváth Eszter",
                ErtesitesiCime = "Székesfehérvár, Bartók Béla út 12.",
                Email = "eszter@example.com",
                SzuletesiDatum = DateTime.Parse("1996-09-08"),
                Matematika = 34,
                Magyar = 7
            },
            new Diak
            {
                OM_Azonosito = "64189075351",
                Neve = "Kiss Attila",
                ErtesitesiCime = "Miskolc, József Attila utca 18.",
                Email = "attila@example.com",
                SzuletesiDatum = DateTime.Parse("1993-12-05"),
                Matematika = 13,
                Magyar = 48
            },
            new Diak
            {
                OM_Azonosito = "18734250658",
                Neve = "Fekete Laura",
                ErtesitesiCime = "Győr, Széchenyi tér 9.",
                Email = "laura@example.com",
                SzuletesiDatum = DateTime.Parse("1999-06-30"),
                Matematika = 2,
                Magyar = 30
            },
            new Diak
            {
                OM_Azonosito = "51698072427",
                Neve = "Bíró Gábor",
                ErtesitesiCime = "Kecskemét, Deák Ferenc utca 21.",
                Email = "gabor@example.com",
                SzuletesiDatum = DateTime.Parse("1994-10-14"),
                Matematika = 9,
                Magyar = 33
            },
            new Diak
            {
                OM_Azonosito = "60157349268",
                Neve = "Mészáros Péter",
                ErtesitesiCime = "Nyíregyháza, Petőfi Sándor utca 26.",
                Email = "peter@example.com",
                SzuletesiDatum = DateTime.Parse("2001-04-01"),
                Matematika = 36,
                Magyar = 21
            },
            new Diak
            {
                OM_Azonosito = "72948316750",
                Neve = "Varga Noémi",
                ErtesitesiCime = "Szombathely, Kossuth Lajos utca 3.",
                Email = "noemi@example.com",
                SzuletesiDatum = DateTime.Parse("1992-08-18"),
                Matematika = 24,
                Magyar = 23
            },
            new Diak
            {
                OM_Azonosito = "84052731649",
                Neve = "Lakatos Dóra",
                ErtesitesiCime = "Veszprém, Ady Endre utca 7.",
                Email = "dora@example.com",
                SzuletesiDatum = DateTime.Parse("2000-01-03"),
                Matematika = 43,
                Magyar = 41
            },
            new Diak
            {
                OM_Azonosito = "85273941680",
                Neve = "Németh Tamás",
                ErtesitesiCime = "Szolnok, Béke tér 14.",
                Email = "tamas@example.com",
                SzuletesiDatum = DateTime.Parse("1998-05-27"),
                Matematika = 5,
                Magyar = 49
            },
            new Diak
            {
                OM_Azonosito = "41593260701",
                Neve = "Orbán Katalin",
                ErtesitesiCime = "Eger, Szabadság utca 32.",
                Email = "katalin@example.com",
                SzuletesiDatum = DateTime.Parse("1996-02-11"),
                Matematika = 37,
                Magyar = 20
            },
            new Diak
            {
                OM_Azonosito = "10486732952",
                Neve = "Simon Balázs",
                ErtesitesiCime = "Debrecen, Király utca 28.",
                Email = "balazs@example.com",
                SzuletesiDatum = DateTime.Parse("1995-07-07"),
                Matematika = 20,
                Magyar = 48
            },
            new Diak
            {
                OM_Azonosito = "92740581643",
                Neve = "Papp Viktória",
                ErtesitesiCime = "Kaposvár, Alkotmány utca 5.",
                Email = "viktor@example.com",
                SzuletesiDatum = DateTime.Parse("1997-11-24"),
                Matematika = 32,
                Magyar = 9
            },
            new Diak
            {
                OM_Azonosito = "10637851454",
                Neve = "Molnár Zoltán",
                ErtesitesiCime = "Szekszárd, Párizsi utca 17.",
                Email = "zoltan@example.com",
                SzuletesiDatum = DateTime.Parse("1993-01-16"),
                Matematika = 3,
                Magyar = 46
            },
            new Diak
            {
                OM_Azonosito = "44025967885",
                Neve = "Fekete Márton",
                ErtesitesiCime = "Pécs, Rákóczi út 13.",
                Email = "marton@example.com",
                SzuletesiDatum = DateTime.Parse("1992-04-29"),
                Matematika = 42,
                Magyar = 31
            },
            new Diak
            {
                OM_Azonosito = "30381425616",
                Neve = "Pál Júlia",
                ErtesitesiCime = "Sopron, Szent Gellért tér 10.",
                Email = "julia@example.com",
                SzuletesiDatum = DateTime.Parse("1999-09-02"),
                Matematika = 49,
                Magyar = 19
            },
            new Diak
            {
                OM_Azonosito = "65082317920",
                Neve = "Takács Orsolya",
                ErtesitesiCime = "Eger, Andrássy út 22.",
                Email = "orsolya@example.com",
                SzuletesiDatum = DateTime.Parse("1994-06-13"),
                Matematika = 31,
                Magyar = 18
            },
            new Diak
            {
                OM_Azonosito = "15374680221",
                Neve = "Kovács Ádám",
                ErtesitesiCime = "Székesfehérvár, Bajnai út 8.",
                Email = "adam@example.com",
                SzuletesiDatum = DateTime.Parse("1996-08-06"),
                Matematika = 18,
                Magyar = 10
            }
        };

            dataGrid.ItemsSource = diakok;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            diakok.Clear();

            // DataGrid adatait hozzáadjuk a Diakok listához
            for (int i = 0; i < dataGrid.Items.Count; i++)
            {
                Diak diak = (Diak)dataGrid.Items[i];
                diakok.Add(diak);
            }

            // Diakok listát beállítjuk a DataGrid forrásaként
            dataGrid.ItemsSource = diakok;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid != null && dataGrid.Items.Count > 1 )
            {
                (dataGrid.ItemsSource as List<Diak>)?.RemoveAt(dataGrid.Items.Count - 2);
                dataGrid.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Nincs több érték!");
            }
        }
    }
}