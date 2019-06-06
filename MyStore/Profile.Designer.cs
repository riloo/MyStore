namespace MyStore
{
    partial class Profile
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
            this.balanceTxt = new System.Windows.Forms.Button();
            this.allPurchTxt = new System.Windows.Forms.Button();
            this.specPurchTxt = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.fillName = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.fillAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.homeLink = new System.Windows.Forms.LinkLabel();
            this.logoutLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // balanceTxt
            // 
            this.balanceTxt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.balanceTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.balanceTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.balanceTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.balanceTxt.Location = new System.Drawing.Point(56, 612);
            this.balanceTxt.Name = "balanceTxt";
            this.balanceTxt.Size = new System.Drawing.Size(204, 137);
            this.balanceTxt.TabIndex = 0;
            this.balanceTxt.Text = "ACCOUNT BALANCE";
            this.balanceTxt.UseVisualStyleBackColor = false;
            this.balanceTxt.Click += new System.EventHandler(this.balanceTxt_Click);
            // 
            // allPurchTxt
            // 
            this.allPurchTxt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.allPurchTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.allPurchTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.allPurchTxt.Location = new System.Drawing.Point(358, 612);
            this.allPurchTxt.Name = "allPurchTxt";
            this.allPurchTxt.Size = new System.Drawing.Size(204, 137);
            this.allPurchTxt.TabIndex = 1;
            this.allPurchTxt.Text = "ALL PURCHASES";
            this.allPurchTxt.UseVisualStyleBackColor = false;
            this.allPurchTxt.Click += new System.EventHandler(this.allPurchTxt_Click);
            // 
            // specPurchTxt
            // 
            this.specPurchTxt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.specPurchTxt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.specPurchTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.specPurchTxt.Location = new System.Drawing.Point(670, 612);
            this.specPurchTxt.Name = "specPurchTxt";
            this.specPurchTxt.Size = new System.Drawing.Size(204, 137);
            this.specPurchTxt.TabIndex = 2;
            this.specPurchTxt.Text = "SPECIFIC PURCHASES";
            this.specPurchTxt.UseVisualStyleBackColor = false;
            this.specPurchTxt.Click += new System.EventHandler(this.specPurchTxt_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.BackColor = System.Drawing.Color.DarkRed;
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(122, 206);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(184, 74);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Username:";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fillName
            // 
            this.fillName.BackColor = System.Drawing.Color.DarkRed;
            this.fillName.ForeColor = System.Drawing.Color.White;
            this.fillName.Location = new System.Drawing.Point(417, 206);
            this.fillName.Name = "fillName";
            this.fillName.Size = new System.Drawing.Size(432, 74);
            this.fillName.TabIndex = 4;
            this.fillName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressLbl
            // 
            this.addressLbl.BackColor = System.Drawing.Color.DarkRed;
            this.addressLbl.ForeColor = System.Drawing.Color.White;
            this.addressLbl.Location = new System.Drawing.Point(122, 366);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(184, 74);
            this.addressLbl.TabIndex = 5;
            this.addressLbl.Text = "Address:";
            this.addressLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fillAddress
            // 
            this.fillAddress.BackColor = System.Drawing.Color.DarkRed;
            this.fillAddress.ForeColor = System.Drawing.Color.White;
            this.fillAddress.Location = new System.Drawing.Point(417, 366);
            this.fillAddress.Name = "fillAddress";
            this.fillAddress.Size = new System.Drawing.Size(432, 74);
            this.fillAddress.TabIndex = 6;
            this.fillAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(248, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 74);
            this.label1.TabIndex = 7;
            this.label1.Text = "MY PROFILE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homeLink
            // 
            this.homeLink.AutoSize = true;
            this.homeLink.Location = new System.Drawing.Point(12, 9);
            this.homeLink.Name = "homeLink";
            this.homeLink.Size = new System.Drawing.Size(99, 32);
            this.homeLink.TabIndex = 8;
            this.homeLink.TabStop = true;
            this.homeLink.Text = "HOME";
            this.homeLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homeLink_LinkClicked);
            // 
            // logoutLink
            // 
            this.logoutLink.AutoSize = true;
            this.logoutLink.Location = new System.Drawing.Point(122, 9);
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(141, 32);
            this.logoutLink.TabIndex = 9;
            this.logoutLink.TabStop = true;
            this.logoutLink.Text = "LOG OUT";
            this.logoutLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logoutLink_LinkClicked);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyStore.Properties.Resources.profilePicture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 867);
            this.Controls.Add(this.logoutLink);
            this.Controls.Add(this.homeLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillAddress);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.fillName);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.specPurchTxt);
            this.Controls.Add(this.allPurchTxt);
            this.Controls.Add(this.balanceTxt);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button balanceTxt;
        private System.Windows.Forms.Button allPurchTxt;
        private System.Windows.Forms.Button specPurchTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label fillName;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label fillAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel homeLink;
        private System.Windows.Forms.LinkLabel logoutLink;
    }
}