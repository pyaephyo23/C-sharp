namespace OJT.App.Views.Menu
{
    partial class frmHome
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnUC = new System.Windows.Forms.Panel();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.SkyBlue;
            this.menuStrip.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem,
            this.ConvertToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1126, 45);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip2";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.unToolStripMenuItem,
            this.unitConversionToolStripMenuItem,
            this.employeesToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(121, 41);
            this.ToolStripMenuItem.Text = "Tables";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(327, 42);
            this.productToolStripMenuItem.Text = "Products";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // unToolStripMenuItem
            // 
            this.unToolStripMenuItem.Name = "unToolStripMenuItem";
            this.unToolStripMenuItem.Size = new System.Drawing.Size(327, 42);
            this.unToolStripMenuItem.Text = "Units";
            this.unToolStripMenuItem.Click += new System.EventHandler(this.unToolStripMenuItem_Click);
            // 
            // unitConversionToolStripMenuItem
            // 
            this.unitConversionToolStripMenuItem.Name = "unitConversionToolStripMenuItem";
            this.unitConversionToolStripMenuItem.Size = new System.Drawing.Size(327, 42);
            this.unitConversionToolStripMenuItem.Text = "UnitConversion";
            this.unitConversionToolStripMenuItem.Click += new System.EventHandler(this.unitConversionToolStripMenuItem_Click);
            // 
            // ConvertToolStripMenuItem
            // 
            this.ConvertToolStripMenuItem.Name = "ConvertToolStripMenuItem";
            this.ConvertToolStripMenuItem.Size = new System.Drawing.Size(211, 41);
            this.ConvertToolStripMenuItem.Text = "Convert Unit";
            this.ConvertToolStripMenuItem.Click += new System.EventHandler(this.ConvertToolStripMenuItem_Click);
            // 
            // pnUC
            // 
            this.pnUC.Location = new System.Drawing.Point(0, 47);
            this.pnUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnUC.Name = "pnUC";
            this.pnUC.Size = new System.Drawing.Size(1126, 513);
            this.pnUC.TabIndex = 3;
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(327, 42);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 564);
            this.Controls.Add(this.pnUC);
            this.Controls.Add(this.menuStrip);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitConversionToolStripMenuItem;
        private System.Windows.Forms.Panel pnUC;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
    }
}