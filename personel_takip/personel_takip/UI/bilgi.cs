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
    public partial class bilgi : Form
    {
        public bilgi(string bilgi)
        {
            InitializeComponent();
            lbl_bilgi.Text = bilgi;
        }


        private void btn_tamam_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
