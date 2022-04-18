
namespace BorsaApplication
{
    partial class Rapor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAlimRapor = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfPurchase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSatimRapor = new System.Windows.Forms.DataGridView();
            this.lblSatimRapor = new System.Windows.Forms.Label();
            this.lblAlimRapor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRapor = new System.Windows.Forms.Button();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimRapor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatimRapor)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlimRapor
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dgvAlimRapor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlimRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlimRapor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAlimRapor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvAlimRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlimRapor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemID,
            this.ItemAmount,
            this.DateOfPurchase});
            this.dgvAlimRapor.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvAlimRapor.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvAlimRapor.Location = new System.Drawing.Point(22, 51);
            this.dgvAlimRapor.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAlimRapor.Name = "dgvAlimRapor";
            this.dgvAlimRapor.RowHeadersVisible = false;
            this.dgvAlimRapor.RowHeadersWidth = 51;
            this.dgvAlimRapor.RowTemplate.Height = 24;
            this.dgvAlimRapor.Size = new System.Drawing.Size(518, 204);
            this.dgvAlimRapor.TabIndex = 3;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // ItemAmount
            // 
            this.ItemAmount.DataPropertyName = "ItemAmount";
            this.ItemAmount.HeaderText = "ItemAmount";
            this.ItemAmount.MinimumWidth = 6;
            this.ItemAmount.Name = "ItemAmount";
            this.ItemAmount.ReadOnly = true;
            // 
            // DateOfPurchase
            // 
            this.DateOfPurchase.DataPropertyName = "DateOfPurchase";
            this.DateOfPurchase.HeaderText = "Date Of Purchase";
            this.DateOfPurchase.MinimumWidth = 6;
            this.DateOfPurchase.Name = "DateOfPurchase";
            this.DateOfPurchase.ReadOnly = true;
            // 
            // dgvSatimRapor
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dgvSatimRapor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSatimRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSatimRapor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSatimRapor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvSatimRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatimRapor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ItemPrice,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvSatimRapor.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvSatimRapor.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvSatimRapor.Location = new System.Drawing.Point(22, 328);
            this.dgvSatimRapor.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSatimRapor.Name = "dgvSatimRapor";
            this.dgvSatimRapor.RowHeadersVisible = false;
            this.dgvSatimRapor.RowHeadersWidth = 51;
            this.dgvSatimRapor.RowTemplate.Height = 24;
            this.dgvSatimRapor.Size = new System.Drawing.Size(518, 204);
            this.dgvSatimRapor.TabIndex = 4;
            // 
            // lblSatimRapor
            // 
            this.lblSatimRapor.AutoSize = true;
            this.lblSatimRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatimRapor.Location = new System.Drawing.Point(17, 295);
            this.lblSatimRapor.Name = "lblSatimRapor";
            this.lblSatimRapor.Size = new System.Drawing.Size(130, 25);
            this.lblSatimRapor.TabIndex = 5;
            this.lblSatimRapor.Text = "Satım Raporu";
            // 
            // lblAlimRapor
            // 
            this.lblAlimRapor.AutoSize = true;
            this.lblAlimRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlimRapor.Location = new System.Drawing.Point(17, 14);
            this.lblAlimRapor.Name = "lblAlimRapor";
            this.lblAlimRapor.Size = new System.Drawing.Size(118, 25);
            this.lblAlimRapor.TabIndex = 6;
            this.lblAlimRapor.Text = "Alım Raporu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bitiş Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Başlangıç Tarihi:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpBitis);
            this.groupBox3.Controls.Add(this.dtpBaslangic);
            this.groupBox3.Controls.Add(this.btnRapor);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(575, 111);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(361, 353);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rapor";
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.Color.Lime;
            this.btnRapor.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnRapor.Location = new System.Drawing.Point(158, 230);
            this.btnRapor.Margin = new System.Windows.Forms.Padding(2);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(189, 41);
            this.btnRapor.TabIndex = 14;
            this.btnRapor.Text = "RAPOR OLUŞTUR";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(147, 98);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 27);
            this.dtpBaslangic.TabIndex = 15;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(147, 164);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 27);
            this.dtpBitis.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ItemPrice
            // 
            this.ItemPrice.DataPropertyName = "ItemPrice";
            this.ItemPrice.HeaderText = "Item Price";
            this.ItemPrice.Name = "ItemPrice";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ItemAmount";
            this.dataGridViewTextBoxColumn3.HeaderText = "ItemAmount";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateOfPurchase";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date Of Purchase";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblAlimRapor);
            this.Controls.Add(this.lblSatimRapor);
            this.Controls.Add(this.dgvSatimRapor);
            this.Controls.Add(this.dgvAlimRapor);
            this.Name = "Rapor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlimRapor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatimRapor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlimRapor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPurchase;
        private System.Windows.Forms.DataGridView dgvSatimRapor;
        private System.Windows.Forms.Label lblSatimRapor;
        private System.Windows.Forms.Label lblAlimRapor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}