using System;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static Tutorial_03.Tutorial_03;



namespace Tutorial_03
{
    public partial class Tutorial_03 : Form
    {
        private List<Employee> employeeList = new List<Employee>();
        private SqlConnection cnn;
        public Tutorial_03()
        {
            InitializeComponent();

            string connectionString;
            connectionString = @"Data Source = PYAE_PHYO\SQLEXPRESS; Initial Catalog = EmployeeDB; Integrated Security = True";
            cnn = new SqlConnection(connectionString);

        }

        private void Tutorial_03_Load(object sender, EventArgs e)
        {

            LoadScreen();
            /* dgvEmployee.Columns.Add("Name", "Name");
             dgvEmployee.Columns.Add("PhNo", "Phone Number");
             dgvEmployee.Columns.Add("Email", "Email");
             dgvEmployee.Columns.Add("EmployeeType", "Employee Type");
             dgvEmployee.Columns.Add("Gender", "Gender");
             dgvEmployee.Columns.Add("DateOfBirth", "Date Of Birth");
             dgvEmployee.Columns.Add("Address", "Address");
             dgvEmployee.Columns.Add("Update", "");
             dgvEmployee.Columns.Add("Delete", "");*/
            dgvEmployee.ReadOnly = true;
            cboEmployeeType.Items.Add("Full Time");
            cboEmployeeType.Items.Add("Part Time");


        }

        //load function
        private void LoadScreen()
        {
            try
            {
                cnn.Open();
                string selectQuery = "SELECT * FROM Employee_tb";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, cnn);
                DataTable employeeTable = new DataTable();
                adapter.Fill(employeeTable);
                dgvEmployee.DataSource = employeeTable;
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


        //Employee class
        public class Employee
        {
            public string Name { get; set; }
            public long PhNo { get; set; }
            public string Email { get; set; }
            public string EmployeeType { get; set; }
            public string Gender { get; set; }
            public string DateOfBirth { get; set; }
            public string Address { get; set; }
        }

        //clearinput
        private void ClearInputs()
        {
            txtName.Clear();
            txtPhNo.Clear();
            txtEmail.Clear();
            cboEmployeeType.SelectedIndex = -1;
            rdoFemale.Checked = false;
            rdoMale.Checked = false;
            dtpBirth.Value = DateTime.Now;
            txtAddress.Clear();

        }

        //btnClear
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        //Email Validation
        private bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, pattern);
        }




