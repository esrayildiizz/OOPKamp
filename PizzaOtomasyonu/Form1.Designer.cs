﻿namespace PizzaOtomasyonu
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEbat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listPizzalar = new System.Windows.Forms.ListBox();
            this.rdbInceKenar = new System.Windows.Forms.RadioButton();
            this.rdbKalinKenar = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.listSepet = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnSiparisiOnayla = new System.Windows.Forms.Button();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(813, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "PİZZA OTOMASYONU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ebat :";
            // 
            // cmbEbat
            // 
            this.cmbEbat.FormattingEnabled = true;
            this.cmbEbat.Location = new System.Drawing.Point(12, 91);
            this.cmbEbat.Name = "cmbEbat";
            this.cmbEbat.Size = new System.Drawing.Size(264, 24);
            this.cmbEbat.TabIndex = 2;
            this.cmbEbat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pizzalar :";
            // 
            // listPizzalar
            // 
            this.listPizzalar.FormattingEnabled = true;
            this.listPizzalar.ItemHeight = 16;
            this.listPizzalar.Location = new System.Drawing.Point(15, 159);
            this.listPizzalar.Name = "listPizzalar";
            this.listPizzalar.Size = new System.Drawing.Size(261, 84);
            this.listPizzalar.TabIndex = 4;
            // 
            // rdbInceKenar
            // 
            this.rdbInceKenar.AutoSize = true;
            this.rdbInceKenar.Checked = true;
            this.rdbInceKenar.Location = new System.Drawing.Point(27, 264);
            this.rdbInceKenar.Name = "rdbInceKenar";
            this.rdbInceKenar.Size = new System.Drawing.Size(91, 20);
            this.rdbInceKenar.TabIndex = 5;
            this.rdbInceKenar.TabStop = true;
            this.rdbInceKenar.Text = "İnce Kenar";
            this.rdbInceKenar.UseVisualStyleBackColor = true;
            // 
            // rdbKalinKenar
            // 
            this.rdbKalinKenar.AutoSize = true;
            this.rdbKalinKenar.Location = new System.Drawing.Point(162, 264);
            this.rdbKalinKenar.Name = "rdbKalinKenar";
            this.rdbKalinKenar.Size = new System.Drawing.Size(95, 20);
            this.rdbKalinKenar.TabIndex = 6;
            this.rdbKalinKenar.Text = "Kalın Kenar";
            this.rdbKalinKenar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox10);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 163);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Malzemeler";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Dana Jambon";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(8, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(63, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Sosis";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(8, 73);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(57, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Mısır";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(8, 99);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(73, 20);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Ançuez";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(8, 125);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(65, 20);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Zeytin";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(128, 125);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(67, 20);
            this.checkBox6.TabIndex = 9;
            this.checkBox6.Text = "Peynir";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(128, 99);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(90, 20);
            this.checkBox7.TabIndex = 8;
            this.checkBox7.Text = "Ton Balığı";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(128, 73);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(70, 20);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "Mantar";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(128, 47);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(66, 20);
            this.checkBox9.TabIndex = 6;
            this.checkBox9.Text = "Sucuk";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(128, 21);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(68, 20);
            this.checkBox10.TabIndex = 5;
            this.checkBox10.Text = "Salam";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adet :";
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(70, 495);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(87, 22);
            this.nudAdet.TabIndex = 9;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(187, 495);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(89, 23);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tutar :";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(350, 496);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 22);
            this.txtTutar.TabIndex = 12;
            // 
            // listSepet
            // 
            this.listSepet.FormattingEnabled = true;
            this.listSepet.ItemHeight = 16;
            this.listSepet.Location = new System.Drawing.Point(303, 91);
            this.listSepet.Name = "listSepet";
            this.listSepet.Size = new System.Drawing.Size(470, 372);
            this.listSepet.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(571, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Toplam Tutar :";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(671, 466);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(0, 16);
            this.lblToplamTutar.TabIndex = 15;
            this.lblToplamTutar.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnSiparisiOnayla
            // 
            this.btnSiparisiOnayla.Location = new System.Drawing.Point(574, 512);
            this.btnSiparisiOnayla.Name = "btnSiparisiOnayla";
            this.btnSiparisiOnayla.Size = new System.Drawing.Size(172, 38);
            this.btnSiparisiOnayla.TabIndex = 16;
            this.btnSiparisiOnayla.Text = "Siparişi Onayla";
            this.btnSiparisiOnayla.UseVisualStyleBackColor = true;
            this.btnSiparisiOnayla.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(456, 495);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(106, 23);
            this.btnSepeteEkle.TabIndex = 17;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 562);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.btnSiparisiOnayla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listSepet);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdbKalinKenar);
            this.Controls.Add(this.rdbInceKenar);
            this.Controls.Add(this.listPizzalar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbEbat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEbat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listPizzalar;
        private System.Windows.Forms.RadioButton rdbInceKenar;
        private System.Windows.Forms.RadioButton rdbKalinKenar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.ListBox listSepet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnSiparisiOnayla;
        private System.Windows.Forms.Button btnSepeteEkle;
    }
}
