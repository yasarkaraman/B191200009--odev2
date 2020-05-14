/****************************************************************************
**                                   SAKARYA ÜNİVERSİTESİ
**                           BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                            BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                             NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                   2019-2020 BAHAR DÖNEMİ
**
**                               ÖDEV NUMARASI..........:2
**                               ÖĞRENCİ ADI............:Yaşar ozan KARAMAN
**                               ÖĞRENCİ NUMARASI.......:B191200009   
**                               DERSİN ALINDIĞI GRUP...:A
****************************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace otobüs_rezerve
{
    public partial class Form2 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        public Form2()
        {
            InitializeComponent();
        }
        void kayityap()
        {
            baglanti = new SqlConnection("Data Source=LAPTOP-VMNDQLS3;Initial Catalog=yolcu;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("Select *From kayit", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            kayityap();
        }
        //Yolcu eklemek için aşağıdaki kod kullanılır
        private void button1_Click_2(object sender, EventArgs e)
        {  //Aşağıdaki kodda ad,soyad ve telefon bilgileri tabloda yer alır.
            string sorgu = "insert into kayit(koltukno,ad,soyad,telefon) values (@koltukno,@ad,@soyad,@telefon)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@koltukno", Convert.ToInt32(textBox4.Text));
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@telefon", Convert.ToInt32(textBox3.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kayityap();

        }
        //Yolcu silmek için aşağıdaki kod kullanılır
        private void button30_Click(object sender, EventArgs e)
        {

            string sorgu = "Delete From kayit Where koltukno=@koltukno";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@koltukno", Convert.ToInt32(textBox4.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kayityap();
        }
        //Yolcu güncellemek için aşağıdaki kod kullanılır

        private void button29_Click(object sender, EventArgs e)
        {
            string sorgu = "update kayit set ad=@ad,soyad=@soyad,telefon=@telefon Where koltukno=@koltukno";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@koltukno", Convert.ToInt32(textBox4.Text));
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@telefon", Convert.ToInt32(textBox3.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kayityap();
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
            Form1 satıs = new Form1();
            satıs.Show();
            this.Hide();
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
        //Aşağıdaki kodlarda herbir koltuk butonuna cinsiyetine göre renk almasını sağlayan kodlar yazılmıştır.
        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button6.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button6.BackColor = Color.Red;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button10.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button10.BackColor = Color.Red;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button14.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button14.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button3.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button3.BackColor = Color.Red;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button2.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button2.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button5.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button5.BackColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button4.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button4.BackColor = Color.Red;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button7.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button7.BackColor = Color.Red;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button8.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button8.BackColor = Color.Red;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button9.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button9.BackColor = Color.Red;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button12.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button12.BackColor = Color.Red;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button13.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button13.BackColor = Color.Red;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button16.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button16.BackColor = Color.Red;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button17.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button17.BackColor = Color.Red;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button11.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button11.BackColor = Color.Red;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button15.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button15.BackColor = Color.Red;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button20.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button20.BackColor = Color.Red;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button21.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button21.BackColor = Color.Red;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button24.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button24.BackColor = Color.Red;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button25.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button25.BackColor = Color.Red;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.Blue; if (radioButton4.Checked == true)
            {
                button18.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button18.BackColor = Color.Red;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button19.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button19.BackColor = Color.Red;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button22.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button22.BackColor = Color.Red;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button23.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button23.BackColor = Color.Red;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button26.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button26.BackColor = Color.Red;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                button27.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked == true)
            {
                button27.BackColor = Color.Red;
            }
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
