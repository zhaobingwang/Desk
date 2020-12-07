
namespace Desk.Win
{
    partial class AssetForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlAddRecords = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAssetTotal = new System.Windows.Forms.TextBox();
            this.lblAssetTotal = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbAssetType = new System.Windows.Forms.ComboBox();
            this.dgvAssetRecords = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlAddRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlAddRecords);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvAssetRecords);
            this.splitContainer1.Size = new System.Drawing.Size(1726, 1010);
            this.splitContainer1.SplitterDistance = 575;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlAddRecords
            // 
            this.pnlAddRecords.Controls.Add(this.btnAdd);
            this.pnlAddRecords.Controls.Add(this.txtAssetTotal);
            this.pnlAddRecords.Controls.Add(this.lblAssetTotal);
            this.pnlAddRecords.Controls.Add(this.lblType);
            this.pnlAddRecords.Controls.Add(this.cmbAssetType);
            this.pnlAddRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddRecords.Location = new System.Drawing.Point(0, 0);
            this.pnlAddRecords.Name = "pnlAddRecords";
            this.pnlAddRecords.Size = new System.Drawing.Size(573, 243);
            this.pnlAddRecords.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(156, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAssetTotal
            // 
            this.txtAssetTotal.Location = new System.Drawing.Point(156, 110);
            this.txtAssetTotal.Name = "txtAssetTotal";
            this.txtAssetTotal.Size = new System.Drawing.Size(263, 30);
            this.txtAssetTotal.TabIndex = 3;
            // 
            // lblAssetTotal
            // 
            this.lblAssetTotal.AutoSize = true;
            this.lblAssetTotal.Location = new System.Drawing.Point(57, 113);
            this.lblAssetTotal.Name = "lblAssetTotal";
            this.lblAssetTotal.Size = new System.Drawing.Size(64, 24);
            this.lblAssetTotal.TabIndex = 2;
            this.lblAssetTotal.Text = "总金额";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(39, 21);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(82, 24);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "资产类型";
            // 
            // cmbAssetType
            // 
            this.cmbAssetType.FormattingEnabled = true;
            this.cmbAssetType.Location = new System.Drawing.Point(156, 17);
            this.cmbAssetType.Name = "cmbAssetType";
            this.cmbAssetType.Size = new System.Drawing.Size(263, 32);
            this.cmbAssetType.TabIndex = 0;
            // 
            // dgvAssetRecords
            // 
            this.dgvAssetRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssetRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAssetRecords.Location = new System.Drawing.Point(0, 0);
            this.dgvAssetRecords.Name = "dgvAssetRecords";
            this.dgvAssetRecords.RowHeadersWidth = 62;
            this.dgvAssetRecords.RowTemplate.Height = 32;
            this.dgvAssetRecords.Size = new System.Drawing.Size(1145, 446);
            this.dgvAssetRecords.TabIndex = 0;
            // 
            // AssetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 1010);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AssetForm";
            this.Text = "AssetForm";
            this.Load += new System.EventHandler(this.AssetForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlAddRecords.ResumeLayout(false);
            this.pnlAddRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlAddRecords;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAssetTotal;
        private System.Windows.Forms.Label lblAssetTotal;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbAssetType;
        private System.Windows.Forms.DataGridView dgvAssetRecords;
    }
}