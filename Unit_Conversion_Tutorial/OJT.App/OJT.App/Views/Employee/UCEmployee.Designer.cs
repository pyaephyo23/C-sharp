namespace OJT.App.Views.Employee
{
    partial class UCEmployee
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
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cboEmployeeType = new System.Windows.Forms.ComboBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.cboTownship = new System.Windows.Forms.ComboBox();
            this.hdEmployeeId = new System.Windows.Forms.Label();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.lblEditTownship = new System.Windows.Forms.LinkLabel();
            this.pnTitle.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(98, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Emloyees";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(639, 436);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 40);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(491, 436);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 40);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(343, 436);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(142, 40);
            this.btnAddNew.TabIndex = 24;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(131, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 16);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Name :";
            // 
            // lblPhNo
            // 
            this.lblPhNo.AutoSize = true;
            this.lblPhNo.Location = new System.Drawing.Point(131, 180);
            this.lblPhNo.Name = "lblPhNo";
            this.lblPhNo.Size = new System.Drawing.Size(76, 16);
            this.lblPhNo.TabIndex = 28;
            this.lblPhNo.Text = "Phone No. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Gender :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(562, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Township :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(562, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Address :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(562, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Date Of Birth :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(562, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Employee Type :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(262, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 22);
            this.txtName.TabIndex = 35;
            // 
            // txtPhNo
            // 
            this.txtPhNo.Location = new System.Drawing.Point(262, 177);
            this.txtPhNo.Name = "txtPhNo";
            this.txtPhNo.Size = new System.Drawing.Size(232, 22);
            this.txtPhNo.TabIndex = 36;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(262, 247);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(232, 22);
            this.txtEmail.TabIndex = 37;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(702, 317);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(232, 90);
            this.txtAddress.TabIndex = 38;
            // 
            // cboEmployeeType
            // 
            this.cboEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployeeType.FormattingEnabled = true;
            this.cboEmployeeType.Location = new System.Drawing.Point(702, 113);
            this.cboEmployeeType.Name = "cboEmployeeType";
            this.cboEmployeeType.Size = new System.Drawing.Size(232, 24);
            this.cboEmployeeType.TabIndex = 40;
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(702, 174);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(232, 22);
            this.dtpBirth.TabIndex = 41;
            // 
            // cboTownship
            // 
            this.cboTownship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTownship.FormattingEnabled = true;
            this.cboTownship.Location = new System.Drawing.Point(702, 247);
            this.cboTownship.Name = "cboTownship";
            this.cboTownship.Size = new System.Drawing.Size(232, 24);
            this.cboTownship.TabIndex = 42;
            this.cboTownship.SelectedIndexChanged += new System.EventHandler(this.cboTownship_SelectedIndexChanged);
            // 
            // hdEmployeeId
            // 
            this.hdEmployeeId.AutoSize = true;
            this.hdEmployeeId.Location = new System.Drawing.Point(37, 107);
            this.hdEmployeeId.Name = "hdEmployeeId";
            this.hdEmployeeId.Size = new System.Drawing.Size(0, 16);
            this.hdEmployeeId.TabIndex = 43;
            this.hdEmployeeId.Visible = false;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(262, 321);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(58, 20);
            this.rdoMale.TabIndex = 44;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(391, 319);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(74, 20);
            this.rdoFemale.TabIndex = 45;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(262, 372);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(60, 20);
            this.rdoOther.TabIndex = 46;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // lblEditTownship
            // 
            this.lblEditTownship.AutoSize = true;
            this.lblEditTownship.Location = new System.Drawing.Point(843, 284);
            this.lblEditTownship.Name = "lblEditTownship";
            this.lblEditTownship.Size = new System.Drawing.Size(91, 16);
            this.lblEditTownship.TabIndex = 47;
            this.lblEditTownship.TabStop = true;
            this.lblEditTownship.Text = "Edit Township";
            this.lblEditTownship.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEditTownship_LinkClicked);
            // 
            // UCEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEditTownship);
            this.Controls.Add(this.rdoOther);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.hdEmployeeId);
            this.Controls.Add(this.cboTownship);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.cboEmployeeType);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPhNo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.pnTitle);
            this.Name = "UCEmployee";
            this.Size = new System.Drawing.Size(1126, 513);
            this.Load += new System.EventHandler(this.UCEmployee_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cboEmployeeType;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.ComboBox cboTownship;
        private System.Windows.Forms.Label hdEmployeeId;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.LinkLabel lblEditTownship;
    }
}
