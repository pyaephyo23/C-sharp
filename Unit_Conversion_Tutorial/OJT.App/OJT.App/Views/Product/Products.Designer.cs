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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.gcProductID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToResizeColumns = false;
            this.dgvProductList.AllowUserToResizeRows = false;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcProductID,
            this.gcName,
            this.gcAddress,
            this.gcDesignation});
            this.dgvProductList.Location = new System.Drawing.Point(21, 90);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductList.RowHeadersVisible = false;
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowTemplate.Height = 24;
            this.dgvProductList.Size = new System.Drawing.Size(1075, 379);
            this.dgvProductList.TabIndex = 6;
            this.dgvProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellClick);
            // 
            // gcProductID
            // 
            this.gcProductID.DataPropertyName = "ProductId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gcProductID.DefaultCellStyle = dataGridViewCellStyle3;
            this.gcProductID.HeaderText = "Product ID";
            this.gcProductID.MinimumWidth = 6;
            this.gcProductID.Name = "gcProductID";
            this.gcProductID.ReadOnly = true;
            this.gcProductID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gcProductID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gcProductID.Width = 125;
            // 
            // gcName
            // 
            this.gcName.DataPropertyName = "Barcode";
            this.gcName.HeaderText = "Barcode";
            this.gcName.MinimumWidth = 6;
            this.gcName.Name = "gcName";
            this.gcName.ReadOnly = true;
            this.gcName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gcName.Width = 125;
            // 
            // gcAddress
            // 
            this.gcAddress.DataPropertyName = "Name";
            this.gcAddress.HeaderText = "Name";
            this.gcAddress.MinimumWidth = 6;
            this.gcAddress.Name = "gcAddress";
            this.gcAddress.ReadOnly = true;
            this.gcAddress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gcAddress.Width = 125;
            // 
            // gcDesignation
            // 
            this.gcDesignation.DataPropertyName = "BaseUnitId";
            this.gcDesignation.HeaderText = "BaseUnitId";
            this.gcDesignation.MinimumWidth = 6;
            this.gcDesignation.Name = "gcDesignation";
            this.gcDesignation.ReadOnly = true;
            this.gcDesignation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gcDesignation.Width = 125;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(590, 486);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 40);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(402, 486);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(126, 40);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Location = new System.Drawing.Point(21, 12);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1075, 48);
            this.pnTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(79, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Product";
            // 
            // UCProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.pnTitle);
            this.Name = "UCProductList";
            this.Size = new System.Drawing.Size(1126, 675);
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridViewLinkColumn gcProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcDesignation;
    }
}