        //check valitaion
        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Length > 20)
            {
                MessageBox.Show("Please enter a valid name (20 characters limit!).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }

            if (!long.TryParse(txtPhNo.Text, out long phoneNumber) || phoneNumber <= 0 || txtPhNo.Text.Length > 15)
            {
                MessageBox.Show("Please enter a valid phone number (15 digits limit!).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhNo.Focus();
                return false;
            }

            if (!ValidateEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }


            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                MessageBox.Show("Please select a gender.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (cboEmployeeType.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee type.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            DateTime currentDate = DateTime.Today;
            DateTime minYear = currentDate.AddYears(-18);
            DateTime selectedDate = dtpBirth.Value;

            if (selectedDate > minYear)
            {
                MessageBox.Show("You must be at least 18 years old to proceed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpBirth.Value = currentDate;
                return false;
            }


            if (string.IsNullOrWhiteSpace(txtAddress.Text) || txtAddress.Text.Length > 200)
            {
                txtAddress.Focus();
                MessageBox.Show("Please enter a valid Address (200 characters limit!).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        //Add data
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            };



            Employee person = new Employee();
            person.Name = txtName.Text;
            person.PhNo = Convert.ToInt64(txtPhNo.Text);
            person.Email = txtEmail.Text;
            person.EmployeeType = cboEmployeeType.SelectedItem.ToString();
            person.Gender = rdoMale.Checked ? "Male" : "Female";
            person.DateOfBirth = Convert.ToString(dtpBirth.Value);
            person.Address = txtAddress.Text;



            try
            {
                cnn.Open();
                string insertQuery = "INSERT INTO Employee_tb (Name, PhNo, Email, Gender, EmployeeType, DateOfBirth, Address) " +
                                     "VALUES (@Name, @PhNo, @Email, @Gender, @EmployeeType, @DateOfBirth, @Address)";
                using (SqlCommand command = new SqlCommand(insertQuery, cnn))
                {
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@PhNo", Convert.ToInt64(txtPhNo.Text));
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@Gender", rdoMale.Checked ? "Male" : "Female");
                    command.Parameters.AddWithValue("@EmployeeType", cboEmployeeType.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@DateOfBirth", Convert.ToString(dtpBirth.Value));
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Added successfully!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                cnn.Close();
            }
            LoadScreen();
            employeeList.Add(person);
            ClearInputs();

        }

        //update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            };

            int rowID = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["ID"].Value);
            try
            {
                cnn.Open();
                string updateQuery = "UPDATE Employee_tb SET Name = @Name, PhNo = @PhNo, Email = @Email, Gender = @Gender, EmployeeType = @EmployeeType, DateOfBirth = @DateOfBirth, Address = @Address WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(updateQuery, cnn))
                {
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@PhNo", Convert.ToInt64(txtPhNo.Text));
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@Gender", rdoMale.Checked ? "Male" : "Female");
                    command.Parameters.AddWithValue("@EmployeeType", cboEmployeeType.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@DateOfBirth", dtpBirth.Value.Date);
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);
                    command.Parameters.AddWithValue("@ID", rowID);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Updated successfully!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                cnn.Close();
            }

            ClearInputs();
            LoadScreen();

        }

        //delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                int rowId = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["ID"].Value);

                try
                {
                    cnn.Open();
                    string deleteQuery = "DELETE FROM Employee_tb WHERE ID = @ID";
                    using (SqlCommand command = new SqlCommand(deleteQuery, cnn))
                    {

                        command.Parameters.AddWithValue("@ID", rowId);
                        command.ExecuteNonQuery();

                    }
                    MessageBox.Show("Deleted successfully!");

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
                {
                    cnn.Close();
                }
                ClearInputs();
                LoadScreen();

            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtPhNo.Text = row.Cells["PhNo"].Value.ToString();
            txtEmail.Text = row.Cells["Email"].Value.ToString();
            if (row.Cells["Gender"].Value.ToString() == "Male")
            {
                rdoMale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = true;
            }
            cboEmployeeType.SelectedItem = row.Cells["EmployeeType"].Value.ToString();
            dtpBirth.Value = DateTime.Now;
            txtAddress.Text = row.Cells["Address"].Value.ToString();

        }







        /*update and delete
        private void dgvEmployee_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];

                if (e.ColumnIndex == dgvEmployee.Columns["Update"].Index)
                {
                    txtName.Text = row.Cells["Name"].Value.ToString();
                    txtPhNo.Text = row.Cells["PhNo"].Value.ToString();
                    txtEmail.Text = row.Cells["Email"].Value.ToString();
                    if (row.Cells["Gender"].Value.ToString() == "Male")
                    {
                        rdoMale.Checked = true;
                    }
                    else
                    {
                        rdoFemale.Checked = true;
                    }
                    cboEmployeeType.SelectedItem = row.Cells["EmployeeType"].Value.ToString();
                    dtpBirth.Value = DateTime.Now;
                    txtAddress.Text = row.Cells["Address"].Value.ToString();
                    dgvEmployee.Rows.RemoveAt(e.RowIndex);
                    employeeList.RemoveAt(e.RowIndex);


                }
                else if (e.ColumnIndex == dgvEmployee.Columns["Delete"].Index)
                {
                    dgvEmployee.Rows.RemoveAt(e.RowIndex);
                    employeeList.RemoveAt(e.RowIndex);
                    ClearInputs();
                }
            }
        }*/
    }
}