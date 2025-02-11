namespace personel_takip
{
    partial class frm_personel
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
            dgw_personel = new DataGridView();
            picb_giren = new PictureBox();
            picb_izlenen = new PictureBox();
            lbl_giren = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_izlenen = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label12 = new Label();
            label13 = new Label();
            label16 = new Label();
            label19 = new Label();
            label20 = new Label();
            label9 = new Label();
            btn_ara = new Button();
            txt_tcno = new TextBox();
            txt_ad = new TextBox();
            txt_soyad = new TextBox();
            txt_cinsiyet = new TextBox();
            txt_dogum = new TextBox();
            txt_mezun = new TextBox();
            txt_gorev = new TextBox();
            txt_gYeri = new TextBox();
            txt_maas = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgw_personel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picb_giren).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picb_izlenen).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgw_personel
            // 
            dgw_personel.AllowUserToAddRows = false;
            dgw_personel.AllowUserToDeleteRows = false;
            dgw_personel.BackgroundColor = Color.WhiteSmoke;
            dgw_personel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_personel.Dock = DockStyle.Bottom;
            dgw_personel.Location = new Point(0, 456);
            dgw_personel.Name = "dgw_personel";
            dgw_personel.ReadOnly = true;
            dgw_personel.RowHeadersWidth = 51;
            dgw_personel.Size = new Size(1200, 358);
            dgw_personel.TabIndex = 0;
            dgw_personel.CellClick += dgw_personel_CellClick;
            // 
            // picb_giren
            // 
            picb_giren.BorderStyle = BorderStyle.Fixed3D;
            picb_giren.Location = new Point(976, 98);
            picb_giren.Name = "picb_giren";
            picb_giren.Size = new Size(212, 255);
            picb_giren.SizeMode = PictureBoxSizeMode.StretchImage;
            picb_giren.TabIndex = 1;
            picb_giren.TabStop = false;
            // 
            // picb_izlenen
            // 
            picb_izlenen.BorderStyle = BorderStyle.Fixed3D;
            picb_izlenen.Location = new Point(12, 98);
            picb_izlenen.Name = "picb_izlenen";
            picb_izlenen.Size = new Size(212, 255);
            picb_izlenen.SizeMode = PictureBoxSizeMode.StretchImage;
            picb_izlenen.TabIndex = 4;
            picb_izlenen.TabStop = false;
            // 
            // lbl_giren
            // 
            lbl_giren.AutoSize = true;
            lbl_giren.Font = new Font("Segoe UI", 10.2F);
            lbl_giren.ForeColor = Color.Green;
            lbl_giren.Location = new Point(976, 388);
            lbl_giren.Name = "lbl_giren";
            lbl_giren.Size = new Size(41, 23);
            lbl_giren.TabIndex = 2;
            lbl_giren.Text = "İsim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(976, 365);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 3;
            label2.Text = "Aktif Kullanıcı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(12, 365);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 5;
            label3.Text = "İzlenen Kullanıcı";
            // 
            // lbl_izlenen
            // 
            lbl_izlenen.AutoSize = true;
            lbl_izlenen.Font = new Font("Segoe UI", 10.2F);
            lbl_izlenen.ForeColor = Color.Blue;
            lbl_izlenen.Location = new Point(12, 388);
            lbl_izlenen.Name = "lbl_izlenen";
            lbl_izlenen.Size = new Size(101, 23);
            lbl_izlenen.TabIndex = 6;
            lbl_izlenen.Text = "İzlenen İsmi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(253, 314);
            label6.Name = "label6";
            label6.Size = new Size(56, 23);
            label6.TabIndex = 9;
            label6.Text = "Soyad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(253, 134);
            label7.Name = "label7";
            label7.Size = new Size(116, 23);
            label7.TabIndex = 10;
            label7.Text = "T.C. Kimlik No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F);
            label4.Location = new Point(253, 226);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 19;
            label4.Text = "Ad";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F);
            label12.Location = new Point(529, 223);
            label12.Name = "label12";
            label12.Size = new Size(112, 23);
            label12.TabIndex = 22;
            label12.Text = "Doğum Tarihi";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F);
            label13.Location = new Point(529, 134);
            label13.Name = "label13";
            label13.Size = new Size(69, 23);
            label13.TabIndex = 21;
            label13.Text = "Cinsiyet";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F);
            label16.Location = new Point(751, 223);
            label16.Name = "label16";
            label16.Size = new Size(87, 23);
            label16.TabIndex = 31;
            label16.Text = "Görev Yeri";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F);
            label19.Location = new Point(751, 134);
            label19.Name = "label19";
            label19.Size = new Size(55, 23);
            label19.TabIndex = 28;
            label19.Text = "Görev";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F);
            label20.Location = new Point(751, 314);
            label20.Name = "label20";
            label20.Size = new Size(50, 23);
            label20.TabIndex = 27;
            label20.Text = "Maaş";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F);
            label9.Location = new Point(529, 314);
            label9.Name = "label9";
            label9.Size = new Size(157, 23);
            label9.TabIndex = 25;
            label9.Text = "Mezuniyet Durumu";
            // 
            // btn_ara
            // 
            btn_ara.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_ara.BackColor = Color.White;
            btn_ara.Cursor = Cursors.Hand;
            btn_ara.Font = new Font("Segoe UI", 10.2F);
            btn_ara.Location = new Point(432, 168);
            btn_ara.Margin = new Padding(4, 6, 4, 6);
            btn_ara.Name = "btn_ara";
            btn_ara.Size = new Size(74, 34);
            btn_ara.TabIndex = 32;
            btn_ara.Text = "Ara";
            btn_ara.TextAlign = ContentAlignment.TopCenter;
            btn_ara.UseVisualStyleBackColor = false;
            btn_ara.Click += btn_ara_Click;
            btn_ara.MouseEnter += btn_ara_MouseEnter;
            btn_ara.MouseLeave += btn_ara_MouseLeave;
            // 
            // txt_tcno
            // 
            txt_tcno.Font = new Font("Segoe UI", 10.2F);
            txt_tcno.Location = new Point(253, 172);
            txt_tcno.Name = "txt_tcno";
            txt_tcno.Size = new Size(172, 30);
            txt_tcno.TabIndex = 33;
            // 
            // txt_ad
            // 
            txt_ad.BackColor = SystemColors.ButtonHighlight;
            txt_ad.Font = new Font("Segoe UI", 10.2F);
            txt_ad.Location = new Point(253, 263);
            txt_ad.Name = "txt_ad";
            txt_ad.ReadOnly = true;
            txt_ad.Size = new Size(180, 30);
            txt_ad.TabIndex = 42;
            // 
            // txt_soyad
            // 
            txt_soyad.BackColor = SystemColors.ButtonHighlight;
            txt_soyad.Font = new Font("Segoe UI", 10.2F);
            txt_soyad.ImeMode = ImeMode.NoControl;
            txt_soyad.Location = new Point(253, 350);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.ReadOnly = true;
            txt_soyad.Size = new Size(180, 30);
            txt_soyad.TabIndex = 50;
            // 
            // txt_cinsiyet
            // 
            txt_cinsiyet.BackColor = SystemColors.ButtonHighlight;
            txt_cinsiyet.Font = new Font("Segoe UI", 10.2F);
            txt_cinsiyet.Location = new Point(529, 172);
            txt_cinsiyet.Name = "txt_cinsiyet";
            txt_cinsiyet.ReadOnly = true;
            txt_cinsiyet.Size = new Size(183, 30);
            txt_cinsiyet.TabIndex = 51;
            // 
            // txt_dogum
            // 
            txt_dogum.BackColor = SystemColors.ButtonHighlight;
            txt_dogum.Font = new Font("Segoe UI", 10.2F);
            txt_dogum.Location = new Point(529, 263);
            txt_dogum.Name = "txt_dogum";
            txt_dogum.ReadOnly = true;
            txt_dogum.Size = new Size(183, 30);
            txt_dogum.TabIndex = 52;
            // 
            // txt_mezun
            // 
            txt_mezun.BackColor = SystemColors.ButtonHighlight;
            txt_mezun.Font = new Font("Segoe UI", 10.2F);
            txt_mezun.Location = new Point(529, 350);
            txt_mezun.Name = "txt_mezun";
            txt_mezun.ReadOnly = true;
            txt_mezun.Size = new Size(183, 30);
            txt_mezun.TabIndex = 53;
            // 
            // txt_gorev
            // 
            txt_gorev.BackColor = SystemColors.ButtonHighlight;
            txt_gorev.Font = new Font("Segoe UI", 10.2F);
            txt_gorev.Location = new Point(751, 172);
            txt_gorev.Name = "txt_gorev";
            txt_gorev.ReadOnly = true;
            txt_gorev.Size = new Size(185, 30);
            txt_gorev.TabIndex = 54;
            // 
            // txt_gYeri
            // 
            txt_gYeri.BackColor = SystemColors.ButtonHighlight;
            txt_gYeri.Font = new Font("Segoe UI", 10.2F);
            txt_gYeri.Location = new Point(751, 263);
            txt_gYeri.Name = "txt_gYeri";
            txt_gYeri.ReadOnly = true;
            txt_gYeri.Size = new Size(185, 30);
            txt_gYeri.TabIndex = 55;
            // 
            // txt_maas
            // 
            txt_maas.BackColor = SystemColors.ButtonHighlight;
            txt_maas.Font = new Font("Segoe UI", 10.2F);
            txt_maas.Location = new Point(751, 350);
            txt_maas.Name = "txt_maas";
            txt_maas.ReadOnly = true;
            txt_maas.Size = new Size(185, 30);
            txt_maas.TabIndex = 56;
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
            panel1.Size = new Size(1200, 64);
            panel1.TabIndex = 57;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 18);
            label5.Name = "label5";
            label5.Size = new Size(332, 28);
            label5.TabIndex = 3;
            label5.Text = "Personel Takip Sistemine Hoşgeldiniz";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(1081, 16);
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
            button1.Location = new Point(1030, 17);
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
            btn_exit.Location = new Point(1132, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(56, 42);
            btn_exit.TabIndex = 0;
            btn_exit.Text = "X";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            btn_exit.MouseEnter += btn_exit_MouseEnter;
            btn_exit.MouseLeave += btn_exit_MouseLeave;
            // 
            // frm_personel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1200, 814);
            Controls.Add(panel1);
            Controls.Add(txt_maas);
            Controls.Add(txt_gYeri);
            Controls.Add(txt_gorev);
            Controls.Add(txt_mezun);
            Controls.Add(txt_dogum);
            Controls.Add(txt_cinsiyet);
            Controls.Add(txt_soyad);
            Controls.Add(txt_ad);
            Controls.Add(txt_tcno);
            Controls.Add(btn_ara);
            Controls.Add(label16);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label9);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lbl_izlenen);
            Controls.Add(label3);
            Controls.Add(picb_izlenen);
            Controls.Add(label2);
            Controls.Add(lbl_giren);
            Controls.Add(picb_giren);
            Controls.Add(dgw_personel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_personel";
            Text = "Personelleri İncele";
            Load += frm_personel_Load;
            ((System.ComponentModel.ISupportInitialize)dgw_personel).EndInit();
            ((System.ComponentModel.ISupportInitialize)picb_giren).EndInit();
            ((System.ComponentModel.ISupportInitialize)picb_izlenen).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgw_personel;
        private PictureBox picb_giren;
        private PictureBox picb_izlenen;
        private Label lbl_giren;
        private Label label2;
        private Label label3;
        private Label lbl_izlenen;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label12;
        private Label label13;
        private Label label16;
        private Label label19;
        private Button btn_ara;
        private TextBox txt_tcno;
        private TextBox txt_ad;
        private Label label20;
        private Label label9;
        private  TextBox txt_soyad;
        private  TextBox txt_cinsiyet;
        private  TextBox txt_dogum;
        private  TextBox txt_mezun;
        private  TextBox txt_gorev;
        private  TextBox txt_gYeri;
        private  TextBox txt_maas;
        private Panel panel1;
        private Label label5;
        private Button button2;
        private Button button1;
        private Button btn_exit;
    }
}