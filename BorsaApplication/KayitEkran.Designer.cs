
namespace BorsaApplication
{
    partial class KayitEkran
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
            this.btnKayit = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mtxTc = new System.Windows.Forms.MaskedTextBox();
            this.mtxTel = new System.Windows.Forms.MaskedTextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAd = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.grpKayit = new System.Windows.Forms.GroupBox();
            this.grpKayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.Lime;
            this.btnKayit.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKayit.Location = new System.Drawing.Point(132, 515);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(186, 54);
            this.btnKayit.TabIndex = 22;
            this.btnKayit.Text = "KAYIT OL";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.AcceptsReturn = true;
            this.txtSifre.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSifre.Location = new System.Drawing.Point(133, 427);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(281, 34);
            this.txtSifre.TabIndex = 8;
            // 
            // txtMail
            // 
            this.txtMail.AcceptsTab = true;
            this.txtMail.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(133, 326);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(281, 34);
            this.txtMail.TabIndex = 6;
            // 
            // txtAdres
            // 
            this.txtAdres.AcceptsTab = true;
            this.txtAdres.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdres.Location = new System.Drawing.Point(134, 244);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(281, 64);
            this.txtAdres.TabIndex = 5;
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.AcceptsReturn = true;
            this.txtKullaniciAd.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKullaniciAd.Location = new System.Drawing.Point(133, 376);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(281, 34);
            this.txtKullaniciAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.AcceptsReturn = true;
            this.txtSoyad.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoyad.Location = new System.Drawing.Point(133, 97);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(281, 34);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtAd
            // 
            this.txtAd.AcceptsReturn = true;
            this.txtAd.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAd.Location = new System.Drawing.Point(133, 45);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(281, 34);
            this.txtAd.TabIndex = 1;
            // 
            // mtxTc
            // 
            this.mtxTc.AllowDrop = true;
            this.mtxTc.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxTc.Location = new System.Drawing.Point(133, 145);
            this.mtxTc.Mask = "00000000000";
            this.mtxTc.Name = "mtxTc";
            this.mtxTc.Size = new System.Drawing.Size(281, 34);
            this.mtxTc.TabIndex = 3;
            this.mtxTc.ValidatingType = typeof(int);
            // 
            // mtxTel
            // 
            this.mtxTel.AllowDrop = true;
            this.mtxTel.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxTel.Location = new System.Drawing.Point(133, 195);
            this.mtxTel.Mask = "(999) 000-0000";
            this.mtxTel.Name = "mtxTel";
            this.mtxTel.Size = new System.Drawing.Size(281, 34);
            this.mtxTel.TabIndex = 4;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(70, 427);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(57, 24);
            this.lblSifre.TabIndex = 26;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblKullaniciAd
            // 
            this.lblKullaniciAd.AutoSize = true;
            this.lblKullaniciAd.Location = new System.Drawing.Point(5, 376);
            this.lblKullaniciAd.Name = "lblKullaniciAd";
            this.lblKullaniciAd.Size = new System.Drawing.Size(122, 24);
            this.lblKullaniciAd.TabIndex = 25;
            this.lblKullaniciAd.Text = "Kullanıcı Adı:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(56, 327);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(71, 24);
            this.lblMail.TabIndex = 24;
            this.lblMail.Text = "E-mail:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(62, 263);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(65, 24);
            this.lblAdres.TabIndex = 23;
            this.lblAdres.Text = "Adres:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(49, 198);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(80, 24);
            this.lblTel.TabIndex = 22;
            this.lblTel.Text = "Telefon:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(6, 148);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(124, 24);
            this.lblTc.TabIndex = 21;
            this.lblTc.Text = "Tc Kimlik No:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(59, 100);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(70, 24);
            this.lblSoyad.TabIndex = 20;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(87, 51);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(40, 24);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad:";
            // 
            // grpKayit
            // 
            this.grpKayit.BackColor = System.Drawing.Color.AliceBlue;
            this.grpKayit.Controls.Add(this.txtSifre);
            this.grpKayit.Controls.Add(this.txtMail);
            this.grpKayit.Controls.Add(this.txtAdres);
            this.grpKayit.Controls.Add(this.txtKullaniciAd);
            this.grpKayit.Controls.Add(this.txtSoyad);
            this.grpKayit.Controls.Add(this.txtAd);
            this.grpKayit.Controls.Add(this.mtxTc);
            this.grpKayit.Controls.Add(this.mtxTel);
            this.grpKayit.Controls.Add(this.lblSifre);
            this.grpKayit.Controls.Add(this.lblKullaniciAd);
            this.grpKayit.Controls.Add(this.lblMail);
            this.grpKayit.Controls.Add(this.lblAdres);
            this.grpKayit.Controls.Add(this.lblTel);
            this.grpKayit.Controls.Add(this.lblTc);
            this.grpKayit.Controls.Add(this.lblSoyad);
            this.grpKayit.Controls.Add(this.lblAd);
            this.grpKayit.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKayit.Location = new System.Drawing.Point(12, 23);
            this.grpKayit.Name = "grpKayit";
            this.grpKayit.Size = new System.Drawing.Size(420, 486);
            this.grpKayit.TabIndex = 23;
            this.grpKayit.TabStop = false;
            this.grpKayit.Text = "KAYIT EKRANI";
            // 
            // KayitEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 593);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.grpKayit);
            this.Name = "KayitEkran";
            this.grpKayit.ResumeLayout(false);
            this.grpKayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mtxTc;
        private System.Windows.Forms.MaskedTextBox mtxTel;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAd;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.GroupBox grpKayit;
    }
}