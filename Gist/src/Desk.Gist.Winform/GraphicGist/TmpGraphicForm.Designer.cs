
namespace Desk.Gist.Winform.GraphicGist
{
    partial class TmpGraphicForm
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnChar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Location = new System.Drawing.Point(47, 48);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(992, 599);
            this.pnlMain.TabIndex = 0;
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.Location = new System.Drawing.Point(1086, 48);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(112, 34);
            this.btnDrawLine.TabIndex = 1;
            this.btnDrawLine.Text = "Line";
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // btnChar
            // 
            this.btnChar.Location = new System.Drawing.Point(1086, 118);
            this.btnChar.Name = "btnChar";
            this.btnChar.Size = new System.Drawing.Size(112, 34);
            this.btnChar.TabIndex = 2;
            this.btnChar.Text = "Char";
            this.btnChar.UseVisualStyleBackColor = true;
            this.btnChar.Click += new System.EventHandler(this.btnChar_Click);
            // 
            // TmpGraphicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 826);
            this.Controls.Add(this.btnChar);
            this.Controls.Add(this.btnDrawLine);
            this.Controls.Add(this.pnlMain);
            this.Name = "TmpGraphicForm";
            this.Text = "TmpGraphicForm";
            this.Load += new System.EventHandler(this.TmpGraphicForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.Button btnChar;
    }
}