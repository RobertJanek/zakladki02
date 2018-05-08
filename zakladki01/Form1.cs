using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace zakladki01
{
    public partial class Form1 : Form
    {
        //przygotowanie zmiennej statycznej do budowania tablic
        //
        const int najw_dlug_plikow = 25000;
        //  ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        //przygotowanie zmiennej statycznej do budowania tablic

        double[] tablica_11 = new double[najw_dlug_plikow];
        double[] tablica_12 = new double[najw_dlug_plikow];
        double[] tablica_13 = new double[najw_dlug_plikow];
        double[] tablica_14 = new double[najw_dlug_plikow];
        double[] tablica_15 = new double[najw_dlug_plikow];
        double[] tablica_16 = new double[najw_dlug_plikow];
        double[] tablica_17 = new double[najw_dlug_plikow];

        double[] tablica_21 = new double[najw_dlug_plikow];
        double[] tablica_22 = new double[najw_dlug_plikow];
        double[] tablica_23 = new double[najw_dlug_plikow];
        double[] tablica_24 = new double[najw_dlug_plikow];
        double[] tablica_25 = new double[najw_dlug_plikow];
        double[] tablica_26 = new double[najw_dlug_plikow];
        double[] tablica_27 = new double[najw_dlug_plikow];

        double[] tablica_31 = new double[najw_dlug_plikow];
        double[] tablica_32 = new double[najw_dlug_plikow];
        double[] tablica_33 = new double[najw_dlug_plikow];
        double[] tablica_34 = new double[najw_dlug_plikow];
        double[] tablica_35 = new double[najw_dlug_plikow];
        double[] tablica_36 = new double[najw_dlug_plikow];
        double[] tablica_37 = new double[najw_dlug_plikow];

        double[] tablica_41 = new double[najw_dlug_plikow];
        double[] tablica_42 = new double[najw_dlug_plikow];
        double[] tablica_43 = new double[najw_dlug_plikow];
        double[] tablica_44 = new double[najw_dlug_plikow];
        double[] tablica_45 = new double[najw_dlug_plikow];
        double[] tablica_46 = new double[najw_dlug_plikow];
        double[] tablica_47 = new double[najw_dlug_plikow];

        double[] tablica_51 = new double[najw_dlug_plikow];
        double[] tablica_52 = new double[najw_dlug_plikow];
        double[] tablica_53 = new double[najw_dlug_plikow];
        double[] tablica_54 = new double[najw_dlug_plikow];
        double[] tablica_55 = new double[najw_dlug_plikow];
        double[] tablica_56 = new double[najw_dlug_plikow];
        double[] tablica_57 = new double[najw_dlug_plikow];

        double[] tablica_61 = new double[najw_dlug_plikow];
        double[] tablica_62 = new double[najw_dlug_plikow];
        double[] tablica_63 = new double[najw_dlug_plikow];
        double[] tablica_64 = new double[najw_dlug_plikow];
        double[] tablica_65 = new double[najw_dlug_plikow];
        double[] tablica_66 = new double[najw_dlug_plikow];
        double[] tablica_67 = new double[najw_dlug_plikow];

        double[] tablica_71 = new double[najw_dlug_plikow];
        double[] tablica_72 = new double[najw_dlug_plikow];
        double[] tablica_73 = new double[najw_dlug_plikow];
        double[] tablica_74 = new double[najw_dlug_plikow];
        double[] tablica_75 = new double[najw_dlug_plikow];
        double[] tablica_76 = new double[najw_dlug_plikow];
        double[] tablica_77 = new double[najw_dlug_plikow];

        ///###############################################

        double[] tablica_gladka_11 = new double[najw_dlug_plikow];
        double[] tablica_gladka_12 = new double[najw_dlug_plikow];
        double[] tablica_gladka_13 = new double[najw_dlug_plikow];
        double[] tablica_gladka_14 = new double[najw_dlug_plikow];
        double[] tablica_gladka_15 = new double[najw_dlug_plikow];
        double[] tablica_gladka_16 = new double[najw_dlug_plikow];
        double[] tablica_gladka_17 = new double[najw_dlug_plikow];

        double[] tablica_gladka_21 = new double[najw_dlug_plikow];
        double[] tablica_gladka_22 = new double[najw_dlug_plikow];
        double[] tablica_gladka_23 = new double[najw_dlug_plikow];
        double[] tablica_gladka_24 = new double[najw_dlug_plikow];
        double[] tablica_gladka_25 = new double[najw_dlug_plikow];
        double[] tablica_gladka_26 = new double[najw_dlug_plikow];
        double[] tablica_gladka_27 = new double[najw_dlug_plikow];

        double[] tablica_gladka_31 = new double[najw_dlug_plikow];
        double[] tablica_gladka_32 = new double[najw_dlug_plikow];
        double[] tablica_gladka_33 = new double[najw_dlug_plikow];
        double[] tablica_gladka_34 = new double[najw_dlug_plikow];
        double[] tablica_gladka_35 = new double[najw_dlug_plikow];
        double[] tablica_gladka_36 = new double[najw_dlug_plikow];
        double[] tablica_gladka_37 = new double[najw_dlug_plikow];

        double[] tablica_gladka_41 = new double[najw_dlug_plikow];
        double[] tablica_gladka_42 = new double[najw_dlug_plikow];
        double[] tablica_gladka_43 = new double[najw_dlug_plikow];
        double[] tablica_gladka_44 = new double[najw_dlug_plikow];
        double[] tablica_gladka_45 = new double[najw_dlug_plikow];
        double[] tablica_gladka_46 = new double[najw_dlug_plikow];
        double[] tablica_gladka_47 = new double[najw_dlug_plikow];

        double[] tablica_gladka_51 = new double[najw_dlug_plikow];
        double[] tablica_gladka_52 = new double[najw_dlug_plikow];
        double[] tablica_gladka_53 = new double[najw_dlug_plikow];
        double[] tablica_gladka_54 = new double[najw_dlug_plikow];
        double[] tablica_gladka_55 = new double[najw_dlug_plikow];
        double[] tablica_gladka_56 = new double[najw_dlug_plikow];
        double[] tablica_gladka_57 = new double[najw_dlug_plikow];

        double[] tablica_gladka_61 = new double[najw_dlug_plikow];
        double[] tablica_gladka_62 = new double[najw_dlug_plikow];
        double[] tablica_gladka_63 = new double[najw_dlug_plikow];
        double[] tablica_gladka_64 = new double[najw_dlug_plikow];
        double[] tablica_gladka_65 = new double[najw_dlug_plikow];
        double[] tablica_gladka_66 = new double[najw_dlug_plikow];
        double[] tablica_gladka_67 = new double[najw_dlug_plikow];

        double[] tablica_gladka_71 = new double[najw_dlug_plikow];
        double[] tablica_gladka_72 = new double[najw_dlug_plikow];
        double[] tablica_gladka_73 = new double[najw_dlug_plikow];
        double[] tablica_gladka_74 = new double[najw_dlug_plikow];
        double[] tablica_gladka_75 = new double[najw_dlug_plikow];
        double[] tablica_gladka_76 = new double[najw_dlug_plikow];
        double[] tablica_gladka_77 = new double[najw_dlug_plikow];

        double[] krok_t_pliku = new double[78];
        //krok czasowy jest różny dla każdego pliku

        List<double> lista_maxow = new List<double>();
        //lista jest krótka, zawiera tylko niezerowe wartości

        double[] tablica_maxow = new double[78];
        //tablica zawiera wszystkie MAXy, wybrane będą kopiowane do listy

        double[] tablica_i_maxow = new double[78];
        //tablica zawiera miejsce wystąpienia MAXa.

        int[] tablica_dlugosci_plikow = new int[78];
        //długość poszczególnych plików - potrzebne do wykresu

        int[] tablica_indeksowania_02_pmax = new int[78];
        //dla której wartości wyliczono 0.2*pmax

        int[] tablica_indeksowania_08_pmax = new int[78];
        //dla której wartości wyliczono 0.8*pmax

        int[] tablica_indeksowania_pzaplonu = new int[78];
        //dla której (i) wartości przekroczono p.zapłonu

        int[] tablica_w = new int[78];
        //parametr w jest potrzebny do wygładzania krzywej

        float[] tablica_k = new float[78];
        //parametr współczynników "mocy" wygładzania [0..1]
        


        /*
        int[] tablica_odwrotnosci_kroku_calk = new int[78];
        //po zmianie na tablicę krok_t_pliku[]
        //odwrotność h_1_x czyli kroku całkowania - tego jeszcze nie robię
        //#####################################################
        //#####################################################
        //#####################################################
        //#####################################################
        //#####################################################
        //#####################################################
        //#####################################################
        //#####################################################
        //#####################################################
        //#####################################################
        //#####################################################
        //#####################################################
        */

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Palette = ChartColorPalette.Pastel;

            for (int k =0; k < 78; k++)
            {
                chart1.Series.Add("seria "+k);
                chart1.Series[k].ChartType = SeriesChartType.FastLine;
                chart1.Series[k].IsVisibleInLegend = false;
            }
            for (int kk = 11; kk < 78; kk++)
            { tablica_k[kk] = 1; }  //wstawienie współczynników wygładzania=1 do całej tabeli

    }

        private void Zmiana_wartosci_suwaka_k(object sender, EventArgs e)
        {
            TrackBar suwak = (sender as TrackBar);
            String strSuwak = suwak.Tag.ToString();

            int intSuwak = int.Parse(strSuwak);
            //MessageBox.Show(""+intSuwak);

            Label labelka = label11;
            switch (intSuwak)
            {
                case 11:
                    labelka = lbl_k_11; break;
                case 12:
                    labelka = lbl_k_12; break;
                case 13:
                    labelka = lbl_k_13; ; break;
                case 14:
                    labelka = lbl_k_14; ; break;
                    //######################################################
                    //######################################################
                    //uzupełnić dla pozostałych suwaków
            }

            float wart = (float)suwak.Value / 10;

            Wpisz_wspolczynnik_k(labelka, wart,intSuwak);

        }
        private void Wpisz_wspolczynnik_k(Label labelka, float k, int numer_suwaka)
        {
            labelka.Visible = true;
            labelka.Text = "" + k;          //wpisuje na formatce do lbl_k_nrpPrzycisku
            tablica_k[numer_suwaka] = k;    //wpisuje to tabeli współczynników k
        }

        private void napelniacz_tablic(Button przycisk, int numer_przycisku, String sciezka, double[] tablica, Label licznik_wierszy, double[] tablica_gladka)
        {
            double dblwiersz;
            int licznik_linii = 0;
            double max_tablicy = 0;

            String linijka;
            System.IO.StreamReader file = new System.IO.StreamReader(sciezka);
            while ((linijka = file.ReadLine()) != null)
            {
                if (licznik_linii > 15) //napełniam tablicę dopiero od 16 linii nagłówka
                {//w linijce trzeba podmienić kropkę na przecinek
                    IFormatProvider FormatProvider = new System.Globalization.CultureInfo("");
                    bool Result = double.TryParse(linijka,
                        System.Globalization.NumberStyles.Float |
                        System.Globalization.NumberStyles.AllowThousands,
                        FormatProvider,
                        out dblwiersz);

                    tablica[licznik_linii - 15] = dblwiersz;
                }
                licznik_linii++;
            }
            licznik_wierszy.Text = "plik zawiera "+ (licznik_linii - 15) + " wierszy. ";
            //i to jest dobre miejsce by wrzucić liczebność pliku do tablicy_długości_plików:
            int dlugosc_tablicy = licznik_linii - 15;
            tablica_dlugosci_plikow[numer_przycisku] = dlugosc_tablicy;
            licznik_wierszy.Visible = true;
            
            for (int i = 0; i < dlugosc_tablicy; i++)//szukam najwyższego elementu czyli pmax
            {
                if (tablica[i] > max_tablicy)
                { max_tablicy = tablica[i];
                    tablica_i_maxow[numer_przycisku] = i;
                }
            }
            MessageBox.Show("Największy element tablicy to "+max_tablicy);

            //zapisać do tablicy pod "nr przycisku"
            tablica_maxow[numer_przycisku] = max_tablicy;
            file.Close();

            //znam pmax, obliczam p02 i p08
            double p02max=0, p08max=0;

            p02max = 0.2 * max_tablicy;
            p08max = 0.8 * max_tablicy;
            //gdzie one są? dla jakiego i
            for (int i = 0; i < dlugosc_tablicy; i++)//szukam elementu 0.2 pmax
            {
                if (tablica[i] > p02max)
                {
                    tablica_indeksowania_02_pmax[numer_przycisku] = i; break;
                }
            }
            MessageBox.Show("znalazłem p02 " + tablica_indeksowania_02_pmax[numer_przycisku]);

            for (int i = 0; i < dlugosc_tablicy; i++)//szukam elementu 0.8 pmax
            {
                if (tablica[i] > p08max)
                {
                    tablica_indeksowania_08_pmax[numer_przycisku] = i; break;
                }
            }
            MessageBox.Show("znalazłem p08 " + tablica_indeksowania_08_pmax[numer_przycisku]);
            tablica_w[numer_przycisku] = (tablica_indeksowania_08_pmax[numer_przycisku] - tablica_indeksowania_02_pmax[numer_przycisku]) / 60;
            //współczynnik w liczony jako różnica p08 - p02

            string strpzaplonu = txtBoxCisnZaplonu1.Text;
             double pzaplonu = Convert.ToDouble(strpzaplonu);
            //gdzie one są? dla jakiego i
            for (int i = 0; i < dlugosc_tablicy; i++)//szukam elementu p.zapł
            {
                if (tablica[i] > pzaplonu)
                {
                    tablica_indeksowania_pzaplonu[numer_przycisku] = i; break;
                }
            }
            MessageBox.Show("znalazłem i dla którego przekroczono p.zapłonu " + tablica_indeksowania_pzaplonu[numer_przycisku]);

            //################## WYKRESY ########################
            chart1.Series[numer_przycisku].IsVisibleInLegend = true;
            int[] tabelaX = new int[najw_dlug_plikow];
            chart1.Series[numer_przycisku].Points.DataBindXY(tabelaX, tablica);

            //Wygładzanie
            //for (int i = 0; i < dlugosc_tablicy; i++)

            //20180113
            
            for (int i = 0; i < dlugosc_tablicy; i++)
            {
                if (((i - 5 * tablica_w[numer_przycisku]) < 1) || (i + 5 * tablica_w[numer_przycisku] > dlugosc_tablicy))
                { tablica_gladka[i] = tablica[i]; }
                //wygładzanie rozpoczynam dopiero od [ns] elementu (czyli [5*w] elementu)
                //dla elementów bliżej krawędzi stosuję kopiowanie z tablicy do "gładkiej"
                // a w = tablica_w[numer_przycisku]
                else
                {
                    int ns = 5 * tablica_w[numer_przycisku];
                    double sum0 = 0.0, sum1 = 0.0;
                    for (int j = -(ns); j < (ns + 1); j++)
                    {
                        double j2_przez_ns2 = (double)(j * j) / (ns * ns);
                        //wykładnik musi być rzutowany na (double)
                        double aj = Math.Exp(-j2_przez_ns2);

                        sum0 += aj;
                        sum1 += aj * tablica[i + j];
                        /*
                        if (j % 10 == -1 || j % 10 == 1)
                        {
                            MessageBox.Show(" węzeł " + j + " aj = " + aj);
                        }
                        */
                    }
                    tablica_gladka[i] = sum1 / sum0;
                    //MessageBox.Show(" węzeł i-ty " +tablica_gladka[i]);
                    
                }
                
            }
            chart1.Series[numer_przycisku + 10].Points.DataBindXY(tabelaX, tablica_gladka);
            chart1.Series[numer_przycisku + 10].IsVisibleInLegend = true;
            String sciezka_sejw = "D:\\plik_gladki_" + button_11.Text + ".txt";
            //chart1.SaveImage(nazwa_pliku, ChartImageFormat.Jpeg);
            using (System.IO.StreamWriter zapis = new System.IO.StreamWriter(@"D:\w.txt"))
            {
                foreach (double wiersz in tablica_gladka)
                {
                    zapis.WriteLine(wiersz);
                }
            }
        }

        private void wczytywanie_Click(object sender, EventArgs e)
        {
            Button przycisk = (sender as Button);
            String nazwa_przycisku = przycisk.Name.ToString(); //który przycisk został wczytany

            String str_numer_przycisku;
            str_numer_przycisku = nazwa_przycisku.Substring(7, 2);
            //MessageBox.Show(str_numer_przycisku);

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "pliki danych od Bartka|*.txt";
            openFileDialog1.Title = "Bartek, podaj plik";
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                IFormatProvider FormatProvider = new System.Globalization.CultureInfo("");
                String sciezka = openFileDialog1.FileName;
                przycisk.Text = openFileDialog1.SafeFileName;
                //zmiana nazwy przycisku po wczytaniu tablicy
                przycisk.ForeColor = System.Drawing.Color.Blue;

                int numer_przycisku;
                numer_przycisku = Int32.Parse(str_numer_przycisku);

                double[] tablica=tablica_11; double[] tablica_gladka = tablica_gladka_11;
                //dlaczego 11? pierwsza z brzegu, w switchu i tak podmieniam na "tab_numer_przycisku"

                Label etykieta = label11;

                
            switch (numer_przycisku)
            {
                    case 11:
                        tablica = tablica_11; tablica_gladka = tablica_gladka_11; etykieta = label11; break;
                    case 12:
                        tablica = tablica_12; tablica_gladka = tablica_gladka_12; etykieta = label12; break;
                    case 13:
                        tablica = tablica_13; tablica_gladka = tablica_gladka_13; etykieta = label13; break;
                    case 14:
                        tablica = tablica_14; tablica_gladka = tablica_gladka_14; etykieta = label14; break;
                    case 15:
                        tablica = tablica_15; tablica_gladka = tablica_gladka_15; etykieta = label15; break;
                    case 16:
                        tablica = tablica_16; tablica_gladka = tablica_gladka_16; etykieta = label16; break;
                    case 17:
                        tablica = tablica_17; tablica_gladka = tablica_gladka_17; etykieta = label17; break;


                    case 21:
                        tablica = tablica_21; tablica_gladka = tablica_gladka_21; etykieta = label21; break;
                    case 22:
                        tablica = tablica_22; tablica_gladka = tablica_gladka_22; etykieta = label22; break;
                    case 23:
                        tablica = tablica_23; tablica_gladka = tablica_gladka_23; etykieta = label23; break;
                    case 24:
                        tablica = tablica_24; tablica_gladka = tablica_gladka_24; etykieta = label24; break;
                    case 25:
                        tablica = tablica_25; tablica_gladka = tablica_gladka_25; etykieta = label25; break;
                    case 26:
                        tablica = tablica_26; tablica_gladka = tablica_gladka_26; etykieta = label26; break;
                    case 27:
                        tablica = tablica_27; tablica_gladka = tablica_gladka_27; etykieta = label27; break;

            ///przygotować do wygładzania funkcji tablice_gladka
            ///############################################
            ///############################################
            ///############################################
            }

                napelniacz_tablic(przycisk, numer_przycisku, sciezka, tablica, etykieta, tablica_gladka);

                                
            }

        }

        private void btnKopiujDoPonizszych1_Click(object sender, EventArgs e)
        {
            numericUpDown12.Text = numericUpDown11.Text; //ustawia wszystkie dt równe temu nUD1 najwyżej
            numericUpDown13.Text = numericUpDown11.Text;
            numericUpDown14.Text = numericUpDown11.Text;
            numericUpDown15.Text = numericUpDown11.Text;
            numericUpDown16.Text = numericUpDown11.Text;
            numericUpDown17.Text = numericUpDown11.Text;
        }
        private void btnKopiujDoPonizszych2_Click(object sender, EventArgs e)
        {
            numericUpDown22.Text = numericUpDown21.Text; //ustawia wszystkie dt równe temu nUD21 najwyżej
            numericUpDown23.Text = numericUpDown21.Text;
            numericUpDown24.Text = numericUpDown21.Text;
            numericUpDown25.Text = numericUpDown21.Text;
            numericUpDown26.Text = numericUpDown21.Text;
            numericUpDown27.Text = numericUpDown21.Text;
        }
        /*
         private void btnKopiujDoPonizszych3_Click(object sender, EventArgs e)
        {
            numericUpDown32.Text = numericUpDown31.Text; //ustawia wszystkie dt równe temu nUD21 najwyżej
            numericUpDown33.Text = numericUpDown31.Text;
            numericUpDown34.Text = numericUpDown31.Text;
            numericUpDown35.Text = numericUpDown31.Text;
            numericUpDown36.Text = numericUpDown31.Text;
            numericUpDown37.Text = numericUpDown31.Text;
        } 
        private void btnKopiujDoPonizszych4_Click(object sender, EventArgs e)
        {
            numericUpDown42.Text = numericUpDown41.Text; //ustawia wszystkie dt równe temu nUD21 najwyżej
            numericUpDown43.Text = numericUpDown41.Text;
            numericUpDown44.Text = numericUpDown41.Text;
            numericUpDown45.Text = numericUpDown41.Text;
            numericUpDown46.Text = numericUpDown41.Text;
            numericUpDown47.Text = numericUpDown41.Text;
        }
        private void btnKopiujDoPonizszych5_Click(object sender, EventArgs e)
        {
            numericUpDown52.Text = numericUpDown51.Text; //ustawia wszystkie dt równe temu nUD21 najwyżej
            numericUpDown53.Text = numericUpDown51.Text;
            numericUpDown54.Text = numericUpDown51.Text;
            numericUpDown55.Text = numericUpDown51.Text;
            numericUpDown56.Text = numericUpDown51.Text;
            numericUpDown57.Text = numericUpDown51.Text;
        }
         */
        ///przygotować na sąsiednie zakładki 3-7
        ///############################################
        ///############################################
        ///############################################
        ///############################################

        private void btnZastosuj1_Click(object sender, EventArgs e)
        {
            krok_t_pliku[11] = Convert.ToDouble(numericUpDown11.Value);
            krok_t_pliku[12] = Convert.ToDouble(numericUpDown12.Value);
            krok_t_pliku[13] = Convert.ToDouble(numericUpDown13.Value);
            krok_t_pliku[14] = Convert.ToDouble(numericUpDown14.Value);
            krok_t_pliku[15] = Convert.ToDouble(numericUpDown15.Value);
            krok_t_pliku[16] = Convert.ToDouble(numericUpDown16.Value);
            krok_t_pliku[17] = Convert.ToDouble(numericUpDown17.Value);
            //
            tabPage1.Text = txtGestosc1.Text + " kg/m3";

            lista_maxow.Clear();

            MessageBox.Show("Max of tablica1 " + tablica_maxow[11] + Environment.NewLine
                + "max wystąpił dla " + tablica_i_maxow[11] + " wiersza."+ Environment.NewLine
                + " Max of tablica2 " + tablica_maxow[12] + Environment.NewLine
                + "max wystąpił dla " + tablica_i_maxow[12] + " wiersza." + Environment.NewLine
                + " Max of tablica3 " + tablica_maxow[13] + Environment.NewLine
                + "max wystąpił dla " + tablica_i_maxow[13] + " wiersza." + Environment.NewLine
                + " Max of tablica4 " + tablica_maxow[14] + Environment.NewLine
                + " Max of tablica5 " + tablica_maxow[15] + Environment.NewLine
                + " Max of tablica6 " + tablica_maxow[16] + Environment.NewLine
                + " Max of tablica7 " + tablica_maxow[17] + Environment.NewLine + Environment.NewLine+
                "Docelowo wyrzucę to okienko, ale tak mi łatwiej sprawdzać, czy spełniły się moje oczekiwania co do pracy programu", "Tytułem podsumowania", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("długość pliku nr1: " + tablica_dlugosci_plikow[11] + Environment.NewLine
                + "długość pliku nr2: " + tablica_dlugosci_plikow[12] + Environment.NewLine
                + "długość pliku nr3: " + tablica_dlugosci_plikow[13] + Environment.NewLine);
            for (int el = 11; el < 18; el++)    //pierwszy przycisk wybiera od 11 do 17
            { if (tablica_maxow[el]>1)  //kopiuj z tablicy do listy tylko jeśli ma "jakąś" wartość >1
                    lista_maxow.Add(tablica_maxow[el]);
                    //do obliczenia średniej potrzebuję liczności (n)
            }
            MessageBox.Show("Średnia maxow " + lista_maxow.Average()+ " obliczona z " + lista_maxow.Count+" wartości.");
        }

        private void btnZastosuj2_Click(object sender, EventArgs e)
        {
            krok_t_pliku[21] = Convert.ToDouble(numericUpDown21.Value);
            krok_t_pliku[22] = Convert.ToDouble(numericUpDown22.Value);
            krok_t_pliku[23] = Convert.ToDouble(numericUpDown23.Value);
            krok_t_pliku[24] = Convert.ToDouble(numericUpDown24.Value);
            krok_t_pliku[25] = Convert.ToDouble(numericUpDown25.Value);
            krok_t_pliku[26] = Convert.ToDouble(numericUpDown26.Value);
            krok_t_pliku[27] = Convert.ToDouble(numericUpDown27.Value);
            tabPage2.Text = txtGestosc2.Text + " kg/m3";

            lista_maxow.Clear();
            for (int el = 21; el < 28; el++)    //drugi przycisk wybiera od 21 do 27
            {
                if (tablica_maxow[el] > 1)  //kopiuj z tablicy do listy tylko jeśli ma "jakąś" wartość >1
                    lista_maxow.Add(tablica_maxow[el]);
            }
            MessageBox.Show("Średnia maxow " + lista_maxow.Average());
        }

///przygotować btnZastosuj 3-7 na sąsiednie zakładki 3-7
            ///############################################
            ///############################################
            ///############################################
            ///############################################

       
        private void btnSaveChart1_Click(object sender, EventArgs e)
        {
            string nazwa_pliku = "D:\\gęstość_" + txtGestosc1.Text + ".jpg";
            chart1.SaveImage(nazwa_pliku, ChartImageFormat.Jpeg);
            MessageBox.Show("Zapisałem plik pod nazwą " + nazwa_pliku);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("zapłon w pliku nr1 nastąpił w: " + tablica_indeksowania_pzaplonu[11] + Environment.NewLine
                + "zapłon w pliku nr2 nastąpił w: " + tablica_indeksowania_pzaplonu[12] + Environment.NewLine
                + "zapłon w pliku nr3 nastąpił w: " + tablica_indeksowania_pzaplonu[13] + Environment.NewLine + Environment.NewLine);
        }

        ///
        ///############################################
        ///############################################
        ///1. wykres powinien być wyświetlany wg czasu, nie [i] : krok_t_pliku[11]
        ///2. wygładzanie - wprowadzić 5*w*k
        ///3. wygładzanie - wprowadzić 
        ///############################################
        ///############################################
    }
}
