using OJT.App.Views.Product;
using OJT.Services.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT.App.Views.Employee
{
    public partial class UCEmployeeList : UserControl
    {
        EmployeeService employeeService = new EmployeeService();
        public UCEmployeeList()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            UCEmployee uCEmployee = new UCEmployee();
            this.Controls.Clear();
            this.Controls.Add(uCEmployee);
        }

        private void UCEmployeeList_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            DataTable dt = employeeService.GetWithName();
            dgvEmployeeList.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }

        private void dgvEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int employeeId = Convert.ToInt32(dgvEmployeeList.Rows[e.RowIndex].Cells["gcEmployeeId"].Value);
                if (e.ColumnIndex == dgvEmployeeList.Columns["gcNo"].Index)
                {
                    UCEmployee uCEmployee = new UCEmployee();
                    uCEmployee.EmployeeId = employeeId.ToString();
                    this.Controls.Clear();
                    this.Controls.Add(uCEmployee);
                }
            }
        }
    }
}
