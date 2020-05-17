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
using System.Windows.Forms;

namespace otobüs_rezerve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
        // Aşağıdaki kodlarda kullancı adı ve şifre sorgulaması yapılır.
        private void button1_Click_2(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123456")
            {
                Form3 rezerve = new Form3();
                rezerve.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Girdiniz.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }   
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
