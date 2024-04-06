using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial_07;
using System.Configuration;
using Tutorial_06;

namespace Tutorial_10
{
    public partial class frm_changePassword : Form
    {
        private string key = "b14ca5898a4e4133bbce2ea2315a1916";
        string cnnString = ConfigurationManager.ConnectionStrings["EmployeeDBConnection"].ConnectionString;

        public frm_changePassword()
        {
            InitializeComponent();         
        }
        public string Email { get; set; }

        //close
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool isValidate()
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || !txtPassword.Text.Any(char.IsUpper) ||
                !txtPassword.Text.Any(char.IsLower) || !txtPassword.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Password must have at least 7 characters, one capital letter, one small letter, and one digit.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus(); ;
                return false;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Please Enter The Same Password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirmPassword.Focus();
                return false;
            }
            return true;
        }
        //save 
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValidate())
            {
                return;
            }
            string encryptedString = AesOperation.EncryptString(key, txtPassword.Text);
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();
                string updateQuery = "UPDATE Users_tb SET Password = @Password WHERE Email = @Email";
                SqlCommand command = new SqlCommand(updateQuery, cnn);           
                command.Parameters.AddWithValue("@Password", encryptedString);
                command.Parameters.AddWithValue("@Email", Email);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Your password has been successfully changed.");
            this.Hide();
            frm_Login LoginForm = new frm_Login();
            LoginForm.Show();
        }
    }
}
