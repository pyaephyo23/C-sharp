namespace OJT.App.Views.Employee
{
    partial class frm_Township
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTownship = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TownshipId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtTownship = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTownship)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTownship
            // 
            this.dgvTownship.AllowUserToAddRows = false;
            this.dgvTownship.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTownship.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTownship.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.gcName,
            this.TownshipId});
            this.dgvTownship.Location = new System.Drawing.Point(12, 221);
            this.dgvTownship.Name = "dgvTownship";
            this.dgvTownship.RowHeadersWidth = 51;
            this.dgvTownship.RowTemplate.Height = 24;
            this.dgvTownship.Size = new System.Drawing.Size(561, 174);
            this.dgvTownship.TabIndex = 0;
            this.dgvTownship.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTownship_CellContentClick);
            // 
            // No
            // 
            this.No.DataPropertyName = "RowNum";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightGray;
            this.No.DefaultCellStyle = dataGridViewCellStyle1;
            this.No.HeaderText = "No.";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            // 
            // gcName
            // 
            this.gcName.DataPropertyName = "Name";
            this.gcName.HeaderText = "Name";
            this.gcName.MinimumWidth = 6;
            this.gcName.Name = "gcName";
            // 
            // TownshipId
            // 
            this.TownshipId.DataPropertyName = "TownshipId";
            this.TownshipId.HeaderText = "TownshipId";
            this.TownshipId.MinimumWidth = 6;
            this.TownshipId.Name = "TownshipId";
            this.TownshipId.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(96, 165);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(101, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(239, 165);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(383, 165);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 34);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtTownship
            // 
            this.txtTownship.Location = new System.Drawing.Point(239, 84);
            this.txtTownship.Name = "txtTownship";
            this.txtTownship.Size = new System.Drawing.Size(245, 22);
            this.txtTownship.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Township :";
            // 
            // frm_Township
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 407);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTownship);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvTownship);
            this.Name = "frm_Township";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Township";
            this.Load += new System.EventHandler(this.Township_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTownship)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTownship;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtTownship;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TownshipId;
    }
}