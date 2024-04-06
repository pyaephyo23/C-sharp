using OJT.Services.Employee;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OJT.App.Views.Employee
{
    public partial class frm_Township : Form
    {
        EmployeeService employeeService = new EmployeeService();
        private int townshipId;
        public frm_Township()
        {
            InitializeComponent();
        }

        private bool isValidate()
        {
            if (string.IsNullOrWhiteSpace(txtTownship.Text) || txtTownship.Text.Length > 20)
            {
                MessageBox.Show("Please enter a valid Township Name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTownship.Focus();
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isValidate())
            {
                return;
            }
            bool success = false;
            if (btnAdd.Text == "Add")
            {
                success = employeeService.InsertTownship(txtTownship.Text);
                if (success)
                {
                    MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK);
                }
            }
            else
            {
                success = employeeService.UpdateTownship(townshipId, txtTownship.Text);
                if (success)
                {
                    MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK);
                }
            }
            BindData();
            btnAdd.Text = "Add";
            txtTownship.Text = "";

        }

        private void Township_Load(object sender, EventArgs e)
        {
            BindData();
        }
        private void BindData()
        {
            DataTable dtTownship = employeeService.GetTownshipWithName();
            dgvTownship.DataSource = dtTownship;
            btnDelete.Enabled = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTownship_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvTownship.Columns["No"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTownship.Rows[e.RowIndex];
                townshipId = Convert.ToInt32(row.Cells["TownshipId"].Value);
                DataTable dtsearch = employeeService.SearchInEmployee(townshipId);
                if ( dtsearch.Rows.Count>0 )
                {
                    MessageBox.Show("You can't delete data that is already use", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtTownship.Text = row.Cells["gcName"].Value.ToString();
                    townshipId = Convert.ToInt32(row.Cells["TownshipId"].Value);
                    btnAdd.Text = "Update";
                    btnDelete.Enabled = true;
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool success = employeeService.DeleteTownship(townshipId);
            if (success)
            {
                MessageBox.Show("Delete Success.", "Success", MessageBoxButtons.OK);
            }
            BindData();
            txtTownship.Text = "";
        }
    }
}
