namespace MyStore
{
    partial class Form1
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
            this.usernamelbl = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginLbl = new System.Windows.Forms.Button();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernamelbl
            // 
            this.usernamelbl.BackColor = System.Drawing.Color.DarkRed;
            this.usernamelbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.ForeColor = System.Drawing.Color.White;
            this.usernamelbl.Location = new System.Drawing.Point(261, 119);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(253, 74);
            this.usernamelbl.TabIndex = 1;
            this.usernamelbl.Text = "Username:";
            this.usernamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usernamelbl.Click += new System.EventHandler(this.usernamelbl_Click);
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(587, 119);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTxt.MinimumSize = new System.Drawing.Size(4, 49);
            this.usernameTxt.Multiline = true;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(441, 68);
            this.usernameTxt.TabIndex = 2;
            this.usernameTxt.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(261, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 74);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginLbl
            // 
            this.loginLbl.BackColor = System.Drawing.Color.DimGray;
            this.loginLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginLbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.ForeColor = System.Drawing.Color.White;
            this.loginLbl.Location = new System.Drawing.Point(0, 639);
            this.loginLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(1227, 103);
            this.loginLbl.TabIndex = 5;
            this.loginLbl.Text = "LOGIN";
            this.loginLbl.UseVisualStyleBackColor = false;
            this.loginLbl.Click += new System.EventHandler(this.loginLbl_Click);
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(587, 264);
            this.passTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passTxt.MinimumSize = new System.Drawing.Size(4, 49);
            this.passTxt.Multiline = true;
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(441, 68);
            this.passTxt.TabIndex = 6;
            this.passTxt.UseWaitCursor = true;
            this.passTxt.TextChanged += new System.EventHandler(this.passTxt_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1227, 742);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.usernamelbl);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "My Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginLbl;
        private System.Windows.Forms.TextBox passTxt;
    }
}

