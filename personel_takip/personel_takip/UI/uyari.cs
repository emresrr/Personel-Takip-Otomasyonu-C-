using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personel_takip.UI
{
    public partial class uyari : Form
    {
        public uyari(string uyari)
        {
            InitializeComponent();
            lbl_uyari.Text = uyari;
        }

        private void btn_tamam_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
    }
}
