namespace Tutorial_03
{
    partial class Tutorial_03
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEmail = new TextBox();
            txtPhNo = new TextBox();
            txtName = new TextBox();
            dgvEmployee = new DataGridView();
            rdoFemale = new RadioButton();
            rdoMale = new RadioButton();
            cboEmployeeType = new ComboBox();
            btnClear = new Button();
            btnAdd = new Button();
            lblEmail = new Label();
            lblGender = new Label();
            lblPhNo = new Label();
            lblEmployeeType = new Label();
            lblName = new Label();
            dtpBirth = new DateTimePicker();
            lblDOB = new Label();
            label2 = new Label();
            txtAddress = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(289, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(270, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPhNo
            // 
            txtPhNo.Location = new Point(289, 100);
            txtPhNo.Name = "txtPhNo";
            txtPhNo.Size = new Size(270, 27);
            txtPhNo.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(289, 41);
            txtName.Name = "txtName";
            txtName.Size = new Size(270, 27);
            txtName.TabIndex = 1;
            // 
            // dgvEmployee
            // 
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(60, 386);
            dgvEmployee.Margin = new Padding(3, 4, 3, 4);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.RowTemplate.Height = 25;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.Size = new Size(1116, 337);
            dgvEmployee.TabIndex = 24;
            dgvEmployee.CellClick += dgvEmployee_CellClick;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Cursor = Cursors.Hand;
            rdoFemale.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rdoFemale.Location = new Point(370, 220);
            rdoFemale.Margin = new Padding(3, 4, 3, 4);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(93, 29);
            rdoFemale.TabIndex = 5;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Cursor = Cursors.Hand;
            rdoMale.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            rdoMale.Location = new Point(289, 220);
            rdoMale.Margin = new Padding(3, 4, 3, 4);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(75, 29);
            rdoMale.TabIndex = 4;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // cboEmployeeType
            // 
            cboEmployeeType.FormattingEnabled = true;
            cboEmployeeType.Location = new Point(803, 40);
            cboEmployeeType.Margin = new Padding(3, 4, 3, 4);
            cboEmployeeType.Name = "cboEmployeeType";
            cboEmployeeType.Size = new Size(270, 28);
            cboEmployeeType.TabIndex = 6;
            cboEmployeeType.Text = "Select Employe Type";
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.MenuHighlight;
            btnClear.Cursor = Cursors.Hand;
            btnClear.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(355, 297);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(222, 44);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.MenuHighlight;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(104, 297);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(222, 44);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(104, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Email";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(104, 220);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(74, 25);
            lblGender.TabIndex = 17;
            lblGender.Text = "Gender";
            // 
            // lblPhNo
            // 
            lblPhNo.AutoSize = true;
            lblPhNo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhNo.Location = new Point(104, 100);
            lblPhNo.Name = "lblPhNo";
            lblPhNo.Size = new Size(140, 25);
            lblPhNo.TabIndex = 16;
            lblPhNo.Text = "Phone Number";
            // 
            // lblEmployeeType
            // 
            lblEmployeeType.AutoSize = true;
            lblEmployeeType.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmployeeType.Location = new Point(635, 40);
            lblEmployeeType.Name = "lblEmployeeType";
            lblEmployeeType.Size = new Size(138, 25);
            lblEmployeeType.TabIndex = 15;
            lblEmployeeType.Text = "Employee Type";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(104, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(149, 25);
            lblName.TabIndex = 14;
            lblName.Text = "Employee Name";
            // 
            // dtpBirth
            // 
            dtpBirth.Location = new Point(803, 100);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(270, 27);
            dtpBirth.TabIndex = 7;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblDOB.Location = new Point(635, 100);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(118, 25);
            lblDOB.TabIndex = 29;
            lblDOB.Text = "Date of Birth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(635, 160);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 30;
            label2.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(803, 161);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(270, 107);
            txtAddress.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.MenuHighlight;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(605, 297);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(222, 44);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.MenuHighlight;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(851, 297);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(222, 44);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Tutorial_03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 768);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtAddress);
            Controls.Add(label2);
            Controls.Add(lblDOB);
            Controls.Add(dtpBirth);
            Controls.Add(txtEmail);
            Controls.Add(txtPhNo);
            Controls.Add(txtName);
            Controls.Add(dgvEmployee);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(cboEmployeeType);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(lblEmail);
            Controls.Add(lblGender);
            Controls.Add(lblPhNo);
            Controls.Add(lblEmployeeType);
            Controls.Add(lblName);
            Name = "Tutorial_03";
            Text = "Employee";
            Load += Tutorial_03_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPhNo;
        private TextBox txtName;
        private DataGridView dgvEmployee;
        private RadioButton rdoFemale;
        private RadioButton rdoMale;
        private ComboBox cboEmployeeType;
        private Button btnClear;
        private Button btnAdd;
        private Label lblEmail;
        private Label lblGender;
        private Label lblPhNo;
        private Label lblEmployeeType;
        private Label lblName;
        private DateTimePicker dtpBirth;
        private Label lblDOB;
        private Label label2;
        private TextBox txtAddress;
        private Button btnUpdate;
        private Button btnDelete;
    }
}