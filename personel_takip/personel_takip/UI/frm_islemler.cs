using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using personel_takip;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;
using personel_takip.UI;


namespace personel_takip
{
    public partial class frm_islemler : Form
    {
        public frm_islemler()
        {
            InitializeComponent();

        }

        Baglanti baglantim = new Baglanti();

        int parola_skoru = 0;
        string yetki = "";
        string cinsiyet = "";

        private void kullanicilari_goster()
        {
            try
            {
                baglantim.BaglantiyiAc();
                MySqlConnection bgl = baglantim.GetConnection();

                MySqlDataAdapter kullanicilari_listele = new MySqlDataAdapter
                  ("SELECT tcno AS 'TC KİMLİ NO'," +
                   "adi AS 'ADI'," +
                   "soyadi AS 'SOYADI'," +
                   "kulAdi AS 'KULLANICI ADI'," +
                   "parola AS 'PAROLA'," +
                   "rol AS 'YETKİ' " +
                   "FROM kullanici " +
                   "ORDER BY tcno ASC", bgl);
                DataSet ds = new DataSet();
                kullanicilari_listele.Fill(ds);
                dgw_kullanici.DataSource = ds.Tables[0];
                baglantim.BaglantiyiKapat();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void personelleri_goster()
        {
            try
            {
                baglantim.BaglantiyiAc();
                MySqlConnection bgl = baglantim.GetConnection();

                MySqlDataAdapter personelleri_listele = new MySqlDataAdapter(
                    "SELECT tcno AS 'TC KİMLİ NO'," +
                    "adi AS 'ADI'," +
                    "soyadi AS 'SOYADI'," +
                    "cinsiyet AS 'CİNSİYET'," +
                    "mezuniyet AS 'MEZUNİYET TARİHİ'," +
                    "dogum AS 'DOĞUM TARİHİ'," +
                    "gorev AS 'GÖREVİ'," +
                    "gorevYeri AS 'GÖREV YERİ'," +
                    "maas AS 'MAAŞ' " +  // Virgül kaldırıldı
                    "FROM personel " +
                    "ORDER BY tcno ASC", bgl);

                DataSet ds = new DataSet();
                personelleri_listele.Fill(ds);
                dgw_personel.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglantim.BaglantiyiKapat(); // Kapatma işlemi finally bloğunda yapılır
            }


        }

        public void resimGetir()
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
                    new uyari("Varsayılan resim dosyası bulunamadı.").ShowDialog();

                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya mesaj göster
                MessageBox.Show("Resim yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void personel_resim_getir()
        {
            try
            {
                // TC Kimlik Numarasını Al
                string tcNo = txt_pTcno.Text.Trim();

                // Eğer TC boşsa işlemi iptal et
                if (string.IsNullOrEmpty(tcNo))
                {
                    picb_personel.Image = null; // Resmi temizle
                    return;
                }

                // Resim dosya yollarını belirle
                string resimKlasoru = Path.Combine(Application.StartupPath, "img");
                string resimYoluJpg = Path.Combine(resimKlasoru, tcNo + ".jpg");
                string resimYoluPng = Path.Combine(resimKlasoru, tcNo + ".png");

                // Mevcut resmi temizle (Bellek kilitlenmesini önler)
                if (picb_personel.Image != null)
                {
                    picb_personel.Image.Dispose();
                    picb_personel.Image = null;
                }

                // Resmi yükle
                if (File.Exists(resimYoluJpg))
                {
                    using (FileStream fs = new FileStream(resimYoluJpg, FileMode.Open, FileAccess.Read))
                    {
                        picb_personel.Image = Image.FromStream(fs);
                    }
                }
                else if (File.Exists(resimYoluPng))
                {
                    using (FileStream fs = new FileStream(resimYoluPng, FileMode.Open, FileAccess.Read))
                    {
                        picb_personel.Image = Image.FromStream(fs);
                    }
                }
                else
                {
                    picb_personel.Image = null; // Resim yoksa temizle
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Resim yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool personel_islem()
        {
            baglantim.BaglantiyiAc();
            MySqlConnection bagla = baglantim.GetConnection();

            MySqlCommand select_sorgu = new MySqlCommand("SELECT * FROM personel WHERE tcno='" + txt_pTcno.Text + "'", bagla);
            MySqlDataReader kayit_okuma = select_sorgu.ExecuteReader();

            bool pKayit_kontrol = false;

            while (kayit_okuma.Read())
            {
                pKayit_kontrol = true;
                break;
            }

            baglantim.BaglantiyiKapat();

            if (!pKayit_kontrol)
            {

                if (txt_pTcno.Text.Length != 11)
                {
                    new uyari("Kimlik numarası 11 karakter olmalıdır.").ShowDialog();
                    txt_pTcno.Focus();
                    return false;
                }

                if (txt_pAdi.Text.Length < 2)
                {
                    new uyari("Ad kısmı boş bırakılamaz.").ShowDialog();
                    txt_pAdi.Focus();
                    return false;
                }

                if (txt_pSoyadi.Text.Length < 2)
                {
                    new uyari("Soyad kısmı boş bırakılamaz.").ShowDialog();
                    txt_pSoyadi.Focus();
                    return false;
                }
                if (dtp_dogum.Value.Date == DateTime.Today)
                {
                    MessageBox.Show("Bu günün tarihini seçtiniz lütfen doğum tarihinizi seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cb_mezuniyet.SelectedIndex == -1)
                {
                    new uyari("Lütfen bir mezuniyet türü seçiniz.").ShowDialog();
                    cb_mezuniyet.Focus();
                    return false;
                }

                if (cb_gorev.SelectedIndex == -1)
                {
                    new uyari("Lütfen bir görev türü seçiniz.").ShowDialog();
                    cb_gorev.Focus();
                    return false;
                }

                if (cb_gYeri.SelectedIndex == -1)
                {
                    new uyari("Lütfen bir görev yeri seçiniz.").ShowDialog();
                    cb_gYeri.Focus();
                    return false;
                }

                if (string.IsNullOrEmpty(txt_maas.Text) || txt_maas.Text.Length < 5)
                {
                    new uyari("Lütfen geçerli bir maaş miktarı giriniz.").ShowDialog();
                    txt_maas.Focus();
                    return false;
                }

                if (picb_personel.Image == null)
                {
                    new uyari("Lütfen bir resim seçiniz.").ShowDialog();
                    return false;
                }

                if (rb_erkek.Checked)
                {
                    cinsiyet = "Erkek";
                }
                else if (rb_kadin.Checked)
                {
                    cinsiyet = "Kadın";
                }
                else
                {
                    MessageBox.Show("Lütfen cinsiyet seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true;
            }
            else
            {
                new uyari("Zaten böyle bir kullanıcı sisteme kayıtlı.").ShowDialog();
                return false;
            }
        }

        public void personel_ekle()
        {
            if (personel_islem())
            {
                try
                {
                    baglantim.BaglantiyiAc();
                    MySqlConnection bagla = baglantim.GetConnection();
                    string sorgu = "INSERT INTO personel (tcno, adi, soyadi, cinsiyet, mezuniyet, dogum, gorev, gorevYeri, maas) VALUES (@tcno, @adi, @soyadi, @cinsiyet, @mezuniyet, @dogum, @gorev, @gorevYeri, @maas)";

                    MySqlCommand personel_ekle = new MySqlCommand(sorgu, bagla);
                    personel_ekle.Parameters.AddWithValue("@tcno", txt_pTcno.Text);
                    personel_ekle.Parameters.AddWithValue("@adi", txt_pAdi.Text);
                    personel_ekle.Parameters.AddWithValue("@soyadi", txt_pSoyadi.Text);
                    personel_ekle.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                    personel_ekle.Parameters.AddWithValue("@mezuniyet", cb_mezuniyet.Text);
                    personel_ekle.Parameters.AddWithValue("@dogum", dtp_dogum.Value);
                    personel_ekle.Parameters.AddWithValue("@gorev", cb_gorev.Text);
                    personel_ekle.Parameters.AddWithValue("@gorevYeri", cb_gYeri.Text);
                    personel_ekle.Parameters.AddWithValue("@maas", txt_maas.Text);
                    personel_ekle.ExecuteNonQuery();
                    baglantim.BaglantiyiKapat();

                    // Resim kaydetme işlemi
                    if (picb_personel.Image != null)
                    {
                        string tcNo = txt_pTcno.Text.Trim(); // TC kimlik numarasını al
                        string imgKlasor = Path.Combine(Application.StartupPath, "img"); // "img" klasörünü belirle

                        Directory.CreateDirectory(imgKlasor); // Eğer img klasörü yoksa oluştur

                        string dosyaYolu = Path.Combine(imgKlasor, tcNo + ".jpg"); // Dosya adını oluştur

                        try
                        {
                            picb_personel.Image.Save(dosyaYolu, ImageFormat.Jpeg);
                            new bilgi("Resim başarıyla kaydedildi.").ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    new bilgi("Yeni kullanıcı kaydı başarı ile oluşturulmuştur.").ShowDialog();
                    tb_personel_temizle(); // Temizleme işlemi
                    personelleri_goster(); // Güncellenmiş listeyi göster
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void kullanici_ekle()
        {
            if (kullanici_islem())
            {
                try
                {
                    baglantim.BaglantiyiAc();
                    MySqlConnection bagla = baglantim.GetConnection();
                    string sorgu = "INSERT INTO kullanici (tcno, adi, soyadi, kulAdi, parola, rol) VALUES (@tcno, @adi, @soyadi, @kulAdi, @parola, @rol)";

                    MySqlCommand kullanici_ekle = new MySqlCommand(sorgu, bagla);
                    kullanici_ekle.Parameters.AddWithValue("@tcno", txt_kimlik.Text);
                    kullanici_ekle.Parameters.AddWithValue("@adi", txt_adi.Text);
                    kullanici_ekle.Parameters.AddWithValue("@soyadi", txt_soyadi.Text);
                    kullanici_ekle.Parameters.AddWithValue("@kulAdi", txt_kulAdi.Text);
                    kullanici_ekle.Parameters.AddWithValue("@parola", txt_parola.Text);
                    kullanici_ekle.Parameters.AddWithValue("@rol", yetki);
                    kullanici_ekle.ExecuteNonQuery();

                    baglantim.BaglantiyiKapat();

                    new bilgi("Yeni kullanıcı kaydı başarı ile oluşturulmuştur.").ShowDialog();
                    tb_kullanici_temizle();
                    kullanicilari_goster();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void personel_ara()
        {
            try
            {
                baglantim.BaglantiyiAc();
                MySqlConnection bagla = baglantim.GetConnection();

                string sorgu = " SELECT tcno, adi, soyadi, cinsiyet, mezuniyet, dogum, gorev, gorevYeri, maas FROM personel WHERE tcno=@tcno";

                MySqlCommand cmd = new MySqlCommand(sorgu, bagla);
                cmd.Parameters.AddWithValue("@tcno", txt_pTcno.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txt_pTcno.Text = reader["tcno"].ToString();
                    txt_pAdi.Text = reader["adi"].ToString();
                    txt_pSoyadi.Text = reader["soyadi"].ToString();
                    cb_mezuniyet.Text = reader["mezuniyet"].ToString();
                    dtp_dogum.Value = Convert.ToDateTime(reader["dogum"]);
                    cb_gorev.Text = reader["gorev"].ToString();
                    cb_gYeri.Text = reader["gorevYeri"].ToString();
                    txt_maas.Text = reader["maas"].ToString();

                    string cinsiyet = reader["cinsiyet"].ToString();
                    if (cinsiyet == "Erkek")
                    {
                        rb_erkek.Checked = true;
                    }
                    else if (cinsiyet == "Kadın")
                    {
                        rb_kadin.Checked = true;
                    }
                }
                else
                {
                    new uyari("Bu kimlik numarasına ait kullanıcı bulunamadı.").ShowDialog();
                }

                reader.Close();
                baglantim.BaglantiyiKapat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        public void kullanici_ara()
        {
            try
            {
                baglantim.BaglantiyiAc();
                MySqlConnection bagla = baglantim.GetConnection();


                string sorgu = "SELECT Adi, Soyadi, KulAdi, Parola, Rol FROM kullanici WHERE tcno = @tcno";

                MySqlCommand cmd = new MySqlCommand(sorgu, bagla);
                cmd.Parameters.AddWithValue("@tcno", txt_kimlik.Text);

                MySqlDataReader reader = cmd.ExecuteReader();
                ;
                if (reader.Read())
                {
                    txt_adi.Text = reader["Adi"].ToString();
                    txt_soyadi.Text = reader["Soyadi"].ToString();
                    txt_kulAdi.Text = reader["KulAdi"].ToString();
                    txt_parola.Text = reader["Parola"].ToString();

                    string rol = reader["rol"].ToString();

                    if (rol == "Kullanıcı")
                    {
                        rb_kullanici.Checked = true;

                    }
                    else if (rol == "Yönetici")
                    {
                        rb_yonetici.Checked = true;
                    }
                }
                else
                {
                    new uyari("Bu kimlik numarasına ait kullanıcı bulunamadı.").ShowDialog();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        public void personel_sil()
        {
            if (dgw_personel.SelectedRows.Count == 0 && txt_pTcno.Text == "") // Seçili satır var mı?
            {
                new uyari("Lütfen bir kullanıcı seçiniz.").ShowDialog();
                return;
            }

            try
            {
                baglantim.BaglantiyiAc();
                MySqlConnection bagla = baglantim.GetConnection();

                string sorgu = "DELETE FROM personel WHERE tcno = @tcno";
                MySqlCommand personel_sil = new MySqlCommand(sorgu, bagla);
                personel_sil.Parameters.AddWithValue("@tcno", txt_pTcno.Text);

                int satirSayisi = personel_sil.ExecuteNonQuery(); // Silinen satır sayısını kontrol et

                if (satirSayisi > 0) // Gerçekten bir şey silindiyse
                {
                    new bilgi("Kullanıcı başarıyla silindi.").ShowDialog();
                    tb_personel_temizle(); // Kullanıcı alanlarını temizle
                    personelleri_goster(); // DataGridView'i güncelle
                }
                else
                {
                    new uyari("Böyle bir kullanıcı bulunamadı.").ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglantim.BaglantiyiKapat(); // Bağlantıyı her durumda kapat
            }
        }

        public void kullanici_sil()
        {

            if (dgw_kullanici.SelectedRows.Count == 0 && txt_kimlik.Text == "") // Seçili satır var mı?
            {
                new uyari("Lütfen bir kullanıcı seçiniz.").ShowDialog();
                return;
            }

            try
            {
                baglantim.BaglantiyiAc();
                MySqlConnection bagla = baglantim.GetConnection();

                string sorgu = "DELETE FROM kullanici WHERE tcno = @tcno";
                MySqlCommand kullanici_sil = new MySqlCommand(sorgu, bagla);
                kullanici_sil.Parameters.AddWithValue("@tcno", txt_kimlik.Text);

                int satirSayisi = kullanici_sil.ExecuteNonQuery(); // Silinen satır sayısını kontrol et

                if (satirSayisi > 0) // Gerçekten bir şey silindiyse
                {
                    new bilgi("Kullanıcı başarıyla silindi.").ShowDialog();
                    tb_kullanici_temizle(); // Kullanıcı alanlarını temizle
                    kullanicilari_goster(); // DataGridView'i güncelle
                }
                else
                {
                    new uyari("Böyle bir kullanıcı bulunamadı.").ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglantim.BaglantiyiKapat(); // Bağlantıyı her durumda kapat
            }
        }

        public void personel_guncelle()
        {

            if (dgw_personel.SelectedRows.Count == 0 && txt_pTcno.Text == "")
            {
                new uyari("Lütfen bir kullanıcı seçiniz.").ShowDialog();
                return;
            }

            if (rb_erkek.Checked)
            {
                cinsiyet = "Erkek";
            }
            else if (rb_kadin.Checked)
            {
                cinsiyet = "Kadın";
            }
            else
            {
                new uyari("Lütfen bir kullanıcı seçiniz.").ShowDialog();
                return;
            }
            if (personel_guncelle_islem())
            {
                try
                {
                    baglantim.BaglantiyiAc();
                    MySqlConnection bagla = baglantim.GetConnection();

                    string sorgu = "UPDATE personel SET adi = @adi, soyadi = @soyadi, cinsiyet = @cinsiyet, mezuniyet = @mezuniyet, dogum = @dogum, gorev = @gorev, gorevYeri = @gorevYeri, maas = @maas WHERE tcno = @tcno";
                    MySqlCommand personel_guncelle = new MySqlCommand(sorgu, bagla);

                    personel_guncelle.Parameters.AddWithValue("@adi", txt_pAdi.Text);
                    personel_guncelle.Parameters.AddWithValue("@soyadi", txt_pSoyadi.Text);
                    personel_guncelle.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                    personel_guncelle.Parameters.AddWithValue("@mezuniyet", cb_mezuniyet.Text);
                    personel_guncelle.Parameters.AddWithValue("@dogum", dtp_dogum.Value.ToString("yyyy-MM-dd"));
                    personel_guncelle.Parameters.AddWithValue("@gorev", cb_gorev.Text);
                    personel_guncelle.Parameters.AddWithValue("@gorevYeri", cb_gYeri.Text);
                    personel_guncelle.Parameters.AddWithValue("@maas", txt_maas.Text);
                    personel_guncelle.Parameters.AddWithValue("@tcno", txt_pTcno.Text);

                    int satirSayisi = personel_guncelle.ExecuteNonQuery();

                    if (satirSayisi > 0)
                    {
                        new bilgi("Kullanıcı bilgileri başarıyla güncellendi.").ShowDialog();
                        tb_personel_temizle();
                        personelleri_goster();
                    }
                    else
                    {
                        new uyari("Lütfen bir kullanıcı seçiniz.").ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    baglantim.BaglantiyiKapat();
                }
            }

        }

        public void kullanici_guncelle()
        {
            if (dgw_kullanici.SelectedRows.Count == 0 && txt_kimlik.Text == "") // Seçili satır var mı?
            {
                new uyari("Lütfen bir kullanıcı seçiniz.").ShowDialog();
                return;
            }
            if (rb_yonetici.Checked)
            {
                yetki = "Yönetici";
            }
            else if (rb_kullanici.Checked)
            {
                yetki = "Kullanıcı";
            }
            if (kullanici_guncelle_islem())
            {
                try
                {
                    baglantim.BaglantiyiAc();
                    MySqlConnection bagla = baglantim.GetConnection();

                    string sorgu = "UPDATE kullanici SET adi=@adi, soyadi=@soyadi, kulAdi=@kulAdi, parola=@parola,rol=@rol WHERE tcno = @tcno";
                    MySqlCommand personel_guncelle = new MySqlCommand(sorgu, bagla);

                    personel_guncelle.Parameters.AddWithValue("@adi", txt_adi.Text);
                    personel_guncelle.Parameters.AddWithValue("@soyadi", txt_soyadi.Text);
                    personel_guncelle.Parameters.AddWithValue("@kulAdi", txt_kulAdi.Text);
                    personel_guncelle.Parameters.AddWithValue("@parola", txt_parola.Text);
                    personel_guncelle.Parameters.AddWithValue("@rol", yetki);
                    personel_guncelle.Parameters.AddWithValue("@tcno", txt_kimlik.Text); // Güncellenen kullanıcıyı belirleyen alan

                    int satirSayisi = personel_guncelle.ExecuteNonQuery(); // Güncellenen satır sayısını kontrol et

                    if (satirSayisi > 0) // Gerçekten bir şey güncellendiyse
                    {
                        new bilgi("Kullanıcı bilgileri başarıyla güncellendi.").ShowDialog();
                        tb_kullanici_temizle(); // Kullanıcı alanlarını temizle
                        kullanicilari_goster(); // DataGridView'i güncelle
                    }
                    else
                    {
                        new uyari("Böyle bir kullanıcı bulunamadı veya değişiklik yapılmadı.").ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    baglantim.BaglantiyiKapat(); // Bağlantıyı her durumda kapat
                }
            }
        }

        private bool personel_guncelle_islem()
        {
            if (txt_pTcno.Text.Length != 11)
            {
                new uyari("Kimlik numarası 11 karakter olmalıdır.").ShowDialog();
                txt_pTcno.Focus();
                return false;
            }

            if (txt_pAdi.Text.Length < 2)
            {
                new uyari("Ad Kısmı boş bırakılamaz.").ShowDialog();
                txt_pAdi.Focus();
                return false;
            }

            if (txt_pSoyadi.Text.Length < 2)
            {
                new uyari("Soyad Kısmı boş bırakılamaz.").ShowDialog();
                txt_pSoyadi.Focus();
                return false;
            }
            if (dtp_dogum.Value.Date == DateTime.Today)
            {
                MessageBox.Show("Bu günün tarihini seçtiniz lütfen doğum tarihinizi seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cb_mezuniyet.SelectedIndex == -1)
            {
                new uyari("Lütfen bir mezuniyet türü seçiniz.").ShowDialog();
                cb_mezuniyet.Focus();
                return false;
            }

            if (cb_gorev.SelectedIndex == -1)
            {
                new uyari("Lütfen bir görev türü seçiniz.").ShowDialog();
                cb_gorev.Focus();
                return false;
            }

            if (cb_gYeri.SelectedIndex == -1)
            {
                new uyari("Lütfen bir görev yeri seçiniz.").ShowDialog();
                cb_gYeri.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txt_maas.Text) || txt_maas.Text.Length >= 5)
            {
                new uyari("Lütfen geçerli bir maaş miktarı giriniz.").ShowDialog();
                txt_maas.Focus();
                return false;
            }

            if (picb_personel.Image == null)
            {
                new uyari("Lütfen bir resim seçiniz.").ShowDialog();
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool kullanici_guncelle_islem()
        {
            // Kimlik numarası kontrolü
            if (txt_kimlik.Text.Length != 11)
            {
                new uyari("Kimlik numarası 11 karakter olmalıdır.").ShowDialog();
                txt_kimlik.Focus();
                return false;
            }
            // Ad kısmı kontrolü
            if (txt_adi.Text.Length < 2)
            {
                new uyari("Ad Kısmı boş bırakılamaz.").ShowDialog();
                txt_adi.Focus();
                return false;
            }
            // Soyad kısmı kontrolü
            if (txt_soyadi.Text.Length < 2)
            {
                new uyari("Soyad Kısmı boş bırakılamaz.").ShowDialog();
                txt_soyadi.Focus();
                return false;
            }
            // Kullanıcı adı kontrolü
            if (txt_kulAdi.Text.Length < 8)
            {
                new uyari("Kullanıcı Adı kısmı en az 8 karakter olmak zorunda.").ShowDialog();
                txt_kulAdi.Focus();
                return false;
            }
            // Parola skoru kontrolü
            if (parola_skoru <= 70)
            {
                new uyari("Parola skorunuz en az 70 olmalı.").ShowDialog();
                txt_parola.Focus();
                return false;
            }
            // Parola eşleşmesi kontrolü
            if (txt_parola.Text != txt_tekrarParola.Text)
            {
                new uyari("Girilen parolalar eşleşmiyor.").ShowDialog();
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool kullanici_islem()
        {
            baglantim.BaglantiyiAc();
            MySqlConnection bagla = baglantim.GetConnection();

            MySqlCommand select_sorgu = new MySqlCommand("SELECT * FROM kullanici WHERE tcno='" + txt_kimlik.Text + "'", bagla);
            MySqlDataReader kayit_okuma = select_sorgu.ExecuteReader();

            bool kayit_kontrol = false;

            while (kayit_okuma.Read())
            {
                kayit_kontrol = true;
                break;
            }

            baglantim.BaglantiyiKapat();

            if (!kayit_kontrol)  // Eğer kullanıcı kayıtlı değilse
            {
                // Kimlik numarası kontrolü
                if (txt_kimlik.Text.Length != 11)
                {
                    new uyari("Kimlik numarası 11 karakter olmalıdır.").ShowDialog();
                    txt_kimlik.Focus();
                    return false;
                }
                // Ad kısmı kontrolü
                if (txt_adi.Text.Length < 2)
                {
                    new uyari("Ad Kısmı boş bırakılamaz.").ShowDialog();
                    txt_adi.Focus();
                    return false;
                }
                // Soyad kısmı kontrolü
                if (txt_soyadi.Text.Length < 2)
                {
                    new uyari("Soyad Kısmı boş bırakılamaz.").ShowDialog();
                    txt_soyadi.Focus();
                    return false;
                }
                // Kullanıcı adı kontrolü
                if (txt_kulAdi.Text.Length < 8)
                {
                    new uyari("Kullanıcı Adı kısmı en az 8 karakter olmak zorunda.").ShowDialog();
                    txt_kulAdi.Focus();
                    return false;
                }
                // Parola skoru kontrolü
                if (parola_skoru <= 70)
                {
                    new uyari("Parola skorunuz en az 70 olmalı.").ShowDialog();
                    txt_parola.Focus();
                    return false;
                }
                // Parola eşleşmesi kontrolü
                if (txt_parola.Text != txt_tekrarParola.Text)
                {
                    new uyari("Girilen parolalar eşleşmiyor.").ShowDialog();
                    return false;
                }
                // Yetki kontrolü
                if (rb_yonetici.Checked)
                {
                    yetki = "Yönetici";
                }
                else if (rb_kullanici.Checked)
                {
                    yetki = "Kullanıcı";
                }
                else
                {
                    MessageBox.Show("Lütfen bir rol seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                return true;  // Tüm kontroller geçtiyse işlemi onayla
            }

            // Kullanıcı zaten kayıtlıysa
            new uyari("Zaten böyle bir kullanıcı sisteme kayıtlı.").ShowDialog();
            return false;
        }

        public void parola_islem()
        {
            bool mesaj_gosterildi = false;
            int imlecPozisyonu = txt_parola.SelectionStart;
            string parola_seviyesi = "";
            int kucuk_harf_skoru = 0;
            int buyuk_harf_skoru = 0;
            int rakam_skoru = 0;
            int sembol_skoru = 0;
            string sifre = txt_parola.Text;
            string duzeltilmis_sifre = "";

            duzeltilmis_sifre = sifre;
            duzeltilmis_sifre = duzeltilmis_sifre
            .Replace("İ", "I").Replace("ı", "i")
            .Replace("Ç", "C").Replace("ç", "c")
            .Replace("Ğ", "G").Replace("ğ", "g")
            .Replace("Ö", "O").Replace("ö", "o")
            .Replace("Ş", "S").Replace("ş", "s")
            .Replace("Ü", "U").Replace("ü", "u");

            if (sifre != duzeltilmis_sifre)
            {
                sifre = duzeltilmis_sifre;
                txt_parola.Text = sifre;
                txt_parola.SelectionStart = imlecPozisyonu;
                uyari.SetError(txt_parola, "Parolanızdaki tüm Türkçe karakterler İngilizceye çevrilecektir.");
            }

            //Şifrenin tüm uzunluğundan olmayanları çıkarıp
            //örneğin Ahmet küçük harfi çıkarınca A kalıyor
            //toplam kelime 5 harf 5-1 den de 4 küçük harf olduğunu tespit ediyoruz 
            int az_karakter_sayisi = sifre.Length - Regex.Replace(sifre, "[a-z]", "").Length;
            kucuk_harf_skoru = Math.Min(2, az_karakter_sayisi) * 10;

            //Aynısının büyük harf versiyonu
            int AZ_karakter_sayisi = sifre.Length - Regex.Replace(sifre, "[A-Z]", "").Length;
            buyuk_harf_skoru = Math.Min(2, AZ_karakter_sayisi) * 10;

            //Aynısının sayı versiyonu 
            int rakam_sayisi = sifre.Length - Regex.Replace(sifre, "[0-9]", "").Length;
            rakam_skoru = Math.Min(2, rakam_sayisi) * 10;

            //Burada da tüm bulduklarımızı çıkarınca geriye semboller kalıyor
            int sembol_sayisi = sifre.Length - az_karakter_sayisi - AZ_karakter_sayisi - rakam_sayisi;
            sembol_skoru = Math.Min(2, sembol_sayisi) * 10;

            parola_skoru = kucuk_harf_skoru + buyuk_harf_skoru + rakam_skoru + sembol_skoru;

            if (sifre.Length < 10)
            {
                parola_skoru += 10;
            }
            else if (sifre.Length >= 10)
            {
                parola_skoru += 20;
            }

            if (kucuk_harf_skoru == 0 || buyuk_harf_skoru == 0 || sembol_sayisi == 0 || rakam_sayisi == 0)
            {
                lbl_kriter.Text = ("Parolanız en az bir büyük harf, bir küçük harf ,bir sembol ve bir rakam içermelidir!");
            }
            else
            {
                lbl_kriter.Text = "";
            }

            if (parola_skoru <= 70)
            {
                lbl_seviye.Text = "Zayıf";
                lbl_seviye.ForeColor = Color.Red;

            }
            else if (parola_skoru <= 90)
            {
                lbl_seviye.Text = "Güçlü";
                lbl_seviye.ForeColor = Color.Orange;
            }
            else
            {
                lbl_seviye.Text = "Çok Güçlü";
                lbl_seviye.ForeColor = Color.Green;
            }

            lbl_skor.Text = "%" + Convert.ToString(parola_skoru);
            pb_gucParola.Value = parola_skoru;
            lbl_skor.BackColor = SystemColors.Control;
        }

        private void tb_kullanici_temizle()
        {
            txt_kimlik.Clear();
            txt_adi.Clear();
            txt_soyadi.Clear();
            txt_kulAdi.Clear();
            txt_parola.Clear();
            txt_tekrarParola.Clear();
        }

        private void tb_personel_temizle()
        {
            txt_pTcno.Clear();
            picb_personel.Image = null;
            txt_pAdi.Clear();
            txt_pSoyadi.Clear();
            cb_mezuniyet.SelectedIndex = -1;
            cb_gorev.SelectedIndex = -1;
            cb_gYeri.SelectedIndex = -1;
            txt_maas.Clear();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            kullanici_ekle();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            kullanici_sil();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            kullanici_guncelle();
        }

        private void txt_kimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bu karakterin işlenmesini engeller.
            }
        }

        private void frm_islemler_Load(object sender, EventArgs e)
        {
            lbl_giren.Text = frm_giris.adi + " " + frm_giris.soyadi;
            kullanicilari_goster();
            personelleri_goster();
            resimGetir();
        }

        private void txt_adi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true; // Geçersiz tuşu engelle
            }
            else if (e.KeyChar == 'ı')
            {
                e.KeyChar = 'I'; // 'ı' karakterini 'I' ile değiştir
            }
            else if (e.KeyChar == 'i')
            {
                e.KeyChar = 'İ';
            }


        }

        private void txt_soyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true; // Geçersiz tuşu engelle
            }
            else if (e.KeyChar == 'ı')
            {
                e.KeyChar = 'I'; // 'ı' karakterini 'I' ile değiştir
            }
            else if (e.KeyChar == 'i')
            {
                e.KeyChar = 'İ';
            }
        }

        private void txt_parola_TextChanged(object sender, EventArgs e)
        {
            parola_islem();
        }

        private void dgw_kullanici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Eğer kullanıcı herhangi bir satıra tıklamazsa hata almamak için kontrol et
            if (e.RowIndex >= 0)
            {
                DataGridViewRow satir = dgw_kullanici.Rows[e.RowIndex];

                // TextBox'lara değerleri ata
                txt_kimlik.Text = satir.Cells[0].Value.ToString();
                txt_adi.Text = satir.Cells[1].Value.ToString();
                txt_soyadi.Text = satir.Cells[2].Value.ToString();
                txt_kulAdi.Text = satir.Cells[3].Value.ToString();
                txt_parola.Text = satir.Cells[4].Value.ToString(); // Şifreyi göstermek istemeyebilirsin

                // RadioButton'ları güncelle
                if (satir.Cells[5].Value.ToString() == "Yönetici")
                {
                    rb_yonetici.Checked = true;
                }
                else
                {
                    rb_kullanici.Checked = true;
                }
            }
        }

        private void dgw_personel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dgw_personel.Rows[e.RowIndex].Cells.Cast<DataGridViewCell>().All(c => c.Value == null || c.Value == DBNull.Value))
            {
                DataGridViewRow satir = dgw_personel.Rows[e.RowIndex];

                // TC Kimlik Numarasını al ve TextBox'a yaz
                txt_pTcno.Text = satir.Cells[0].Value?.ToString() ?? "";

                // Diğer TextBox'lara bilgileri ata
                txt_pAdi.Text = satir.Cells[1].Value?.ToString() ?? "";
                txt_pSoyadi.Text = satir.Cells[2].Value?.ToString() ?? "";
                cb_mezuniyet.Text = satir.Cells[4].Value?.ToString() ?? "";
                dtp_dogum.Value = satir.Cells[5].Value != null ? Convert.ToDateTime(satir.Cells[5].Value) : DateTime.Now;
                cb_gorev.Text = satir.Cells[6].Value?.ToString() ?? "";
                cb_gYeri.Text = satir.Cells[7].Value?.ToString() ?? "";
                txt_maas.Text = satir.Cells[8].Value?.ToString() ?? "";

                // Cinsiyeti kontrol et
                if (satir.Cells[3].Value != null && satir.Cells[3].Value.ToString() == "Erkek")
                {
                    rb_erkek.Checked = true;
                }
                else
                {
                    rb_kadin.Checked = true;
                }

                // Resmi getir
                personel_resim_getir();
            }
            else
            {
                new uyari("Lütfen dolu bir satır seçin.").ShowDialog();
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            kullanici_ara();
        }

        private void btn_frmTemizle_Click(object sender, EventArgs e)
        {
            tb_kullanici_temizle();
        }

        private void btn_pGozat_Click(object sender, EventArgs e)
        {
            OpenFileDialog resim_sec = new OpenFileDialog();
            resim_sec.Title = "Personel Resmi Seçiniz.";
            resim_sec.Filter = "JPG Dosyalar (*.jpg)|*.jpg";
            if (resim_sec.ShowDialog() == DialogResult.OK)
            {
                this.picb_personel.Image = new Bitmap(resim_sec.OpenFile());
            }


        }

        private void txt_pAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true; // Geçersiz tuşu engelle
            }
            else if (e.KeyChar == 'ı')
            {
                e.KeyChar = 'I'; // 'ı' karakterini 'I' ile değiştir
            }
            else if (e.KeyChar == 'i')
            {
                e.KeyChar = 'İ';
            }
        }

        private void txt_pSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true; // Geçersiz tuşu engelle
            }
            else if (e.KeyChar == 'ı')
            {
                e.KeyChar = 'I'; // 'ı' karakterini 'I' ile değiştir
            }
            else if (e.KeyChar == 'i')
            {
                e.KeyChar = 'İ';
            }
        }

        private void txt_pTcno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bu karakterin işlenmesini engeller.
            }
        }

        private void btn_pKayit_Click(object sender, EventArgs e)
        {
            personel_ekle();
        }

        private void btn_pAra_Click(object sender, EventArgs e)
        {
            personel_ara();
        }

        private void btn_pSil_Click(object sender, EventArgs e)
        {
            personel_sil();
        }

        private void btn_pGuncelle_Click(object sender, EventArgs e)
        {
            personel_guncelle();
        }

        private void btn_pTemizle_Click(object sender, EventArgs e)
        {
            tb_personel_temizle();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btn_pKayit_MouseEnter(object sender, EventArgs e)
        {
            btn_pKayit.BackColor = Color.CornflowerBlue;
            btn_pKayit.ForeColor = Color.White;
        }

        private void btn_pKayit_MouseLeave(object sender, EventArgs e)
        {
            btn_pKayit.BackColor = Color.White;
            btn_pKayit.ForeColor = Color.Black;
        }

        private void btn_pSil_MouseEnter(object sender, EventArgs e)
        {
            btn_pSil.BackColor = Color.CornflowerBlue;
            btn_pSil.ForeColor = Color.White;
        }

        private void btn_pSil_MouseLeave(object sender, EventArgs e)
        {
            btn_pSil.BackColor = Color.White;
            btn_pSil.ForeColor = Color.Black;
        }

        private void btn_pGuncelle_MouseEnter(object sender, EventArgs e)
        {
            btn_pGuncelle.BackColor = Color.CornflowerBlue;
            btn_pGuncelle.ForeColor = Color.White;
        }

        private void btn_pGuncelle_MouseLeave(object sender, EventArgs e)
        {
            btn_pGuncelle.BackColor = Color.White;
            btn_pGuncelle.ForeColor = Color.Black;
        }

        private void btn_pTemizle_MouseEnter(object sender, EventArgs e)
        {
            btn_pTemizle.BackColor = Color.CornflowerBlue;
            btn_pTemizle.ForeColor = Color.White;
        }

        private void btn_pTemizle_MouseLeave(object sender, EventArgs e)
        {
            btn_pTemizle.BackColor = Color.White;
            btn_pTemizle.ForeColor = Color.Black;
        }

        private void btn_pAra_MouseEnter(object sender, EventArgs e)
        {
            btn_pAra.BackColor = Color.CornflowerBlue;
            btn_pAra.ForeColor = Color.White;
        }

        private void btn_pAra_MouseLeave(object sender, EventArgs e)
        {
            btn_pAra.BackColor = Color.White;
            btn_pAra.ForeColor = Color.Black;
        }

        private void btn_pGozat_MouseEnter(object sender, EventArgs e)
        {
            btn_pGozat.BackColor = Color.CornflowerBlue;
            btn_pGozat.ForeColor = Color.White;
        }

        private void btn_pGozat_MouseLeave(object sender, EventArgs e)
        {
            btn_pGozat.BackColor = Color.White;
            btn_pGozat.ForeColor = Color.Black;
        }

        private void btn_kaydet_MouseEnter(object sender, EventArgs e)
        {
            btn_kaydet.BackColor = Color.CornflowerBlue;
            btn_kaydet.ForeColor = Color.White;
        }

        private void btn_kaydet_MouseLeave(object sender, EventArgs e)
        {
            btn_kaydet.BackColor = Color.White;
            btn_kaydet.ForeColor = Color.Black;
        }

        private void btn_sil_MouseEnter(object sender, EventArgs e)
        {
            btn_sil.BackColor = Color.CornflowerBlue;
            btn_sil.ForeColor = Color.White;
        }

        private void btn_sil_MouseLeave(object sender, EventArgs e)
        {
            btn_sil.BackColor = Color.White;
            btn_sil.ForeColor = Color.Black;
        }

        private void btn_guncelle_MouseEnter(object sender, EventArgs e)
        {
            btn_guncelle.BackColor = Color.CornflowerBlue;
            btn_guncelle.ForeColor = Color.White;
        }

        private void btn_guncelle_MouseLeave(object sender, EventArgs e)
        {
            btn_guncelle.BackColor = Color.White;
            btn_guncelle.ForeColor = Color.Black;
        }

        private void btn_frmTemizle_MouseEnter(object sender, EventArgs e)
        {
            btn_frmTemizle.BackColor = Color.CornflowerBlue;
            btn_frmTemizle.ForeColor = Color.White;
        }

        private void btn_frmTemizle_MouseLeave(object sender, EventArgs e)
        {
            btn_frmTemizle.BackColor = Color.White;
            btn_frmTemizle.ForeColor = Color.Black;
        }

        private void btn_ara_MouseEnter(object sender, EventArgs e)
        {
            btn_ara.BackColor = Color.CornflowerBlue;
            btn_ara.ForeColor = Color.White;
        }

        private void btn_ara_MouseLeave(object sender, EventArgs e)
        {
            btn_ara.BackColor = Color.White;
            btn_ara.ForeColor = Color.Black;
        }
    }
}