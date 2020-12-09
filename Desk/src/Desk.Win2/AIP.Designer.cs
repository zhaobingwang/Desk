
namespace Desk.Win
{
    partial class AIP
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
            this.lblMonth = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lblMonthlyAmount = new System.Windows.Forms.Label();
            this.txtMonthlyAmount = new System.Windows.Forms.TextBox();
            this.lblAnnualYield = new System.Windows.Forms.Label();
            this.txtAnnualYield = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblResult);
            this.pnlMain.Controls.Add(this.lblMonth);
            this.pnlMain.Controls.Add(this.txtMonth);
            this.pnlMain.Controls.Add(this.lblMonthlyAmount);
            this.pnlMain.Controls.Add(this.txtMonthlyAmount);
            this.pnlMain.Controls.Add(this.lblAnnualYield);
            this.pnlMain.Controls.Add(this.txtAnnualYield);
            this.pnlMain.Controls.Add(this.btnCalculate);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 450);
            this.pnlMain.TabIndex = 0;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(65, 158);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(82, 24);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "定投月数";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(171, 152);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(150, 30);
            this.txtMonth.TabIndex = 5;
            // 
            // lblMonthlyAmount
            // 
            this.lblMonthlyAmount.AutoSize = true;
            this.lblMonthlyAmount.Location = new System.Drawing.Point(13, 95);
            this.lblMonthlyAmount.Name = "lblMonthlyAmount";
            this.lblMonthlyAmount.Size = new System.Drawing.Size(154, 24);
            this.lblMonthlyAmount.TabIndex = 4;
            this.lblMonthlyAmount.Text = "每月定投额（元）";
            // 
            // txtMonthlyAmount
            // 
            this.txtMonthlyAmount.Location = new System.Drawing.Point(171, 92);
            this.txtMonthlyAmount.Name = "txtMonthlyAmount";
            this.txtMonthlyAmount.Size = new System.Drawing.Size(150, 30);
            this.txtMonthlyAmount.TabIndex = 3;
            // 
            // lblAnnualYield
            // 
            this.lblAnnualYield.AutoSize = true;
            this.lblAnnualYield.Location = new System.Drawing.Point(13, 32);
            this.lblAnnualYield.Name = "lblAnnualYield";
            this.lblAnnualYield.Size = new System.Drawing.Size(152, 24);
            this.lblAnnualYield.TabIndex = 2;
            this.lblAnnualYield.Text = "年化收益率（%）";
            // 
            // txtAnnualYield
            // 
            this.txtAnnualYield.Location = new System.Drawing.Point(171, 29);
            this.txtAnnualYield.Name = "txtAnnualYield";
            this.txtAnnualYield.Size = new System.Drawing.Size(150, 30);
            this.txtAnnualYield.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(171, 231);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 34);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "计算";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(437, 35);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(47, 24);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "0.00";
            // 
            // AIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.Name = "AIP";
            this.Text = "AIP";
            this.Load += new System.EventHandler(this.AIP_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblAnnualYield;
        private System.Windows.Forms.TextBox txtAnnualYield;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblMonthlyAmount;
        private System.Windows.Forms.TextBox txtMonthlyAmount;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lblResult;
    }
}