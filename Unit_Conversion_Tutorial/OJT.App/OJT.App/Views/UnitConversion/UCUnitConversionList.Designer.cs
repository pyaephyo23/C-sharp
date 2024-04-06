namespace OJT.App.Views.UnitConversion
{
    partial class UCUnitConversionList
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
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dgvUnitConversionList = new System.Windows.Forms.DataGridView();
            this.gcProductName = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gcBaseUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcMultiplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcToUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitConversionList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Location = new System.Drawing.Point(29, 40);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1069, 48);
            this.pnTitle.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "UnitConversion Listing";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(597, 431);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(419, 431);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(142, 40);
            this.btnAddNew.TabIndex = 8;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dgvUnitConversionList
            // 
            this.dgvUnitConversionList.AllowUserToAddRows = false;
            this.dgvUnitConversionList.AllowUserToResizeColumns = false;
            this.dgvUnitConversionList.AllowUserToResizeRows = false;
            this.dgvUnitConversionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnitConversionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnitConversionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcProductName,
            this.gcBaseUnitName,
            this.gcMultiplier,
            this.gcToUnitName});
            this.dgvUnitConversionList.Location = new System.Drawing.Point(29, 116);
            this.dgvUnitConversionList.Name = "dgvUnitConversionList";
            this.dgvUnitConversionList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnitConversionList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnitConversionList.RowHeadersVisible = false;
            this.dgvUnitConversionList.RowHeadersWidth = 51;
            this.dgvUnitConversionList.RowTemplate.Height = 24;
            this.dgvUnitConversionList.Size = new System.Drawing.Size(1069, 277);
            this.dgvUnitConversionList.TabIndex = 7;
            this.dgvUnitConversionList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellContentClick);
            // 
            // gcProductName
            // 
            this.gcProductName.DataPropertyName = "ProductId";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gcProductName.DefaultCellStyle = dataGridViewCellStyle1;
            this.gcProductName.HeaderText = "Product ID";
            this.gcProductName.MinimumWidth = 6;
            this.gcProductName.Name = "gcProductName";
            this.gcProductName.ReadOnly = true;
            this.gcProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gcProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gcBaseUnitName
            // 
            this.gcBaseUnitName.DataPropertyName = "BaseUnitId";
            this.gcBaseUnitName.HeaderText = "Base Unit Id";
            this.gcBaseUnitName.MinimumWidth = 6;
            this.gcBaseUnitName.Name = "gcBaseUnitName";
            this.gcBaseUnitName.ReadOnly = true;
            this.gcBaseUnitName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gcMultiplier
            // 
            this.gcMultiplier.DataPropertyName = "Multiplier";
            this.gcMultiplier.HeaderText = "Multiplier";
            this.gcMultiplier.MinimumWidth = 6;
            this.gcMultiplier.Name = "gcMultiplier";
            this.gcMultiplier.ReadOnly = true;
            this.gcMultiplier.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // gcToUnitName
            // 
            this.gcToUnitName.DataPropertyName = "ToUnitId";
            this.gcToUnitName.HeaderText = "To Unit Id";
            this.gcToUnitName.MinimumWidth = 6;
            this.gcToUnitName.Name = "gcToUnitName";
            this.gcToUnitName.ReadOnly = true;
            this.gcToUnitName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.ForeColor = System.Drawing.Color.Brown;
            this.btnDownload.Location = new System.Drawing.Point(30, 431);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(142, 40);
            this.btnDownload.TabIndex = 11;
            this.btnDownload.Text = "Download Data";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.ForeColor = System.Drawing.Color.Brown;
            this.btnUpload.Location = new System.Drawing.Point(956, 431);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(142, 40);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload Data";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // UCUnitConversionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgvUnitConversionList);
            this.Name = "UCUnitConversionList";
            this.Size = new System.Drawing.Size(1126, 513);
            this.Load += new System.EventHandler(this.UCUnitConversionList_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitConversionList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgvUnitConversionList;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.DataGridViewLinkColumn gcProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcBaseUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcMultiplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcToUnitName;
        private System.Windows.Forms.Button btnUpload;
    }
}
