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
        // Aşağıdaki kodlar sayesinde sql veritabanı ile c# uygulaması arasında bağlantı kurulur ve veriler koltuknosuna göre sıralanır.
        void kayityap()
        {
            baglanti = new SqlConnection("Data Source=LAPTOP-VMNDQLS3;Initial Catalog=yolcu;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("Select *From kayıt Order By koltukno ASC", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            kayityap();
        }
          private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
          {
            
        }
        //Yolcu eklemek için aşağıdaki kod kullanılır
        private void button1_Click_2(object sender, EventArgs e)
        { 
            if (label2.Text == "00" ||textBox1.Text==""||textBox2.Text==""||maskedTextBox1.Text=="")
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz!");
            }
            else
            {
                string sorgu = "insert into kayıt(tarih,guzergah,koltukno,ad,soyad,telefon) values (@tarih,@guzergah,@koltukno,@ad,@soyad,@telefon)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@tarih", label6.Text);
                komut.Parameters.AddWithValue("@guzergah", label10.Text);
                komut.Parameters.AddWithValue("@koltukno", Convert.ToInt32(label2.Text));
                komut.Parameters.AddWithValue("@ad", textBox1.Text);
                komut.Parameters.AddWithValue("@soyad", textBox2.Text);
                komut.Parameters.AddWithValue("@telefon", maskedTextBox1.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                kayityap();
                textBox1.Clear();
                textBox2.Clear();
                maskedTextBox1.Clear();
                label2.Text = "00";
            }
        }
        //Yolcu silmek için aşağıdaki kod kullanılır
        private void button30_Click(object sender, EventArgs e)
        {

            string sorgu = "Delete From kayıt Where koltukno=@koltukno";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@koltukno",Convert.ToInt32(label2.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kayityap();
            textBox1.Clear();
            textBox2.Clear();
            maskedTextBox1.Clear();
            label2.Text = "00";
        }
        //Yolcu güncellemek için aşağıdaki kod kullanılır

        private void button29_Click(object sender, EventArgs e)
        {
            if (label2.Text == "00" || textBox1.Text == "" || textBox2.Text == "" || maskedTextBox1.Text == "")
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz!");
            }
            else
            {
                string sorgu = "update kayıt set ad=@ad,soyad=@soyad,telefon=@telefon Where koltukno=@koltukno";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@koltukno", Convert.ToInt32(label2.Text));
                komut.Parameters.AddWithValue("@ad", textBox1.Text);
                komut.Parameters.AddWithValue("@soyad", textBox2.Text);
                komut.Parameters.AddWithValue("@telefon", maskedTextBox1.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                kayityap();
                textBox1.Clear();
                textBox2.Clear();
                maskedTextBox1.Clear();
                label2.Text = "00";
            }
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
            label2.Text = "5";
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
            label2.Text = "13";
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
            label2.Text = "15";
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
            label2.Text ="1";
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
            label2.Text = "2";
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
            label2.Text = "3";
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
            label2.Text = "4";
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
            label2.Text = "6";
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
            label2.Text = "7";
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
            label2.Text = "8";
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
            label2.Text = "9";
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
            label2.Text = "10";
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
            label2.Text = "11";
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
            label2.Text = "12";
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
            label2.Text = "14";
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
            label2.Text = "16";
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
            label2.Text = "17";
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
            label2.Text = "18";
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
            label2.Text = "19";
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
            label2.Text = "20";
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
            label2.Text = "21";
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
            label2.Text = "22";
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
            label2.Text = "23";
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
            label2.Text = "24";
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
            label2.Text = "25";
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
            label2.Text = "26";
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
        //Aşağıdaki kodlar sayesinde yolcu bilgileri tabloya yazılmış olur
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            label6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            label10.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
