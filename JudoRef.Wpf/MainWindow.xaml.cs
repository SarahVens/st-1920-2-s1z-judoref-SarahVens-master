using System;
using System.Windows;

namespace JudoRef.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Globale Variabelen
 
 //Code voor de array's
        /*
        string naamJudoka1;
        string naamJudoka2;
        string gordelJudoka1;
        string gordelJudoka2;
        */
        string returnScore;
        string scoreNaam;
        int punten;
        int judokanummer;
        int totaleScoreJudoka1=0;
        int totaleScoreJudoka2=0;

//Einde Globale Variabelen

//Array Declareren
        string[] judokas = new string[2];
        string[] gordels = new string[2];
   

//Einde Array declareren
        public MainWindow()
        {
            InitializeComponent();
        }
 //Methoden
        private void VulComboboxGordels(params string[] gordels)
        {
            foreach (string gordel in gordels)
            {
                cmbGordel1.Items.Add(gordel);
                cmbGordel2.Items.Add(gordel);
            }
        }

        private void UpdateGuiStartKamp()
        {
            //showing stuff
            btnStopWedstrijd.Visibility = Visibility.Visible;
            stpScore1.Visibility = Visibility.Visible;
            stpScore2.Visibility = Visibility.Visible;
            lstScoreTabel.Visibility = Visibility.Visible;
            //other
            btnStartKamp.IsEnabled = false;
        }

        private void BeginSituatie()
        {
            //hiding stuff
            btnStopWedstrijd.Visibility = Visibility.Hidden;
            stpScore1.Visibility = Visibility.Hidden;
            stpScore2.Visibility = Visibility.Hidden;
            lstScoreTabel.Visibility = Visibility.Hidden;
            //clearing stuff
            lstScoreTabel.Items.Clear();
            txtJudoka1.Text = "";
            txtJudoka2.Text = "";
            cmbGordel1.SelectedIndex = 0;
            cmbGordel2.SelectedIndex = 0;
            lblScore1.Content = "0";
            lblScore2.Content = "0";
            totaleScoreJudoka1 = 0;
            totaleScoreJudoka2 = 0;
            //other
            btnStartKamp.IsEnabled = true;
            stpScore1.IsEnabled = true;
            stpScore2.IsEnabled = true;

        }
