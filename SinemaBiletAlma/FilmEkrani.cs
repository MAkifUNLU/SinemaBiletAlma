using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBiletAlma
{
    public partial class FilmEkrani : Form
    {
        public FilmEkrani()
        {
            InitializeComponent();
        }

        private void FilmEkrani_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinemaBiletAlmaDataSet1.filmler' table. You can move, or remove it, as needed.
            this.filmlerTableAdapter.Fill(this.sinemaBiletAlmaDataSet1.filmler);

        }
        public int index;
        public void setIndex(int i)
        {
            index = i;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            setIndex(secilen);
            textBoxfilmad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxtur.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBoxzivyon.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBoxseans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secilen = index;
            Fragman fragman = new Fragman();
            
            if (secilen == 0)
            {
                fragman.url = "https://www.youtube.com/watch?v=7BG-BpvkYB8&t=3s";
            }
            else if (secilen == 1)
            {
                fragman.url = "https://www.youtube.com/watch?v=QAUuOfHmF2k";
            }
            else if (secilen == 2)
            {
                fragman.url = "https://www.youtube.com/watch?v=uPIEn0M8su0";
            }
            else if (secilen == 3)
            {
                fragman.url = "https://www.youtube.com/watch?v=hfa5F-kRTq4&t=1s";
            }
            else if (secilen == 4)
            {
                fragman.url = "https://www.youtube.com/watch?v=we_O2o8NJlI";
            }
            else if (secilen == 5)
            {
                fragman.url = "https://www.youtube.com/watch?v=bG668swkcBs";
            }
            else if (secilen == 6)
            {
                fragman.url = "https://www.youtube.com/watch?v=sTcgpq4mw6Y";
            }
            else if (secilen == 7)
            {
                fragman.url = "https://www.youtube.com/watch?v=fNT_Hs_YWA0&t=1s";
            }
            else if (secilen == 8)
            {
                fragman.url = "https://www.youtube.com/watch?v=i-vz6Wz0jTI";
            }
            fragman.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            int secilen = index;
            BiletAl biletAl = new BiletAl();
            biletAl.filmadi = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            biletAl.Show();
        }
    }
}
