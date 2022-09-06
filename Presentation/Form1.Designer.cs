namespace Presentation
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.txtNumberOfStudent = new System.Windows.Forms.TextBox();
            this.txtNumberOfEmploye = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwOkul = new System.Windows.Forms.DataGridView();
            this.grpOgretmen = new System.Windows.Forms.GroupBox();
            this.txtAd = new System.Windows.Forms.Label();
            this.txtOgretmenMaas = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.Label();
            this.txtOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.Label();
            this.txtOgretmenAdi = new System.Windows.Forms.TextBox();
            this.btnOgretmenEkle = new System.Windows.Forms.Button();
            this.btnOgretmenListele = new System.Windows.Forms.Button();
            this.btnOgretmenSil = new System.Windows.Forms.Button();
            this.btnOgretmenGuncelle = new System.Windows.Forms.Button();
            this.txtOgrenciSayisi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbEvli = new System.Windows.Forms.RadioButton();
            this.rdbBekar = new System.Windows.Forms.RadioButton();
            this.dgwOgretmen = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOkul)).BeginInit();
            this.grpOgretmen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgretmen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Okul Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğrenci Sayısı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çalışan Sayısı";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 148);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(114, 52);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(132, 148);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(114, 52);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(252, 148);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(114, 52);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(372, 148);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(114, 52);
            this.btnListele.TabIndex = 6;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Location = new System.Drawing.Point(123, 39);
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Size = new System.Drawing.Size(291, 20);
            this.txtSchoolName.TabIndex = 7;
            // 
            // txtNumberOfStudent
            // 
            this.txtNumberOfStudent.Location = new System.Drawing.Point(123, 73);
            this.txtNumberOfStudent.Name = "txtNumberOfStudent";
            this.txtNumberOfStudent.Size = new System.Drawing.Size(291, 20);
            this.txtNumberOfStudent.TabIndex = 8;
            // 
            // txtNumberOfEmploye
            // 
            this.txtNumberOfEmploye.Location = new System.Drawing.Point(123, 103);
            this.txtNumberOfEmploye.Name = "txtNumberOfEmploye";
            this.txtNumberOfEmploye.Size = new System.Drawing.Size(291, 20);
            this.txtNumberOfEmploye.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumberOfEmploye);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumberOfStudent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSchoolName);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 215);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Okul Ekle";
            // 
            // dgwOkul
            // 
            this.dgwOkul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOkul.Location = new System.Drawing.Point(12, 233);
            this.dgwOkul.Name = "dgwOkul";
            this.dgwOkul.Size = new System.Drawing.Size(592, 426);
            this.dgwOkul.TabIndex = 11;
            this.dgwOkul.SelectionChanged += new System.EventHandler(this.dgwOkul_SelectionChanged);
            // 
            // grpOgretmen
            // 
            this.grpOgretmen.Controls.Add(this.rdbBekar);
            this.grpOgretmen.Controls.Add(this.rdbEvli);
            this.grpOgretmen.Controls.Add(this.label8);
            this.grpOgretmen.Controls.Add(this.txtOgrenciSayisi);
            this.grpOgretmen.Controls.Add(this.label7);
            this.grpOgretmen.Controls.Add(this.txtAd);
            this.grpOgretmen.Controls.Add(this.txtOgretmenMaas);
            this.grpOgretmen.Controls.Add(this.txtSoyad);
            this.grpOgretmen.Controls.Add(this.txtOgretmenSoyad);
            this.grpOgretmen.Controls.Add(this.txtMaas);
            this.grpOgretmen.Controls.Add(this.txtOgretmenAdi);
            this.grpOgretmen.Controls.Add(this.btnOgretmenEkle);
            this.grpOgretmen.Controls.Add(this.btnOgretmenListele);
            this.grpOgretmen.Controls.Add(this.btnOgretmenSil);
            this.grpOgretmen.Controls.Add(this.btnOgretmenGuncelle);
            this.grpOgretmen.Location = new System.Drawing.Point(610, 12);
            this.grpOgretmen.Name = "grpOgretmen";
            this.grpOgretmen.Size = new System.Drawing.Size(592, 215);
            this.grpOgretmen.TabIndex = 12;
            this.grpOgretmen.TabStop = false;
            this.grpOgretmen.Text = "Öğretmen Ekle";
            // 
            // txtAd
            // 
            this.txtAd.AutoSize = true;
            this.txtAd.Location = new System.Drawing.Point(24, 22);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(28, 13);
            this.txtAd.TabIndex = 0;
            this.txtAd.Text = "AD :";
            // 
            // txtOgretmenMaas
            // 
            this.txtOgretmenMaas.Location = new System.Drawing.Point(132, 69);
            this.txtOgretmenMaas.Name = "txtOgretmenMaas";
            this.txtOgretmenMaas.Size = new System.Drawing.Size(291, 20);
            this.txtOgretmenMaas.TabIndex = 9;
            // 
            // txtSoyad
            // 
            this.txtSoyad.AutoSize = true;
            this.txtSoyad.Location = new System.Drawing.Point(24, 46);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(50, 13);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Text = "SOYAD :";
            // 
            // txtOgretmenSoyad
            // 
            this.txtOgretmenSoyad.Location = new System.Drawing.Point(132, 42);
            this.txtOgretmenSoyad.Name = "txtOgretmenSoyad";
            this.txtOgretmenSoyad.Size = new System.Drawing.Size(291, 20);
            this.txtOgretmenSoyad.TabIndex = 8;
            // 
            // txtMaas
            // 
            this.txtMaas.AutoSize = true;
            this.txtMaas.Location = new System.Drawing.Point(24, 73);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(43, 13);
            this.txtMaas.TabIndex = 2;
            this.txtMaas.Text = "MAAŞ :";
            // 
            // txtOgretmenAdi
            // 
            this.txtOgretmenAdi.Location = new System.Drawing.Point(132, 19);
            this.txtOgretmenAdi.Name = "txtOgretmenAdi";
            this.txtOgretmenAdi.Size = new System.Drawing.Size(291, 20);
            this.txtOgretmenAdi.TabIndex = 7;
            // 
            // btnOgretmenEkle
            // 
            this.btnOgretmenEkle.Location = new System.Drawing.Point(12, 148);
            this.btnOgretmenEkle.Name = "btnOgretmenEkle";
            this.btnOgretmenEkle.Size = new System.Drawing.Size(114, 52);
            this.btnOgretmenEkle.TabIndex = 3;
            this.btnOgretmenEkle.Text = "Ekle";
            this.btnOgretmenEkle.UseVisualStyleBackColor = true;
            this.btnOgretmenEkle.Click += new System.EventHandler(this.btnOgretmenEkle_Click);
            // 
            // btnOgretmenListele
            // 
            this.btnOgretmenListele.Location = new System.Drawing.Point(372, 148);
            this.btnOgretmenListele.Name = "btnOgretmenListele";
            this.btnOgretmenListele.Size = new System.Drawing.Size(114, 52);
            this.btnOgretmenListele.TabIndex = 6;
            this.btnOgretmenListele.Text = "Listele";
            this.btnOgretmenListele.UseVisualStyleBackColor = true;
            this.btnOgretmenListele.Click += new System.EventHandler(this.btnOgretmenListele_Click);
            // 
            // btnOgretmenSil
            // 
            this.btnOgretmenSil.Location = new System.Drawing.Point(132, 148);
            this.btnOgretmenSil.Name = "btnOgretmenSil";
            this.btnOgretmenSil.Size = new System.Drawing.Size(114, 52);
            this.btnOgretmenSil.TabIndex = 4;
            this.btnOgretmenSil.Text = "Sil";
            this.btnOgretmenSil.UseVisualStyleBackColor = true;
            this.btnOgretmenSil.Click += new System.EventHandler(this.btnOgretmenSil_Click);
            // 
            // btnOgretmenGuncelle
            // 
            this.btnOgretmenGuncelle.Location = new System.Drawing.Point(252, 148);
            this.btnOgretmenGuncelle.Name = "btnOgretmenGuncelle";
            this.btnOgretmenGuncelle.Size = new System.Drawing.Size(114, 52);
            this.btnOgretmenGuncelle.TabIndex = 5;
            this.btnOgretmenGuncelle.Text = "Güncelle";
            this.btnOgretmenGuncelle.UseVisualStyleBackColor = true;
            this.btnOgretmenGuncelle.Click += new System.EventHandler(this.btnOgretmenGuncelle_Click);
            // 
            // txtOgrenciSayisi
            // 
            this.txtOgrenciSayisi.Location = new System.Drawing.Point(132, 95);
            this.txtOgrenciSayisi.Name = "txtOgrenciSayisi";
            this.txtOgrenciSayisi.Size = new System.Drawing.Size(291, 20);
            this.txtOgrenciSayisi.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Öğr Sayısı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Menedi Durumu :";
            // 
            // rdbEvli
            // 
            this.rdbEvli.AutoSize = true;
            this.rdbEvli.Location = new System.Drawing.Point(132, 121);
            this.rdbEvli.Name = "rdbEvli";
            this.rdbEvli.Size = new System.Drawing.Size(48, 17);
            this.rdbEvli.TabIndex = 13;
            this.rdbEvli.TabStop = true;
            this.rdbEvli.Text = "EVLİ";
            this.rdbEvli.UseVisualStyleBackColor = true;
            // 
            // rdbBekar
            // 
            this.rdbBekar.AutoSize = true;
            this.rdbBekar.Location = new System.Drawing.Point(223, 121);
            this.rdbBekar.Name = "rdbBekar";
            this.rdbBekar.Size = new System.Drawing.Size(61, 17);
            this.rdbBekar.TabIndex = 14;
            this.rdbBekar.TabStop = true;
            this.rdbBekar.Text = "BEKAR";
            this.rdbBekar.UseVisualStyleBackColor = true;
            // 
            // dgwOgretmen
            // 
            this.dgwOgretmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgretmen.Location = new System.Drawing.Point(610, 233);
            this.dgwOgretmen.Name = "dgwOgretmen";
            this.dgwOgretmen.Size = new System.Drawing.Size(592, 426);
            this.dgwOgretmen.TabIndex = 13;
            this.dgwOgretmen.SelectionChanged += new System.EventHandler(this.dgwOgretmen_SelectionChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 671);
            this.Controls.Add(this.dgwOgretmen);
            this.Controls.Add(this.grpOgretmen);
            this.Controls.Add(this.dgwOkul);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOkul)).EndInit();
            this.grpOgretmen.ResumeLayout(false);
            this.grpOgretmen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgretmen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.TextBox txtNumberOfStudent;
        private System.Windows.Forms.TextBox txtNumberOfEmploye;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwOkul;
        private System.Windows.Forms.GroupBox grpOgretmen;
        private System.Windows.Forms.Label txtAd;
        private System.Windows.Forms.TextBox txtOgretmenMaas;
        private System.Windows.Forms.Label txtSoyad;
        private System.Windows.Forms.TextBox txtOgretmenSoyad;
        private System.Windows.Forms.Label txtMaas;
        private System.Windows.Forms.TextBox txtOgretmenAdi;
        private System.Windows.Forms.Button btnOgretmenEkle;
        private System.Windows.Forms.Button btnOgretmenListele;
        private System.Windows.Forms.Button btnOgretmenSil;
        private System.Windows.Forms.Button btnOgretmenGuncelle;
        private System.Windows.Forms.TextBox txtOgrenciSayisi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbBekar;
        private System.Windows.Forms.RadioButton rdbEvli;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgwOgretmen;
    }
}

