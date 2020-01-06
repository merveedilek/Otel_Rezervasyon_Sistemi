﻿namespace Otel_Rezervasyon_Sistemi.Formlar
{
    partial class RezervasyonYap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonYap));
            this.cmbRezervasyonTipi = new System.Windows.Forms.ComboBox();
            this.lblRezervasyonTipi = new System.Windows.Forms.Label();
            this.nudOdaSayisi = new System.Windows.Forms.NumericUpDown();
            this.lblOdaSayisi = new System.Windows.Forms.Label();
            this.nudKisiSayisi = new System.Windows.Forms.NumericUpDown();
            this.lblKonaklayacakKisiSayisi = new System.Windows.Forms.Label();
            this.lblCikisTarihi = new System.Windows.Forms.Label();
            this.dtpCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblGirisTarihi = new System.Windows.Forms.Label();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYatakSayisi = new System.Windows.Forms.Label();
            this.cmbOdaNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRezTipAcıklama = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gBoxMusteri = new System.Windows.Forms.GroupBox();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.btnBosOda = new System.Windows.Forms.Button();
            this.btnFiyatGor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudOdaSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKisiSayisi)).BeginInit();
            this.gBoxMusteri.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRezervasyonTipi
            // 
            this.cmbRezervasyonTipi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbRezervasyonTipi.FormattingEnabled = true;
            this.cmbRezervasyonTipi.Location = new System.Drawing.Point(204, 228);
            this.cmbRezervasyonTipi.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRezervasyonTipi.Name = "cmbRezervasyonTipi";
            this.cmbRezervasyonTipi.Size = new System.Drawing.Size(122, 21);
            this.cmbRezervasyonTipi.TabIndex = 31;
            this.cmbRezervasyonTipi.SelectedIndexChanged += new System.EventHandler(this.cmbRezervasyonTipi_SelectedIndexChanged);
            // 
            // lblRezervasyonTipi
            // 
            this.lblRezervasyonTipi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRezervasyonTipi.AutoSize = true;
            this.lblRezervasyonTipi.BackColor = System.Drawing.Color.Transparent;
            this.lblRezervasyonTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRezervasyonTipi.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblRezervasyonTipi.Location = new System.Drawing.Point(56, 228);
            this.lblRezervasyonTipi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRezervasyonTipi.Name = "lblRezervasyonTipi";
            this.lblRezervasyonTipi.Size = new System.Drawing.Size(144, 17);
            this.lblRezervasyonTipi.TabIndex = 27;
            this.lblRezervasyonTipi.Text = "Rezervasyon Tipi :";
            // 
            // nudOdaSayisi
            // 
            this.nudOdaSayisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudOdaSayisi.Location = new System.Drawing.Point(205, 167);
            this.nudOdaSayisi.Margin = new System.Windows.Forms.Padding(2);
            this.nudOdaSayisi.Name = "nudOdaSayisi";
            this.nudOdaSayisi.Size = new System.Drawing.Size(40, 20);
            this.nudOdaSayisi.TabIndex = 23;
            this.nudOdaSayisi.ValueChanged += new System.EventHandler(this.nudOdaSayisi_ValueChanged);
            // 
            // lblOdaSayisi
            // 
            this.lblOdaSayisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOdaSayisi.AutoSize = true;
            this.lblOdaSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lblOdaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaSayisi.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblOdaSayisi.Location = new System.Drawing.Point(60, 170);
            this.lblOdaSayisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOdaSayisi.Name = "lblOdaSayisi";
            this.lblOdaSayisi.Size = new System.Drawing.Size(96, 17);
            this.lblOdaSayisi.TabIndex = 22;
            this.lblOdaSayisi.Text = "Oda Sayısı :";
            // 
            // nudKisiSayisi
            // 
            this.nudKisiSayisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudKisiSayisi.Location = new System.Drawing.Point(261, 122);
            this.nudKisiSayisi.Margin = new System.Windows.Forms.Padding(2);
            this.nudKisiSayisi.Name = "nudKisiSayisi";
            this.nudKisiSayisi.Size = new System.Drawing.Size(40, 20);
            this.nudKisiSayisi.TabIndex = 21;
            this.nudKisiSayisi.ValueChanged += new System.EventHandler(this.nudKisiSayisi_ValueChanged);
            // 
            // lblKonaklayacakKisiSayisi
            // 
            this.lblKonaklayacakKisiSayisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKonaklayacakKisiSayisi.AutoSize = true;
            this.lblKonaklayacakKisiSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lblKonaklayacakKisiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKonaklayacakKisiSayisi.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblKonaklayacakKisiSayisi.Location = new System.Drawing.Point(60, 122);
            this.lblKonaklayacakKisiSayisi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKonaklayacakKisiSayisi.Name = "lblKonaklayacakKisiSayisi";
            this.lblKonaklayacakKisiSayisi.Size = new System.Drawing.Size(197, 17);
            this.lblKonaklayacakKisiSayisi.TabIndex = 20;
            this.lblKonaklayacakKisiSayisi.Text = "Konaklayacak Kişi Sayısı :";
            // 
            // lblCikisTarihi
            // 
            this.lblCikisTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCikisTarihi.AutoSize = true;
            this.lblCikisTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblCikisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCikisTarihi.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCikisTarihi.Location = new System.Drawing.Point(56, 74);
            this.lblCikisTarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCikisTarihi.Name = "lblCikisTarihi";
            this.lblCikisTarihi.Size = new System.Drawing.Size(99, 17);
            this.lblCikisTarihi.TabIndex = 19;
            this.lblCikisTarihi.Text = "Çıkış Tarihi :";
            // 
            // dtpCikisTarihi
            // 
            this.dtpCikisTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpCikisTarihi.Location = new System.Drawing.Point(160, 71);
            this.dtpCikisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpCikisTarihi.Name = "dtpCikisTarihi";
            this.dtpCikisTarihi.Size = new System.Drawing.Size(165, 20);
            this.dtpCikisTarihi.TabIndex = 18;
            // 
            // dtpGirisTarihi
            // 
            this.dtpGirisTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpGirisTarihi.Location = new System.Drawing.Point(160, 22);
            this.dtpGirisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtpGirisTarihi.Name = "dtpGirisTarihi";
            this.dtpGirisTarihi.Size = new System.Drawing.Size(165, 20);
            this.dtpGirisTarihi.TabIndex = 17;
            // 
            // lblGirisTarihi
            // 
            this.lblGirisTarihi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGirisTarihi.AutoSize = true;
            this.lblGirisTarihi.BackColor = System.Drawing.Color.Transparent;
            this.lblGirisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisTarihi.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblGirisTarihi.Location = new System.Drawing.Point(57, 22);
            this.lblGirisTarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGirisTarihi.Name = "lblGirisTarihi";
            this.lblGirisTarihi.Size = new System.Drawing.Size(99, 17);
            this.lblGirisTarihi.TabIndex = 16;
            this.lblGirisTarihi.Text = "Giriş Tarihi :";
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRezervasyonYap.BackColor = System.Drawing.Color.Silver;
            this.btnRezervasyonYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervasyonYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonYap.ForeColor = System.Drawing.Color.Black;
            this.btnRezervasyonYap.Location = new System.Drawing.Point(50, 440);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(123, 49);
            this.btnRezervasyonYap.TabIndex = 32;
            this.btnRezervasyonYap.Text = "REZERVASYON YAP";
            this.btnRezervasyonYap.UseVisualStyleBackColor = false;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(56, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Oda Numaranız : ";
            // 
            // lblYatakSayisi
            // 
            this.lblYatakSayisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblYatakSayisi.AutoSize = true;
            this.lblYatakSayisi.BackColor = System.Drawing.Color.Transparent;
            this.lblYatakSayisi.Location = new System.Drawing.Point(201, 327);
            this.lblYatakSayisi.Name = "lblYatakSayisi";
            this.lblYatakSayisi.Size = new System.Drawing.Size(35, 13);
            this.lblYatakSayisi.TabIndex = 34;
            this.lblYatakSayisi.Text = "label2";
            // 
            // cmbOdaNo
            // 
            this.cmbOdaNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbOdaNo.FormattingEnabled = true;
            this.cmbOdaNo.Location = new System.Drawing.Point(205, 272);
            this.cmbOdaNo.Name = "cmbOdaNo";
            this.cmbOdaNo.Size = new System.Drawing.Size(121, 21);
            this.cmbOdaNo.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(56, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Yatak Sayisi : ";
            // 
            // lblRezTipAcıklama
            // 
            this.lblRezTipAcıklama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRezTipAcıklama.AutoSize = true;
            this.lblRezTipAcıklama.BackColor = System.Drawing.Color.Transparent;
            this.lblRezTipAcıklama.Location = new System.Drawing.Point(373, 231);
            this.lblRezTipAcıklama.Name = "lblRezTipAcıklama";
            this.lblRezTipAcıklama.Size = new System.Drawing.Size(0, 13);
            this.lblRezTipAcıklama.TabIndex = 38;
            // 
            // lblFiyat
            // 
            this.lblFiyat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.BackColor = System.Drawing.Color.Transparent;
            this.lblFiyat.Location = new System.Drawing.Point(201, 377);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(35, 13);
            this.lblFiyat.TabIndex = 39;
            this.lblFiyat.Text = "label3";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(56, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Toplam Tutar = ";
            // 
            // gBoxMusteri
            // 
            this.gBoxMusteri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gBoxMusteri.BackColor = System.Drawing.Color.Gainsboro;
            this.gBoxMusteri.Controls.Add(this.lblTCNo);
            this.gBoxMusteri.Controls.Add(this.lblSoyad);
            this.gBoxMusteri.Controls.Add(this.lblAd);
            this.gBoxMusteri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gBoxMusteri.Location = new System.Drawing.Point(667, 22);
            this.gBoxMusteri.Name = "gBoxMusteri";
            this.gBoxMusteri.Size = new System.Drawing.Size(590, 484);
            this.gBoxMusteri.TabIndex = 41;
            this.gBoxMusteri.TabStop = false;
            this.gBoxMusteri.Text = "Müşteri Giris";
            // 
            // lblTCNo
            // 
            this.lblTCNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCNo.Location = new System.Drawing.Point(372, 16);
            this.lblTCNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(63, 17);
            this.lblTCNo.TabIndex = 27;
            this.lblTCNo.Text = "TC No :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(229, 16);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(63, 17);
            this.lblSoyad.TabIndex = 26;
            this.lblSoyad.Text = "Soyad :";
            // 
            // lblAd
            // 
            this.lblAd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(80, 16);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(37, 17);
            this.lblAd.TabIndex = 25;
            this.lblAd.Text = "Ad :";
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGeriDon.BackColor = System.Drawing.Color.Silver;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.ForeColor = System.Drawing.Color.Black;
            this.btnGeriDon.Location = new System.Drawing.Point(240, 440);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(123, 49);
            this.btnGeriDon.TabIndex = 42;
            this.btnGeriDon.Text = "GERİ DÖN";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCıkıs.BackColor = System.Drawing.Color.Silver;
            this.btnCıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkıs.ForeColor = System.Drawing.Color.Black;
            this.btnCıkıs.Location = new System.Drawing.Point(427, 440);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(123, 49);
            this.btnCıkıs.TabIndex = 43;
            this.btnCıkıs.Text = "ÇIKIŞ YAP";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // btnBosOda
            // 
            this.btnBosOda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBosOda.BackColor = System.Drawing.Color.Silver;
            this.btnBosOda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBosOda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBosOda.ForeColor = System.Drawing.Color.Black;
            this.btnBosOda.Location = new System.Drawing.Point(355, 267);
            this.btnBosOda.Name = "btnBosOda";
            this.btnBosOda.Size = new System.Drawing.Size(155, 28);
            this.btnBosOda.TabIndex = 44;
            this.btnBosOda.Text = "BOŞ ODALARI GÖR";
            this.btnBosOda.UseVisualStyleBackColor = false;
            this.btnBosOda.Click += new System.EventHandler(this.btnBosOda_Click);
            // 
            // btnFiyatGor
            // 
            this.btnFiyatGor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFiyatGor.BackColor = System.Drawing.Color.Silver;
            this.btnFiyatGor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiyatGor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiyatGor.ForeColor = System.Drawing.Color.Black;
            this.btnFiyatGor.Location = new System.Drawing.Point(334, 359);
            this.btnFiyatGor.Name = "btnFiyatGor";
            this.btnFiyatGor.Size = new System.Drawing.Size(123, 49);
            this.btnFiyatGor.TabIndex = 45;
            this.btnFiyatGor.Text = "Fiyat Gör";
            this.btnFiyatGor.UseVisualStyleBackColor = false;
            this.btnFiyatGor.Click += new System.EventHandler(this.btnFiyatGor_Click);
            // 
            // RezervasyonYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Otel_Rezervasyon_Sistemi.Properties.Resources.aa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 518);
            this.Controls.Add(this.btnFiyatGor);
            this.Controls.Add(this.btnBosOda);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.gBoxMusteri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblRezTipAcıklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOdaNo);
            this.Controls.Add(this.lblYatakSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Controls.Add(this.cmbRezervasyonTipi);
            this.Controls.Add(this.lblRezervasyonTipi);
            this.Controls.Add(this.nudOdaSayisi);
            this.Controls.Add(this.lblOdaSayisi);
            this.Controls.Add(this.nudKisiSayisi);
            this.Controls.Add(this.lblKonaklayacakKisiSayisi);
            this.Controls.Add(this.lblCikisTarihi);
            this.Controls.Add(this.dtpCikisTarihi);
            this.Controls.Add(this.dtpGirisTarihi);
            this.Controls.Add(this.lblGirisTarihi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RezervasyonYap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervasyonYap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RezervasyonYap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOdaSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKisiSayisi)).EndInit();
            this.gBoxMusteri.ResumeLayout(false);
            this.gBoxMusteri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRezervasyonTipi;
        private System.Windows.Forms.Label lblRezervasyonTipi;
        private System.Windows.Forms.NumericUpDown nudOdaSayisi;
        private System.Windows.Forms.Label lblOdaSayisi;
        private System.Windows.Forms.NumericUpDown nudKisiSayisi;
        private System.Windows.Forms.Label lblKonaklayacakKisiSayisi;
        private System.Windows.Forms.Label lblCikisTarihi;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.Label lblGirisTarihi;
        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYatakSayisi;
        private System.Windows.Forms.ComboBox cmbOdaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRezTipAcıklama;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gBoxMusteri;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btnBosOda;
        private System.Windows.Forms.Button btnFiyatGor;
    }
}