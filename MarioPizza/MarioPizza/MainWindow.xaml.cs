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

namespace MarioPizza
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Naam = null;
        string Adres = null;
        string Postcode = null;
        string Woonplaats = null;
        string SelectedPizza = null;
        string Aantal = null;
        int radchek = 0;
        double prijs;
        double aantal;
        double totaal;
        double totaal1;
        string[] pizzas = new string[11];
        double[] voedigkosten = new double[11];
        public double prijstotaal = 0;
        public MainWindow()
        {
            InitializeComponent();
           
        }
        
        private void BtToevoeg(object sender, RoutedEventArgs e)
        {
             ComboBoxItem cmbiPenP = cmbPenP.SelectedItem as ComboBoxItem;
            SelectedPizza = cmbiPenP.Content.ToString();
           
            if (tbAantaal.Text == "" || tbAantaal.Text == "0") // conditions aangeven
            {
                TbTotaalbedrag1.Foreground = Brushes.Red;
                TbTotaalbedrag1.Text = "*** Error *** ";
            }
                        
            else
            {
              



                if (rtbOverzicht.Items.Contains(cmbiPenP.Content.ToString())) // als de listbox bevat de inhoud van de combobox
                {
                    MessageBox.Show("graag andere Pizza kiezen");

                }
                else
                {

                    switch (SelectedPizza) // switch om  de geselcteerd pizza te breaking
                    {
                        case "Pizza Napoli":
                            voedigkosten[0] = totaal; // waarde gegeven 
                            pizzas[0] = SelectedPizza; // waarde gegeven 
                            totaal1 = double.Parse(TbTotaal.Text); // de omzeten van string naar doubel
                            totaal = totaal1 + voedigkosten[0]; // de pijs berekenen 
                            TbTotaal.Text = totaal.ToString("0.00"); // toen de nieuwe pijs en afronden op twee dins
                            break;

                        case "Pizza Quattro Stagioni":
                            voedigkosten[1] = totaal; // waarde gegeven 
                            pizzas[1] = SelectedPizza; // waarde gegeven 
                            totaal1 = double.Parse(TbTotaal.Text); // de omzeten van string naar doubel
                            totaal = totaal1 + voedigkosten[1]; // de pijs berekenen 
                            TbTotaal.Text = totaal.ToString("0.00"); // toen de nieuwe pijs en afronden op twee dins
                            break;

                        case "Pizza Hawaii":
                            voedigkosten[2] = totaal; // waarde gegeven 
                            pizzas[2] = SelectedPizza; // waarde gegeven 
                            totaal1 = double.Parse(TbTotaal.Text); // de omzeten van string naar doubel
                            totaal = totaal1 + voedigkosten[2]; // de pijs berekenen 
                            TbTotaal.Text = totaal.ToString("0.00"); // toen de nieuwe pijs en afronden op twee dins
                             break;

                        case "Pizza Margaritha":
                            voedigkosten[3] = totaal; // waarde gegeven 
                            pizzas[3] = SelectedPizza; // waarde gegeven 
                            totaal1 = double.Parse(TbTotaal.Text); // de omzeten van string naar doubel
                            totaal = totaal1 + voedigkosten[3]; // de pijs berekenen 
                            TbTotaal.Text = totaal.ToString("0.00"); // toen de nieuwe pijs en afronden op twee dins
                            break;
                        case "Pizza Pepperoni":
                            voedigkosten[4] = totaal; // waarde gegeven 
                            pizzas[4] = SelectedPizza; // waarde gegeven 
                            totaal1 = double.Parse(TbTotaal.Text); // de omzeten van string naar doubel
                            totaal = totaal1 + voedigkosten[4]; // de pijs berekenen 
                            TbTotaal.Text = totaal.ToString("0.00"); // toen de nieuwe pijs en afronden op twee dins
                            break;
                        case "Pizza Diavola":
                            voedigkosten[5] = totaal; // waarde gegeven 
                            pizzas[5] = SelectedPizza; // waarde gegeven 
                            totaal1 = double.Parse(TbTotaal.Text); // de omzeten van string naar doubel
                            totaal = totaal1 + voedigkosten[5]; // de pijs berekenen 
                            TbTotaal.Text = totaal.ToString("0.00"); // toen de nieuwe pijs en afronden op twee dins
                            break;
                        case "Pizza Funghi":

                            voedigkosten[6] = totaal; // waarde gegeven 
                            pizzas[6] = SelectedPizza; // waarde gegeven 
                            totaal1 = double.Parse(TbTotaal.Text); // de omzeten van string naar doubel
                            totaal = totaal1 + voedigkosten[6]; // de pijs berekenen 
                            TbTotaal.Text = totaal.ToString("0.00"); // toen de nieuwe pijs en afronden op twee dins
                            break;

                        case "Pizza Calzone":
                            voedigkosten[7] = totaal; // waarde gegeven 
                            pizzas[7] = SelectedPizza; // waarde gegeven 
                            totaal1 = double.Parse(TbTotaal.Text); // de omzeten van string naar doubel
                            totaal = totaal1 + voedigkosten[7]; // de pijs berekenen 
                            TbTotaal.Text = totaal.ToString("0.00"); // toen de nieuwe pijs en afronden op twee dins
                            break;
                        case "Pizza Prosciutto":

                            voedigkosten[8] = totaal; // waarde gegeven 
                            pizzas[8] = SelectedPizza; // waarde gegeven 
                            totaal1 = double.Parse(TbTotaal.Text); // de omzeten van string naar doubel
                            totaal = totaal1 + voedigkosten[8]; // de pijs berekenen 
                            TbTotaal.Text = totaal.ToString("0.00"); // toen de nieuwe pijs en afronden op twee dins
                            break;
                        case "Pizza Tonno ":


                            voedigkosten[9] = totaal; // waarde gegeven 
                            pizzas[9] = SelectedPizza; // waarde gegeven 
                            totaal1 = double.Parse(TbTotaal.Text); // de omzeten van string naar doubel
                            totaal = totaal1 + voedigkosten[9]; // de pijs berekenen 
                            TbTotaal.Text = totaal.ToString("0.00"); // toen de nieuwe pijs en afronden op twee dins
                            break;
                        case "Pizza Frute di Mare":

                            voedigkosten[10] = totaal; // waarde gegeven 
                            pizzas[10] = SelectedPizza; // waarde gegeven 
                            totaal1 = double.Parse(TbTotaal.Text); // de omzeten van string naar doubel
                            totaal = totaal1 + voedigkosten[10]; // de pijs berekenen 
                            TbTotaal.Text = totaal.ToString("0.00"); // toen de nieuwe pijs en afronden op twee dins
                            break;
                    }
                    string Name = tbNaam.Text;
                    Postcode = tbPlaats.Text;


                    Adres = tbAdres.Text;
                    Woonplaats = tbPlaats2.Text;


                    rtbOverzicht.Items.Add(SelectedPizza + System.Environment.NewLine + "Aantaal: " + Aantal + System.Environment.NewLine + "Prijs:  €" + totaal);
                    // rtbOverzicht.Items.Add(SelectedPizza);// de selectedpizza toevoegen aan de lixtbox 
                    //rtbOverzicht.Items.Add("aantaal: " + aantal); // de aantal toevoegen aan de lixtbox
                    //rtbOverzicht.Items.Add("prijs: " + totaal);  // de totaal toevoegen aan de lixtbox




                    if (Name == "")
                    {
                        rtbOverzicht.Items.Clear();
                        TbTotaal.Text = 0.ToString("0.00");
                        MessageBox.Show("graag u naam invullen", "", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                    else if (Postcode == "")
                    {
                        rtbOverzicht.Items.Clear();
                        TbTotaal.Text = 0.ToString("0.00");
                        MessageBox.Show("graag u postcode invullen ", "", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                    else if (Woonplaats == "")
                    {
                        rtbOverzicht.Items.Clear();
                        MessageBox.Show("graag u plaats invullen ", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else if (Adres == "")
                    {
                        rtbOverzicht.Items.Clear();
                        TbTotaal.Text = 0.ToString("0.00");
                        MessageBox.Show("graag u adras invullen ", "", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                    else if (Aantal == null)
                    {
                        rtbOverzicht.Items.Clear();
                        TbTotaal.Text = 0.ToString("0.00");
                        MessageBox.Show("graag de aantaal invullen ", "", MessageBoxButton.OK, MessageBoxImage.Error);

                    }
                   
                }
            }
        }
        private string Money(double price)
        {
            return price.ToString("€ 0.00");
        }

        private void BtBetaal(object sender, RoutedEventArgs e)
        {
            if (rtbOverzicht.Items.Count == 0) // als de listbox leeg is 
            {
                MessageBox.Show("Kies een pizza uit");
            }
            else
            {



                try
                {
                    Postcode = tbPlaats.Text;
                    string post1 = Postcode.Substring(0, 1);
                    string post2 = Postcode.Substring(0, Postcode.Length - 3);
                    string post3 = Postcode.Substring(4, 1);
                    string post4 = Postcode.Substring(5, 2);
                    bool result1 = post4.All(Char.IsLetter);
                    // poste code cotrloeren 
                    int pos = int.Parse(post2);
                    int pos1 = int.Parse(post1);
                    if (pos1 == 0)
                    {
                        MessageBox.Show("postcode begint niet met 0", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else if (post3 != " ")
                    {
                        MessageBox.Show("graag een spatie tussen cijfes en letters", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                       else if (result1 == true)
                    {
                        if (Name == null || Postcode == null || Woonplaats == null || Adres == null || Aantal == null)
                        {
                            MessageBox.Show("graag u gegevens bijwerken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        else
                        {
                            MessageBoxResult result = MessageBox.Show("Kloppen u gegevens de in de overzicht\"?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
                            if (result == MessageBoxResult.Yes)
                            {
                                MessageBox.Show("U kunt door gaan met betalen");
                                rtbOverzicht.Items.Clear();
                                tbAantaal.Text = "";
                                tbAantaal.IsReadOnly = true;
                                cmbPenP.SelectedItem = null;
                                Radiobutton1.IsChecked = false;
                                Radiobutton1.IsEnabled = false;
                                Radiobutton2.IsChecked = false;
                                Radiobutton2.IsEnabled = false;
                                TbTotaalbedrag1.Text = 0.ToString("0.00");
                                TbTotaal.Text = 0.ToString("0.00");
                                TbPrijs.Text = "Prijs: € " + 0.ToString("0.00");
                                tbNaam.Clear();
                                tbAdres.Clear();
                                tbPlaats.Clear();
                                tbPlaats2.Clear();
                                Naam = null;
                                Adres = null;
                                Postcode = null;
                                Woonplaats = null;
                                SelectedPizza = null;
                                Aantal = null;
                                radchek = 0;
                                prijs = 0;
                                aantal = 0;
                                totaal = 0;
                                totaal1 = 0;

                            }
                            else
                            {
                                MessageBox.Show("graag u gegevens bijwerken", "", MessageBoxButton.OK, MessageBoxImage.Question);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("graag u poste code  bijwerken", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
                catch
                {
                    MessageBox.Show("graag u postcode contruleren ");
                }

            }
        }

       
        private void cmbPenP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbPenP.SelectedItem == null)
            {

            }
            else
            {
                ComboBoxItem cmbiPenP = cmbPenP.SelectedItem as ComboBoxItem;
                SelectedPizza = cmbiPenP.Content.ToString();



                if (Radiobutton1.IsEnabled == false && Radiobutton2.IsEnabled == false && tbAantaal.IsReadOnly == true) // als de radiobutten is niet enabeld en textbox is readonly 
                {
                    Radiobutton1.IsEnabled = true; // maak het enabled
                    Radiobutton2.IsEnabled = true;
                    tbAantaal.IsReadOnly = false; // maakthet niet readonly 
                }

                if (Radiobutton1.IsChecked == true)
                {
                    radchek = 1;
                }
                else if (Radiobutton2.IsChecked == true)
                {
                    radchek = 2;
                }
                switch (SelectedPizza)// conditions aangeven
                {
                    case "Pizza Napoli":
                    case "Pizza Quattro Stagioni":
                    case "Pizza Hawaii": // de wardes van de compobox 

                        switch (radchek)
                        {

                            case 1: // de wardes van de radio RadioButton 
                                prijs = 10 * 70 / 100; // prijs berekenen van 25 cm 
                                TbPrijs.Text = "prijs:€" + "" + prijs.ToString("0.00");
                                totaal = aantal * prijs;
                                TbTotaalbedrag1.Text = totaal.ToString("0.00");
                                TbTotaalbedrag1.Foreground = Brushes.Black;
                                break;

                            case 2:
                                prijs = 10;
                                TbPrijs.Text = "prijs:€" + "" + prijs.ToString("0.00");
                                totaal = aantal * prijs;
                                TbTotaalbedrag1.Text = totaal.ToString("0.00");
                                TbTotaalbedrag1.Foreground = Brushes.Black;
                                break;
                        }
                        break;

                    case "Pizza Margaritha":
                        switch (radchek)
                        {
                            case 1:
                                prijs = 8 * 70 / 100;
                                TbPrijs.Text = "prijs:€" + "" + prijs.ToString("0.00");
                                totaal = aantal * prijs;
                                TbTotaalbedrag1.Text = totaal.ToString("0.00");
                                TbTotaalbedrag1.Foreground = Brushes.Black;
                                break;
                            case 2:
                                prijs = 8;
                                TbPrijs.Text = "prijs:€" + "" + prijs.ToString("0.00");
                                totaal = aantal * prijs;
                                TbTotaalbedrag1.Text = totaal.ToString("0.00");
                                TbTotaalbedrag1.Foreground = Brushes.Black;
                                break;

                        }
                        break;



                    case "Pizza Pepperoni":
                        switch (radchek)
                        {
                            case 1:
                                prijs = 9 * 70 / 100;
                                TbPrijs.Text = "prijs:€" + "" + prijs.ToString("0.00");
                                totaal = aantal * prijs;
                                TbTotaalbedrag1.Text = totaal.ToString("0.00");
                                TbTotaalbedrag1.Foreground = Brushes.Black;
                                break;
                            case 2:
                                prijs = 9;
                                TbPrijs.Text = "prijs:€" + "" + prijs.ToString("0.00");
                                totaal = aantal * prijs;
                                TbTotaalbedrag1.Text = totaal.ToString("0.00");
                                TbTotaalbedrag1.Foreground = Brushes.Black;
                                break;
                        }

                        break;
                    case "Pizza Diavola":
                    case "Pizza Funghi":
                        switch (radchek)
                        {
                            case 1:
                                prijs = 10.50 * 70 / 100;
                                TbPrijs.Text = "prijs:€" + "" + prijs.ToString("0.00");
                                totaal = aantal * prijs;
                                TbTotaalbedrag1.Text = totaal.ToString("0.00");
                                TbTotaalbedrag1.Foreground = Brushes.Black;
                                break;
                            case 2:
                                prijs = 10.50;
                                TbPrijs.Text = "prijs:€" + "" + prijs.ToString("0.00");
                                totaal = aantal * prijs;
                                TbTotaalbedrag1.Text = totaal.ToString("0.00");
                                TbTotaalbedrag1.Foreground = Brushes.Black;
                                break;
                        }

                        break;

                    case "Pizza Calzone":
                    case "Pizza Prosciutto":
                        switch (radchek)
                        {
                            case 1:
                                prijs = 11 * 70 / 100;
                                TbPrijs.Text = "prijs:€" + "" + prijs.ToString("0.00");
                                totaal = aantal * prijs;
                                TbTotaalbedrag1.Text = totaal.ToString("0.00");
                                TbTotaalbedrag1.Foreground = Brushes.Black;
                                break;
                            case 2:
                                prijs = 11;
                                TbPrijs.Text = "prijs:€" + "" + prijs.ToString("0.00");
                                totaal = aantal * prijs;
                                TbTotaalbedrag1.Text = totaal.ToString("0.00");
                                TbTotaalbedrag1.Foreground = Brushes.Black;
                                break;
                        }
                        break;
                    case "Pizza Tonno":
                        switch (radchek)
                        {
                            case 1:
                                prijs = 12 * 70 / 100;
                                TbPrijs.Text = "prijs:€" + "" + prijs.ToString("0.00");
                                totaal = aantal * prijs;
                                TbTotaalbedrag1.Text = totaal.ToString("0.00");
                                TbTotaalbedrag1.Foreground = Brushes.Black;
                                break;
                            case 2:
                                prijs = 12;
                                TbPrijs.Text = "prijs:€" + "" + prijs.ToString("0.00");
                                totaal = aantal * prijs;
                                TbTotaalbedrag1.Text = totaal.ToString("0.00");
                                TbTotaalbedrag1.Foreground = Brushes.Black;
                                break;
                        }
                        break;

                    case "Pizza Frute di Mare":
                        switch (radchek)
                        {
                            case 1:
                                prijs = 14 * 70 / 100;
                                TbPrijs.Text = "prijs:€" + "" + prijs.ToString("0.00");
                                totaal = aantal * prijs;
                                TbTotaalbedrag1.Text = totaal.ToString("0.00");
                                TbTotaalbedrag1.Foreground = Brushes.Black;
                                break;
                            case 2:
                                prijs = 14;
                                TbPrijs.Text = "prijs:€" + "" + prijs.ToString("0.00");
                                totaal = aantal * prijs;
                                TbTotaalbedrag1.Text = totaal.ToString("0.00");
                                TbTotaalbedrag1.Foreground = Brushes.Black;
                                break;
                        }
                        break;
                }
            }
              

        }

        private void Radiobutton1_Checked(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cmbiPenP = cmbPenP.SelectedItem as ComboBoxItem;
            SelectedPizza = cmbiPenP.Content.ToString();
            radchek = 1;
            switch (SelectedPizza) // switch om  de geselcteerd pizza te breaking
            {
                case "Pizza Napoli":
                case "Pizza Quattro Stagioni":
                case "Pizza Hawaii":
                    prijs = 10 * 70 / 100;
                    TbPrijs.Text = "prijs:€" + "" + prijs.ToString("0.00");
                    totaal = aantal * prijs;
                    TbTotaalbedrag1.Text = totaal.ToString("0.00");
                    TbTotaalbedrag1.Foreground = Brushes.Black;

                    break;
                case "Pizza Margaritha":
                    prijs = 8 * 70 / 100;
                    TbPrijs.Text = "prijs:€" + prijs.ToString("0.00");
                    totaal = aantal * prijs;
                    TbTotaalbedrag1.Text = totaal.ToString("0.00");
                    TbTotaalbedrag1.Foreground = Brushes.Black;
                    break;
                case "Pizza Pepperoni":
                    prijs = 9 * 70 / 100;
                    TbPrijs.Text = "prijs:€" + prijs.ToString("0.00");
                    totaal = aantal * prijs;
                    TbTotaalbedrag1.Text = totaal.ToString("0.00");
                    TbTotaalbedrag1.Foreground = Brushes.Black;
                    break;
                case "Pizza Diavola":
                case "Pizza Funghi":

                    prijs = 10.50 * 70 / 100;
                    TbPrijs.Text = "prijs:€" + prijs.ToString("0.00");
                    totaal = aantal * prijs;
                    TbTotaalbedrag1.Text = totaal.ToString("0.00");
                    TbTotaalbedrag1.Foreground = Brushes.Black;
                    break;

                case "Pizza Calzone":
                case "Pizza Prosciutto":

                    prijs = 11 * 70 / 100;
                    TbPrijs.Text = "prijs:€" + prijs.ToString("0.00");
                    totaal = aantal * prijs;
                    TbTotaalbedrag1.Text = totaal.ToString("0.00");
                    TbTotaalbedrag1.Foreground = Brushes.Black;
                    break;
                case "Pizza Tonno ":


                    prijs = 12 * 70 / 100;
                    TbPrijs.Text = "prijs:€" + prijs.ToString("0.00");
                    totaal = aantal * prijs;
                    TbTotaalbedrag1.Text = totaal.ToString("0.00");
                    TbTotaalbedrag1.Foreground = Brushes.Black;
                    break;
                case "Pizza Frute di Mare":

                    prijs = 14 * 70 / 100;
                    TbPrijs.Text = "prijs:€" + prijs.ToString("0.00");
                    totaal = aantal * prijs;
                    TbTotaalbedrag1.Text = totaal.ToString("0.00");
                    TbTotaalbedrag1.Foreground = Brushes.Black;
                    break;
            }


        }

        private void Radiobutton2_Checked(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cmbiPenP = cmbPenP.SelectedItem as ComboBoxItem;
            SelectedPizza = cmbiPenP.Content.ToString();
            radchek = 2;
            switch (SelectedPizza) // switch om  de geselcteerd pizza te breaking
            {
                case "Pizza Napoli":
                case "Pizza Quattro Stagioni":
                case "Pizza Hawaii":
                    prijs = 10;
                    TbPrijs.Text = "prijs:€" + "" + prijs.ToString("0.00");
                    totaal = aantal * prijs;
                    TbTotaalbedrag1.Text = totaal.ToString("0.00");
                    TbTotaalbedrag1.Foreground = Brushes.Black;

                    break;
                case "Pizza Margaritha":
                    prijs = 8;
                    TbPrijs.Text = "prijs:€" + prijs.ToString("0.00");
                    totaal = aantal * prijs;
                    TbTotaalbedrag1.Text = totaal.ToString("0.00");
                    TbTotaalbedrag1.Foreground = Brushes.Black;
                    break;
                case "Pizza Pepperoni":
                    prijs = 9;
                    TbPrijs.Text = "prijs:€" + prijs.ToString("0.00");
                    totaal = aantal * prijs;
                    TbTotaalbedrag1.Text = totaal.ToString("0.00");
                    TbTotaalbedrag1.Foreground = Brushes.Black;
                    break;
                case "Pizza Diavola":
                case "Pizza Funghi":

                    prijs = 10.50;
                    TbPrijs.Text = "prijs:€" + prijs.ToString("0.00");
                    totaal = aantal * prijs;
                    TbTotaalbedrag1.Text = totaal.ToString("0.00");
                    TbTotaalbedrag1.Foreground = Brushes.Black;
                    break;

                case "Pizza Calzone":
                case "Pizza Prosciutto":

                    prijs = 11;
                    TbPrijs.Text = "prijs:€" + prijs.ToString("0.00");
                    totaal = aantal * prijs;
                    TbTotaalbedrag1.Text = totaal.ToString("0.00");
                    TbTotaalbedrag1.Foreground = Brushes.Black;
                    break;
                case "Pizza Tonno ":


                    prijs = 12 ;
                    TbPrijs.Text = "prijs:€" + prijs.ToString("0.00");
                    totaal = aantal * prijs;
                    TbTotaalbedrag1.Text = totaal.ToString("0.00");
                    TbTotaalbedrag1.Foreground = Brushes.Black;
                    break;
                case "Pizza Frute di Mare":

                    prijs = 14 ;
                    TbPrijs.Text = "prijs:€" + prijs.ToString("0.00");
                    totaal = aantal * prijs;
                    TbTotaalbedrag1.Text = totaal.ToString("0.00");
                    TbTotaalbedrag1.Foreground = Brushes.Black;
                    break;
            }


        }

        private void tbAantaal_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((string.IsNullOrEmpty(tbAantaal.Text)))
            {

            }
            else
            {
                try
                {
                    Aantal = tbAantaal.Text;
                    aantal = double.Parse(Aantal); // de Variable veranderen van str naar double  
                    totaal = aantal * prijs; // prijs breaking
                    TbTotaalbedrag1.Text =  totaal.ToString("0.00"); // laten zien in Tb 
                    TbTotaalbedrag1.Foreground = Brushes.Black;
                }
                catch
                {
                    MessageBox.Show("graag nummer invoeren bij aantal", "", MessageBoxButton.OK, MessageBoxImage.Error);
                    tbAantaal.Text = "";

                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        { 
            // array gemaakte  voor alle ItemsSource van pizzas
            pizzas[0] = null;
            pizzas[1] = null;
            pizzas[2] = null;
            pizzas[3] = null;
            pizzas[4] = null;
            pizzas[5] = null;
            pizzas[6] = null;
            pizzas[7] = null;
            pizzas[8] = null;
            pizzas[9] = null;
            pizzas[10] = null;

            // array gemaakte  voor alle ItemsSource van kosten
            voedigkosten[0] = 0;
            voedigkosten[1] = 0;
            voedigkosten[2] = 0;
            voedigkosten[3] = 0;
            voedigkosten[4] = 0;
            voedigkosten[5] = 0;
            voedigkosten[6] = 0;
            voedigkosten[7] = 0;
            voedigkosten[8] = 0;
            voedigkosten[9] = 0;
            voedigkosten[10] = 0;
        }

        private void rtbOverzicht_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //string selecteditem = (string)rtbOverzicht.SelectedItem; // pak selected item
            //string[] listitems = selecteditem.Split('$'); // split string op $ teken
            //double prijs = double.Parse(listitems[1]);  // paarse tweede ding naar double

            //totaal = totaal - prijs;    // afhalen prijs van paarse
            //TbTotaal.Text = totaal.ToString("0.00");  // new total

            //if (rtbOverzicht.SelectedItem == pizzas[0])
            // {
            //     totaal1 = double.Parse(TbTotaal.Text);
            //     totaal = totaal1 - voedigkosten[0];
            //     TbTotaal.Text = totaal.ToString("0.00");
            // }
            // else if (rtbOverzicht.SelectedItem == pizzas[1])
            // {
            //     totaal1 = double.Parse(TbTotaal.Text);
            //     totaal = totaal1 - voedigkosten[1];
            //     TbTotaal.Text = totaal.ToString("0.00");
            // }
            // else if (rtbOverzicht.SelectedItem == pizzas[2])
            // {
            //     totaal1 = double.Parse(TbTotaal.Text);
            //     totaal = totaal1 - voedigkosten[2];
            //     TbTotaal.Text = totaal.ToString("0.00");
            // }
            // else if (rtbOverzicht.SelectedItem == pizzas[3])
            // {
            //     totaal1 = double.Parse(TbTotaal.Text);
            //     totaal = totaal1 - voedigkosten[3];
            //     TbTotaal.Text = totaal.ToString("0.00");
            // }
            // else if (rtbOverzicht.SelectedItem == pizzas[4])
            // {
            //     totaal1 = double.Parse(TbTotaal.Text);
            //     totaal = totaal1 - voedigkosten[4];
            //     TbTotaal.Text = totaal.ToString("0.00");
            // }
            // else if (rtbOverzicht.SelectedItem == pizzas[5])
            // {
            //     totaal1 = double.Parse(TbTotaal.Text);
            //     totaal = totaal1 - voedigkosten[5];
            //     TbTotaal.Text = totaal.ToString("0.00");
            // }
            // else if (rtbOverzicht.SelectedItem == pizzas[6])
            // {
            //     totaal1 = double.Parse(TbTotaal.Text);
            //     totaal = totaal1 - voedigkosten[6];
            //     TbTotaal.Text = totaal.ToString("0.00");
            // }
            // else if (rtbOverzicht.SelectedItem == pizzas[7])
            // {
            //     totaal1 = double.Parse(TbTotaal.Text);
            //     totaal = totaal1 - voedigkosten[7];
            //     TbTotaal.Text = totaal.ToString("0.00");
            // }
            // else if (rtbOverzicht.SelectedItem == pizzas[8])
            // {
            //     totaal1 = double.Parse(TbTotaal.Text);
            //     totaal = totaal1 - voedigkosten[8];
            //     TbTotaal.Text = totaal.ToString("0.00");
            // }
            // else if (rtbOverzicht.SelectedItem == pizzas[9])
            // {
            //     totaal1 = double.Parse(TbTotaal.Text);
            //     totaal = totaal1 - voedigkosten[9];
            //     TbTotaal.Text = totaal.ToString("0.00");
            // }
            // else if (rtbOverzicht.SelectedItem == pizzas[10])
            // {
            //     totaal1 = double.Parse(TbTotaal.Text);
            //     totaal = totaal1 - voedigkosten[10];
            //     TbTotaal.Text = totaal.ToString("0.00");
            // }
            //try
            //{
            //    //tbAantaal.Text = "";
            //    //TbTotaalbedrag1.Text = 0.ToString("0.00");
            //    //aantal = 0;
            //    //TbTotaal.Text = totaal.ToString("0.00");
            //    rtbOverzicht.Items.RemoveAt(rtbOverzicht.SelectedIndex); // de besteling  verwijderen
            //}
            //catch
            //{


            //}
            MessageBoxResult answer = MessageBox.Show("wilt u het gerecht verwijderen", "verwijder u besteling", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (answer == MessageBoxResult.Yes)
            {
                string[] dishes = rtbOverzicht.SelectedItem.ToString().Split('€');
                double remove = 0;
                double.TryParse(dishes[1], out remove);
                prijstotaal = prijstotaal - remove;
                TbTotaal.Text = Money(prijstotaal);                
                rtbOverzicht.Items.Remove(rtbOverzicht.SelectedItem);
                return;
            }
            else
            {
                return;
            }

        }
    }
}
