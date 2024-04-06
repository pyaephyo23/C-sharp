using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using Tutorial_06;
using Tutorial_05;
using Tutorial_07;

namespace Tutorial_10
{
    public partial class frm_forgotPassword : Form
    {
        private string currentRecoveryCode = "";
        string EmailID;
        string connectionString = ConfigurationManager.ConnectionStrings["EmployeeDBConnection"].ConnectionString;

        public frm_forgotPassword()
        {
            InitializeComponent();
        }
        //generate code
        private string GenerateRecoveryCode()
        {
            Random random = new Random();
            return random.Next(1000, 9999).ToString();
        }

        //sendRecoveryCode
        private void SendRecoveryCode(string email, string recoveryCode)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("ppk1999minatoecm@gmail.com", "jvtasajebfycuwdi"),
                EnableSsl = true,
            };

            MailMessage mailMessage = new MailMessage
            {
                From = new MailAddress("ppk1999minatoecm@gmail.com"),
                Subject = "Recovery Code",
                Body = $"Your password recovery code is: {recoveryCode}",
            };
            mailMessage.To.Add(email);
            smtpClient.Send(mailMessage);
        }

        //btn click
        private void btnSendCode_Click(object sender, EventArgs e)
        {
            if (btnSend.Text == "Send Recovery Code" || btnSend.Text == "Send Again")
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    if (string.IsNullOrEmpty(txtEmail.Text))
                    {
                        MessageBox.Show("Pleae Enter Email", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtEmail.Focus(); ;
                    }
                    else
                    {
                        try
                        {
                            cnn.Open();
                            string selectQuery = "SELECT COUNT(*) FROM Users_tb WHERE Email = @Email";
                            SqlCommand command = new SqlCommand(selectQuery, cnn);
                            command.Parameters.AddWithValue("@Email", txtEmail.Text);
                            int userCount = (int)command.ExecuteScalar();
                            if (userCount > 0)
                            {
                                currentRecoveryCode = GenerateRecoveryCode();
                                string email = txtEmail.Text;
                                SendRecoveryCode(email, currentRecoveryCode);
                                MessageBox.Show("Recovery code sent to your email.");
                                EmailID = txtEmail.Text;
                                lblEmail.Text = "Code";
                                btnSend.Text = "Recover Account";              
                                txtEmail.Clear();
                                
                            }
                            else
                            {
                                MessageBox.Show("Sorry! Wrong Email");
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
            else if (btnSend.Text == "Recover Account")
            {
                if (txtEmail.Text == currentRecoveryCode)
                {

                    frm_changePassword changePasswordForm = new frm_changePassword();
                    changePasswordForm.Email = EmailID;
                    changePasswordForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The recovery code you entered is incorrect. Please Try Again");
                    btnSend.Text = "Send Again";
                    lblEmail.Text = "Email";
                }

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frm_Login LoginForm = new frm_Login();
            LoginForm.Show();
            this.Hide();
        }
    }
}
