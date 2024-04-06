namespace OJT.App.Views.UnitConversion
{
    partial class UCUnitConversion
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
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.cboToUnit = new System.Windows.Forms.ComboBox();
            this.cboBaseUnit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hdProductId = new System.Windows.Forms.Label();
            this.hdBaseUnitId = new System.Windows.Forms.Label();
            this.hdToUnitId = new System.Windows.Forms.Label();
            this.pnTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultiplier.Location = new System.Drawing.Point(438, 269);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(250, 26);
            this.txtMultiplier.TabIndex = 19;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(625, 380);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(142, 40);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(477, 380);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 40);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(329, 380);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(142, 40);
            this.btnAddNew.TabIndex = 20;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Location = new System.Drawing.Point(31, 23);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1071, 48);
            this.pnTitle.TabIndex = 24;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(151, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Unit Conversion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(737, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "To Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Base Unit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Product";
            // 
            // cboProduct
            // 
            this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(103, 164);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(250, 24);
            this.cboProduct.TabIndex = 27;
            this.cboProduct.SelectedIndexChanged += new System.EventHandler(this.cboProduct_SelectedIndexChanged);
            // 
            // cboToUnit
            // 
            this.cboToUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToUnit.FormattingEnabled = true;
            this.cboToUnit.Location = new System.Drawing.Point(742, 164);
            this.cboToUnit.Name = "cboToUnit";
            this.cboToUnit.Size = new System.Drawing.Size(250, 24);
            this.cboToUnit.TabIndex = 26;
            this.cboToUnit.SelectedIndexChanged += new System.EventHandler(this.cboToUnit_SelectedIndexChanged);
            // 
            // cboBaseUnit
            // 
            this.cboBaseUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaseUnit.FormattingEnabled = true;
            this.cboBaseUnit.Location = new System.Drawing.Point(438, 164);
            this.cboBaseUnit.Name = "cboBaseUnit";
            this.cboBaseUnit.Size = new System.Drawing.Size(250, 24);
            this.cboBaseUnit.TabIndex = 25;
            this.cboBaseUnit.SelectedIndexChanged += new System.EventHandler(this.cboBaseUnit_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Multiplier";
            // 
            // hdProductId
            // 
            this.hdProductId.AutoSize = true;
            this.hdProductId.Location = new System.Drawing.Point(377, 35);
            this.hdProductId.Name = "hdProductId";
            this.hdProductId.Size = new System.Drawing.Size(0, 16);
            this.hdProductId.TabIndex = 32;
            this.hdProductId.Visible = false;
            // 
            // hdBaseUnitId
            // 
            this.hdBaseUnitId.AutoSize = true;
            this.hdBaseUnitId.Location = new System.Drawing.Point(465, 35);
            this.hdBaseUnitId.Name = "hdBaseUnitId";
            this.hdBaseUnitId.Size = new System.Drawing.Size(0, 16);
            this.hdBaseUnitId.TabIndex = 33;
            this.hdBaseUnitId.Visible = false;
            // 
            // hdToUnitId
            // 
            this.hdToUnitId.AutoSize = true;
            this.hdToUnitId.Location = new System.Drawing.Point(551, 35);
            this.hdToUnitId.Name = "hdToUnitId";
            this.hdToUnitId.Size = new System.Drawing.Size(0, 16);
            this.hdToUnitId.TabIndex = 34;
            this.hdToUnitId.Visible = false;
            // 
            // UCUnitConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hdToUnitId);
            this.Controls.Add(this.hdBaseUnitId);
            this.Controls.Add(this.hdProductId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboProduct);
            this.Controls.Add(this.cboToUnit);
            this.Controls.Add(this.cboBaseUnit);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.txtMultiplier);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Name = "UCUnitConversion";
            this.Size = new System.Drawing.Size(1126, 513);
            this.Load += new System.EventHandler(this.UCUnitConversion_Load);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.ComboBox cboToUnit;
        private System.Windows.Forms.ComboBox cboBaseUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hdProductId;
        private System.Windows.Forms.Label hdBaseUnitId;
        private System.Windows.Forms.Label hdToUnitId;
    }
}
