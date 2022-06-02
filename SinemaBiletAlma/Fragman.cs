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
    public partial class Fragman : Form
    {
        public string url;
        public Fragman()
        {
        InitializeComponent();
            
        }

        private void Fragman_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(url);
        }
    }
}
