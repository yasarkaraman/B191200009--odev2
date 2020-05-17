/****************************************************************************
**                                   SAKARYA ÜNİVERSİTESİ
**                           BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                            BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                             NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                   2019-2020 BAHAR DÖNEMİ
**
**                               PROJE NUMARASI.........:01
**                               ÖĞRENCİ ADI............:Yaşar ozan KARAMAN
**                               ÖĞRENCİ NUMARASI.......:B191200009   
**                               DERSİN ALINDIĞI GRUP...:A
****************************************************************************/
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace otobüs_rezerve
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            // Aşağıdaki kodlar sayesinde butona basıldığında her ilin enlem ve boylam değerleri comboBoxlardaki seçilen illerin enlem ve boylam bilgileri değişkenlere atanır.

            double tutar, km;
            double enlem1 = 0;
            double boylam1 = 0;
            double enlem2 = 0;
            double boylam2 = 0;
            string secim1 = comboBox1.Text;
            string secim2 = comboBox2.Text;
            switch (comboBox1.Text)
            {
                case "Adana":
                    enlem1 = 37.00000000;
                    boylam1 = 35.32133330;
                    break;
                case "Ankara":
                    enlem1 = 39.92077000;
                    boylam1 = 32.85411000;
                    break;
                case "Antalya":
                    enlem1 = 36.88414000;
                    boylam1 = 30.70563000;
                    break;
                case "Aydın":
                    enlem1 = 37.84440000;
                    boylam1 = 27.84580000;
                    break;
                case "Balıkesir":
                    enlem1 = 39.64836900;
                    boylam1 = 27.88261000;
                    break;
                case "Bursa":
                    enlem1 = 40.18257000;
                    boylam1 = 29.06687000;
                    break;
                case "Denizli":
                    enlem1 = 37.77652000;
                    boylam1 = 29.08639000;
                    break;
                case "Diyarbakır":
                    enlem1 = 37.91441000;
                    boylam1 = 40.23062900;
                    break;
                case "Erzurum":
                    enlem1 = 39.90431890;
                    boylam1 = 41.26788530;
                    break;
                case "Eskişehir":
                    enlem1 = 39.78430200;
                    boylam1 = 30.51922000;
                    break;
                case "Gaziantep":
                    enlem1 = 37.06622000;
                    boylam1 = 37.38332000;
                    break;
                case "Hatay":
                    enlem1 = 36.40184880;
                    boylam1 = 36.34980970;
                    break;
                case "İstanbul":
                    enlem1 = 41.00527000;
                    boylam1 = 28.97696000;
                    break;
                case "İzmir":
                    enlem1 = 38.41885000;
                    boylam1 = 27.12872000;
                    break;
                case "Kahramanmaraş":
                    enlem1 = 37.58333330;
                    boylam1 = 36.93333330;
                    break;
                case "Kayseri":
                    enlem1 = 38.73333330;
                    boylam1 = 35.48333330;
                    break;
                case "Kocaeli":
                    enlem1 = 40.85327040;
                    boylam1 = 29.88152030;
                    break;
                case "Konya":
                    enlem1 = 37.86666670;
                    boylam1 = 32.48333330;
                    break;
                case "Malatya":
                    enlem1 = 38.35519000;
                    boylam1 = 38.30946000;
                    break;
                case "Manisa":
                    enlem1 = 38.61909900;
                    boylam1 = 27.42892100;
                    break;
                case "Mardin":
                    enlem1 = 37.31223610;
                    boylam1 = 40.73511200;
                    break;
                case "Mersin":
                    enlem1 = 36.80000000;
                    boylam1 = 34.63333330;
                    break;
                case "Muğla":
                    enlem1 = 37.21527780;
                    boylam1 = 28.36361110;
                    break;
                case "Ordu":
                    enlem1 = 40.98333330;
                    boylam1 = 37.88333330;
                    break;
                case "Sakarya":
                    enlem1 = 40.75687930;
                    boylam1 = 30.37813800;
                    break;
                case "Samsun":
                    enlem1 = 41.29278200;
                    boylam1 = 36.33128000;
                    break;
                case "Şanlıurfa":
                    enlem1 = 37.15000000;
                    boylam1 = 38.80000000;
                    break;
                case "Tekirdağ":
                    enlem1 = 40.98333330;
                    boylam1 = 27.51666670;
                    break;
                case "Trabzon":
                    enlem1 = 41.00000000;
                    boylam1 = 39.73333330;
                    break;
                case "Van":
                    enlem1 = 39.73333330;
                    boylam1 = 43.38000000;
                    break;
                default:
                    break;
            }
            switch(comboBox2.Text)
            {
                case "Adana":
                    enlem2 = 37.00000000;
                boylam2 = 35.32133330;
                break;
                case "Ankara":
                    enlem2 = 39.92077000;
                boylam2 = 32.85411000;
                break;
                case "Antalya":
                    enlem2 = 36.88414000;
                boylam2 = 30.70563000;
                break;
                case "Aydın":
                    enlem2 = 37.84440000;
                boylam2 = 27.84580000;
                break;
                case "Balıkesir":
                    enlem2 = 39.64836900;
                boylam2 = 27.88261000;
                break;
                case "Bursa":
                    enlem2 = 40.18257000;
                boylam2 = 29.06687000;
                break;
                case "Denizli":
                    enlem2 = 37.77652000;
                boylam2 = 29.08639000;
                break;
                case "Diyarbakır":
                    enlem2 = 37.91441000;
                boylam2 = 40.23062900;
                break;
                case "Erzurum":
                    enlem2 = 39.90431890;
                boylam2 = 41.26788530;
                break;
                case "Eskişehir":
                    enlem2 = 39.78430200;
                boylam2 = 30.51922000;
                break;
                case "Gaziantep":
                    enlem2 = 37.06622000;
                boylam2 = 37.38332000;
                break;
                case "Hatay":
                    enlem2 = 36.40184880;
                boylam2 = 36.34980970;
                break;
                case "İstanbul":
                    enlem2 = 41.00527000;
                boylam2 = 28.97696000;
                break;
                case "İzmir":
                    enlem2 = 38.41885000;
                boylam2 = 27.12872000;
                break;
                case "Kahramanmaraş":
                    enlem2 = 37.58333330;
                boylam2 = 36.93333330;
                break;
                case "Kayseri":
                    enlem2 = 38.73333330;
                boylam2 = 35.48333330;
                break;
                case "Kocaeli":
                    enlem2 = 40.85327040;
                boylam2 = 29.88152030;
                break;
                case "Konya":
                    enlem2 = 37.86666670;
                boylam2 = 32.48333330;
                break;
                case "Malatya":
                    enlem2 = 38.35519000;
                boylam2 = 38.30946000;
                break;
                case "Manisa":
                    enlem2 = 38.61909900;
                boylam2 = 27.42892100;
                break;
                case "Mardin":
                    enlem2 = 37.31223610;
                boylam2 = 40.73511200;
                break;
                case "Mersin":
                    enlem2 = 36.80000000;
                boylam2 = 34.63333330;
                break;
                case "Muğla":
                    enlem2 = 37.21527780;
                boylam2 = 28.36361110;
                break;
                case "Ordu":
                    enlem2 = 40.98333330;
                boylam2 = 37.88333330;
                break;
                case "Sakarya":
                    enlem2 = 40.75687930;
                boylam2 = 30.37813800;
                break;
                case "Samsun":
                    enlem2 = 41.29278200;
                boylam2 = 36.33128000;
                break;
                case "Şanlıurfa":
                    enlem2 = 37.15000000;
                boylam2 = 38.80000000;
                break;
                case "Tekirdağ":
                    enlem2 = 40.98333330;
                boylam2 = 27.51666670;
                break;
                case "Trabzon":
                    enlem2 = 41.00000000;
                boylam2 = 39.73333330;
                break;
                case "Van":
                    enlem2 = 39.73333330;
                boylam2 = 43.38000000;
                break;
                default:
                    break;
            }
           
            //Aşağıdaki kodlar sayesinde kilometreye bağlı olarak tutar bulunur ve küsüratı atılır.
            km = Kmhesap(enlem1, boylam1, enlem2, boylam2);
            tutar = km / 7;
            tutar = Math.Round(tutar, 0);
            label6.Text =tutar.ToString();
            
        }
        // Aşağıdaki fonksiyon sayesinde atanan değerler ile kilometre hesabı yapılıyor
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {



        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {


        }

    
      

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
        //Aşağıdaki kod sayesinde diğer forma veri aktarımı olur ve diğer forma geçilir.
        private void button1_Click(object sender, EventArgs e)
        {
            if (label6.Text == "0")
            {
                MessageBox.Show("Lütfen şehir bilgilerini girip hesapla butonuna bastıkdan sonra onaylaya basınız");

            }
            else {
                Form2 frm2 = new Form2();
                frm2.label6.Text = Convert.ToString(dateTimePicker1.Value);
                frm2.Show();
                this.Hide();
                frm2.label10.Text = "" + comboBox1.Text + "-" + comboBox2.Text + "";
                frm2.label11.Text = label6.Text;
                    
            }
            
        }
        // Aşağıdaki kod sayesinde işlem iptal edilmesi durumunda başlangıç formuna dönmeyi sağlar.
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 giris = new Form1();
            giris.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
