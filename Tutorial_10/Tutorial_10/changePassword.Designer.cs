namespace Tutorial_10
{
    partial class frm_changePassword
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
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(224, 40);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(334, 27);
            txtPassword.TabIndex = 1;
            txtPassword.Tag = "2";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(54, 35);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(164, 30);
            lblPassword.TabIndex = 21;
            lblPassword.Text = "New Password :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(224, 100);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(334, 27);
            txtConfirmPassword.TabIndex = 2;
            txtConfirmPassword.Tag = "2";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmPassword.Location = new Point(28, 97);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(198, 30);
            lblConfirmPassword.TabIndex = 23;
            lblConfirmPassword.Text = "Confirm Password :";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(224, 160);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(164, 44);
            btnSave.TabIndex = 3;
            btnSave.Tag = "5";
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Highlight;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(394, 160);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(164, 44);
            btnClose.TabIndex = 4;
            btnClose.Tag = "6";
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // frm_changePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 241);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Name = "frm_changePassword";
            Text = "Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private Button btnSave;
        private Button btnClose;
    }
}