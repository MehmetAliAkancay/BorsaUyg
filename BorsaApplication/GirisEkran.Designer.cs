
namespace BorsaApplication
{
    partial class GirisEkran
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
            this.grpGiris = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.mtxtGirisSifre = new MetroFramework.Controls.MetroTextBox();
            this.mtxtGirisKullanici = new MetroFramework.Controls.MetroTextBox();
            this.btnGirisKayit = new System.Windows.Forms.Button();
            this.lblKayit = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpGiris.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpGiris
            // 
            this.grpGiris.BackColor = System.Drawing.Color.AliceBlue;
            this.grpGiris.Controls.Add(this.btnGiris);
            this.grpGiris.Controls.Add(this.mtxtGirisSifre);
            this.grpGiris.Controls.Add(this.mtxtGirisKullanici);
            this.grpGiris.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpGiris.Location = new System.Drawing.Point(12, 38);
            this.grpGiris.Name = "grpGiris";
            this.grpGiris.Size = new System.Drawing.Size(420, 325);
            this.grpGiris.TabIndex = 26;
            this.grpGiris.TabStop = false;
            this.grpGiris.Text = "GİRİŞ EKRANI";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGiris.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnGiris.Location = new System.Drawing.Point(26, 194);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(355, 54);
            this.btnGiris.TabIndex = 24;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // mtxtGirisSifre
            // 
            // 
            // 
            // 
            this.mtxtGirisSifre.CustomButton.Image = null;
            this.mtxtGirisSifre.CustomButton.Location = new System.Drawing.Point(319, 2);
            this.mtxtGirisSifre.CustomButton.Name = "";
            this.mtxtGirisSifre.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtGirisSifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtGirisSifre.CustomButton.TabIndex = 1;
            this.mtxtGirisSifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtGirisSifre.CustomButton.UseSelectable = true;
            this.mtxtGirisSifre.CustomButton.Visible = false;
            this.mtxtGirisSifre.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtxtGirisSifre.Lines = new string[0];
            this.mtxtGirisSifre.Location = new System.Drawing.Point(26, 120);
            this.mtxtGirisSifre.MaxLength = 32767;
            this.mtxtGirisSifre.Multiline = true;
            this.mtxtGirisSifre.Name = "mtxtGirisSifre";
            this.mtxtGirisSifre.PasswordChar = '*';
            this.mtxtGirisSifre.PromptText = "Şifre";
            this.mtxtGirisSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtGirisSifre.SelectedText = "";
            this.mtxtGirisSifre.SelectionLength = 0;
            this.mtxtGirisSifre.SelectionStart = 0;
            this.mtxtGirisSifre.ShortcutsEnabled = true;
            this.mtxtGirisSifre.Size = new System.Drawing.Size(355, 38);
            this.mtxtGirisSifre.TabIndex = 23;
            this.mtxtGirisSifre.UseSelectable = true;
            this.mtxtGirisSifre.WaterMark = "Şifre";
            this.mtxtGirisSifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtGirisSifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // mtxtGirisKullanici
            // 
            // 
            // 
            // 
            this.mtxtGirisKullanici.CustomButton.Image = null;
            this.mtxtGirisKullanici.CustomButton.Location = new System.Drawing.Point(319, 2);
            this.mtxtGirisKullanici.CustomButton.Name = "";
            this.mtxtGirisKullanici.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.mtxtGirisKullanici.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtGirisKullanici.CustomButton.TabIndex = 1;
            this.mtxtGirisKullanici.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtGirisKullanici.CustomButton.UseSelectable = true;
            this.mtxtGirisKullanici.CustomButton.Visible = false;
            this.mtxtGirisKullanici.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtxtGirisKullanici.Lines = new string[0];
            this.mtxtGirisKullanici.Location = new System.Drawing.Point(26, 54);
            this.mtxtGirisKullanici.MaxLength = 32767;
            this.mtxtGirisKullanici.Multiline = true;
            this.mtxtGirisKullanici.Name = "mtxtGirisKullanici";
            this.mtxtGirisKullanici.PasswordChar = '\0';
            this.mtxtGirisKullanici.PromptText = "Kullanıcı Adı";
            this.mtxtGirisKullanici.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtGirisKullanici.SelectedText = "";
            this.mtxtGirisKullanici.SelectionLength = 0;
            this.mtxtGirisKullanici.SelectionStart = 0;
            this.mtxtGirisKullanici.ShortcutsEnabled = true;
            this.mtxtGirisKullanici.Size = new System.Drawing.Size(355, 38);
            this.mtxtGirisKullanici.TabIndex = 0;
            this.mtxtGirisKullanici.UseSelectable = true;
            this.mtxtGirisKullanici.WaterMark = "Kullanıcı Adı";
            this.mtxtGirisKullanici.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtGirisKullanici.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // btnGirisKayit
            // 
            this.btnGirisKayit.BackColor = System.Drawing.Color.Lime;
            this.btnGirisKayit.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGirisKayit.Location = new System.Drawing.Point(125, 435);
            this.btnGirisKayit.Name = "btnGirisKayit";
            this.btnGirisKayit.Size = new System.Drawing.Size(185, 54);
            this.btnGirisKayit.TabIndex = 28;
            this.btnGirisKayit.Text = "KAYIT OL";
            this.btnGirisKayit.UseVisualStyleBackColor = false;
            this.btnGirisKayit.Click += new System.EventHandler(this.btnGirisKayit_Click);
            // 
            // lblKayit
            // 
            this.lblKayit.AutoSize = true;
            this.lblKayit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblKayit.Location = new System.Drawing.Point(35, 391);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(368, 17);
            this.lblKayit.TabIndex = 27;
            this.lblKayit.Text = "Henüz kayıt olmadıysan aşağıdaki butona tıklayıp kayıt ol.";
            // 
            // GirisEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 526);
            this.Controls.Add(this.grpGiris);
            this.Controls.Add(this.btnGirisKayit);
            this.Controls.Add(this.lblKayit);
            this.Name = "GirisEkran";
            this.grpGiris.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGiris;
        private System.Windows.Forms.Button btnGiris;
        private MetroFramework.Controls.MetroTextBox mtxtGirisSifre;
        private MetroFramework.Controls.MetroTextBox mtxtGirisKullanici;
        private System.Windows.Forms.Button btnGirisKayit;
        private System.Windows.Forms.Label lblKayit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}