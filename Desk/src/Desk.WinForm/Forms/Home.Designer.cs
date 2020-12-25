
namespace Desk.WinForm
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.mnsHome = new System.Windows.Forms.MenuStrip();
            this.mnsItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsItemAsset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsItemSpider = new System.Windows.Forms.ToolStripMenuItem();
            this.icnMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmnNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnNotifySpider = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnNotifyAddAsset = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnNotifyExit = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cartesianChartAsset = new LiveCharts.WinForms.CartesianChart();
            this.mnsHome.SuspendLayout();
            this.cmnNotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsHome
            // 
            this.mnsHome.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsItemTools});
            this.mnsHome.Location = new System.Drawing.Point(0, 0);
            this.mnsHome.Name = "mnsHome";
            this.mnsHome.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mnsHome.Size = new System.Drawing.Size(1511, 32);
            this.mnsHome.TabIndex = 0;
            this.mnsHome.Text = "mnsHome";
            // 
            // mnsItemTools
            // 
            this.mnsItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsItemAsset,
            this.mnsItemSpider});
            this.mnsItemTools.Name = "mnsItemTools";
            this.mnsItemTools.Size = new System.Drawing.Size(71, 28);
            this.mnsItemTools.Text = "Tools";
            // 
            // mnsItemAsset
            // 
            this.mnsItemAsset.Name = "mnsItemAsset";
            this.mnsItemAsset.Size = new System.Drawing.Size(166, 34);
            this.mnsItemAsset.Text = "Assets";
            // 
            // mnsItemSpider
            // 
            this.mnsItemSpider.Name = "mnsItemSpider";
            this.mnsItemSpider.Size = new System.Drawing.Size(166, 34);
            this.mnsItemSpider.Text = "Spider";
            // 
            // icnMain
            // 
            this.icnMain.ContextMenuStrip = this.cmnNotify;
            this.icnMain.Icon = ((System.Drawing.Icon)(resources.GetObject("icnMain.Icon")));
            this.icnMain.Text = "notifyIcon1";
            this.icnMain.Visible = true;
            this.icnMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.icnMain_MouseDoubleClick);
            // 
            // cmnNotify
            // 
            this.cmnNotify.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmnNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnNotifySpider,
            this.cmnNotifyAddAsset,
            this.cmnNotifyExit});
            this.cmnNotify.Name = "cmnNotify";
            this.cmnNotify.Size = new System.Drawing.Size(153, 94);
            // 
            // cmnNotifySpider
            // 
            this.cmnNotifySpider.Name = "cmnNotifySpider";
            this.cmnNotifySpider.Size = new System.Drawing.Size(152, 30);
            this.cmnNotifySpider.Text = "Spider";
            // 
            // cmnNotifyAddAsset
            // 
            this.cmnNotifyAddAsset.Name = "cmnNotifyAddAsset";
            this.cmnNotifyAddAsset.Size = new System.Drawing.Size(152, 30);
            this.cmnNotifyAddAsset.Text = "添加资产";
            // 
            // cmnNotifyExit
            // 
            this.cmnNotifyExit.Name = "cmnNotifyExit";
            this.cmnNotifyExit.Size = new System.Drawing.Size(152, 30);
            this.cmnNotifyExit.Text = "退出";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cartesianChartAsset);
            this.splitContainer1.Size = new System.Drawing.Size(1511, 932);
            this.splitContainer1.SplitterDistance = 503;
            this.splitContainer1.TabIndex = 1;
            // 
            // cartesianChartAsset
            // 
            this.cartesianChartAsset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChartAsset.Location = new System.Drawing.Point(16, 14);
            this.cartesianChartAsset.Name = "cartesianChartAsset";
            this.cartesianChartAsset.Size = new System.Drawing.Size(975, 396);
            this.cartesianChartAsset.TabIndex = 0;
            this.cartesianChartAsset.Text = "cartesianChart1";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1511, 964);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mnsHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsHome;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.SizeChanged += new System.EventHandler(this.Home_SizeChanged);
            this.mnsHome.ResumeLayout(false);
            this.mnsHome.PerformLayout();
            this.cmnNotify.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsHome;
        private System.Windows.Forms.ToolStripMenuItem mnsItemTools;
        private System.Windows.Forms.ToolStripMenuItem mnsItemAsset;
        private System.Windows.Forms.NotifyIcon icnMain;
        private System.Windows.Forms.ContextMenuStrip cmnNotify;
        private System.Windows.Forms.ToolStripMenuItem cmnNotifyExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private LiveCharts.WinForms.CartesianChart cartesianChartAsset;
        private System.Windows.Forms.ToolStripMenuItem cmnNotifyAddAsset;
        private System.Windows.Forms.ToolStripMenuItem mnsItemSpider;
        private System.Windows.Forms.ToolStripMenuItem cmnNotifySpider;
    }
}

