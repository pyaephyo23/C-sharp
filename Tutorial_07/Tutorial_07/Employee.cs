using System;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Formats.Asn1;
using System.Globalization;

namespace Tutorial_05
{
    public partial class frm_Employee : Form
    {
        private SqlConnection cnn;
        private int pageSize = 10;
        private int currentPage = 1;
        public frm_Employee()
        {
            InitializeComponent();
            string connectionString;
            connectionString = @"Data Source = PYAE_PHYO\SQLEXPRESS; Initial Catalog = EmployeeDB; Integrated Security = True";
            cnn = new SqlConnection(connectionString);
        }
        private void Tutorial_05_Load(object sender, EventArgs e)
        {
            LoadScreen();
            dgvEmployee.ReadOnly = true;
            cboEmployeeType.Items.Add("Full Time");
            cboEmployeeType.Items.Add("Part Time");

        }

        //LoadScreen
        private void LoadScreen()
        {
            try
            {
                cnn.Open();
                string selectQuery = $"SELECT ID, Name, PhNo, Email, Gender, EmployeeType, DateOfBirth, Address, 'Update' AS Update_Option, 'Delete' AS Delete_Option " +
                                     $"FROM (SELECT ROW_NUMBER() OVER (ORDER BY Name) AS RowNum, * FROM EmployeeTB) AS Temp " +
                                     $"WHERE RowNum BETWEEN {(currentPage - 1) * pageSize + 1} AND {currentPage * pageSize}";

                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, cnn);
                DataTable employeeTable = new DataTable();
                adapter.Fill(employeeTable);
                dgvEmployee.DataSource = employeeTable;
                dgvEmployee.Columns["ID"].Visible = false;
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
            btnAdd.Text = "Add";
        }

        //Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            };

            //Update Data
            if (btnAdd.Text == "Update")
            {
                int rowID = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["ID"].Value);
                try
                {
                    cnn.Open();
                    string updateQuery = "UPDATE EmployeeTB SET Name = @Name, PhNo = @PhNo, Email = @Email, Gender = @Gender, EmployeeType = @EmployeeType, DateOfBirth = @DateOfBirth, Address = @Address WHERE ID = @ID";
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

            //Add Data
            else
            {
                try
                {
                    cnn.Open();
                    string insertQuery = "INSERT INTO EmployeeTB (Name, PhNo, Email, Gender, EmployeeType, DateOfBirth, Address) " +
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
                ClearInputs();
            }
        }

        //clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        //update click
        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvEmployee.Columns["Update_Option"].Index && e.RowIndex >= 0)
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
                dtpBirth.Value = DateTime.Parse(row.Cells["DateOfBirth"].Value.ToString());
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                btnAdd.Text = "Update";
            }

            //Delete Data
            else if (e.ColumnIndex == dgvEmployee.Columns["Delete_Option"].Index && e.RowIndex >= 0)
            {
                int rowId = Convert.ToInt32(dgvEmployee.SelectedRows[0].Cells["ID"].Value);
                try
                {
                    cnn.Open();
                    string deleteQuery = "DELETE FROM EmployeeTB WHERE ID = @ID";
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

        //btnPrev
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadScreen();
            }
        }

