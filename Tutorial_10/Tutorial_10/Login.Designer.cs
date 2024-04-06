namespace Tutorial_06
{
    partial class frm_Login
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
            btnClose = new Button();
            btnLogIn = new Button();
            lblUserName = new Label();
            lblPassword = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblForgotPassword = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Highlight;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(427, 195);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(164, 44);
            btnClose.TabIndex = 0;
            btnClose.Tag = "4";
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = SystemColors.Highlight;
            btnLogIn.Cursor = Cursors.Hand;
            btnLogIn.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(231, 195);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(164, 44);
            btnLogIn.TabIndex = 1;
            btnLogIn.Tag = "3";
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.Location = new Point(71, 60);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(122, 30);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "Username :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(89, 123);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(114, 30);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(231, 60);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(360, 27);
            txtUserName.TabIndex = 4;
            txtUserName.Tag = "1";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(231, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(360, 27);
            txtPassword.TabIndex = 5;
            txtPassword.Tag = "2";
            // 
            // lblForgotPassword
            // 
            lblForgotPassword.AutoSize = true;
            lblForgotPassword.Cursor = Cursors.Hand;
            lblForgotPassword.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lblForgotPassword.ForeColor = SystemColors.Highlight;
            lblForgotPassword.Location = new Point(355, 278);
            lblForgotPassword.Name = "lblForgotPassword";
            lblForgotPassword.Size = new Size(251, 30);
            lblForgotPassword.TabIndex = 6;
            lblForgotPassword.Text = "Forgot your password?";
            lblForgotPassword.Click += lblForgotPassword_Click;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 334);
            Controls.Add(lblForgotPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(btnLogIn);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnLogIn;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblForgotPassword;
    }
}