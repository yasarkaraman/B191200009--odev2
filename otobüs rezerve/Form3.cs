/****************************************************************************
**                                   SAKARYA ÜNİVERSİTESİ
**                           BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                            BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                             NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                   2019-2020 BAHAR DÖNEMİ
**
**                               ÖDEV NUMARASI..........:1
**                               ÖĞRENCİ ADI............:Yaşar ozan KARAMAN
**                               ÖĞRENCİ NUMARASI.......:B191200009   
**                               DERSİN ALINDIĞI GRUP...:A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otobüs_rezerve
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        static Double Kmhesap(double firstLat, double firstLng, double secondLat, double secondLng)
        {

            int Rk = 6373;

            double lat1, lon1, lat2, lon2, dlat, dlon, a, c, dk, km;

            lat1 = firstLat * Math.PI / 180;
            lon1 = firstLng * Math.PI / 180;
            lat2 = secondLat * Math.PI / 180;
            lon2 = secondLng * Math.PI / 180;

            dlat = lat2 - lat1;
            dlon = lon2 - lon1;

            a = Math.Pow(Math.Sin(dlat / 2), 2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Pow(Math.Sin(dlon / 2), 2);
            c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            dk = c * Rk;
            km = Math.Round(dk, 3);
            Console.WriteLine(km.ToString());
            return km;
        }


        private void button28_Click(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
            // Aşağıdaki kodlar sayesinde butona basıldığında her ilin enlem ve boylam değerleri comboBoxlardaki seçilen illerin enlem ve boylam bilgileri değişkenlere atanır.

            double tutar, km;
            double enlem1 = 0;
            double boylam1 = 0;
            double enlem2 = 0;
            double boylam2 = 0;
            string secim1 = comboBox3.Text;
            string secim2 = comboBox4.Text;

            if (comboBox3.Text == "Adana")
            {
                enlem1 = 37.00000000;
                boylam1 = 35.32133330;

            }
            else if (comboBox3.Text == "Ankara")
            {
                enlem1 = 39.92077000;
                boylam1 = 32.85411000;
            }

            else if (comboBox3.Text == "Adana")
            {
                enlem1 = 37.00000000;
                boylam1 = 35.32133330;
            }
            else if (comboBox3.Text == "Ankara")
            {
                enlem1 = 39.92077000;
                boylam1 = 32.85411000;
            }
            else if (comboBox3.Text == "Antalya")
            {
                enlem1 = 36.88414000;
                boylam1 = 30.70563000;
            }
            else if (comboBox3.Text == "Aydın")
            {
                enlem1 = 37.84440000;
                boylam1 = 27.84580000;
            }
            else if (comboBox3.Text == "Balıkesir")
            {
                enlem1 = 39.64836900;
                boylam1 = 27.88261000;
            }
            else if (comboBox3.Text == "Bursa")
            {
                enlem1 = 40.18257000;
                boylam1 = 29.06687000;
            }
            else if (comboBox3.Text == "Denizli")
            {
                enlem1 = 37.77652000;
                boylam1 = 29.08639000;
            }
            else if (comboBox3.Text == "Diyarbakır")
            {
                enlem1 = 37.91441000;
                boylam1 = 40.23062900;
            }
            else if (comboBox3.Text == "Erzurum")
            {
                enlem1 = 39.90431890;
                boylam1 = 41.26788530;
            }
            else if (comboBox3.Text == "Eskişehir")
            {
                enlem1 = 39.78430200;
                boylam1 = 30.51922000;
            }
            else if (comboBox3.Text == "Gaziantep")
            {
                enlem1 = 37.06622000;
                boylam1 = 37.38332000;
            }
            else if (comboBox3.Text == "Hatay")
            {
                enlem1 = 36.40184880;
                boylam1 = 36.34980970;
            }
            else if (comboBox3.Text == "İstanbul")
            {
                enlem1 = 41.00527000;
                boylam1 = 28.97696000;
            }
            else if (comboBox3.Text == "İzmir")
            {
                enlem1 = 38.41885000;
                boylam1 = 27.12872000;
            }
            else if (comboBox3.Text == "Kahramanmaraş")
            {
                enlem1 = 37.58333330;
                boylam1 = 36.93333330;
            }
            else if (comboBox3.Text == "Kayseri")
            {
                enlem1 = 38.73333330;
                boylam1 = 35.48333330;
            }
            else if (comboBox3.Text == "Kocaeli")
            {
                enlem1 = 40.85327040;
                boylam1 = 29.88152030;
            }
            else if (comboBox3.Text == "Konya")
            {
                enlem1 = 37.86666670;
                boylam1 = 32.48333330;
            }
            else if (comboBox3.Text == "Malatya")
            {
                enlem1 = 38.35519000;
                boylam1 = 38.30946000;
            }
            else if (comboBox3.Text == "Manisa")
            {
                enlem1 = 38.61909900;
                boylam1 = 27.42892100;
            }
            else if (comboBox3.Text == "Mardin")
            {
                enlem1 = 37.31223610;
                boylam1 = 40.73511200;
            }
            else if (comboBox3.Text == "Mersin")
            {
                enlem1 = 36.80000000;
                boylam1 = 34.63333330;
            }
            else if (comboBox3.Text == "Muğla")
            {
                enlem1 = 37.21527780;
                boylam1 = 28.36361110;
            }
            else if (comboBox3.Text == "Ordu")
            {
                enlem1 = 40.98333330;
                boylam1 = 37.88333330;
            }
            else if (comboBox3.Text == "Sakarya")
            {
                enlem1 = 40.75687930;
                boylam1 = 30.37813800;
            }
            else if (comboBox3.Text == "Samsun")
            {
                enlem1 = 41.29278200;
                boylam1 = 36.33128000;
            }
            else if (comboBox3.Text == "Şanlıurfa")
            {
                enlem1 = 37.15000000;
                boylam1 = 38.80000000;
            }
            else if (comboBox3.Text == "Tekirdağ")
            {
                enlem1 = 40.98333330;
                boylam1 = 27.51666670;
            }
            else if (comboBox3.Text == "Trabzon")
            {
                enlem1 = 41.00000000;
                boylam1 = 39.73333330;
            }
            else if (comboBox3.Text == "Van")
            {
                enlem1 = 39.73333330;
                boylam1 = 43.38000000;
            }
            if (comboBox4.Text == "Adana")
            {
                enlem2 = 37.00000000;
                boylam2 = 35.32133330;

            }
            else if (comboBox4.Text == "Ankara")
            {
                enlem2 = 39.92077000;
                boylam2 = 32.85411000;
            }

            else if (comboBox4.Text == "Adana")
            {
                enlem2 = 37.00000000;
                boylam2 = 35.32133330;
            }
            else if (comboBox4.Text == "Ankara")
            {
                enlem2 = 39.92077000;
                boylam2 = 32.85411000;
            }
            else if (comboBox4.Text == "Antalya")
            {
                enlem2 = 36.88414000;
                boylam2 = 30.70563000;
            }
            else if (comboBox4.Text == "Aydın")
            {
                enlem2 = 37.84440000;
                boylam2 = 27.84580000;
            }
            else if (comboBox4.Text == "Balıkesir")
            {
                enlem2 = 39.64836900;
                boylam2 = 27.88261000;
            }
            else if (comboBox4.Text == "Bursa")
            {
                enlem2 = 40.18257000;
                boylam2 = 29.06687000;
            }
            else if (comboBox4.Text == "Denizli")
            {
                enlem2 = 37.77652000;
                boylam2 = 29.08639000;
            }
            else if (comboBox4.Text == "Diyarbakır")
            {
                enlem2 = 37.91441000;
                boylam2 = 40.23062900;
            }
            else if (comboBox4.Text == "Erzurum")
            {
                enlem2 = 39.90431890;
                boylam2 = 41.26788530;
            }
            else if (comboBox4.Text == "Eskişehir")
            {
                enlem2 = 39.78430200;
                boylam2 = 30.51922000;
            }
            else if (comboBox4.Text == "Gaziantep")
            {
                enlem2 = 37.06622000;
                boylam2 = 37.38332000;
            }
            else if (comboBox4.Text == "Hatay")
            {
                enlem2 = 36.40184880;
                boylam2 = 36.34980970;
            }
            else if (comboBox4.Text == "İstanbul")
            {
                enlem2 = 41.00527000;
                boylam2 = 28.97696000;
            }
            else if (comboBox4.Text == "İzmir")
            {
                enlem2 = 38.41885000;
                boylam2 = 27.12872000;
            }
            else if (comboBox4.Text == "Kahramanmaraş")
            {
                enlem2 = 37.58333330;
                boylam2 = 36.93333330;
            }
            else if (comboBox4.Text == "Kayseri")
            {
                enlem2 = 38.73333330;
                boylam2 = 35.48333330;
            }
            else if (comboBox4.Text == "Kocaeli")
            {
                enlem2 = 40.85327040;
                boylam2 = 29.88152030;
            }
            else if (comboBox4.Text == "Konya")
            {
                enlem2 = 37.86666670;
                boylam2 = 32.48333330;
            }
            else if (comboBox4.Text == "Malatya")
            {
                enlem2 = 38.35519000;
                boylam2 = 38.30946000;
            }
            else if (comboBox4.Text == "Manisa")
            {
                enlem2 = 38.61909900;
                boylam2 = 27.42892100;
            }
            else if (comboBox4.Text == "Mardin")
            {
                enlem2 = 37.31223610;
                boylam2 = 40.73511200;
            }
            else if (comboBox4.Text == "Mersin")
            {
                enlem2 = 36.80000000;
                boylam2 = 34.63333330;
            }
            else if (comboBox4.Text == "Muğla")
            {
                enlem2 = 37.21527780;
                boylam2 = 28.36361110;
            }
            else if (comboBox4.Text == "Ordu")
            {
                enlem2 = 40.98333330;
                boylam2 = 37.88333330;
            }
            else if (comboBox4.Text == "Sakarya")
            {
                enlem2 = 40.75687930;
                boylam2 = 30.37813800;
            }
            else if (comboBox4.Text == "Samsun")
            {
                enlem2 = 41.29278200;
                boylam2 = 36.33128000;
            }
            else if (comboBox4.Text == "Şanlıurfa")
            {
                enlem2 = 37.15000000;
                boylam2 = 38.80000000;
            }
            else if (comboBox4.Text == "Tekirdağ")
            {
                enlem2 = 40.98333330;
                boylam2 = 27.51666670;
            }
            else if (comboBox4.Text == "Trabzon")
            {
                enlem2 = 41.00000000;
                boylam2 = 39.73333330;
            }
            else if (comboBox4.Text == "Van")
            {
                enlem2 = 39.73333330;
                boylam2 = 43.38000000;
            }
            //Aşağıdaki kodlar sayesinde kilometreye bağlı olarak tutar bulunur ve küsüratı atılır.
            km = Kmhesap(enlem1, boylam1, enlem2, boylam2);
            tutar = km / 7;
            tutar = Math.Round(tutar, 0);
            //Aşağıdaki kodlarda tutar kısmına radiobuttonlarda tekyön seçildiğinde tutarın kendisi gidiş-dönüş seçildiğinde tutarın 2 katının yazılması sağlanmıştır.
            if (radioButton3.Checked == true)
            {
                textBox1.Text = tutar.ToString();
            }
            if (radioButton4.Checked == true)
            {
                tutar = tutar * 2;
                textBox1.Text = tutar.ToString();
            }


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 rezerve = new Form2();
            rezerve.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 rezerve = new Form1();
            rezerve.Show();
            this.Hide();
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


