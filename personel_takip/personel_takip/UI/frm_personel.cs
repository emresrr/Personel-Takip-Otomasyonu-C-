using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using personel_takip;
using personel_takip.UI;


namespace personel_takip
{
    public partial class frm_personel : Form
    {
        public frm_personel()
        {
            InitializeComponent();
        }

        Baglanti baglantim = new Baglanti();

        private void personelleri_goster()
        {
            MySqlConnection bagla = baglantim.GetConnection();
            try
            {
                baglantim.BaglantiyiAc();
                string query = "SELECT tcno AS 'TC NO'," +
                    " adi AS 'AD', " +
                    "soyadi AS 'SOYAD'," +
                    " cinsiyet AS 'CİNSİYET'," +
                    " mezuniyet AS 'MEZUNİYET'," +
                    " dogum AS 'DOĞUM TARİHİ'," +
                    " gorev AS 'GÖREV', " +
                    "gorevYeri AS 'GÖREV YERİ'," +
                    " maas AS 'MAAŞ' FROM personel" +
                    " ORDER BY tcno ASC";

                MySqlDataAdapter da = new MySqlDataAdapter(query, bagla);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgw_personel.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglantim.BaglantiyiKapat();
            }
        }

        private void personel_ara()
        {
            MySqlConnection bagla = baglantim.GetConnection();
            try
            {
                baglantim.BaglantiyiAc();
                string sorgu = "SELECT * FROM personel WHERE tcno=@tcno";
                MySqlCommand cmd = new MySqlCommand(sorgu, bagla);
                cmd.Parameters.AddWithValue("@tcno", txt_tcno.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txt_ad.Text = reader["adi"].ToString();
                    txt_soyad.Text = reader["soyadi"].ToString();
                    txt_cinsiyet.Text = reader["cinsiyet"].ToString();
                    txt_mezun.Text = reader["mezuniyet"].ToString();
                    txt_gorev.Text = reader["gorev"].ToString();
                    txt_gYeri.Text = reader["gorevYeri"].ToString();
                    txt_maas.Text = reader["maas"].ToString();

                    lbl_izlenen.Text = txt_ad.Text + " " + txt_soyad.Text;

                    // 📌 Doğum tarihini Label'a yazdır
                    if (reader["dogum"] != DBNull.Value)
                    {
                        txt_dogum.Text = Convert.ToDateTime(reader["dogum"]).ToString("dd.MM.yyyy");
                    }
                    else
                    {
                        txt_dogum.Text = "Bilinmiyor";
                    }
                }
                else
                {
                    new uyari("Bu kimlik numarasına ait personel bulunamadı!").ShowDialog();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglantim.BaglantiyiKapat();
            }
        }

        public void giren_resmi_getir()
        {
            try
            {
                // Resmin dosya yolu
                string resimYoluJpg = Path.Combine(Application.StartupPath, "img", frm_giris.tcno + ".jpg");
                string resimYoluPng = Path.Combine(Application.StartupPath, "img", frm_giris.tcno + ".png");

                // Dosyaların varlığını kontrol et
                if (File.Exists(resimYoluJpg))
                {
                    // Eğer .jpg varsa, resmi yükle
                    picb_giren.Image = Image.FromFile(resimYoluJpg);
                }
                else if (File.Exists(resimYoluPng))
                {
                    // Eğer .png varsa, resmi yükle
                    picb_giren.Image = Image.FromFile(resimYoluPng);
                }
                else
                {
                    // Varsayılan resim de yoksa, hata mesajı göster
                    new uyari("Varsayılan resim dosyası bulunamadı!").ShowDialog();


                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya mesaj göster
                new uyari("Resim yüklenemedi. ").ShowDialog();
            }

        }

        public void personel_resim_getir()
        {
            try
            {
                // TC Kimlik Numarasını Al
                string tcNo = txt_tcno.Text.Trim();

                // Eğer TC boşsa işlemi iptal et
                if (string.IsNullOrEmpty(tcNo))
                {
                    picb_izlenen.Image = null; // Resmi temizle
                    return;
                }

                // Resim dosya yollarını belirle
                string resimKlasoru = Path.Combine(Application.StartupPath, "img");
                string resimYoluJpg = Path.Combine(resimKlasoru, tcNo + ".jpg");
                string resimYoluPng = Path.Combine(resimKlasoru, tcNo + ".png");

                // Mevcut resmi temizle (Bellek kilitlenmesini önler)
                if (picb_izlenen.Image != null)
                {
                    picb_izlenen.Image.Dispose();
                    picb_izlenen.Image = null;
                }

                // Resmi yükle
                if (File.Exists(resimYoluJpg))
                {
                    using (FileStream fs = new FileStream(resimYoluJpg, FileMode.Open, FileAccess.Read))
                    {
                        picb_izlenen.Image = Image.FromStream(fs);
                    }
                }
                else if (File.Exists(resimYoluPng))
                {
                    using (FileStream fs = new FileStream(resimYoluPng, FileMode.Open, FileAccess.Read))
                    {
                        picb_izlenen.Image = Image.FromStream(fs);
                    }
                }
                else
                {
                    picb_izlenen.Image = null; // Resim yoksa temizle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Resim yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            personel_resim_getir();
            personel_ara();
        }

        private void frm_personel_Load(object sender, EventArgs e)
        {
            lbl_giren.Text = frm_giris.adi + " " + frm_giris.soyadi;
            giren_resmi_getir();
            personelleri_goster();
        }

        private void dgw_personel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0) // Eğer geçerli bir satırsa
            {
                personel_resim_getir();

                txt_tcno.Text = dgw_personel.Rows[rowIndex].Cells[0].Value.ToString();
                txt_ad.Text = dgw_personel.Rows[rowIndex].Cells[1].Value.ToString();
                txt_soyad.Text = dgw_personel.Rows[rowIndex].Cells[2].Value.ToString();
                txt_mezun.Text = dgw_personel.Rows[rowIndex].Cells[4].Value.ToString();
                txt_gorev.Text = dgw_personel.Rows[rowIndex].Cells[6].Value.ToString();
                txt_gYeri.Text = dgw_personel.Rows[rowIndex].Cells[7].Value.ToString();
                txt_maas.Text = dgw_personel.Rows[rowIndex].Cells[8].Value.ToString();

                // Cinsiyet bilgisi
                txt_cinsiyet.Text = dgw_personel.Rows[rowIndex].Cells[3].Value.ToString();
                lbl_izlenen.Text = txt_ad.Text + " " + txt_soyad.Text;

                // Doğum tarihi bilgisi
                if (dgw_personel.Rows[rowIndex].Cells[5].Value != DBNull.Value)
                {
                    txt_dogum.Text = Convert.ToDateTime(dgw_personel.Rows[rowIndex].Cells[5].Value).ToString("dd.MM.yyyy");
                }
                else
                {
                    txt_dogum.Text = "Bilinmiyor";
                }

            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ara_MouseEnter(object sender, EventArgs e)
        {
            btn_ara.ForeColor = Color.White;
            btn_ara.BackColor = Color.CornflowerBlue;
        }

        private void btn_ara_MouseLeave(object sender, EventArgs e)
        {
            btn_ara.ForeColor = Color.Black;
            btn_ara.BackColor = Color.White;
        }

        private void btn_exit_MouseEnter(object sender, EventArgs e)
        {
            btn_exit.ForeColor = Color.White;
            btn_exit.BackColor = Color.IndianRed;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.ForeColor = Color.Black;
            btn_exit.BackColor = Color.White;
        }
    }
}
