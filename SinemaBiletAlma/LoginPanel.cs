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
using System.IO;
using System.Configuration;

namespace SinemaBiletAlma
{
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
           
        }
        public static string username;
        public string getusrname(string str)
        {
            username = str;
            return username;
        }
        public static string dbUrl;
        public void setDburl(string str)
        {
            dbUrl = str;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string link;
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                link = sr.ReadLine();
                setDburl(link);
                MessageBox.Show(dbUrl); 
                
            }
        }

        SqlConnection conn;

        private void button1_Click(object sender, EventArgs e)
        {
            if (dbUrl == null)
            {
                MessageBox.Show("Veritabanı yok");
            }
            else
            {
            conn = new SqlConnection(dbUrl);
            conn.Open();

            SqlCommand login = new SqlCommand("Select * from login where username = @p1 and password = @p2", conn);
            login.Parameters.AddWithValue("@p1", textBoxusername.Text);
            login.Parameters.AddWithValue("@p2", textBoxpassword.Text);

            //kullanıcı adını alma
            getusrname(textBoxusername.Text);
            SqlDataReader dr = login.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("giriş başarılı");
                this.Hide();
                FilmEkrani filmEkrani = new FilmEkrani();
                filmEkrani.Show();
            }
            else
            {
                MessageBox.Show("Giriş başarısız");
            }
            conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dbUrl == null)
            {
                MessageBox.Show("Veritabanı yok");
            }
            else
            {
                this.Hide();
                KayitOl kayitOl = new KayitOl();
                kayitOl.Show();
            }
        }

        private void bagla_Click(object sender, EventArgs e)
        {

        }

        
    }
}
