namespace OJT.App.Views.Employee
{
    partial class UCEmployeeList
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.gcNo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gcEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcPhNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcEmployeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TownshipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Location = new System.Drawing.Point(23, 20);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1069, 48);
            this.pnTitle.TabIndex = 23;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Employee List";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.ForeColor = System.Drawing.Color.Brown;
            this.btnUpload.Location = new System.Drawing.Point(950, 439);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(142, 40);
            this.btnUpload.TabIndex = 28;
            this.btnUpload.Text = "Upload Data";
            this.btnUpload.UseVisualStyleBackColor = false;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.ForeColor = System.Drawing.Color.Brown;
            this.btnDownload.Location = new System.Drawing.Point(24, 439);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(142, 40);
            this.btnDownload.TabIndex = 27;
            this.btnDownload.Text = "Download Data";
            this.btnDownload.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(581, 439);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 40);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(399, 439);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(142, 40);
            this.btnAddNew.TabIndex = 25;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AllowUserToAddRows = false;
            this.dgvEmployeeList.AllowUserToResizeColumns = false;
            this.dgvEmployeeList.AllowUserToResizeRows = false;
            this.dgvEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeList.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvEmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcNo,
            this.gcEmployeeId,
            this.gcName,
            this.gcPhNo,
            this.gcEmail,
            this.gcGender,
            this.gcEmployeeType,
            this.DateOfBirth,
            this.Address,
            this.TownshipName});
            this.dgvEmployeeList.Location = new System.Drawing.Point(23, 112);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployeeList.RowHeadersVisible = false;
            this.dgvEmployeeList.RowHeadersWidth = 51;
            this.dgvEmployeeList.RowTemplate.Height = 24;
            this.dgvEmployeeList.Size = new System.Drawing.Size(1069, 297);
            this.dgvEmployeeList.TabIndex = 24;
            this.dgvEmployeeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeList_CellContentClick);
            // 
            // gcNo
            // 
            this.gcNo.DataPropertyName = "RowNum";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            this.gcNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.gcNo.HeaderText = "No.";
            this.gcNo.MinimumWidth = 6;
            this.gcNo.Name = "gcNo";
            this.gcNo.ReadOnly = true;
            // 
            // gcEmployeeId
            // 
            this.gcEmployeeId.DataPropertyName = "EmployeeId";
            this.gcEmployeeId.HeaderText = "Employee ID";
            this.gcEmployeeId.MinimumWidth = 6;
            this.gcEmployeeId.Name = "gcEmployeeId";
            this.gcEmployeeId.ReadOnly = true;
            this.gcEmployeeId.Visible = false;
            // 
            // gcName
            // 
            this.gcName.DataPropertyName = "Name";
            this.gcName.HeaderText = "Name";
            this.gcName.MinimumWidth = 6;
            this.gcName.Name = "gcName";
            this.gcName.ReadOnly = true;
            // 
            // gcPhNo
            // 
            this.gcPhNo.DataPropertyName = "PhNo";
            this.gcPhNo.HeaderText = "Phone Number";
            this.gcPhNo.MinimumWidth = 6;
            this.gcPhNo.Name = "gcPhNo";
            this.gcPhNo.ReadOnly = true;
            // 
            // gcEmail
            // 
            this.gcEmail.DataPropertyName = "Email";
            this.gcEmail.HeaderText = "Email";
            this.gcEmail.MinimumWidth = 6;
            this.gcEmail.Name = "gcEmail";
            this.gcEmail.ReadOnly = true;
            // 
            // gcGender
            // 
            this.gcGender.DataPropertyName = "Gender";
            this.gcGender.HeaderText = "Gender";
            this.gcGender.MinimumWidth = 6;
            this.gcGender.Name = "gcGender";
            this.gcGender.ReadOnly = true;
            // 
            // gcEmployeeType
            // 
            this.gcEmployeeType.DataPropertyName = "EmployeeType";
            this.gcEmployeeType.HeaderText = "Employee Type";
            this.gcEmployeeType.MinimumWidth = 6;
            this.gcEmployeeType.Name = "gcEmployeeType";
            this.gcEmployeeType.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "DateOfBirth";
            this.DateOfBirth.HeaderText = "DateOfBirth";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address ";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // TownshipName
            // 
            this.TownshipName.DataPropertyName = "TownshipName";
            this.TownshipName.HeaderText = "Township";
            this.TownshipName.MinimumWidth = 6;
            this.TownshipName.Name = "TownshipName";
            this.TownshipName.ReadOnly = true;
            // 
            // UCEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgvEmployeeList);
            this.Controls.Add(this.pnTitle);
            this.Name = "UCEmployeeList";
            this.Size = new System.Drawing.Size(1126, 513);
            this.Load += new System.EventHandler(this.UCEmployeeList_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.DataGridViewButtonColumn gcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcPhNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcEmployeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn TownshipName;
    }
}
