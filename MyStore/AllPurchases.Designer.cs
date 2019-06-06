namespace MyStore
{
    partial class AllPurchases
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
            this.purchaseList = new System.Windows.Forms.ListView();
            this.orderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // purchaseList
            // 
            this.purchaseList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.purchaseList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderNum,
            this.orderDate,
            this.item,
            this.qty,
            this.price});
            this.purchaseList.FullRowSelect = true;
            this.purchaseList.GridLines = true;
            this.purchaseList.LabelEdit = true;
            this.purchaseList.Location = new System.Drawing.Point(0, 64);
            this.purchaseList.Name = "purchaseList";
            this.purchaseList.Size = new System.Drawing.Size(1196, 555);
            this.purchaseList.TabIndex = 0;
            this.purchaseList.TileSize = new System.Drawing.Size(10, 10);
            this.purchaseList.UseCompatibleStateImageBehavior = false;
            this.purchaseList.View = System.Windows.Forms.View.Details;
            this.purchaseList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // orderNum
            // 
            this.orderNum.Text = "Order #";
            this.orderNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderDate
            // 
            this.orderDate.Text = "Order Date";
            this.orderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orderDate.Width = 75;
            // 
            // item
            // 
            this.item.Text = "Item";
            this.item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item.Width = 65;
            // 
            // qty
            // 
            this.qty.Text = "Quantity";
            this.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qty.Width = 50;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backLink
            // 
            this.backLink.BackColor = System.Drawing.Color.White;
            this.backLink.Location = new System.Drawing.Point(12, 9);
            this.backLink.Name = "backLink";
            this.backLink.Size = new System.Drawing.Size(107, 38);
            this.backLink.TabIndex = 11;
            this.backLink.TabStop = true;
            this.backLink.Text = "BACK";
            this.backLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backLink_LinkClicked);
            // 
            // AllPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 694);
            this.Controls.Add(this.backLink);
            this.Controls.Add(this.purchaseList);
            this.Name = "AllPurchases";
            this.Text = "AllPurchases";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView purchaseList;
        private System.Windows.Forms.ColumnHeader orderNum;
        private System.Windows.Forms.ColumnHeader orderDate;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.LinkLabel backLink;
    }
}