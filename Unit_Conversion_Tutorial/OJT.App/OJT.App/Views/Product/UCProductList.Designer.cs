namespace OJT.App.Views.Product
{
    partial class UCProductList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.gcProductID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gcBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcBaseUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToResizeColumns = false;
            this.dgvProductList.AllowUserToResizeRows = false;
            this.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductList.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvProductList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcProductID,
            this.gcBarcode,
            this.gcName,
            this.gcBaseUnitId});
            this.dgvProductList.Location = new System.Drawing.Point(24, 114);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductList.RowHeadersVisible = false;
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowTemplate.Height = 24;
            this.dgvProductList.Size = new System.Drawing.Size(1069, 297);
            this.dgvProductList.TabIndex = 3;
            this.dgvProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellContentClick);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(400, 441);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(142, 40);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(582, 441);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 40);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Location = new System.Drawing.Point(24, 22);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1069, 48);
            this.pnTitle.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Product Listing";
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.ForeColor = System.Drawing.Color.Brown;
            this.btnDownload.Location = new System.Drawing.Point(25, 441);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(142, 40);
            this.btnDownload.TabIndex = 7;
            this.btnDownload.Text = "Download Data";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.ForeColor = System.Drawing.Color.Brown;
            this.btnUpload.Location = new System.Drawing.Point(951, 441);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(142, 40);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "Upload Data";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // gcProductID
            // 
            this.gcProductID.DataPropertyName = "ProductId";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.gcProductID.DefaultCellStyle = dataGridViewCellStyle1;
            this.gcProductID.HeaderText = "Product ID";
            this.gcProductID.MinimumWidth = 6;
            this.gcProductID.Name = "gcProductID";
            this.gcProductID.ReadOnly = true;
            this.gcProductID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gcProductID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gcBarcode
            // 
            this.gcBarcode.DataPropertyName = "Barcode";
            this.gcBarcode.HeaderText = "Barcode";
            this.gcBarcode.MinimumWidth = 6;
            this.gcBarcode.Name = "gcBarcode";
            this.gcBarcode.ReadOnly = true;
            this.gcBarcode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gcName
            // 
            this.gcName.DataPropertyName = "Name";
            this.gcName.HeaderText = "Name";
            this.gcName.MinimumWidth = 6;
            this.gcName.Name = "gcName";
            this.gcName.ReadOnly = true;
            this.gcName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gcBaseUnitId
            // 
            this.gcBaseUnitId.DataPropertyName = "BaseUnitId";
            this.gcBaseUnitId.HeaderText = "Base Unit Id";
            this.gcBaseUnitId.MinimumWidth = 6;
            this.gcBaseUnitId.Name = "gcBaseUnitId";
            this.gcBaseUnitId.ReadOnly = true;
            this.gcBaseUnitId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // UCProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgvProductList);
            this.Name = "UCProductList";
            this.Size = new System.Drawing.Size(1126, 513);
            this.Load += new System.EventHandler(this.ProductListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.DataGridViewLinkColumn gcProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcBaseUnitId;
    }
}
