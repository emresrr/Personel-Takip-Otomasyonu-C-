using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using personel_takip;
using System.Drawing;
using System.Drawing.Configuration;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using personel_takip.UI;

namespace personel_takip
{
    public partial class frm_giris : Form
    {
        private Baglanti baglanti;
        private int hak = 5; // Kalan giri� hakk�
        private bool durum = false; // Giri� durumu

        public static string tcno;
        public static string adi;
        public static string soyadi;
        public static string yetki;
        private string originalText = "";

        public frm_giris()
        {
            InitializeComponent();
            baglanti = new Baglanti(); // Veritaban� ba�lant�s� ba�lat�l�yor
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                if (hak != 0)
                {
                    baglanti.BaglantiyiAc(); // Veritaban� ba�lant�s�n� a�

                    // Veritaban�ndan kullan�c�lar� sorgula
                    MySqlCommand sorgu = new MySqlCommand("SELECT * FROM kullanici", baglanti.GetConnection());
                    MySqlDataReader kayit_oku = sorgu.ExecuteReader();

                    // Veritaban�ndaki her kayd� kontrol et
                    while (kayit_oku.Read())
                    {
                        // Kullan�c� ad�, parola ve rol kontrol�
                        if (kayit_oku["kulAdi"].ToString() == txt_kulAdi.Text && kayit_oku["parola"].ToString() == txt_parola.Text)
                        {
                            // Kullan�c� yetkisini kontrol et
                            if (kayit_oku["rol"].ToString() == "Y�netici" && rb_yonetici.Checked)
                            {
                                durum = true;
                                tcno = kayit_oku["tcno"].ToString(); // TC no'yu al
                                adi = kayit_oku["adi"].ToString(); // Ad� al
                                soyadi = kayit_oku["soyadi"].ToString(); // Soyad� al
                                yetki = kayit_oku["rol"].ToString(); // Yetkiyi al
                                this.Hide(); // Giri� ba�ar�l�ysa formu gizle
                                frm_islemler islemler = new frm_islemler();
                                islemler.Show(); // Y�netici ekran�na y�nlendir
                                break; // Giri� ba�ar�l�ysa d�ng�y� sonland�r
                            }
                            else if (kayit_oku["rol"].ToString() == "Kullan�c�" && rb_kullanici.Checked)
                            {
                                durum = true;
                                tcno = kayit_oku["tcno"].ToString(); // TC no'yu al
                                adi = kayit_oku["adi"].ToString(); // Ad� al
                                soyadi = kayit_oku["soyadi"].ToString(); // Soyad� al
                                yetki = kayit_oku["rol"].ToString(); // Yetkiyi al
                                this.Hide(); // Giri� ba�ar�l�ysa formu gizle
                                frm_personel frm = new frm_personel();
                                frm.Show();
                                break; // Giri� ba�ar�l�ysa d�ng�y� sonland�r
                            }
                        }
                    }

                    // E�er giri� ba�ar�s�zsa
                    if (durum == false)
                    {
                        hak--;
                        lbl_hak.Text = Convert.ToString(hak); // Kalan giri� hakk�n� g�ncelle
                        new uyari("Ge�ersiz kullan�c� ad�, parola veya yetki.").ShowDialog();

                    }

                    // Hak 0 olursa, giri� hakk� bitmi�tir
                    if (hak == 0)
                    {
                        new uyari("Giri� hakk�n�z bitmi�tir.").ShowDialog();
                        Application.Exit(); // Uygulamay� kapat
                    }

                    // Ba�lant�y� kapat
                    baglanti.BaglantiyiKapat();
                }
            }
            catch (MySqlException mysqlEx)
            {
                // Veritaban� hatas� durumunda kullan�c�y� uyar
                MessageBox.Show("Veritaban� hatas�: " + mysqlEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Di�er hatalar i�in uyar� mesaj� g�ster
                MessageBox.Show("Bir hata olu�tu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_giris_MouseEnter(object sender, EventArgs e)
        {

            btn_giris.BackColor = Color.MediumSlateBlue;
            btn_giris.ForeColor = Color.White;
            
        }

        private void btn_giris_MouseLeave(object sender, EventArgs e)
        {
            btn_giris.BackColor = Color.White; 
            btn_giris.ForeColor = Color.Black;
            

        }

        private void btn_cikis_MouseEnter(object sender, EventArgs e)
        {
            btn_cikis.BackColor = Color.MediumSlateBlue;
            btn_cikis.ForeColor = Color.White;

        }
        private void btn_cikis_MouseLeave(object sender, EventArgs e)
        {
            btn_cikis.BackColor = Color.White;
            btn_cikis.ForeColor = Color.Black;
            
        }

        private void btn_exit_MouseEnter(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.IndianRed;
            btn_exit.ForeColor = Color.White;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.BackColor = Color.White;
            btn_exit.ForeColor = Color.Black;
        }
    }
}

