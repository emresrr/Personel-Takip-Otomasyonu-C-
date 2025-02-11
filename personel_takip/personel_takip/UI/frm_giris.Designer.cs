using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace personel_takip
{
    partial class frm_giris
    {
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbl_hak;
        private TextBox txt_parola;
        private Button btn_giris;
        private Button btn_cikis;
        private PictureBox pictureBox1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_giris));
            panel1 = new Panel();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            btn_exit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbl_hak = new Label();
            txt_parola = new TextBox();
            btn_giris = new Button();
            btn_cikis = new Button();
            pictureBox1 = new PictureBox();
            rb_kullanici = new RadioButton();
            txt_kulAdi = new TextBox();
            rb_yonetici = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 64);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 17);
            label5.Name = "label5";
            label5.Size = new Size(288, 28);
            label5.TabIndex = 3;
            label5.Text = "Hoşgeldiniz , lütfen giriş yapınız";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(417, 16);
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
            button1.Location = new Point(366, 17);
            button1.Name = "button1";
            button1.Size = new Size(45, 36);
            button1.TabIndex = 1;
            button1.Text = "―";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.White;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_exit.Location = new Point(468, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(56, 42);
            btn_exit.TabIndex = 0;
            btn_exit.Text = "X";
            btn_exit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            btn_exit.MouseEnter += btn_exit_MouseEnter;
            btn_exit.MouseLeave += btn_exit_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(206, 340);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(234, 439);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 3;
            label2.Text = "Parola";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(168, 566);
            label3.Name = "label3";
            label3.Size = new Size(53, 28);
            label3.TabIndex = 4;
            label3.Text = "Yetki";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(12, 754);
            label4.Name = "label4";
            label4.Size = new Size(113, 28);
            label4.TabIndex = 5;
            label4.Text = "Kalan Hak : ";
            // 
            // lbl_hak
            // 
            lbl_hak.AutoSize = true;
            lbl_hak.BackColor = Color.WhiteSmoke;
            lbl_hak.Font = new Font("Segoe UI", 12F);
            lbl_hak.ForeColor = SystemColors.HotTrack;
            lbl_hak.Location = new Point(114, 754);
            lbl_hak.Name = "lbl_hak";
            lbl_hak.Size = new Size(23, 28);
            lbl_hak.TabIndex = 6;
            lbl_hak.Text = "5";
            // 
            // txt_parola
            // 
            txt_parola.BackColor = Color.White;
            txt_parola.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_parola.Location = new Point(160, 470);
            txt_parola.MaxLength = 12;
            txt_parola.Name = "txt_parola";
            txt_parola.PasswordChar = '•';
            txt_parola.Size = new Size(214, 47);
            txt_parola.TabIndex = 12;
            // 
            // btn_giris
            // 
            btn_giris.BackColor = Color.White;
            btn_giris.Cursor = Cursors.Hand;
            btn_giris.FlatAppearance.BorderColor = Color.White;
            btn_giris.FlatAppearance.BorderSize = 15;
            btn_giris.FlatAppearance.MouseDownBackColor = Color.White;
            btn_giris.Font = new Font("Segoe UI", 12F);
            btn_giris.ForeColor = SystemColors.ActiveCaptionText;
            btn_giris.Location = new Point(288, 662);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(132, 47);
            btn_giris.TabIndex = 7;
            btn_giris.Text = "Oturum Aç";
            btn_giris.UseVisualStyleBackColor = false;
            btn_giris.Click += btn_giris_Click;
            btn_giris.MouseEnter += btn_giris_MouseEnter;
            btn_giris.MouseLeave += btn_giris_MouseLeave;
            // 
            // btn_cikis
            // 
            btn_cikis.BackColor = Color.White;
            btn_cikis.Cursor = Cursors.Hand;
            btn_cikis.FlatAppearance.BorderColor = Color.White;
            btn_cikis.FlatAppearance.BorderSize = 15;
            btn_cikis.FlatAppearance.MouseDownBackColor = Color.White;
            btn_cikis.Font = new Font("Segoe UI", 12F);
            btn_cikis.ForeColor = SystemColors.ActiveCaptionText;
            btn_cikis.Location = new Point(114, 662);
            btn_cikis.Name = "btn_cikis";
            btn_cikis.Size = new Size(132, 47);
            btn_cikis.TabIndex = 13;
            btn_cikis.Text = "Çıkış";
            btn_cikis.UseVisualStyleBackColor = false;
            btn_cikis.Click += btn_cikis_Click;
            btn_cikis.MouseEnter += btn_cikis_MouseEnter;
            btn_cikis.MouseLeave += btn_cikis_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(143, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(248, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // rb_kullanici
            // 
            rb_kullanici.AutoSize = true;
            rb_kullanici.BackColor = Color.WhiteSmoke;
            rb_kullanici.Cursor = Cursors.Hand;
            rb_kullanici.FlatStyle = FlatStyle.System;
            rb_kullanici.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rb_kullanici.ForeColor = SystemColors.ControlText;
            rb_kullanici.Location = new Point(248, 585);
            rb_kullanici.Name = "rb_kullanici";
            rb_kullanici.Size = new Size(130, 36);
            rb_kullanici.TabIndex = 10;
            rb_kullanici.TabStop = true;
            rb_kullanici.Text = "Kullanıcı";
            rb_kullanici.UseVisualStyleBackColor = false;
            // 
            // txt_kulAdi
            // 
            txt_kulAdi.BackColor = Color.White;
            txt_kulAdi.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_kulAdi.Location = new Point(160, 371);
            txt_kulAdi.MaxLength = 12;
            txt_kulAdi.Name = "txt_kulAdi";
            txt_kulAdi.Size = new Size(214, 47);
            txt_kulAdi.TabIndex = 15;
            // 
            // rb_yonetici
            // 
            rb_yonetici.AutoSize = true;
            rb_yonetici.BackColor = Color.WhiteSmoke;
            rb_yonetici.Checked = true;
            rb_yonetici.Cursor = Cursors.Hand;
            rb_yonetici.FlatAppearance.BorderColor = Color.DarkRed;
            rb_yonetici.FlatAppearance.BorderSize = 10;
            rb_yonetici.FlatAppearance.CheckedBackColor = Color.Red;
            rb_yonetici.FlatStyle = FlatStyle.System;
            rb_yonetici.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rb_yonetici.ForeColor = SystemColors.ControlText;
            rb_yonetici.Location = new Point(248, 544);
            rb_yonetici.Name = "rb_yonetici";
            rb_yonetici.Size = new Size(124, 36);
            rb_yonetici.TabIndex = 9;
            rb_yonetici.TabStop = true;
            rb_yonetici.Text = "Yönetici";
            rb_yonetici.UseVisualStyleBackColor = false;
            // 
            // frm_giris
            // 
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(534, 791);
            Controls.Add(btn_giris);
            Controls.Add(txt_kulAdi);
            Controls.Add(rb_kullanici);
            Controls.Add(rb_yonetici);
            Controls.Add(pictureBox1);
            Controls.Add(btn_cikis);
            Controls.Add(txt_parola);
            Controls.Add(lbl_hak);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_giris";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btn_exit;
        private Button button2;
        private Button button1;
        private Label label5;
        private RadioButton rb_kullanici;
        private TextBox txt_kulAdi;
        private RadioButton rb_yonetici;
    }
}
