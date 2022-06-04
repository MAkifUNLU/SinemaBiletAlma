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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(LoginPanel.dbUrl);
        private void button1_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            SqlCommand register = new SqlCommand("insert into login (ad,soyad,username,password)" +
                "values(@p1,@p2,@p3,@p4)", conn);
            register.Parameters.AddWithValue("@p1", textBoxad.Text.Trim());
            register.Parameters.AddWithValue("@p2", textBoxsoyad.Text.Trim());
            register.Parameters.AddWithValue("@p3", textBoxusername.Text.Trim());
            register.Parameters.AddWithValue("@p4", textBoxpassword.Text.Trim());
            if (textBoxusername.Text.Trim() == "")
            {
                MessageBox.Show("Kullanici adi giriniz");
            }
            else if (textBoxpassword.Text.Trim() == "")
            {
                MessageBox.Show("Sifre giriniz");
            }
            else if (textBoxad.Text.Trim() == "")
            {
                MessageBox.Show("Ad giriniz");
            }
            else if (textBoxsoyad.Text.Trim() == "")
            {
                MessageBox.Show("Soyad giriniz");
            }
            else
            {
                register.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarılı\n Giriş sayfasına dönülüyor");
                this.Hide();
                LoginPanel loginPanel = new LoginPanel();
                loginPanel.Show();
            }

            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPanel loginPanel = new LoginPanel();
            loginPanel.Show();
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {

        }

        private void textBoxad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
