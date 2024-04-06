using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Tutorial_05;
using Tutorial_07;
using Tutorial_10;

namespace Tutorial_06
{
    public partial class frm_Login : Form
    {
        private string key = "b14ca5898a4e4133bbce2ea2315a1916";
        private string cnnString = @"Data Source=PYAE_PHYO\SQLEXPRESS;Initial Catalog = EmployeeDB; Integrated Security = True";
        public frm_Login()
        {
            InitializeComponent();
        }

        //Login Button
        private void btnLogIn_Click(object sender, EventArgs e)
        {

            using (SqlConnection cnn = new SqlConnection(cnnString))
            {

                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    MessageBox.Show("Pleae Enter User Name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserName.Focus();

                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Pleae Enter Password", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus(); ;
                }
                else
                {
                    try
                    {
                        string encryptString = AesOperation.EncryptString(key, txtPassword.Text);
                        cnn.Open();
                        string selectQuery = "SELECT COUNT(*) FROM Users_tb WHERE UserName = @UserName AND Password = @Password";
                        SqlCommand command = new SqlCommand(selectQuery, cnn);
                        command.Parameters.AddWithValue("@UserName", txtUserName.Text);
                        command.Parameters.AddWithValue("@Password", encryptString);
                        int userCount = (int)command.ExecuteScalar();
                        if (userCount > 0)
                        {
                            MessageBox.Show($"Login successful! Welcome {txtUserName.Text}");
                            frm_Employee ToEmployss = new frm_Employee();
                            ToEmployss.Show();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Sorry! Wrong Username or Password");
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
            }
        }
        //close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            frm_forgotPassword forgetPasswordForm = new frm_forgotPassword();
            forgetPasswordForm.Show();
            this.Hide();
        }
    }
}