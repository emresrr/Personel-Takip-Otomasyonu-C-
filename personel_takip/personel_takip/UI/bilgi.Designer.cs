namespace personel_takip.UI
{
    partial class bilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bilgi));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            lbl_bilgi = new Label();
            btn_tamam = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 66);
            panel1.TabIndex = 62;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(397, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(120, 9);
            label5.Name = "label5";
            label5.Size = new Size(227, 38);
            label5.TabIndex = 3;
            label5.Text = "BİLGİLENDİRME";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(lbl_bilgi);
            panel2.Location = new Point(12, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 106);
            panel2.TabIndex = 64;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(10, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 89);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // lbl_bilgi
            // 
            lbl_bilgi.AutoSize = true;
            lbl_bilgi.Location = new Point(96, 17);
            lbl_bilgi.Name = "lbl_bilgi";
            lbl_bilgi.Size = new Size(328, 20);
            lbl_bilgi.TabIndex = 0;
            lbl_bilgi.Text = "Dikkat bu bir uyarı mesajıdır lütfen dikkat ediniz.";
            // 
            // btn_tamam
            // 
            btn_tamam.BackColor = Color.White;
            btn_tamam.Cursor = Cursors.Hand;
            btn_tamam.FlatAppearance.BorderColor = Color.White;
            btn_tamam.FlatAppearance.BorderSize = 15;
            btn_tamam.FlatAppearance.MouseDownBackColor = Color.White;
            btn_tamam.FlatStyle = FlatStyle.System;
            btn_tamam.Font = new Font("Segoe UI", 12F);
            btn_tamam.ForeColor = SystemColors.ActiveCaptionText;
            btn_tamam.Location = new Point(363, 184);
            btn_tamam.Name = "btn_tamam";
            btn_tamam.Size = new Size(92, 37);
            btn_tamam.TabIndex = 63;
            btn_tamam.Text = "Tamam";
            btn_tamam.UseVisualStyleBackColor = false;
            btn_tamam.Click += btn_tamam_Click_1;
            // 
            // bilgi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 233);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btn_tamam);
            FormBorderStyle = FormBorderStyle.None;
            Name = "bilgi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_bilgi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label lbl_bilgi;
        private Button btn_tamam;
    }
}