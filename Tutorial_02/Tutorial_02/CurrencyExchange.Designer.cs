namespace Tutorial_02
{
    partial class tutorial_02
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
            label1 = new Label();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            txtExchangeRate = new TextBox();
            txtToCurrencyName = new TextBox();
            txtFromCurrencyAmount = new TextBox();
            txtFromCurrencyName = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(187, 58);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(259, 37);
            label1.TabIndex = 0;
            label1.Text = "Currency Exchange";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Location = new Point(187, 170);
            lbl1.Margin = new Padding(0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(202, 25);
            lbl1.TabIndex = 1;
            lbl1.Text = "From Currency Name";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.Location = new Point(187, 250);
            lbl2.Margin = new Padding(0);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(223, 25);
            lbl2.TabIndex = 2;
            lbl2.Text = "From Currency Amount";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl3.Location = new Point(187, 330);
            lbl3.Margin = new Padding(0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(176, 25);
            lbl3.TabIndex = 3;
            lbl3.Text = "To Currency Name";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl4.Location = new Point(187, 410);
            lbl4.Margin = new Padding(0);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(141, 25);
            lbl4.TabIndex = 4;
            lbl4.Text = "Exchange Rate";
            // 
            // txtExchangeRate
            // 
            txtExchangeRate.Location = new Point(524, 407);
            txtExchangeRate.Name = "txtExchangeRate";
            txtExchangeRate.Size = new Size(220, 32);
            txtExchangeRate.TabIndex = 4;
            // 
            // txtToCurrencyName
            // 
            txtToCurrencyName.Location = new Point(524, 327);
            txtToCurrencyName.Name = "txtToCurrencyName";
            txtToCurrencyName.Size = new Size(220, 32);
            txtToCurrencyName.TabIndex = 3;
            // 
            // txtFromCurrencyAmount
            // 
            txtFromCurrencyAmount.Location = new Point(524, 247);
            txtFromCurrencyAmount.Name = "txtFromCurrencyAmount";
            txtFromCurrencyAmount.Size = new Size(220, 32);
            txtFromCurrencyAmount.TabIndex = 2;
            // 
            // txtFromCurrencyName
            // 
            txtFromCurrencyName.Location = new Point(524, 167);
            txtFromCurrencyName.Name = "txtFromCurrencyName";
            txtFromCurrencyName.Size = new Size(220, 32);
            txtFromCurrencyName.TabIndex = 1;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(291, 512);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(339, 47);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // tutorial_02
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 651);
            Controls.Add(btnCalculate);
            Controls.Add(txtFromCurrencyName);
            Controls.Add(txtFromCurrencyAmount);
            Controls.Add(txtToCurrencyName);
            Controls.Add(txtExchangeRate);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(0);
            Name = "tutorial_02";
            Text = "Tutorial_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private TextBox txtExchangeRate;
        private TextBox txtToCurrencyName;
        private TextBox txtFromCurrencyAmount;
        private TextBox txtFromCurrencyName;
        private Button btnCalculate;
    }
}