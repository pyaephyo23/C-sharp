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
using System.Net.Mail;
using Tutorial_07;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;

namespace Tutorial_06
{
    public partial class frm_register : Form
    {
        private string cnnString = @"Data Source=PYAE_PHYO\SQLEXPRESS;Initial Catalog = EmployeeDB; Integrated Security = True";
        private string key = "b14ca5898a4e4133bbce2ea2315a1916";
        public frm_register()
        {
            InitializeComponent();
        }
        //Email Validation
        private bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, pattern);
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
            if (!ValidateEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
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
            string inputEmail = txtEmail.Text;
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
                string checkEmailQuery = "SELECT COUNT(*) FROM Users_tb WHERE Email = @Email";
                SqlCommand checkEmailCmd = new SqlCommand(checkEmailQuery, cnn);
                checkEmailCmd.Parameters.AddWithValue("@Email", inputEmail);
                int existingEmailCount = (int)checkEmailCmd.ExecuteScalar();

                if (existingEmailCount > 0)
                {
                    MessageBox.Show("This email address is already associated with an account.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Focus();
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
            //encryption
            string encryptedString = AesOperation.EncryptString(key, txtPassword.Text);
            using (SqlConnection cnn = new SqlConnection(cnnString))
            {
                cnn.Open();
                string insertQuery = "INSERT INTO Users_tb (UserName, Password, Email) VALUES (@UserName, @Password, @Email)";
                SqlCommand command = new SqlCommand(insertQuery, cnn);
                command.Parameters.AddWithValue("@UserName", txtUserName.Text);
                command.Parameters.AddWithValue("@Password", encryptedString);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Registration successful!");

            //send email
            string fromMail = "ppk1999minatoecm@gmail.com";
            string fromPassword = "jvtasajebfycuwdi";
            string toMail = txtEmail.Text;
            string subject = "Welcome !!";
            string body = "Thank you for registering on our app";
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(fromMail, toMail, subject, body);
            cleanInputs();
        }

        //cleanInputs
        private void cleanInputs()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtEmail.Clear();
            txtUserName.Focus();
        }

        //Close
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //to Login
        private void lblLogin_Click(object sender, EventArgs e)
        {
            frm_Login logInForm = new frm_Login();
            logInForm.Show();
            this.Hide();
        }
    }
}

