namespace MyStore
{
    partial class DisplayItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iTEMSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sTOREDataSet2 = new MyStore.STOREDataSet2();
            this.iTEMSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTOREDataSet1 = new MyStore.STOREDataSet1();
            this.iTEMSTableAdapter = new MyStore.STOREDataSet1TableAdapters.ITEMSTableAdapter();
            this.homeLink = new System.Windows.Forms.LinkLabel();
            this.iTEMSTableAdapter1 = new MyStore.STOREDataSet2TableAdapters.ITEMSTableAdapter();
            this.item_upc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itempriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buy = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_upc,
            this.itemdescriptionDataGridViewTextBoxColumn,
            this.itempriceDataGridViewTextBoxColumn,
            this.QUANTITY,
            this.buy});
            this.dataGridView1.DataSource = this.iTEMSBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Narkisim", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1608, 906);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iTEMSBindingSource1
            // 
            this.iTEMSBindingSource1.DataMember = "ITEMS";
            this.iTEMSBindingSource1.DataSource = this.sTOREDataSet2;
            // 
            // sTOREDataSet2
            // 
            this.sTOREDataSet2.DataSetName = "STOREDataSet2";
            this.sTOREDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTEMSBindingSource
            // 
            this.iTEMSBindingSource.DataMember = "ITEMS";
            this.iTEMSBindingSource.DataSource = this.sTOREDataSet1;
            // 
            // sTOREDataSet1
            // 
            this.sTOREDataSet1.DataSetName = "STOREDataSet1";
            this.sTOREDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iTEMSTableAdapter
            // 
            this.iTEMSTableAdapter.ClearBeforeFill = true;
            // 
            // homeLink
            // 
            this.homeLink.AutoSize = true;
            this.homeLink.BackColor = System.Drawing.Color.White;
            this.homeLink.Location = new System.Drawing.Point(10, 15);
            this.homeLink.Name = "homeLink";
            this.homeLink.Size = new System.Drawing.Size(92, 32);
            this.homeLink.TabIndex = 9;
            this.homeLink.TabStop = true;
            this.homeLink.Text = "BACK";
            this.homeLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homeLink_LinkClicked);
            // 
            // iTEMSTableAdapter1
            // 
            this.iTEMSTableAdapter1.ClearBeforeFill = true;
            // 
            // item_upc
            // 
            this.item_upc.DataPropertyName = "item_upc";
            this.item_upc.FillWeight = 104.1666F;
            this.item_upc.HeaderText = "UPC";
            this.item_upc.Name = "item_upc";
            this.item_upc.ReadOnly = true;
            this.item_upc.Visible = false;
            // 
            // itemdescriptionDataGridViewTextBoxColumn
            // 
            this.itemdescriptionDataGridViewTextBoxColumn.DataPropertyName = "item_description";
            this.itemdescriptionDataGridViewTextBoxColumn.FillWeight = 109.3966F;
            this.itemdescriptionDataGridViewTextBoxColumn.HeaderText = "ITEM";
            this.itemdescriptionDataGridViewTextBoxColumn.Name = "itemdescriptionDataGridViewTextBoxColumn";
            this.itemdescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itempriceDataGridViewTextBoxColumn
            // 
            this.itempriceDataGridViewTextBoxColumn.DataPropertyName = "item_price";
            this.itempriceDataGridViewTextBoxColumn.FillWeight = 109.3966F;
            this.itempriceDataGridViewTextBoxColumn.HeaderText = "PRICE";
            this.itempriceDataGridViewTextBoxColumn.Name = "itempriceDataGridViewTextBoxColumn";
            this.itempriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // QUANTITY
            // 
            this.QUANTITY.FillWeight = 77.03987F;
            this.QUANTITY.HeaderText = "QUANTITY";
            this.QUANTITY.Name = "QUANTITY";
            this.QUANTITY.ToolTipText = "0";
            // 
            // buy
            // 
            this.buy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.buy.HeaderText = "BUY";
            this.buy.MinimumWidth = 10;
            this.buy.Name = "buy";
            this.buy.ReadOnly = true;
            this.buy.Text = "BUY";
            this.buy.UseColumnTextForButtonValue = true;
            this.buy.Width = 10;
            // 
            // DisplayItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1608, 907);
            this.Controls.Add(this.homeLink);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DisplayItems";
            this.Text = "DisplayItems";
            this.Load += new System.EventHandler(this.DisplayItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iTEMSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOREDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private STOREDataSet1 sTOREDataSet1;
        private System.Windows.Forms.BindingSource iTEMSBindingSource;
        private STOREDataSet1TableAdapters.ITEMSTableAdapter iTEMSTableAdapter;
        private System.Windows.Forms.LinkLabel homeLink;
        private STOREDataSet2 sTOREDataSet2;
        private System.Windows.Forms.BindingSource iTEMSBindingSource1;
        private STOREDataSet2TableAdapters.ITEMSTableAdapter iTEMSTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_upc;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itempriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTITY;
        private System.Windows.Forms.DataGridViewButtonColumn buy;
    }
}