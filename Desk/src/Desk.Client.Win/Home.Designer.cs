
namespace Desk.Client.Win
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmnNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmnNotifyExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1223, 842);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.ContextMenuStrip = this.cmnNotify;
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "notifyIconMain";
            this.notifyIconMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconMain_MouseDoubleClick);
            // 
            // cmnNotify
            // 
            this.cmnNotify.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmnNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnNotifyExit});
            this.cmnNotify.Name = "cmnNotify";
            this.cmnNotify.Size = new System.Drawing.Size(112, 34);
            // 
            // cmnNotifyExit
            // 
            this.cmnNotifyExit.Name = "cmnNotifyExit";
            this.cmnNotifyExit.Size = new System.Drawing.Size(111, 30);
            this.cmnNotifyExit.Text = "Exit";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 866);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.SizeChanged += new System.EventHandler(this.Home_SizeChanged);
            this.cmnNotify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.ContextMenuStrip cmnNotify;
        private System.Windows.Forms.ToolStripMenuItem cmnNotifyExit;
    }
}

