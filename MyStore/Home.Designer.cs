namespace MyStore
{
    partial class Home
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
            this.browseItemsBtn = new System.Windows.Forms.Button();
            this.profileBtn = new System.Windows.Forms.Button();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // browseItemsBtn
            // 
            this.browseItemsBtn.BackColor = System.Drawing.Color.DarkRed;
            this.browseItemsBtn.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseItemsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.browseItemsBtn.Location = new System.Drawing.Point(173, 298);
            this.browseItemsBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.browseItemsBtn.Name = "browseItemsBtn";
            this.browseItemsBtn.Size = new System.Drawing.Size(432, 203);
            this.browseItemsBtn.TabIndex = 0;
            this.browseItemsBtn.Text = "BROWSE ITEMS";
            this.browseItemsBtn.UseVisualStyleBackColor = false;
            this.browseItemsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.profileBtn.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.profileBtn.Location = new System.Drawing.Point(808, 298);
            this.profileBtn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(432, 203);
            this.profileBtn.TabIndex = 1;
            this.profileBtn.Text = "MY PROFILE";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // logoutLink
            // 
            this.logoutLink.AutoSize = true;
            this.logoutLink.BackColor = System.Drawing.Color.Transparent;
            this.logoutLink.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.logoutLink.Location = new System.Drawing.Point(130, 9);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(141, 32);
            this.logoutLink.TabIndex = 10;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "LOG OUT";
            this.logoutLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLink_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabel1.Location = new System.Drawing.Point(12, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(99, 32);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "HOME";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1424, 801);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.logoutLink);
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.browseItemsBtn);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseItemsBtn;
        private System.Windows.Forms.Button profileBtn;
        private System.Windows.Forms.LinkLabel logoutLink;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}