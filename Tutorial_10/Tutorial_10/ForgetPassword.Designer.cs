namespace Tutorial_10
{
    partial class frm_forgotPassword
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
            txtEmail = new TextBox();
            lblEmail = new Label();
            btnSend = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(154, 40);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 27);
            txtEmail.TabIndex = 18;
            txtEmail.Tag = "2";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(38, 40);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(75, 30);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email :";
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.Highlight;
            btnSend.Cursor = Cursors.Hand;
            btnSend.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(154, 100);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(268, 41);
            btnSend.TabIndex = 20;
            btnSend.Tag = "5";
            btnSend.Text = "Send Recovery Code";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSendCode_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.Highlight;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(154, 160);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(268, 41);
            btnBack.TabIndex = 21;
            btnBack.Tag = "5";
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // frm_forgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 238);
            Controls.Add(btnBack);
            Controls.Add(btnSend);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Name = "frm_forgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forget Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label lblEmail;
        private Button btnSend;
        private Button btnBack;
    }
}