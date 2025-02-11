namespace personel_takip
{
    partial class frm_islemler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_islemler));
            txt_kimlik = new TextBox();
            txt_adi = new TextBox();
            txt_soyadi = new TextBox();
            txt_kulAdi = new TextBox();
            txt_parola = new TextBox();
            txt_tekrarParola = new TextBox();
            rb_yonetici = new RadioButton();
            rb_kullanici = new RadioButton();
            btn_kaydet = new Button();
            btn_guncelle = new Button();
            btn_sil = new Button();
            btn_frmTemizle = new Button();
            pb_gucParola = new ProgressBar();
            btn_ara = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tb_islemler = new TabControl();
            tabPage1 = new TabPage();
            lbl_skor = new Label();
            lbl_seviye = new Label();
            lbl_kriter = new Label();
            dgw_kullanici = new DataGridView();
            tabPage2 = new TabPage();
            txt_maas = new TextBox();
            picb_personel = new PictureBox();
            btn_pGozat = new Button();
            dtp_dogum = new DateTimePicker();
            cb_gYeri = new ComboBox();
            cb_gorev = new ComboBox();
            cb_mezuniyet = new ComboBox();
            label20 = new Label();
            label19 = new Label();
            dgw_personel = new DataGridView();
            txt_pTcno = new TextBox();
            label12 = new Label();
            txt_pAdi = new TextBox();
            label13 = new Label();
            txt_pSoyadi = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            rb_erkek = new RadioButton();
            label18 = new Label();
            rb_kadin = new RadioButton();
            btn_pAra = new Button();
            btn_pKayit = new Button();
            btn_pGuncelle = new Button();
            btn_pTemizle = new Button();
            btn_pSil = new Button();
            picb_giren = new PictureBox();
            label8 = new Label();
            lbl_giren = new Label();
            uyari = new ErrorProvider(components);
            panel1 = new Panel();
            label9 = new Label();
            button2 = new Button();
            button1 = new Button();
            btn_exit = new Button();
            tb_islemler.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_kullanici).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picb_personel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgw_personel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picb_giren).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uyari).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_kimlik
            // 
            txt_kimlik.Font = new Font("Segoe UI", 10.2F);
            txt_kimlik.Location = new Point(149, 43);
            txt_kimlik.MaxLength = 11;
            txt_kimlik.Name = "txt_kimlik";
            txt_kimlik.Size = new Size(125, 30);
            txt_kimlik.TabIndex = 0;
            // 
            // txt_adi
            // 
            txt_adi.CharacterCasing = CharacterCasing.Upper;
            txt_adi.Font = new Font("Segoe UI", 10.2F);
            txt_adi.Location = new Point(149, 88);
            txt_adi.MaxLength = 50;
            txt_adi.Name = "txt_adi";
            txt_adi.Size = new Size(125, 30);
            txt_adi.TabIndex = 1;
            txt_adi.KeyPress += txt_adi_KeyPress;
            // 
            // txt_soyadi
            // 
            txt_soyadi.CharacterCasing = CharacterCasing.Upper;
            txt_soyadi.Font = new Font("Segoe UI", 10.2F);
            txt_soyadi.Location = new Point(149, 133);
            txt_soyadi.MaxLength = 50;
            txt_soyadi.Name = "txt_soyadi";
            txt_soyadi.Size = new Size(125, 30);
            txt_soyadi.TabIndex = 2;
            txt_soyadi.KeyPress += txt_soyadi_KeyPress;
            // 
            // txt_kulAdi
            // 
            txt_kulAdi.Font = new Font("Segoe UI", 10.2F);
            txt_kulAdi.Location = new Point(149, 226);
            txt_kulAdi.MaxLength = 8;
            txt_kulAdi.Name = "txt_kulAdi";
            txt_kulAdi.Size = new Size(125, 30);
            txt_kulAdi.TabIndex = 3;
            // 
            // txt_parola
            // 
            txt_parola.Font = new Font("Segoe UI", 10.2F);
            txt_parola.Location = new Point(149, 270);
            txt_parola.MaxLength = 10;
            txt_parola.Name = "txt_parola";
            txt_parola.Size = new Size(125, 30);
            txt_parola.TabIndex = 4;
            txt_parola.TextChanged += txt_parola_TextChanged;
            // 
            // txt_tekrarParola
            // 
            txt_tekrarParola.Font = new Font("Segoe UI", 10.2F);
            txt_tekrarParola.Location = new Point(149, 318);
            txt_tekrarParola.MaxLength = 10;
            txt_tekrarParola.Name = "txt_tekrarParola";
            txt_tekrarParola.PasswordChar = '•';
            txt_tekrarParola.Size = new Size(125, 30);
            txt_tekrarParola.TabIndex = 5;
            // 
            // rb_yonetici
            // 
            rb_yonetici.AutoSize = true;
            rb_yonetici.Checked = true;
            rb_yonetici.Cursor = Cursors.Hand;
            rb_yonetici.FlatStyle = FlatStyle.System;
            rb_yonetici.Font = new Font("Segoe UI", 10.2F);
            rb_yonetici.Location = new Point(160, 180);
            rb_yonetici.Name = "rb_yonetici";
            rb_yonetici.Size = new Size(99, 28);
            rb_yonetici.TabIndex = 6;
            rb_yonetici.TabStop = true;
            rb_yonetici.Text = "Yönetici";
            rb_yonetici.UseVisualStyleBackColor = true;
            // 
            // rb_kullanici
            // 
            rb_kullanici.AutoSize = true;
            rb_kullanici.Cursor = Cursors.Hand;
            rb_kullanici.FlatStyle = FlatStyle.System;
            rb_kullanici.Font = new Font("Segoe UI", 10.2F);
            rb_kullanici.Location = new Point(264, 180);
            rb_kullanici.Name = "rb_kullanici";
            rb_kullanici.Size = new Size(103, 28);
            rb_kullanici.TabIndex = 7;
            rb_kullanici.TabStop = true;
            rb_kullanici.Text = "Kullanıcı";
            rb_kullanici.UseVisualStyleBackColor = true;
            // 
            // btn_kaydet
            // 
            btn_kaydet.BackColor = Color.White;
            btn_kaydet.Cursor = Cursors.Hand;
            btn_kaydet.Font = new Font("Segoe UI", 10.2F);
            btn_kaydet.ForeColor = SystemColors.ActiveCaptionText;
            btn_kaydet.Location = new Point(403, 389);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(109, 36);
            btn_kaydet.TabIndex = 8;
            btn_kaydet.Text = "Kaydet";
            btn_kaydet.UseVisualStyleBackColor = false;
            btn_kaydet.Click += btn_kaydet_Click;
            btn_kaydet.MouseEnter += btn_kaydet_MouseEnter;
            btn_kaydet.MouseLeave += btn_kaydet_MouseLeave;
            // 
            // btn_guncelle
            // 
            btn_guncelle.BackColor = Color.White;
            btn_guncelle.Cursor = Cursors.Hand;
            btn_guncelle.Font = new Font("Segoe UI", 10.2F);
            btn_guncelle.ForeColor = SystemColors.ActiveCaptionText;
            btn_guncelle.Location = new Point(633, 389);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(109, 37);
            btn_guncelle.TabIndex = 9;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            btn_guncelle.MouseEnter += btn_guncelle_MouseEnter;
            btn_guncelle.MouseLeave += btn_guncelle_MouseLeave;
            // 
            // btn_sil
            // 
            btn_sil.BackColor = Color.White;
            btn_sil.Cursor = Cursors.Hand;
            btn_sil.Font = new Font("Segoe UI", 10.2F);
            btn_sil.ForeColor = SystemColors.ActiveCaptionText;
            btn_sil.Location = new Point(518, 389);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(109, 37);
            btn_sil.TabIndex = 10;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            btn_sil.MouseEnter += btn_sil_MouseEnter;
            btn_sil.MouseLeave += btn_sil_MouseLeave;
            // 
            // btn_frmTemizle
            // 
            btn_frmTemizle.BackColor = Color.White;
            btn_frmTemizle.Cursor = Cursors.Hand;
            btn_frmTemizle.Font = new Font("Segoe UI", 10.2F);
            btn_frmTemizle.ForeColor = SystemColors.ActiveCaptionText;
            btn_frmTemizle.Location = new Point(748, 389);
            btn_frmTemizle.Name = "btn_frmTemizle";
            btn_frmTemizle.Size = new Size(152, 36);
            btn_frmTemizle.TabIndex = 11;
            btn_frmTemizle.Text = "Formu Temizle";
            btn_frmTemizle.UseVisualStyleBackColor = true;
            btn_frmTemizle.Click += btn_frmTemizle_Click;
            btn_frmTemizle.MouseEnter += btn_frmTemizle_MouseEnter;
            btn_frmTemizle.MouseLeave += btn_frmTemizle_MouseLeave;
            // 
            // pb_gucParola
            // 
            pb_gucParola.ForeColor = SystemColors.ControlText;
            pb_gucParola.Location = new Point(310, 301);
            pb_gucParola.Name = "pb_gucParola";
            pb_gucParola.Size = new Size(202, 32);
            pb_gucParola.TabIndex = 12;
            // 
            // btn_ara
            // 
            btn_ara.BackColor = Color.White;
            btn_ara.Cursor = Cursors.Hand;
            btn_ara.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_ara.ForeColor = SystemColors.ActiveCaptionText;
            btn_ara.Location = new Point(280, 43);
            btn_ara.Name = "btn_ara";
            btn_ara.Size = new Size(87, 30);
            btn_ara.TabIndex = 13;
            btn_ara.Text = "Ara";
            btn_ara.UseVisualStyleBackColor = true;
            btn_ara.Click += btn_ara_Click;
            btn_ara.MouseEnter += btn_ara_MouseEnter;
            btn_ara.MouseLeave += btn_ara_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.Location = new Point(27, 46);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 14;
            label1.Text = "T.C. Kimlik No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(108, 91);
            label2.Name = "label2";
            label2.Size = new Size(35, 23);
            label2.TabIndex = 15;
            label2.Text = "Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(84, 133);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 16;
            label3.Text = "Soyadı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.Location = new Point(98, 180);
            label4.Name = "label4";
            label4.Size = new Size(45, 23);
            label4.TabIndex = 17;
            label4.Text = "Yetki";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.Location = new Point(40, 229);
            label5.Name = "label5";
            label5.Size = new Size(103, 23);
            label5.TabIndex = 18;
            label5.Text = "Kullanıcı Adı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(86, 273);
            label6.Name = "label6";
            label6.Size = new Size(57, 23);
            label6.TabIndex = 19;
            label6.Text = "Parola";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(32, 321);
            label7.Name = "label7";
            label7.Size = new Size(111, 23);
            label7.TabIndex = 20;
            label7.Text = "Parola Tekrarı";
            // 
            // tb_islemler
            // 
            tb_islemler.Controls.Add(tabPage1);
            tb_islemler.Controls.Add(tabPage2);
            tb_islemler.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tb_islemler.Location = new Point(12, 70);
            tb_islemler.Name = "tb_islemler";
            tb_islemler.SelectedIndex = 0;
            tb_islemler.Size = new Size(950, 811);
            tb_islemler.TabIndex = 21;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(lbl_skor);
            tabPage1.Controls.Add(lbl_seviye);
            tabPage1.Controls.Add(lbl_kriter);
            tabPage1.Controls.Add(dgw_kullanici);
            tabPage1.Controls.Add(txt_kimlik);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txt_adi);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txt_soyadi);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txt_kulAdi);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txt_parola);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txt_tekrarParola);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(rb_yonetici);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(rb_kullanici);
            tabPage1.Controls.Add(btn_ara);
            tabPage1.Controls.Add(btn_kaydet);
            tabPage1.Controls.Add(pb_gucParola);
            tabPage1.Controls.Add(btn_guncelle);
            tabPage1.Controls.Add(btn_frmTemizle);
            tabPage1.Controls.Add(btn_sil);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(942, 775);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Kullanıcı İşlemleri";
            // 
            // lbl_skor
            // 
            lbl_skor.AutoSize = true;
            lbl_skor.BackColor = SystemColors.ControlLight;
            lbl_skor.ForeColor = SystemColors.ControlText;
            lbl_skor.Location = new Point(392, 305);
            lbl_skor.Name = "lbl_skor";
            lbl_skor.Size = new Size(43, 23);
            lbl_skor.TabIndex = 27;
            lbl_skor.Text = "Skor";
            // 
            // lbl_seviye
            // 
            lbl_seviye.AutoSize = true;
            lbl_seviye.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lbl_seviye.Location = new Point(518, 305);
            lbl_seviye.Name = "lbl_seviye";
            lbl_seviye.Size = new Size(57, 23);
            lbl_seviye.TabIndex = 26;
            lbl_seviye.Text = "Seviye";
            // 
            // lbl_kriter
            // 
            lbl_kriter.AutoSize = true;
            lbl_kriter.Location = new Point(310, 270);
            lbl_kriter.Name = "lbl_kriter";
            lbl_kriter.Size = new Size(202, 23);
            lbl_kriter.TabIndex = 25;
            lbl_kriter.Text = "\"Lütfen daha iyi şifre gir \"";
            // 
            // dgw_kullanici
            // 
            dgw_kullanici.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_kullanici.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgw_kullanici.BackgroundColor = Color.White;
            dgw_kullanici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_kullanici.Dock = DockStyle.Bottom;
            dgw_kullanici.Location = new Point(3, 470);
            dgw_kullanici.Name = "dgw_kullanici";
            dgw_kullanici.RowHeadersWidth = 51;
            dgw_kullanici.Size = new Size(936, 302);
            dgw_kullanici.TabIndex = 21;
            dgw_kullanici.CellClick += dgw_kullanici_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(txt_maas);
            tabPage2.Controls.Add(picb_personel);
            tabPage2.Controls.Add(btn_pGozat);
            tabPage2.Controls.Add(dtp_dogum);
            tabPage2.Controls.Add(cb_gYeri);
            tabPage2.Controls.Add(cb_gorev);
            tabPage2.Controls.Add(cb_mezuniyet);
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(label19);
            tabPage2.Controls.Add(dgw_personel);
            tabPage2.Controls.Add(txt_pTcno);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(txt_pAdi);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(txt_pSoyadi);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(rb_erkek);
            tabPage2.Controls.Add(label18);
            tabPage2.Controls.Add(rb_kadin);
            tabPage2.Controls.Add(btn_pAra);
            tabPage2.Controls.Add(btn_pKayit);
            tabPage2.Controls.Add(btn_pGuncelle);
            tabPage2.Controls.Add(btn_pTemizle);
            tabPage2.Controls.Add(btn_pSil);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(942, 775);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Personel İşlemleri";
            // 
            // txt_maas
            // 
            txt_maas.Location = new Point(154, 414);
            txt_maas.MaxLength = 6;
            txt_maas.Name = "txt_maas";
            txt_maas.Size = new Size(125, 30);
            txt_maas.TabIndex = 60;
            // 
            // picb_personel
            // 
            picb_personel.BackColor = SystemColors.ControlLight;
            picb_personel.BorderStyle = BorderStyle.Fixed3D;
            picb_personel.Location = new Point(507, 50);
            picb_personel.Name = "picb_personel";
            picb_personel.Size = new Size(235, 266);
            picb_personel.SizeMode = PictureBoxSizeMode.StretchImage;
            picb_personel.TabIndex = 59;
            picb_personel.TabStop = false;
            // 
            // btn_pGozat
            // 
            btn_pGozat.BackColor = Color.White;
            btn_pGozat.Cursor = Cursors.Hand;
            btn_pGozat.Font = new Font("Segoe UI", 10.2F);
            btn_pGozat.ForeColor = SystemColors.ActiveCaptionText;
            btn_pGozat.Location = new Point(748, 60);
            btn_pGozat.Name = "btn_pGozat";
            btn_pGozat.Size = new Size(96, 31);
            btn_pGozat.TabIndex = 58;
            btn_pGozat.Text = "Gözat";
            btn_pGozat.UseVisualStyleBackColor = true;
            btn_pGozat.Click += btn_pGozat_Click;
            btn_pGozat.MouseEnter += btn_pGozat_MouseEnter;
            btn_pGozat.MouseLeave += btn_pGozat_MouseLeave;
            // 
            // dtp_dogum
            // 
            dtp_dogum.Location = new Point(154, 219);
            dtp_dogum.MaxDate = new DateTime(2007, 12, 31, 0, 0, 0, 0);
            dtp_dogum.MinDate = new DateTime(1970, 12, 31, 0, 0, 0, 0);
            dtp_dogum.Name = "dtp_dogum";
            dtp_dogum.Size = new Size(233, 30);
            dtp_dogum.TabIndex = 57;
            dtp_dogum.Value = new DateTime(2007, 12, 31, 0, 0, 0, 0);
            // 
            // cb_gYeri
            // 
            cb_gYeri.AutoCompleteCustomSource.AddRange(new string[] { "AR-GE", "İnsan Kaynakları", "Bilgi İşlem ", "Üretim ", "Paketleme", "Nakliye" });
            cb_gYeri.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_gYeri.FormattingEnabled = true;
            cb_gYeri.Items.AddRange(new object[] { "AR-GE", "Bilgi İşlem", "Muhasebe", "Üretim", "Paketleme", "Nakliye" });
            cb_gYeri.Location = new Point(154, 366);
            cb_gYeri.Name = "cb_gYeri";
            cb_gYeri.Size = new Size(125, 31);
            cb_gYeri.TabIndex = 54;
            // 
            // cb_gorev
            // 
            cb_gorev.AutoCompleteCustomSource.AddRange(new string[] { "Yönetici", "Mimar ", "Mühendir", "Şoför ", "Temizlik Personeli" });
            cb_gorev.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_gorev.FormattingEnabled = true;
            cb_gorev.Items.AddRange(new object[] { "Yönetici ", "Memur", "Şoför", "İşci" });
            cb_gorev.Location = new Point(154, 319);
            cb_gorev.Name = "cb_gorev";
            cb_gorev.Size = new Size(125, 31);
            cb_gorev.TabIndex = 53;
            // 
            // cb_mezuniyet
            // 
            cb_mezuniyet.AutoCompleteCustomSource.AddRange(new string[] { "İlköğretim", "Ortaöğretim", "Lise", "Üniversite" });
            cb_mezuniyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_mezuniyet.FormattingEnabled = true;
            cb_mezuniyet.Items.AddRange(new object[] { "İlköğretim", "Ortaöğretim", "Lise", "Üniversite" });
            cb_mezuniyet.Location = new Point(154, 267);
            cb_mezuniyet.Name = "cb_mezuniyet";
            cb_mezuniyet.Size = new Size(125, 31);
            cb_mezuniyet.TabIndex = 51;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(98, 414);
            label20.Name = "label20";
            label20.Size = new Size(50, 23);
            label20.TabIndex = 50;
            label20.Text = "Maaş";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(61, 369);
            label19.Name = "label19";
            label19.Size = new Size(87, 23);
            label19.TabIndex = 49;
            label19.Text = "Görev Yeri";
            // 
            // dgw_personel
            // 
            dgw_personel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_personel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgw_personel.BackgroundColor = Color.White;
            dgw_personel.ColumnHeadersHeight = 29;
            dgw_personel.Dock = DockStyle.Bottom;
            dgw_personel.Location = new Point(3, 486);
            dgw_personel.Name = "dgw_personel";
            dgw_personel.RowHeadersWidth = 51;
            dgw_personel.Size = new Size(936, 286);
            dgw_personel.TabIndex = 47;
            dgw_personel.CellClick += dgw_personel_CellClick;
            // 
            // txt_pTcno
            // 
            txt_pTcno.Location = new Point(154, 35);
            txt_pTcno.MaxLength = 11;
            txt_pTcno.Name = "txt_pTcno";
            txt_pTcno.Size = new Size(125, 30);
            txt_pTcno.TabIndex = 26;
            txt_pTcno.KeyPress += txt_pTcno_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(89, 319);
            label12.Name = "label12";
            label12.Size = new Size(59, 23);
            label12.TabIndex = 46;
            label12.Text = "Görevi";
            // 
            // txt_pAdi
            // 
            txt_pAdi.CharacterCasing = CharacterCasing.Upper;
            txt_pAdi.Location = new Point(154, 82);
            txt_pAdi.Name = "txt_pAdi";
            txt_pAdi.Size = new Size(125, 30);
            txt_pAdi.TabIndex = 27;
            txt_pAdi.KeyPress += txt_pAdi_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(36, 219);
            label13.Name = "label13";
            label13.Size = new Size(112, 23);
            label13.TabIndex = 45;
            label13.Text = "Doğum Tarihi";
            // 
            // txt_pSoyadi
            // 
            txt_pSoyadi.CharacterCasing = CharacterCasing.Upper;
            txt_pSoyadi.Location = new Point(154, 130);
            txt_pSoyadi.Name = "txt_pSoyadi";
            txt_pSoyadi.Size = new Size(125, 30);
            txt_pSoyadi.TabIndex = 28;
            txt_pSoyadi.KeyPress += txt_pSoyadi_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(55, 270);
            label14.Name = "label14";
            label14.Size = new Size(93, 23);
            label14.TabIndex = 44;
            label14.Text = "Mezuniyeti";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(79, 178);
            label15.Name = "label15";
            label15.Size = new Size(69, 23);
            label15.TabIndex = 43;
            label15.Text = "Cinsiyet";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(88, 133);
            label16.Name = "label16";
            label16.Size = new Size(60, 23);
            label16.TabIndex = 42;
            label16.Text = "Soyadı";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(113, 80);
            label17.Name = "label17";
            label17.Size = new Size(35, 23);
            label17.TabIndex = 41;
            label17.Text = "Adı";
            // 
            // rb_erkek
            // 
            rb_erkek.AutoSize = true;
            rb_erkek.Checked = true;
            rb_erkek.Cursor = Cursors.Hand;
            rb_erkek.Location = new Point(154, 178);
            rb_erkek.Name = "rb_erkek";
            rb_erkek.Size = new Size(71, 27);
            rb_erkek.TabIndex = 32;
            rb_erkek.TabStop = true;
            rb_erkek.Text = "Erkek";
            rb_erkek.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(37, 38);
            label18.Name = "label18";
            label18.Size = new Size(116, 23);
            label18.TabIndex = 40;
            label18.Text = "T.C. Kimlik No";
            // 
            // rb_kadin
            // 
            rb_kadin.AutoSize = true;
            rb_kadin.Cursor = Cursors.Hand;
            rb_kadin.Location = new Point(231, 178);
            rb_kadin.Name = "rb_kadin";
            rb_kadin.Size = new Size(74, 27);
            rb_kadin.TabIndex = 33;
            rb_kadin.TabStop = true;
            rb_kadin.Text = "Kadın";
            rb_kadin.UseVisualStyleBackColor = true;
            // 
            // btn_pAra
            // 
            btn_pAra.BackColor = Color.White;
            btn_pAra.Cursor = Cursors.Hand;
            btn_pAra.Font = new Font("Segoe UI", 10.2F);
            btn_pAra.ForeColor = SystemColors.ActiveCaptionText;
            btn_pAra.Location = new Point(285, 33);
            btn_pAra.Name = "btn_pAra";
            btn_pAra.Size = new Size(94, 32);
            btn_pAra.TabIndex = 39;
            btn_pAra.Text = "Ara";
            btn_pAra.UseVisualStyleBackColor = true;
            btn_pAra.Click += btn_pAra_Click;
            btn_pAra.MouseEnter += btn_pAra_MouseEnter;
            btn_pAra.MouseLeave += btn_pAra_MouseLeave;
            // 
            // btn_pKayit
            // 
            btn_pKayit.BackColor = Color.White;
            btn_pKayit.Cursor = Cursors.Hand;
            btn_pKayit.Font = new Font("Segoe UI", 10.2F);
            btn_pKayit.ForeColor = SystemColors.ActiveCaptionText;
            btn_pKayit.Location = new Point(403, 414);
            btn_pKayit.Name = "btn_pKayit";
            btn_pKayit.Size = new Size(109, 36);
            btn_pKayit.TabIndex = 34;
            btn_pKayit.Text = "Kaydet";
            btn_pKayit.UseVisualStyleBackColor = false;
            btn_pKayit.Click += btn_pKayit_Click;
            btn_pKayit.MouseEnter += btn_pKayit_MouseEnter;
            btn_pKayit.MouseLeave += btn_pKayit_MouseLeave;
            // 
            // btn_pGuncelle
            // 
            btn_pGuncelle.BackColor = Color.White;
            btn_pGuncelle.Cursor = Cursors.Hand;
            btn_pGuncelle.Font = new Font("Segoe UI", 10.2F);
            btn_pGuncelle.ForeColor = SystemColors.ActiveCaptionText;
            btn_pGuncelle.Location = new Point(633, 414);
            btn_pGuncelle.Name = "btn_pGuncelle";
            btn_pGuncelle.Size = new Size(109, 36);
            btn_pGuncelle.TabIndex = 35;
            btn_pGuncelle.Text = "Güncelle";
            btn_pGuncelle.UseVisualStyleBackColor = true;
            btn_pGuncelle.Click += btn_pGuncelle_Click;
            btn_pGuncelle.MouseEnter += btn_pGuncelle_MouseEnter;
            btn_pGuncelle.MouseLeave += btn_pGuncelle_MouseLeave;
            // 
            // btn_pTemizle
            // 
            btn_pTemizle.BackColor = Color.White;
            btn_pTemizle.Cursor = Cursors.Hand;
            btn_pTemizle.Font = new Font("Segoe UI", 10.2F);
            btn_pTemizle.ForeColor = SystemColors.ActiveCaptionText;
            btn_pTemizle.Location = new Point(748, 413);
            btn_pTemizle.Name = "btn_pTemizle";
            btn_pTemizle.Size = new Size(152, 36);
            btn_pTemizle.TabIndex = 37;
            btn_pTemizle.Text = "Formu Temizle";
            btn_pTemizle.UseVisualStyleBackColor = true;
            btn_pTemizle.Click += btn_pTemizle_Click;
            btn_pTemizle.MouseEnter += btn_pTemizle_MouseEnter;
            btn_pTemizle.MouseLeave += btn_pTemizle_MouseLeave;
            // 
            // btn_pSil
            // 
            btn_pSil.BackColor = Color.White;
            btn_pSil.Cursor = Cursors.Hand;
            btn_pSil.Font = new Font("Segoe UI", 10.2F);
            btn_pSil.ForeColor = SystemColors.ActiveCaptionText;
            btn_pSil.Location = new Point(518, 414);
            btn_pSil.Name = "btn_pSil";
            btn_pSil.Size = new Size(109, 35);
            btn_pSil.TabIndex = 36;
            btn_pSil.Text = "Sil";
            btn_pSil.UseVisualStyleBackColor = true;
            btn_pSil.Click += btn_pSil_Click;
            btn_pSil.MouseEnter += btn_pSil_MouseEnter;
            btn_pSil.MouseLeave += btn_pSil_MouseLeave;
            // 
            // picb_giren
            // 
            picb_giren.BackColor = SystemColors.Control;
            picb_giren.Image = (Image)resources.GetObject("picb_giren.Image");
            picb_giren.Location = new Point(991, 109);
            picb_giren.Name = "picb_giren";
            picb_giren.Size = new Size(217, 245);
            picb_giren.SizeMode = PictureBoxSizeMode.StretchImage;
            picb_giren.TabIndex = 22;
            picb_giren.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(993, 372);
            label8.Name = "label8";
            label8.Size = new Size(112, 23);
            label8.TabIndex = 23;
            label8.Text = "Aktif Kullanıcı";
            // 
            // lbl_giren
            // 
            lbl_giren.AutoSize = true;
            lbl_giren.Font = new Font("Segoe UI", 10.2F);
            lbl_giren.ForeColor = Color.Green;
            lbl_giren.Location = new Point(993, 395);
            lbl_giren.Name = "lbl_giren";
            lbl_giren.Size = new Size(126, 23);
            lbl_giren.TabIndex = 24;
            lbl_giren.Text = "KULLANICI ADI";
            // 
            // uyari
            // 
            uyari.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1241, 64);
            panel1.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(12, 17);
            label9.Name = "label9";
            label9.Size = new Size(318, 28);
            label9.TabIndex = 3;
            label9.Text = "Personel Takip Sistemine Hoşgeldin";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(1122, 16);
            button2.Name = "button2";
            button2.Size = new Size(45, 36);
            button2.TabIndex = 2;
            button2.Text = "❒";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(1071, 17);
            button1.Name = "button1";
            button1.Size = new Size(45, 36);
            button1.TabIndex = 1;
            button1.Text = "―";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_exit.Location = new Point(1173, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(56, 42);
            btn_exit.TabIndex = 0;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            btn_exit.MouseEnter += btn_exit_MouseEnter;
            btn_exit.MouseLeave += btn_exit_MouseLeave;
            // 
            // frm_islemler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1241, 884);
            Controls.Add(panel1);
            Controls.Add(lbl_giren);
            Controls.Add(picb_giren);
            Controls.Add(label8);
            Controls.Add(tb_islemler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_islemler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_islemler";
            Load += frm_islemler_Load;
            tb_islemler.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_kullanici).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picb_personel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgw_personel).EndInit();
            ((System.ComponentModel.ISupportInitialize)picb_giren).EndInit();
            ((System.ComponentModel.ISupportInitialize)uyari).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_kimlik;
        private TextBox txt_adi;
        private TextBox txt_soyadi;
        private TextBox txt_kulAdi;
        private TextBox txt_parola;
        private TextBox txt_tekrarParola;
        private RadioButton rb_yonetici;
        private RadioButton rb_kullanici;
        private Button btn_kaydet;
        private Button btn_guncelle;
        private Button btn_sil;
        private Button btn_frmTemizle;
        private ProgressBar pb_gucParola;
        private Button btn_ara;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TabControl tb_islemler;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox picb_giren;
        private Label label8;
        private Label lbl_giren;
        private Label lbl_kriter;
        private DataGridView dgw_kullanici;
        private ComboBox cb_mezuniyet;
        private Label label20;
        private Label label19;
        private DataGridView dgw_personel;
        private TextBox txt_pTcno;
        private Label label12;
        private TextBox txt_pAdi;
        private Label label13;
        private TextBox txt_pSoyadi;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private RadioButton rb_erkek;
        private Label label18;
        private RadioButton rb_kadin;
        private Button btn_pAra;
        private Button btn_pKayit;
        private Button btn_pGuncelle;
        private Button btn_pTemizle;
        private Button btn_pSil;
        private PictureBox picb_personel;
        private Button btn_pGozat;
        private DateTimePicker dtp_dogum;
        private ComboBox cb_gYeri;
        private ComboBox cb_gorev;
        private Label lbl_skor;
        private Label lbl_seviye;
        private ErrorProvider uyari;
        private TextBox txt_maas;
        private Panel panel1;
        private Label label9;
        private Button button2;
        private Button button1;
        private Button btn_exit;
    }
}