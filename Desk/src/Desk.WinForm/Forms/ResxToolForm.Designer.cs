
namespace Desk.WinForm
{
    partial class ResxToolForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResxToolForm));
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "app.png");
            this.imgList.Images.SetKeyName(1, "draw.png");
            this.imgList.Images.SetKeyName(2, "files-and-folders.png");
            this.imgList.Images.SetKeyName(3, "lock.png");
            this.imgList.Images.SetKeyName(4, "mails.png");
            this.imgList.Images.SetKeyName(5, "notebook.png");
            this.imgList.Images.SetKeyName(6, "print.png");
            this.imgList.Images.SetKeyName(7, "setup.png");
            // 
            // ResxToolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 732);
            this.Name = "ResxToolForm";
            this.Text = "ResxToolForm";
            this.Load += new System.EventHandler(this.ResxToolForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgList;
    }
}