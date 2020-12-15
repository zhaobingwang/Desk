
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
            this.mnsHome = new System.Windows.Forms.MenuStrip();
            this.mnsItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsItemAsset = new System.Windows.Forms.ToolStripMenuItem();
            this.icnMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmnNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnNotifyExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsHome.SuspendLayout();
            this.cmnNotify.SuspendLayout();
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
            this.mnsHome.Size = new System.Drawing.Size(978, 32);
            this.mnsHome.TabIndex = 0;
            this.mnsHome.Text = "mnsHome";
            // 
            // mnsItemTools
            // 
            this.mnsItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsItemAsset});
            this.mnsItemTools.Name = "mnsItemTools";
            this.mnsItemTools.Size = new System.Drawing.Size(71, 28);
            this.mnsItemTools.Text = "Tools";
            // 
            // mnsItemAsset
            // 
            this.mnsItemAsset.Name = "mnsItemAsset";
            this.mnsItemAsset.Size = new System.Drawing.Size(164, 34);
            this.mnsItemAsset.Text = "Assets";
            // 
            // icnMain
            // 
            this.icnMain.ContextMenuStrip = this.cmnNotify;
            this.icnMain.Text = "notifyIcon1";
            this.icnMain.Visible = true;
            this.icnMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.icnMain_MouseDoubleClick);
            // 
            // cmnNotify
            // 
            this.cmnNotify.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmnNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnNotifyExit});
            this.cmnNotify.Name = "cmnNotify";
            this.cmnNotify.Size = new System.Drawing.Size(117, 34);
            // 
            // cmnNotifyExit
            // 
            this.cmnNotifyExit.Name = "cmnNotifyExit";
            this.cmnNotifyExit.Size = new System.Drawing.Size(116, 30);
            this.cmnNotifyExit.Text = "退出";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 540);
            this.Controls.Add(this.mnsHome);
            this.MainMenuStrip = this.mnsHome;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.SizeChanged += new System.EventHandler(this.Home_SizeChanged);
            this.mnsHome.ResumeLayout(false);
            this.mnsHome.PerformLayout();
            this.cmnNotify.ResumeLayout(false);
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
    }
}

