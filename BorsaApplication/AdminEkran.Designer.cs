
namespace BorsaApplication
{
    partial class AdminEkran
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpAdmin = new System.Windows.Forms.GroupBox();
            this.mtabControl = new MetroFramework.Controls.MetroTabControl();
            this.mtabPageUrun = new MetroFramework.Controls.MetroTabPage();
            this.btnCoinEkle = new System.Windows.Forms.Button();
            this.dgvUrunKontrol = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAccept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtabPara = new MetroFramework.Controls.MetroTabPage();
            this.btnParaEkle = new System.Windows.Forms.Button();
            this.dgvParaKontrol = new System.Windows.Forms.DataGridView();
            this.UserID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoneyAccept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpAdmin.SuspendLayout();
            this.mtabControl.SuspendLayout();
            this.mtabPageUrun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunKontrol)).BeginInit();
            this.mtabPara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParaKontrol)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAdmin
            // 
            this.grpAdmin.Controls.Add(this.mtabControl);
            this.grpAdmin.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAdmin.Location = new System.Drawing.Point(17, 46);
            this.grpAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAdmin.Name = "grpAdmin";
            this.grpAdmin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAdmin.Size = new System.Drawing.Size(764, 399);
            this.grpAdmin.TabIndex = 0;
            this.grpAdmin.TabStop = false;
            this.grpAdmin.Text = "ADMIN EKRANI";
            // 
            // mtabControl
            // 
            this.mtabControl.Controls.Add(this.mtabPageUrun);
            this.mtabControl.Controls.Add(this.mtabPara);
            this.mtabControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.mtabControl.Location = new System.Drawing.Point(4, 26);
            this.mtabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtabControl.Name = "mtabControl";
            this.mtabControl.SelectedIndex = 1;
            this.mtabControl.Size = new System.Drawing.Size(754, 362);
            this.mtabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.mtabControl.TabIndex = 29;
            this.mtabControl.UseSelectable = true;
            // 
            // mtabPageUrun
            // 
            this.mtabPageUrun.AllowDrop = true;
            this.mtabPageUrun.Controls.Add(this.btnCoinEkle);
            this.mtabPageUrun.Controls.Add(this.dgvUrunKontrol);
            this.mtabPageUrun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtabPageUrun.HorizontalScrollbarBarColor = true;
            this.mtabPageUrun.HorizontalScrollbarHighlightOnWheel = false;
            this.mtabPageUrun.HorizontalScrollbarSize = 8;
            this.mtabPageUrun.Location = new System.Drawing.Point(4, 44);
            this.mtabPageUrun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtabPageUrun.Name = "mtabPageUrun";
            this.mtabPageUrun.Size = new System.Drawing.Size(746, 314);
            this.mtabPageUrun.TabIndex = 0;
            this.mtabPageUrun.Text = "ÜRÜN KONTROL EKRANI";
            this.mtabPageUrun.VerticalScrollbarBarColor = true;
            this.mtabPageUrun.VerticalScrollbarHighlightOnWheel = false;
            this.mtabPageUrun.VerticalScrollbarSize = 8;
            this.mtabPageUrun.Enter += new System.EventHandler(this.mtabPageUrun_Enter);
            // 
            // btnCoinEkle
            // 
            this.btnCoinEkle.BackColor = System.Drawing.Color.Lime;
            this.btnCoinEkle.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoinEkle.Location = new System.Drawing.Point(282, 266);
            this.btnCoinEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCoinEkle.Name = "btnCoinEkle";
            this.btnCoinEkle.Size = new System.Drawing.Size(150, 32);
            this.btnCoinEkle.TabIndex = 4;
            this.btnCoinEkle.Text = "ONAYLA";
            this.btnCoinEkle.UseVisualStyleBackColor = false;
            this.btnCoinEkle.Click += new System.EventHandler(this.btnCoinEkle_Click);
            // 
            // dgvUrunKontrol
            // 
            this.dgvUrunKontrol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUrunKontrol.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUrunKontrol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvUrunKontrol.ColumnHeadersHeight = 29;
            this.dgvUrunKontrol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.ItemID,
            this.ItemAmount,
            this.ItemAccept});
            this.dgvUrunKontrol.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvUrunKontrol.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvUrunKontrol.Location = new System.Drawing.Point(20, 12);
            this.dgvUrunKontrol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUrunKontrol.Name = "dgvUrunKontrol";
            this.dgvUrunKontrol.RowHeadersWidth = 51;
            this.dgvUrunKontrol.RowTemplate.Height = 24;
            this.dgvUrunKontrol.Size = new System.Drawing.Size(701, 236);
            this.dgvUrunKontrol.TabIndex = 2;
            // 
            // UserID
            // 
            this.UserID.DataPropertyName = "UserID";
            this.UserID.HeaderText = "User ID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            // 
            // ItemAmount
            // 
            this.ItemAmount.DataPropertyName = "ItemAmount";
            this.ItemAmount.HeaderText = "ItemAmount";
            this.ItemAmount.MinimumWidth = 6;
            this.ItemAmount.Name = "ItemAmount";
            // 
            // ItemAccept
            // 
            this.ItemAccept.DataPropertyName = "ItemAccept";
            this.ItemAccept.HeaderText = "Item Accept";
            this.ItemAccept.MinimumWidth = 6;
            this.ItemAccept.Name = "ItemAccept";
            // 
            // mtabPara
            // 
            this.mtabPara.Controls.Add(this.btnParaEkle);
            this.mtabPara.Controls.Add(this.dgvParaKontrol);
            this.mtabPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtabPara.HorizontalScrollbarBarColor = true;
            this.mtabPara.HorizontalScrollbarHighlightOnWheel = false;
            this.mtabPara.HorizontalScrollbarSize = 8;
            this.mtabPara.Location = new System.Drawing.Point(4, 44);
            this.mtabPara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtabPara.Name = "mtabPara";
            this.mtabPara.Size = new System.Drawing.Size(746, 314);
            this.mtabPara.TabIndex = 1;
            this.mtabPara.Text = "PARA KONTROL EKRANI";
            this.mtabPara.VerticalScrollbarBarColor = true;
            this.mtabPara.VerticalScrollbarHighlightOnWheel = false;
            this.mtabPara.VerticalScrollbarSize = 8;
            this.mtabPara.Enter += new System.EventHandler(this.mtabPara_Enter);
            // 
            // btnParaEkle
            // 
            this.btnParaEkle.BackColor = System.Drawing.Color.Lime;
            this.btnParaEkle.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParaEkle.Location = new System.Drawing.Point(282, 266);
            this.btnParaEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnParaEkle.Name = "btnParaEkle";
            this.btnParaEkle.Size = new System.Drawing.Size(150, 32);
            this.btnParaEkle.TabIndex = 6;
            this.btnParaEkle.Text = "ONAYLA";
            this.btnParaEkle.UseVisualStyleBackColor = false;
            this.btnParaEkle.Click += new System.EventHandler(this.btnParaEkle_Click);
            // 
            // dgvParaKontrol
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvParaKontrol.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParaKontrol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParaKontrol.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvParaKontrol.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvParaKontrol.ColumnHeadersHeight = 29;
            this.dgvParaKontrol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID1,
            this.MoneyAmount,
            this.MoneyAccept});
            this.dgvParaKontrol.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvParaKontrol.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvParaKontrol.Location = new System.Drawing.Point(19, 16);
            this.dgvParaKontrol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvParaKontrol.Name = "dgvParaKontrol";
            this.dgvParaKontrol.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dgvParaKontrol.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvParaKontrol.RowTemplate.Height = 24;
            this.dgvParaKontrol.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvParaKontrol.Size = new System.Drawing.Size(701, 236);
            this.dgvParaKontrol.TabIndex = 5;
            // 
            // UserID1
            // 
            this.UserID1.DataPropertyName = "UserID";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UserID1.DefaultCellStyle = dataGridViewCellStyle2;
            this.UserID1.HeaderText = "User ID";
            this.UserID1.MinimumWidth = 6;
            this.UserID1.Name = "UserID1";
            // 
            // MoneyAmount
            // 
            this.MoneyAmount.DataPropertyName = "MoneyAmount";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MoneyAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.MoneyAmount.HeaderText = "Money Amount";
            this.MoneyAmount.MinimumWidth = 6;
            this.MoneyAmount.Name = "MoneyAmount";
            // 
            // MoneyAccept
            // 
            this.MoneyAccept.DataPropertyName = "MoneyAccept";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MoneyAccept.DefaultCellStyle = dataGridViewCellStyle4;
            this.MoneyAccept.HeaderText = "Money Accept";
            this.MoneyAccept.MinimumWidth = 6;
            this.MoneyAccept.Name = "MoneyAccept";
            // 
            // AdminEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 463);
            this.Controls.Add(this.grpAdmin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminEkran";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminEkran_FormClosed);
            this.grpAdmin.ResumeLayout(false);
            this.mtabControl.ResumeLayout(false);
            this.mtabPageUrun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunKontrol)).EndInit();
            this.mtabPara.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParaKontrol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdmin;
        private MetroFramework.Controls.MetroTabControl mtabControl;
        private MetroFramework.Controls.MetroTabPage mtabPageUrun;
        private System.Windows.Forms.Button btnCoinEkle;
        private System.Windows.Forms.DataGridView dgvUrunKontrol;
        private MetroFramework.Controls.MetroTabPage mtabPara;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnParaEkle;
        private System.Windows.Forms.DataGridView dgvParaKontrol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoneyAccept;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAccept;
    }
}