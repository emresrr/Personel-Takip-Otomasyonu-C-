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
        private int hak = 5; // Kalan giriþ hakký
        private bool durum = false; // Giriþ durumu

        public static string tcno;
        public static string adi;
        public static string soyadi;
        public static string yetki;
        private string originalText = "";

        public frm_giris()
        {
            InitializeComponent();
            baglanti = new Baglanti(); // Veritabaný baðlantýsý baþlatýlýyor
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
                    baglanti.BaglantiyiAc(); // Veritabaný baðlantýsýný aç

                    // Veritabanýndan kullanýcýlarý sorgula
                    MySqlCommand sorgu = new MySqlCommand("SELECT * FROM kullanici", baglanti.GetConnection());
                    MySqlDataReader kayit_oku = sorgu.ExecuteReader();

                    // Veritabanýndaki her kaydý kontrol et
                    while (kayit_oku.Read())
                    {
                        // Kullanýcý adý, parola ve rol kontrolü
                        if (kayit_oku["kulAdi"].ToString() == txt_kulAdi.Text && kayit_oku["parola"].ToString() == txt_parola.Text)
                        {
                            // Kullanýcý yetkisini kontrol et
                            if (kayit_oku["rol"].ToString() == "Yönetici" && rb_yonetici.Checked)
                            {
                                durum = true;
                                tcno = kayit_oku["tcno"].ToString(); // TC no'yu al
                                adi = kayit_oku["adi"].ToString(); // Adý al
                                soyadi = kayit_oku["soyadi"].ToString(); // Soyadý al
                                yetki = kayit_oku["rol"].ToString(); // Yetkiyi al
                                this.Hide(); // Giriþ baþarýlýysa formu gizle
                                frm_islemler islemler = new frm_islemler();
                                islemler.Show(); // Yönetici ekranýna yönlendir
                                break; // Giriþ baþarýlýysa döngüyü sonlandýr
                            }
                            else if (kayit_oku["rol"].ToString() == "Kullanýcý" && rb_kullanici.Checked)
                            {
                                durum = true;
                                tcno = kayit_oku["tcno"].ToString(); // TC no'yu al
                                adi = kayit_oku["adi"].ToString(); // Adý al
                                soyadi = kayit_oku["soyadi"].ToString(); // Soyadý al
                                yetki = kayit_oku["rol"].ToString(); // Yetkiyi al
                                this.Hide(); // Giriþ baþarýlýysa formu gizle
                                frm_personel frm = new frm_personel();
                                frm.Show();
                                break; // Giriþ baþarýlýysa döngüyü sonlandýr
                            }
                        }
                    }

                    // Eðer giriþ baþarýsýzsa
                    if (durum == false)
                    {
                        hak--;
                        lbl_hak.Text = Convert.ToString(hak); // Kalan giriþ hakkýný güncelle
                        new uyari("Geçersiz kullanýcý adý, parola veya yetki.").ShowDialog();

                    }

                    // Hak 0 olursa, giriþ hakký bitmiþtir
                    if (hak == 0)
                    {
                        new uyari("Giriþ hakkýnýz bitmiþtir.").ShowDialog();
                        Application.Exit(); // Uygulamayý kapat
                    }

                    // Baðlantýyý kapat
                    baglanti.BaglantiyiKapat();
                }
            }
            catch (MySqlException mysqlEx)
            {
                // Veritabaný hatasý durumunda kullanýcýyý uyar
                MessageBox.Show("Veritabaný hatasý: " + mysqlEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Diðer hatalar için uyarý mesajý göster
                MessageBox.Show("Bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

