
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetHomeForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlAddAsset = new System.Windows.Forms.Panel();
            this.txtAssetTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAssetType = new System.Windows.Forms.ComboBox();
            this.btnAddAsset = new System.Windows.Forms.Button();
            this.dgvAssetStatistics = new System.Windows.Forms.DataGridView();
            this.cartesianChartAsset = new LiveCharts.WinForms.CartesianChart();
            this.dgvAssetRecords = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlAddAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlAddAsset);
            this.splitContainer1.Panel1.Controls.Add(this.dgvAssetStatistics);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cartesianChartAsset);
            this.splitContainer1.Panel2.Controls.Add(this.dgvAssetRecords);
            this.splitContainer1.Size = new System.Drawing.Size(1503, 840);
            this.splitContainer1.SplitterDistance = 501;
            this.splitContainer1.SplitterWidth = 5;
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
            this.pnlAddAsset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAddAsset.Name = "pnlAddAsset";
            this.pnlAddAsset.Size = new System.Drawing.Size(499, 227);
            this.pnlAddAsset.TabIndex = 0;
            // 
            // txtAssetTotal
            // 
            this.txtAssetTotal.Location = new System.Drawing.Point(210, 108);
            this.txtAssetTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAssetTotal.Name = "txtAssetTotal";
            this.txtAssetTotal.Size = new System.Drawing.Size(184, 30);
            this.txtAssetTotal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "总金额：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "资产类型：";
            // 
            // cmbAssetType
            // 
            this.cmbAssetType.FormattingEnabled = true;
            this.cmbAssetType.Location = new System.Drawing.Point(210, 40);
            this.cmbAssetType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbAssetType.Name = "cmbAssetType";
            this.cmbAssetType.Size = new System.Drawing.Size(184, 32);
            this.cmbAssetType.TabIndex = 1;
            // 
            // btnAddAsset
            // 
            this.btnAddAsset.Location = new System.Drawing.Point(210, 175);
            this.btnAddAsset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddAsset.Name = "btnAddAsset";
            this.btnAddAsset.Size = new System.Drawing.Size(115, 35);
            this.btnAddAsset.TabIndex = 0;
            this.btnAddAsset.Text = "新增";
            this.btnAddAsset.UseVisualStyleBackColor = true;
            this.btnAddAsset.Click += new System.EventHandler(this.btnAddAsset_Click);
            // 
            // dgvAssetStatistics
            // 
            this.dgvAssetStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssetStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssetStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAssetStatistics.Location = new System.Drawing.Point(0, 341);
            this.dgvAssetStatistics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAssetStatistics.Name = "dgvAssetStatistics";
            this.dgvAssetStatistics.RowHeadersWidth = 51;
            this.dgvAssetStatistics.RowTemplate.Height = 29;
            this.dgvAssetStatistics.Size = new System.Drawing.Size(499, 497);
            this.dgvAssetStatistics.TabIndex = 1;
            // 
            // cartesianChartAsset
            // 
            this.cartesianChartAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartAsset.Location = new System.Drawing.Point(18, 341);
            this.cartesianChartAsset.Margin = new System.Windows.Forms.Padding(2);
            this.cartesianChartAsset.Name = "cartesianChartAsset";
            this.cartesianChartAsset.Size = new System.Drawing.Size(941, 470);
            this.cartesianChartAsset.TabIndex = 0;
            this.cartesianChartAsset.Text = "cartesianChart1";
            // 
            // dgvAssetRecords
            // 
            this.dgvAssetRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssetRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssetRecords.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvAssetRecords.Location = new System.Drawing.Point(0, 0);
            this.dgvAssetRecords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAssetRecords.Name = "dgvAssetRecords";
            this.dgvAssetRecords.RowHeadersWidth = 51;
            this.dgvAssetRecords.RowTemplate.Height = 29;
            this.dgvAssetRecords.Size = new System.Drawing.Size(995, 320);
            this.dgvAssetRecords.TabIndex = 0;
            // 
            // AssetHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 840);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AssetHomeForm";
            this.Text = "AssetHomeForm";
            this.Load += new System.EventHandler(this.AssetHomeForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlAddAsset.ResumeLayout(false);
            this.pnlAddAsset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssetRecords)).EndInit();
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
        private LiveCharts.WinForms.CartesianChart cartesianChartAsset;
    }
}