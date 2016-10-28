namespace OgrenciKayit
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
            this.components = new System.ComponentModel.Container();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lstOgrenci = new System.Windows.Forms.ListBox();
            this.cmsOgrenciDuzenle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.denemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deneme1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deneme2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.denee3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dddToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ddddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.cmsOgrenciDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(379, 6);
            this.txtArama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(185, 22);
            this.txtArama.TabIndex = 18;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(211, 127);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(101, 62);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lstOgrenci
            // 
            this.lstOgrenci.ContextMenuStrip = this.cmsOgrenciDuzenle;
            this.lstOgrenci.FormattingEnabled = true;
            this.lstOgrenci.ItemHeight = 16;
            this.lstOgrenci.Location = new System.Drawing.Point(379, 36);
            this.lstOgrenci.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstOgrenci.Name = "lstOgrenci";
            this.lstOgrenci.Size = new System.Drawing.Size(185, 340);
            this.lstOgrenci.TabIndex = 17;
            this.lstOgrenci.SelectedIndexChanged += new System.EventHandler(this.lstOgrenci_SelectedIndexChanged);
            // 
            // cmsOgrenciDuzenle
            // 
            this.cmsOgrenciDuzenle.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOgrenciDuzenle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.güncelleToolStripMenuItem,
            this.toolStripSeparator1,
            this.denemeToolStripMenuItem});
            this.cmsOgrenciDuzenle.Name = "cmsOgrenciDuzenle";
            this.cmsOgrenciDuzenle.Size = new System.Drawing.Size(142, 88);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.silToolStripMenuItem.Text = "&Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.güncelleToolStripMenuItem.Text = "Gü&ncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // denemeToolStripMenuItem
            // 
            this.denemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deneme1ToolStripMenuItem,
            this.deneme2ToolStripMenuItem,
            this.denee3ToolStripMenuItem});
            this.denemeToolStripMenuItem.Name = "denemeToolStripMenuItem";
            this.denemeToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.denemeToolStripMenuItem.Text = "Deneme";
            // 
            // deneme1ToolStripMenuItem
            // 
            this.deneme1ToolStripMenuItem.Name = "deneme1ToolStripMenuItem";
            this.deneme1ToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.deneme1ToolStripMenuItem.Text = "deneme1";
            // 
            // deneme2ToolStripMenuItem
            // 
            this.deneme2ToolStripMenuItem.Name = "deneme2ToolStripMenuItem";
            this.deneme2ToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.deneme2ToolStripMenuItem.Text = "Deneme2";
            // 
            // denee3ToolStripMenuItem
            // 
            this.denee3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dddToolStripMenuItem,
            this.dddToolStripMenuItem1,
            this.ddddToolStripMenuItem});
            this.denee3ToolStripMenuItem.Name = "denee3ToolStripMenuItem";
            this.denee3ToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.denee3ToolStripMenuItem.Text = "denee3";
            // 
            // dddToolStripMenuItem
            // 
            this.dddToolStripMenuItem.Name = "dddToolStripMenuItem";
            this.dddToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.dddToolStripMenuItem.Text = "ddd";
            // 
            // dddToolStripMenuItem1
            // 
            this.dddToolStripMenuItem1.Name = "dddToolStripMenuItem1";
            this.dddToolStripMenuItem1.Size = new System.Drawing.Size(120, 26);
            this.dddToolStripMenuItem1.Text = "ddd";
            // 
            // ddddToolStripMenuItem
            // 
            this.ddddToolStripMenuItem.Name = "ddddToolStripMenuItem";
            this.ddddToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.ddddToolStripMenuItem.Text = "dddd";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(112, 90);
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(200, 24);
            this.cmbCinsiyet.TabIndex = 15;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(112, 62);
            this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpDogumTarihi.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(112, 33);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 22);
            this.txtSoyad.TabIndex = 13;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(112, 6);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 22);
            this.txtAd.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 389);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.lstOgrenci);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Öğrenci Kayıt Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsOgrenciDuzenle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lstOgrenci;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ContextMenuStrip cmsOgrenciDuzenle;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem denemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deneme1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deneme2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem denee3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dddToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ddddToolStripMenuItem;
    }
}

