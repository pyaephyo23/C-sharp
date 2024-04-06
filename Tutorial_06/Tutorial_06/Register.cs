using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_06
{
    public partial class frm_register : Form
    {
        private string cnnString = @"Data Source=PYAE_PHYO\SQLEXPRESS;Initial Catalog = EmployeeDB; Integrated Security = True";

        public frm_register()
        {
            InitializeComponent();
        }

        //is Validate
        private bool isValidate()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || txtUserName.Text.Length < 6)
            {
                MessageBox.Show("Username must have at least 6 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Focus();
                return false;

            }
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
            string inputUserName = txtUserName.Text;
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();
                //check user
                string checkQuery = "SELECT COUNT(*) FROM Users_tb WHERE UserName = @UserName";
                SqlCommand checkCmd = new SqlCommand(checkQuery, cnn);
                checkCmd.Parameters.AddWithValue("@UserName", inputUserName);
                int existingUserCount = (int)checkCmd.ExecuteScalar();

                if (existingUserCount > 0)
                {
                    MessageBox.Show("This username already exists.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserName.Focus();
                    return false;
                }
            }

                return true;
        }

        //btnSave
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValidate())
            {
                return;
            }
            string inputUserName = txtUserName.Text;
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();
                string insertQuery = "INSERT INTO Users_tb (UserName, Password) VALUES (@UserName, @Password)";
                SqlCommand command = new SqlCommand(insertQuery, cnn);
                command.Parameters.AddWithValue("@UserName", txtUserName.Text);
                command.Parameters.AddWithValue("@Password", txtPassword.Text);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Registration successful!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            frm_Login logInForm = new frm_Login();
            logInForm.Show();
            this.Hide();          
        }
    }
}

