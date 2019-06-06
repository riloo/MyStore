namespace MyStore
{
    partial class AccountBalance
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
            this.label1 = new System.Windows.Forms.Label();
            this.payAmt = new System.Windows.Forms.TextBox();
            this.fillBalance = new System.Windows.Forms.Label();
            this.payBtn = new System.Windows.Forms.Button();
            this.backLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(137, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "BALANCE:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payAmt
            // 
            this.payAmt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payAmt.BackColor = System.Drawing.Color.White;
            this.payAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payAmt.ForeColor = System.Drawing.Color.DarkRed;
            this.payAmt.Location = new System.Drawing.Point(326, 368);
            this.payAmt.MaximumSize = new System.Drawing.Size(250, 50);
            this.payAmt.MinimumSize = new System.Drawing.Size(250, 75);
            this.payAmt.Multiline = true;
            this.payAmt.Name = "payAmt";
            this.payAmt.Size = new System.Drawing.Size(250, 75);
            this.payAmt.TabIndex = 3;
            this.payAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.payAmt.UseWaitCursor = true;
            this.payAmt.TextChanged += new System.EventHandler(this.payAmt_TextChanged);
            // 
            // fillBalance
            // 
            this.fillBalance.BackColor = System.Drawing.Color.Transparent;
            this.fillBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillBalance.ForeColor = System.Drawing.Color.DarkRed;
            this.fillBalance.Location = new System.Drawing.Point(432, 163);
            this.fillBalance.Name = "fillBalance";
            this.fillBalance.Size = new System.Drawing.Size(308, 57);
            this.fillBalance.TabIndex = 4;
            this.fillBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // payBtn
            // 
            this.payBtn.BackColor = System.Drawing.Color.Black;
            this.payBtn.ForeColor = System.Drawing.Color.White;
            this.payBtn.Location = new System.Drawing.Point(388, 473);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(137, 72);
            this.payBtn.TabIndex = 5;
            this.payBtn.Text = "PAY";
            this.payBtn.UseVisualStyleBackColor = false;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // backLink
            // 
            this.backLink.AutoSize = true;
            this.backLink.BackColor = System.Drawing.Color.White;
            this.backLink.Location = new System.Drawing.Point(12, 9);
            this.backLink.Name = "backLink";
            this.backLink.Size = new System.Drawing.Size(99, 32);
            this.backLink.TabIndex = 10;
            this.backLink.TabStop = true;
            this.backLink.Text = " BACK";
            this.backLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backLink_LinkClicked);
            // 
            // AccountBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 626);
            this.Controls.Add(this.backLink);
            this.Controls.Add(this.payBtn);
            this.Controls.Add(this.fillBalance);
            this.Controls.Add(this.payAmt);
            this.Controls.Add(this.label1);
            this.Name = "AccountBalance";
            this.Text = "AccountBalance";
            this.Load += new System.EventHandler(this.AccountBalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox payAmt;
        private System.Windows.Forms.Label fillBalance;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.LinkLabel backLink;
    }
}