        //btnNext
        private void btnNext_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string countQuery = "SELECT COUNT(*) FROM EmployeeTB";
            SqlCommand countCommand = new SqlCommand(countQuery, cnn);
            int totalRecords = Convert.ToInt32(countCommand.ExecuteScalar());
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            cnn.Close();
            if (currentPage < totalPages)
            {
                currentPage++;
            }
            LoadScreen();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadScreen();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string countQuery = "SELECT COUNT(*) FROM EmployeeTB";
            SqlCommand countCommand = new SqlCommand(countQuery, cnn);
            int totalRecords = Convert.ToInt32(countCommand.ExecuteScalar());
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
            cnn.Close();
            currentPage = totalPages;
            LoadScreen();
        }

        //upload data
        private void btnUploadData_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    using (var package = new OfficeOpenXml.ExcelPackage(new FileInfo(filePath)))
                    {
                        var worksheet = package.Workbook.Worksheets[0];
                        List<string> errorlist = new List<string>();
                        for (int row = worksheet.Dimension.Start.Row + 1; row <= worksheet.Dimension.End.Row; row++)
                        {
                            string name = worksheet.Cells[row, 1].Value?.ToString();
                            string phNo = worksheet.Cells[row, 2].Value?.ToString();
                            string email = worksheet.Cells[row, 3].Value?.ToString();
                            string gender = worksheet.Cells[row, 4].Value?.ToString();
                            string employeeType = worksheet.Cells[row, 5].Value?.ToString();
                            string dateOfBirth = worksheet.Cells[row, 6].Value?.ToString();
                            string address = worksheet.Cells[row, 7].Value?.ToString();

                            // Validate data
                            bool isValid = true;
                            string errorMessage = $"Errors in line {row}\n";

                            if (string.IsNullOrWhiteSpace(name))
                            {
                                isValid = false;
                                errorMessage += "> There is no Data in Name column\n";
                            }

                            if (string.IsNullOrWhiteSpace(phNo))
                            {
                                isValid = false;
                                errorMessage += "> There is no Data in Phone Number column\n";
                            }

                            if (string.IsNullOrWhiteSpace(email))
                            {
                                isValid = false;
                                errorMessage += "> There is no Data in Email column\n\n";
                            }

                            if (!long.TryParse(phNo, out long phoneNumber) || phoneNumber <= 0)
                            {
                                isValid = false;
                                errorMessage += "> Invalid phone number.\n";
                            }

                            if (!ValidateEmail(email))
                            {
                                isValid = false;
                                errorMessage += "> Invalid email address.\n";
                            }

                            if (string.IsNullOrWhiteSpace(gender) || (gender != "Male" && gender != "Female"))
                            {
                                isValid = false;
                                errorMessage += "> Invalid gender.\n";
                            }

                            if (string.IsNullOrWhiteSpace(employeeType) || (employeeType != "Full Time" && employeeType != "Part Time"))
                            {
                                isValid = false;
                                errorMessage += "> Invalid Employee type.\n";
                            }

                            DateTime selectedDate;
                            if (!DateTime.TryParse(dateOfBirth, out selectedDate) || selectedDate > DateTime.Today.AddYears(-18))
                            {
                                isValid = false;
                                errorMessage += "> Invalid date of birth.\n";
                            }

                            if (string.IsNullOrWhiteSpace(address))
                            {
                                isValid = false;
                                errorMessage += "> There is no Data in Address column.\n";
                            }

                            if (!isValid)
                            {
                                errorlist.Add(errorMessage);
                            }
                        }

                        if (errorlist.Count > 0)
                        {
                            string errorMessage = string.Join("\n", errorlist);
                            MessageBox.Show(errorMessage, "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            cnn.Open();
                            for (int row = worksheet.Dimension.Start.Row + 1; row <= worksheet.Dimension.End.Row; row++)
                            {
                                string name = worksheet.Cells[row, 1].Value?.ToString();
                                string phNo = worksheet.Cells[row, 2].Value?.ToString();
                                string email = worksheet.Cells[row, 3].Value?.ToString();
                                string gender = worksheet.Cells[row, 4].Value?.ToString();
                                string employeeType = worksheet.Cells[row, 5].Value?.ToString();
                                string dateOfBirth = worksheet.Cells[row, 6].Value?.ToString();
                                string address = worksheet.Cells[row, 7].Value?.ToString();
                                string insertQuery = "INSERT INTO EmployeeTB (Name, PhNo, Email, Gender, EmployeeType, DateOfBirth, Address) " +
                                                     "VALUES (@Name, @PhNo, @Email, @Gender, @EmployeeType, @DateOfBirth, @Address)";
                                using (SqlCommand command = new SqlCommand(insertQuery, cnn))
                                {
                                    command.Parameters.AddWithValue("@Name", name);
                                    command.Parameters.AddWithValue("@PhNo", phNo);
                                    command.Parameters.AddWithValue("@Email", email);
                                    command.Parameters.AddWithValue("@Gender", gender);
                                    command.Parameters.AddWithValue("@EmployeeType", employeeType);
                                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                                    command.Parameters.AddWithValue("@Address", address);
                                    command.ExecuteNonQuery();
                                }
                            }
                            cnn.Close();
                            MessageBox.Show("Uploaded successfully!");
                            LoadScreen();
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        //download Data
        private void btnDownloadData_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo newFile = new FileInfo(saveFileDialog.FileName);
                    using (var package = new OfficeOpenXml.ExcelPackage(newFile))
                    {
                        var worksheet = package.Workbook.Worksheets.Add("EmployeeData");
                        worksheet.Cells["A1"].LoadFromDataTable((DataTable)dgvEmployee.DataSource, true);

                        for (int i = 1; i <= worksheet.Dimension.End.Column; i++)
                        {
                            worksheet.Column(i).AutoFit();
                        }
                        package.Save();
                        MessageBox.Show("Downloaded successfully!");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}