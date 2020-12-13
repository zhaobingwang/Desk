
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
            this.mnsHome = new System.Windows.Forms.MenuStrip();
            this.mnsItemTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsItemAsset = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsHome
            // 
            this.mnsHome.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsItemTools});
            this.mnsHome.Location = new System.Drawing.Point(0, 0);
            this.mnsHome.Name = "mnsHome";
            this.mnsHome.Size = new System.Drawing.Size(800, 28);
            this.mnsHome.TabIndex = 0;
            this.mnsHome.Text = "mnsHome";
            // 
            // mnsItemTools
            // 
            this.mnsItemTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsItemAsset});
            this.mnsItemTools.Name = "mnsItemTools";
            this.mnsItemTools.Size = new System.Drawing.Size(63, 24);
            this.mnsItemTools.Text = "Tools";
            // 
            // mnsItemAsset
            // 
            this.mnsItemAsset.Name = "mnsItemAsset";
            this.mnsItemAsset.Size = new System.Drawing.Size(139, 26);
            this.mnsItemAsset.Text = "Assets";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsHome);
            this.MainMenuStrip = this.mnsHome;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.mnsHome.ResumeLayout(false);
            this.mnsHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsHome;
        private System.Windows.Forms.ToolStripMenuItem mnsItemTools;
        private System.Windows.Forms.ToolStripMenuItem mnsItemAsset;
    }
}

