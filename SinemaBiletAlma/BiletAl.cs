using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SinemaBiletAlma
{
    public partial class BiletAl : Form
    {
        public BiletAl()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(LoginPanel.dbUrl);

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.Lime;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lime;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Lime;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Lime;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Lime;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Lime;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Lime;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Lime;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Lime;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Lime;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Lime;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.Lime;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.Lime;
        }
        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.Lime;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Lime;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Lime;
        }
        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.Lime;
        }
        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.Lime;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.Lime;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.Lime;
        }
        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.Lime;
        }
        private void button25_Click(object sender, EventArgs e)
        {
            button25.BackColor = Color.Lime;
        }
        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.Lime;
        }
        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackColor = Color.Lime;
        }
        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.Lime;
        }
        private void button21_Click_1(object sender, EventArgs e)
        {
            button21.BackColor = Color.Lime;
        }

        public string usrname = LoginPanel.username;
        public string filmadi;
        public int fiyat = 0;

        public void renktemizle()
        {
            button1.BackColor = Color.SeaGreen;
            button2.BackColor = Color.SeaGreen;
            button3.BackColor = Color.SeaGreen;
            button4.BackColor = Color.SeaGreen;
            button5.BackColor = Color.SeaGreen;
            button6.BackColor = Color.SeaGreen;
            button7.BackColor = Color.SeaGreen;
            button8.BackColor = Color.SeaGreen;
            button9.BackColor = Color.SeaGreen;
            button10.BackColor = Color.SeaGreen;
            button11.BackColor = Color.SeaGreen;
            button12.BackColor = Color.SeaGreen;
            button13.BackColor = Color.SeaGreen;
            button14.BackColor = Color.SeaGreen;
            button15.BackColor = Color.SeaGreen;
            button16.BackColor = Color.SeaGreen;
            button17.BackColor = Color.SeaGreen;
            button18.BackColor = Color.SeaGreen;
            button19.BackColor = Color.SeaGreen;
            button20.BackColor = Color.SeaGreen;
            button21.BackColor = Color.SeaGreen;
            button22.BackColor = Color.SeaGreen;
            button23.BackColor = Color.SeaGreen;
            button24.BackColor = Color.SeaGreen;
            button25.BackColor = Color.SeaGreen;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FilmEkrani filmEkrani = new FilmEkrani();
            filmEkrani.Show();
        }
        
        private void button26_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            SqlCommand kayit = new SqlCommand("insert into rezervasyonlar (username,filmad,sehir,seans,dil,tarih)" +
                "values(@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            kayit.Parameters.AddWithValue("@p1", usrname);
            kayit.Parameters.AddWithValue("@p2", filmadi);
            kayit.Parameters.AddWithValue("@p3",comboBoxsehir.Text);
            kayit.Parameters.AddWithValue("@p4",comboBoxseans.Text);
            kayit.Parameters.AddWithValue("@p5",comboBoxdil.Text);
            kayit.Parameters.AddWithValue("@p6",dateTimePicker1.Value.ToString());

            if(comboBoxsehir.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen şehir seçiniz.");
            }
            else if (comboBoxseans.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen seans seçiniz.");
            }
            else if (comboBoxdil.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen dil seçiniz.");
            }
            else
            {
                kayit.ExecuteNonQuery();
                MessageBox.Show("Bilet Başarıyla Alındı");
            }
            conn.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button2.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button3.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button4.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button5.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button6.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button7.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button8.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button9.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button10.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button11.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button12.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button13.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button14.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button15.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button16.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button17.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button18.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button19.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button20.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button21.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button21.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button22.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button23.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button24.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if (button25.BackColor == Color.Lime)
            {
                fiyat += 20;
            }
            if(fiyat<=60)
            {
                MessageBox.Show("Seçtiğiniz koltuklar için toplam fiyat: " + fiyat);
            }
            else
            {
                MessageBox.Show("Bir müşteri en fazla 3 adet bilet alabilir");
            }
            fiyat = 0;

            renktemizle();
        }

       
    }
}
