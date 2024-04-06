namespace OJT.App.Views.Units
{
    partial class UCUnitsListing
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
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dgvUnitList = new System.Windows.Forms.DataGridView();
            this.gcUnitID = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gcAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Location = new System.Drawing.Point(24, 22);
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
            this.lblTitle.Size = new System.Drawing.Size(117, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Units Listing";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(592, 435);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(410, 435);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(142, 40);
            this.btnAddNew.TabIndex = 8;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dgvUnitList
            // 
            this.dgvUnitList.AllowUserToAddRows = false;
            this.dgvUnitList.AllowUserToResizeColumns = false;
            this.dgvUnitList.AllowUserToResizeRows = false;
            this.dgvUnitList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUnitList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnitList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcUnitID,
            this.gcAddress});
            this.dgvUnitList.Location = new System.Drawing.Point(24, 113);
            this.dgvUnitList.Name = "dgvUnitList";
            this.dgvUnitList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnitList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUnitList.RowHeadersVisible = false;
            this.dgvUnitList.RowHeadersWidth = 51;
            this.dgvUnitList.RowTemplate.Height = 24;
            this.dgvUnitList.Size = new System.Drawing.Size(1069, 279);
            this.dgvUnitList.TabIndex = 7;
            this.dgvUnitList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnitList_CellContentClick);
            // 
            // gcUnitID
            // 
            this.gcUnitID.DataPropertyName = "UnitId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gcUnitID.DefaultCellStyle = dataGridViewCellStyle3;
            this.gcUnitID.HeaderText = "Unit ID";
            this.gcUnitID.MinimumWidth = 6;
            this.gcUnitID.Name = "gcUnitID";
            this.gcUnitID.ReadOnly = true;
            this.gcUnitID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gcUnitID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // gcAddress
            // 
            this.gcAddress.DataPropertyName = "Name";
            this.gcAddress.HeaderText = "Name";
            this.gcAddress.MinimumWidth = 6;
            this.gcAddress.Name = "gcAddress";
            this.gcAddress.ReadOnly = true;
            this.gcAddress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.ForeColor = System.Drawing.Color.Brown;
            this.btnDownload.Location = new System.Drawing.Point(32, 435);
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
            this.btnUpload.Location = new System.Drawing.Point(951, 435);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(142, 40);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.Text = "Upload Data";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // UCUnitsListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgvUnitList);
            this.Name = "UCUnitsListing";
            this.Size = new System.Drawing.Size(1126, 513);
            this.Load += new System.EventHandler(this.UCUnitsListing_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgvUnitList;
        private System.Windows.Forms.DataGridViewLinkColumn gcUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcAddress;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnUpload;
    }
}
