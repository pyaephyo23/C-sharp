using OJT.App.Views.Product;
using OJT.Entities.Employee;
using OJT.Services.Employee;
using OJT.Services.product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT.App.Views.Employee
{
    public partial class UCEmployee : UserControl
    {
        EmployeeService employeeService = new EmployeeService();
        UCEmployeeList uCEmployeeList = new UCEmployeeList();
        private int selectedTownshipId;
        public string EmployeeId
        { set { hdEmployeeId.Text = value; } }
        public UCEmployee()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            };
            AddorUpdate();
        }

        private void UCEmployee_Load(object sender, EventArgs e)
        {
            BindData();
            BtnControl();
        }

        private void BindData()
        {
            DataTable dtTownship = employeeService.GetTownship();
            cboTownship.DataSource = dtTownship;
            cboTownship.DisplayMember = "Name";
            cboTownship.ValueMember = "TownshipId";

            cboEmployeeType.Items.Add("Full Time");
            cboEmployeeType.Items.Add("Part Time");
            if (!String.IsNullOrEmpty(hdEmployeeId.Text))
            {
                DataTable dt = employeeService.Get(Convert.ToInt32(hdEmployeeId.Text));
                if (dt.Rows.Count > 0)
                {
                    txtName.Text = dt.Rows[0]["Name"].ToString();
                    txtPhNo.Text = dt.Rows[0]["PhNo"].ToString();
                    txtEmail.Text = dt.Rows[0]["Email"].ToString();
                    if (dt.Rows[0]["Gender"].ToString() == "Male")
                    {
                        rdoMale.Checked = true;
                    }
                    else if (dt.Rows[0]["Gender"].ToString() == "Female")
                    {
                        rdoFemale.Checked = true;
                    }
                    else
                    {
                        rdoOther.Checked = true;
                    }
                    cboEmployeeType.SelectedItem = dt.Rows[0]["EmployeeType"].ToString();
                    dtpBirth.Value = DateTime.Parse(dt.Rows[0]["DateOfBirth"].ToString());
                    txtAddress.Text = dt.Rows[0]["Address"].ToString();
                    cboTownship.SelectedValue = dt.Rows[0]["TownshipId"].ToString();
                }
            }
        }

        private void AddorUpdate()
        {
            EmployeeService employeeService = new EmployeeService();
            EmployeeEntity employeeEntity = CreateData();
            bool success = false;

            if (String.IsNullOrEmpty(hdEmployeeId.Text))
            {
                success = employeeService.Insert(employeeEntity);
                if (success)
                {
                    MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK);
                }
            }
            else
            {
                success = employeeService.Update(employeeEntity);
                if (success)
                {
                    MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK);
                }
            }
            this.Controls.Clear();
            this.Controls.Add(uCEmployeeList);
        }

        private EmployeeEntity CreateData()
        {
            EmployeeEntity employeeEntity = new EmployeeEntity();

            if (!String.IsNullOrEmpty(hdEmployeeId.Text))
            {
                employeeEntity.employeeId = Convert.ToInt32(hdEmployeeId.Text);
            }
            employeeEntity.name = txtName.Text;
            employeeEntity.phNo = Convert.ToInt64(txtPhNo.Text);
            employeeEntity.email = txtEmail.Text;
            if (rdoMale.Checked)
            {
                employeeEntity.gender = "Male";
            }
            if (rdoFemale.Checked)
            {
                employeeEntity.gender = "Female";
            }
            if (rdoOther.Checked)
            {
                employeeEntity.gender = "Other";
            }
            employeeEntity.employeeType = cboEmployeeType.SelectedItem.ToString();
            employeeEntity.dateOfBirth = dtpBirth.Value.Date;
            employeeEntity.address = txtAddress.Text;
            employeeEntity.townshipId = selectedTownshipId;
            return employeeEntity;
        }

        private void BtnControl()
        {
            if (String.IsNullOrEmpty(hdEmployeeId.Text))
            {
                btnAddNew.Text = "Add New";
                btnDelete.Enabled = false;
            }
            else
            {
                btnAddNew.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            return Regex.IsMatch(email, pattern);
        }

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


            if (!rdoMale.Checked && !rdoFemale.Checked && !rdoOther.Checked)
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

        private void cboTownship_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = cboTownship.SelectedItem as DataRowView;
            selectedTownshipId = Convert.ToInt32(selectedRow["TownshipId"]);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            bool success = employeeService.Delete(Convert.ToInt32(hdEmployeeId.Text));
            if (success)
            {
                MessageBox.Show("Delete Success.", "Success", MessageBoxButtons.OK);
            }
            this.Controls.Clear();
            this.Controls.Add(uCEmployeeList);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(uCEmployeeList);
        }

        private void lblEditTownship_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Township Township = new frm_Township();
            Township.Show();
            this.Controls.Clear();
        }
    }
}
