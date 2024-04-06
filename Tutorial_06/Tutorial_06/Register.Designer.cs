namespace Tutorial_06
{
    partial class frm_register
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
            txtUserName = new TextBox();
            lblPassword = new Label();
            lblUserName = new Label();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            btnSave = new Button();
            btnClose = new Button();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(292, 120);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(360, 27);
            txtPassword.TabIndex = 11;
            txtPassword.Tag = "2";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(292, 60);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(360, 27);
            txtUserName.TabIndex = 10;
            txtUserName.Tag = "1";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(132, 120);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 30);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password :";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(132, 60);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(122, 30);
            lblUserName.TabIndex = 8;
            lblUserName.Text = "Username :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(292, 180);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(360, 27);
            txtConfirmPassword.TabIndex = 13;
            txtConfirmPassword.Tag = "2";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmPassword.Location = new Point(56, 180);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(198, 30);
            lblConfirmPassword.TabIndex = 12;
            lblConfirmPassword.Text = "Confirm Password :";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Highlight;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(292, 252);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(164, 44);
            btnSave.TabIndex = 15;
            btnSave.Tag = "3";
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
            btnClose.Location = new Point(488, 252);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(164, 44);
            btnClose.TabIndex = 14;
            btnClose.Tag = "4";
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Cursor = Cursors.Hand;
            lblLogin.Font = new Font("Segoe UI", 13F, FontStyle.Underline, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.HotTrack;
            lblLogin.Location = new Point(405, 312);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(247, 30);
            lblLogin.TabIndex = 16;
            lblLogin.Text = "Already have a account?";
            lblLogin.Click += lblLogin_Click;
            // 
            // frm_register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 375);
            Controls.Add(lblLogin);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Name = "frm_register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label lblPassword;
        private Label lblUserName;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private Button btnSave;
        private Button btnClose;
        private Label lblLogin;
    }
}