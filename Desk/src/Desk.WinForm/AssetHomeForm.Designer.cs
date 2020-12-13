
namespace Desk.WinForm
{
    partial class AssetHomeForm
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
            this.pnlAddAsset = new System.Windows.Forms.Panel();
            this.txtAssetTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAssetType = new System.Windows.Forms.ComboBox();
            this.btnAddAsset = new System.Windows.Forms.Button();
            this.dgvAssetRecords = new System.Windows.Forms.DataGridView();
            this.dgvAssetStatistics = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlAddAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetStatistics)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.pnlAddAsset);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvAssetStatistics);
            this.splitContainer1.Panel2.Controls.Add(this.dgvAssetRecords);
            this.splitContainer1.Size = new System.Drawing.Size(1230, 700);
            this.splitContainer1.SplitterDistance = 410;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlAddAsset
            // 
            this.pnlAddAsset.Controls.Add(this.txtAssetTotal);
            this.pnlAddAsset.Controls.Add(this.label2);
            this.pnlAddAsset.Controls.Add(this.label1);
            this.pnlAddAsset.Controls.Add(this.cmbAssetType);
            this.pnlAddAsset.Controls.Add(this.btnAddAsset);
            this.pnlAddAsset.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddAsset.Location = new System.Drawing.Point(0, 0);
            this.pnlAddAsset.Name = "pnlAddAsset";
            this.pnlAddAsset.Size = new System.Drawing.Size(408, 189);
            this.pnlAddAsset.TabIndex = 0;
            // 
            // txtAssetTotal
            // 
            this.txtAssetTotal.Location = new System.Drawing.Point(172, 90);
            this.txtAssetTotal.Name = "txtAssetTotal";
            this.txtAssetTotal.Size = new System.Drawing.Size(151, 27);
            this.txtAssetTotal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "总金额：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "资产类型：";
            // 
            // cmbAssetType
            // 
            this.cmbAssetType.FormattingEnabled = true;
            this.cmbAssetType.Location = new System.Drawing.Point(172, 33);
            this.cmbAssetType.Name = "cmbAssetType";
            this.cmbAssetType.Size = new System.Drawing.Size(151, 28);
            this.cmbAssetType.TabIndex = 1;
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.Location = new System.Drawing.Point(172, 146);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Size = new System.Drawing.Size(94, 29);
            this.btnAddAsset.TabIndex = 0;
            this.btnAddAsset.Text = "新增";
            this.btnAddAsset.UseVisualStyleBackColor = true;
            this.btnAddAsset.Click += new System.EventHandler(this.btnAddAsset_Click);
            // 
            // dgvAssetRecords
            // 
            this.dgvAssetRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssetRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAssetRecords.Location = new System.Drawing.Point(0, 0);
            this.dgvAssetRecords.Name = "dgvAssetRecords";
            this.dgvAssetRecords.RowHeadersWidth = 51;
            this.dgvAssetRecords.RowTemplate.Height = 29;
            this.dgvAssetRecords.Size = new System.Drawing.Size(814, 267);
            this.dgvAssetRecords.TabIndex = 0;
            // 
            // dgvAssetStatistics
            // 
            this.dgvAssetStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssetStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAssetStatistics.Location = new System.Drawing.Point(0, 284);
            this.dgvAssetStatistics.Name = "dgvAssetStatistics";
            this.dgvAssetStatistics.RowHeadersWidth = 51;
            this.dgvAssetStatistics.RowTemplate.Height = 29;
            this.dgvAssetStatistics.Size = new System.Drawing.Size(814, 414);
            this.dgvAssetStatistics.TabIndex = 1;
            // 
            // AssetHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 700);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AssetHomeForm";
            this.Text = "AssetHomeForm";
            this.Load += new System.EventHandler(this.AssetHomeForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlAddAsset.ResumeLayout(false);
            this.pnlAddAsset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlAddAsset;
        private System.Windows.Forms.TextBox txtAssetTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAssetType;
        private System.Windows.Forms.Button btnAddAsset;
        private System.Windows.Forms.DataGridView dgvAssetRecords;
        private System.Windows.Forms.DataGridView dgvAssetStatistics;
    }
}