namespace MyStore
{
    partial class SpecificPurchase
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
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.dateFromLbl = new System.Windows.Forms.Label();
            this.dateToLbl = new System.Windows.Forms.Label();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.goBtn = new System.Windows.Forms.Button();
            this.dateRadio = new System.Windows.Forms.RadioButton();
            this.priceRadio = new System.Windows.Forms.RadioButton();
            this.priceFromLbl = new System.Windows.Forms.Label();
            this.priceToLbl = new System.Windows.Forms.Label();
            this.priceFromTxt = new System.Windows.Forms.TextBox();
            this.priceToTxt = new System.Windows.Forms.TextBox();
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
            this.purchaseList.Location = new System.Drawing.Point(185, 421);
            this.purchaseList.Name = "purchaseList";
            this.purchaseList.Size = new System.Drawing.Size(1307, 555);
            this.purchaseList.TabIndex = 1;
            this.purchaseList.TileSize = new System.Drawing.Size(10, 10);
            this.purchaseList.UseCompatibleStateImageBehavior = false;
            this.purchaseList.View = System.Windows.Forms.View.Details;
            this.purchaseList.SelectedIndexChanged += new System.EventHandler(this.purchaseList_SelectedIndexChanged);
            // 
            // orderNum
            // 
            this.orderNum.Text = "Order #";
            this.orderNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orderNum.Width = 100;
            // 
            // orderDate
            // 
            this.orderDate.Text = "Order Date";
            this.orderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.orderDate.Width = 120;
            // 
            // item
            // 
            this.item.Text = "Item";
            this.item.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.item.Width = 115;
            // 
            // qty
            // 
            this.qty.Text = "Quantity";
            this.qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qty.Width = 100;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.Width = 133;
            // 
            // dateFromPicker
            // 
            this.dateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromPicker.Location = new System.Drawing.Point(385, 138);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(200, 38);
            this.dateFromPicker.TabIndex = 2;
            this.dateFromPicker.Value = new System.DateTime(2019, 6, 4, 13, 47, 1, 0);
            // 
            // dateFromLbl
            // 
            this.dateFromLbl.AutoSize = true;
            this.dateFromLbl.Location = new System.Drawing.Point(163, 143);
            this.dateFromLbl.Name = "dateFromLbl";
            this.dateFromLbl.Size = new System.Drawing.Size(155, 32);
            this.dateFromLbl.TabIndex = 3;
            this.dateFromLbl.Text = "Date From:";
            // 
            // dateToLbl
            // 
            this.dateToLbl.AutoSize = true;
            this.dateToLbl.Location = new System.Drawing.Point(163, 248);
            this.dateToLbl.Name = "dateToLbl";
            this.dateToLbl.Size = new System.Drawing.Size(123, 32);
            this.dateToLbl.TabIndex = 4;
            this.dateToLbl.Text = "Date To:";
            // 
            // dateToPicker
            // 
            this.dateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToPicker.Location = new System.Drawing.Point(385, 242);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(200, 38);
            this.dateToPicker.TabIndex = 5;
            this.dateToPicker.Value = new System.DateTime(2019, 6, 4, 13, 47, 1, 0);
            // 
            // goBtn
            // 
            this.goBtn.BackColor = System.Drawing.Color.DarkRed;
            this.goBtn.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBtn.ForeColor = System.Drawing.Color.White;
            this.goBtn.Location = new System.Drawing.Point(743, 154);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(151, 106);
            this.goBtn.TabIndex = 6;
            this.goBtn.Text = "GO";
            this.goBtn.UseVisualStyleBackColor = false;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // dateRadio
            // 
            this.dateRadio.AutoSize = true;
            this.dateRadio.Location = new System.Drawing.Point(205, 54);
            this.dateRadio.Name = "dateRadio";
            this.dateRadio.Size = new System.Drawing.Size(339, 36);
            this.dateRadio.TabIndex = 7;
            this.dateRadio.TabStop = true;
            this.dateRadio.Text = "Search Orders by Date";
            this.dateRadio.UseVisualStyleBackColor = true;
            this.dateRadio.CheckedChanged += new System.EventHandler(this.dateRadio_CheckedChanged);
            // 
            // priceRadio
            // 
            this.priceRadio.AutoSize = true;
            this.priceRadio.Location = new System.Drawing.Point(1077, 54);
            this.priceRadio.Name = "priceRadio";
            this.priceRadio.Size = new System.Drawing.Size(344, 36);
            this.priceRadio.TabIndex = 8;
            this.priceRadio.TabStop = true;
            this.priceRadio.Text = "Search Orders by Price";
            this.priceRadio.UseVisualStyleBackColor = true;
            this.priceRadio.CheckedChanged += new System.EventHandler(this.priceRadio_CheckedChanged);
            // 
            // priceFromLbl
            // 
            this.priceFromLbl.AutoSize = true;
            this.priceFromLbl.Location = new System.Drawing.Point(1021, 143);
            this.priceFromLbl.Name = "priceFromLbl";
            this.priceFromLbl.Size = new System.Drawing.Size(160, 32);
            this.priceFromLbl.TabIndex = 9;
            this.priceFromLbl.Text = "Price From:";
            // 
            // priceToLbl
            // 
            this.priceToLbl.AutoSize = true;
            this.priceToLbl.Location = new System.Drawing.Point(1021, 248);
            this.priceToLbl.Name = "priceToLbl";
            this.priceToLbl.Size = new System.Drawing.Size(128, 32);
            this.priceToLbl.TabIndex = 10;
            this.priceToLbl.Text = "Price To:";
            // 
            // priceFromTxt
            // 
            this.priceFromTxt.Location = new System.Drawing.Point(1276, 126);
            this.priceFromTxt.MaximumSize = new System.Drawing.Size(200, 200);
            this.priceFromTxt.MinimumSize = new System.Drawing.Size(200, 50);
            this.priceFromTxt.Name = "priceFromTxt";
            this.priceFromTxt.Size = new System.Drawing.Size(200, 38);
            this.priceFromTxt.TabIndex = 11;
            // 
            // priceToTxt
            // 
            this.priceToTxt.Location = new System.Drawing.Point(1276, 230);
            this.priceToTxt.MaximumSize = new System.Drawing.Size(200, 200);
            this.priceToTxt.MinimumSize = new System.Drawing.Size(200, 50);
            this.priceToTxt.Name = "priceToTxt";
            this.priceToTxt.Size = new System.Drawing.Size(200, 38);
            this.priceToTxt.TabIndex = 12;
            // 
            // backLink
            // 
            this.backLink.BackColor = System.Drawing.Color.Transparent;
            this.backLink.Location = new System.Drawing.Point(12, 9);
            this.backLink.Name = "backLink";
            this.backLink.Size = new System.Drawing.Size(107, 38);
            this.backLink.TabIndex = 13;
            this.backLink.TabStop = true;
            this.backLink.Text = "BACK";
            this.backLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backLink_LinkClicked);
            // 
            // SpecificPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1685, 988);
            this.Controls.Add(this.backLink);
            this.Controls.Add(this.priceToTxt);
            this.Controls.Add(this.priceFromTxt);
            this.Controls.Add(this.priceToLbl);
            this.Controls.Add(this.priceFromLbl);
            this.Controls.Add(this.priceRadio);
            this.Controls.Add(this.dateRadio);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.dateToPicker);
            this.Controls.Add(this.dateToLbl);
            this.Controls.Add(this.dateFromLbl);
            this.Controls.Add(this.dateFromPicker);
            this.Controls.Add(this.purchaseList);
            this.Name = "SpecificPurchase";
            this.Text = "Specific Purchase Search";
            this.Load += new System.EventHandler(this.SpecificPurchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView purchaseList;
        private System.Windows.Forms.ColumnHeader orderNum;
        private System.Windows.Forms.ColumnHeader orderDate;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader qty;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.Label dateFromLbl;
        private System.Windows.Forms.Label dateToLbl;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.RadioButton dateRadio;
        private System.Windows.Forms.RadioButton priceRadio;
        private System.Windows.Forms.Label priceFromLbl;
        private System.Windows.Forms.Label priceToLbl;
        private System.Windows.Forms.TextBox priceFromTxt;
        private System.Windows.Forms.TextBox priceToTxt;
        private System.Windows.Forms.LinkLabel backLink;
    }
}