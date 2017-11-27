using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zakladki01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //tabControl1.SelectedIndexChanged
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void wczytywanie_Click(object sender, EventArgs e)
        {
            Button przycisk = (sender as Button);
            MessageBox.Show(przycisk.Name.ToString());
            //if (przycisk.Name.ToString() == button3)
            //{ }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "pliki danych od Bartka|*.txt";
            openFileDialog1.Title = "Bartek, podaj plik";
            IFormatProvider FormatProvider =  new System.Globalization.CultureInfo("");

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                { 
                String sciezka_1_1 = openFileDialog1.FileName;
                
                button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft; //zmieniam napis na przycisku
                button1.Text = openFileDialog1.SafeFileName;
                button1.ForeColor = System.Drawing.Color.Blue;

                String linijka;
                double[] tablica_1_1 = new double[50000];
                double dblwiersz;
                long licznik_linii=0;

                System.IO.StreamReader file = new System.IO.StreamReader(sciezka_1_1);
                while ((linijka = file.ReadLine()) != null)
                {
                    //MessageBox.Show("linijka " + licznik_linii+ " " +linijka); czytam nagłówek
                    if (licznik_linii > 15) //napełniam tablicę dopiero od 16 linii nagłówka
                    {//w linijce trzeba podmienić kropkę na przecinek
                        bool Result = double.TryParse(linijka, 
                            System.Globalization.NumberStyles.Float | 
                            System.Globalization.NumberStyles.AllowThousands,
                            FormatProvider,
                            out dblwiersz);

                        tablica_1_1[licznik_linii-15] = dblwiersz;
                        //MessageBox.Show("linijka jako String = " + linijka + "\n wiersz double = " + tablica_1_1[licznik_linii-15] + "\n jako " + (licznik_linii-15) + " element tablicy");
                    }
                        licznik_linii++;
                }
                file.Close();
                MessageBox.Show("wczytałem tablicę o " + (licznik_linii - 15) + " elementach");
            }
            //openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown2.Text = numericUpDown1.Text; //ustawia wszystkie dt równe temu nUD1 najwyżej
            numericUpDown3.Text = numericUpDown1.Text;
            numericUpDown4.Text = numericUpDown1.Text;
            numericUpDown5.Text = numericUpDown1.Text;
            numericUpDown6.Text = numericUpDown1.Text;
            numericUpDown7.Text = numericUpDown1.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double h_1_1, h_1_2, h_1_3, h_1_4, h_1_5, h_1_6, h_1_7;
            h_1_1 = Convert.ToDouble(numericUpDown1.Value);
            h_1_2 = Convert.ToDouble(numericUpDown2.Value);
            h_1_3 = Convert.ToDouble(numericUpDown3.Value);
            h_1_4 = Convert.ToDouble(numericUpDown4.Value);
            h_1_5 = Convert.ToDouble(numericUpDown5.Value);
            h_1_6 = Convert.ToDouble(numericUpDown6.Value);
            h_1_7 = Convert.ToDouble(numericUpDown7.Value);
            //
            tabPage1.Text = textBox1.Text+" kg/m3";
            String napis = Convert.ToString(h_1_1);
            MessageBox.Show(napis);
        }
        //private void tabControl1.SelectedIndexChanged(object sender, EventArgs e)
        //{ }

    }
}