//Code voor de array's:
        /*
                private void VerwerkScoreJudoka1(int punten, string scoreNaam) 
                {
                   returnScore = $"{DateTime.Now} {naamJudoka1} ({gordelJudoka1}) scoort {punten} punten met een {scoreNaam}";
                }
                private void VerwerkScoreJudoka2(int punten, string scoreNaam)
                {
                    returnScore = $"{DateTime.Now} {naamJudoka2} ({gordelJudoka2}) scoort {punten} punten met een {scoreNaam}";
                }
        */
        private void VerwerkScoreJudoka(int punten, string scoreNaam, int judokanummer)
        {
            returnScore = $"{DateTime.Now} {judokas[judokanummer]} ({gordels[judokanummer]}) scoort {punten} punten met een {scoreNaam}";
        }
        private void BtnScoreUit()
        {
            stpScore1.IsEnabled = false;
            stpScore2.IsEnabled = false;
        }

 //Einde methoden

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           //Titel
            Title = " Judoref - Sarah Vens";

           //fill out combobox
            VulComboboxGordels(
                "Wit",
                "Geel",
                "Oranje",
                "Groen",
                "Blauw",
                "Bruin",
                "Zwart"
                );
            BeginSituatie();
        }
 //Buttons
        private void btnStartKamp_Click(object sender, RoutedEventArgs e)
        {

            //Voor de array's
            /*
            naamJudoka1 = txtJudoka1.Text;
            naamJudoka2 = txtJudoka2.Text;
            gordelJudoka1 = cmbGordel1.SelectedItem.ToString();
            gordelJudoka2 = cmbGordel2.SelectedItem.ToString();
            */
            //check if names are filled out
            if (txtJudoka1.Text == "" || txtJudoka2.Text == "") 
            { 
                MessageBox.Show("Gelieve de namen van de judoka in te vullen.");
            }
            else
            {
                //fill out arrays
                judokas[0] = txtJudoka1.Text;
                judokas[1] = txtJudoka2.Text;
                gordels[0] = cmbGordel1.SelectedItem.ToString();
                gordels[1] = cmbGordel2.SelectedItem.ToString();
                UpdateGuiStartKamp();
                //fill out listbox
                lstScoreTabel.Items.Add($"Start kamp tussen {judokas[0]} (Gordel {gordels[0]}) en {judokas[1]} (Gordel {gordels[1]})");
                
            }
        }

        private void btnStopWedstrijd_Click(object sender, RoutedEventArgs e)
        {
            BeginSituatie();
        }

 //Judoka 1
        private void btnKoka1_Click(object sender, RoutedEventArgs e)
        {
            punten = 3;
            scoreNaam = "Koka";
            //voor uitbreiding naar array's
            /*VerwerkScoreJudoka1(punten, scoreNaam);*/
            judokanummer = 0;
            VerwerkScoreJudoka(punten,scoreNaam,judokanummer);
            lstScoreTabel.Items.Add(returnScore);
            totaleScoreJudoka1 = totaleScoreJudoka1 + punten;
            lblScore1.Content = Convert.ToString(totaleScoreJudoka1);
            if (totaleScoreJudoka1 > 25) BtnScoreUit();


        }

        private void btnYuko1_Click(object sender, RoutedEventArgs e)
        {
            punten = 5;
            scoreNaam = "Yoku";
            //voor uitbreiding naar array's
            /*VerwerkScoreJudoka1(punten, scoreNaam);*/
            judokanummer = 0;
            VerwerkScoreJudoka(punten, scoreNaam, judokanummer);
            lstScoreTabel.Items.Add(returnScore);
            totaleScoreJudoka1 = totaleScoreJudoka1 + punten;
            lblScore1.Content = Convert.ToString(totaleScoreJudoka1);
            if (totaleScoreJudoka1 > 25) BtnScoreUit();
        }

        private void btnWazeri1_Click(object sender, RoutedEventArgs e)
        {
            punten = 7;
            scoreNaam = "Wazeri";
            //voor uitbreiding naar array's
            /*VerwerkScoreJudoka1(punten, scoreNaam);*/
            judokanummer = 0;
            VerwerkScoreJudoka(punten, scoreNaam, judokanummer);
            lstScoreTabel.Items.Add(returnScore);
            totaleScoreJudoka1 = totaleScoreJudoka1 + punten;
            lblScore1.Content = Convert.ToString(totaleScoreJudoka1);
            if (totaleScoreJudoka1 > 25) BtnScoreUit();
        }

        private void btnIppon1_Click(object sender, RoutedEventArgs e)
        {
            punten = 25;
            scoreNaam = "Ippon";
            //voor uitbreiding naar array's
            /*VerwerkScoreJudoka1(punten, scoreNaam);*/
            judokanummer = 0;
            VerwerkScoreJudoka(punten, scoreNaam, judokanummer);
            lstScoreTabel.Items.Add(returnScore);
            totaleScoreJudoka1 = totaleScoreJudoka1 + punten;
            lblScore1.Content = Convert.ToString(totaleScoreJudoka1);
            if (totaleScoreJudoka1 > 25) BtnScoreUit();
        }
 //Judoka 2
        private void btnKoka2_Click(object sender, RoutedEventArgs e)
        {
            punten = 3;
            scoreNaam = "Koka";
            //voor uitbreiding naar array's
            /*VerwerkScoreJudoka2(punten, scoreNaam);*/
            judokanummer = 1;
            VerwerkScoreJudoka(punten, scoreNaam, judokanummer);
            lstScoreTabel.Items.Add(returnScore);
            totaleScoreJudoka2 = totaleScoreJudoka2 + punten;
            lblScore2.Content = Convert.ToString(totaleScoreJudoka2);
            if (totaleScoreJudoka2 > 25) BtnScoreUit();
        }

        private void btnYuko2_Click(object sender, RoutedEventArgs e)
        {
            punten = 5;
            scoreNaam = "Yuko";
            //voor uitbreiding naar array's
            /*VerwerkScoreJudoka2(punten, scoreNaam);*/
            judokanummer = 1;
            VerwerkScoreJudoka(punten, scoreNaam, judokanummer);
            lstScoreTabel.Items.Add(returnScore);
            totaleScoreJudoka2 = totaleScoreJudoka2 + punten;
            lblScore2.Content = Convert.ToString(totaleScoreJudoka2);
            if (totaleScoreJudoka2 > 25) BtnScoreUit();
        }

        private void btnWazeri2_Click(object sender, RoutedEventArgs e)
        {
            punten = 7;
            scoreNaam = "Wazeri";
            //voor uitbreiding naar array's
            /*VerwerkScoreJudoka2(punten, scoreNaam);*/
            judokanummer = 1;
            VerwerkScoreJudoka(punten, scoreNaam, judokanummer);
            lstScoreTabel.Items.Add(returnScore);
            totaleScoreJudoka2 = totaleScoreJudoka2 + punten;
            lblScore2.Content = Convert.ToString(totaleScoreJudoka2);
            if (totaleScoreJudoka2 > 25) BtnScoreUit();
        }

        private void btnIppon2_Click(object sender, RoutedEventArgs e)
        {
            punten = 25;
            scoreNaam = "Ippon";
            //voor uitbreiding naar array's
            /*VerwerkScoreJudoka2(punten, scoreNaam);*/
            judokanummer = 1;
            VerwerkScoreJudoka(punten, scoreNaam, judokanummer);
            lstScoreTabel.Items.Add(returnScore);
            totaleScoreJudoka2 = totaleScoreJudoka2 + punten;
            lblScore2.Content = Convert.ToString(totaleScoreJudoka2);
            if (totaleScoreJudoka2 > 25) BtnScoreUit();
        }
    }
}
