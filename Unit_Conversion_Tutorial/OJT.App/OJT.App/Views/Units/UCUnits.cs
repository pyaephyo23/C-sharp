using Entities.Product;
using OJT.App.Views.Product;
using OJT.Services.product;
using OJT.Services.Unit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT.App.Views.Units
{
    public partial class UCUnits : UserControl
    {
        public string ID
        { set { hdUnitId.Text = value; } }
        UnitService unitService = new UnitService();
        UCUnitsListing ucUnitsListing = new UCUnitsListing();
        public UCUnits()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Length > 20)
            {
                MessageBox.Show("Please enter a valid name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            AddorUpdate();
        }

        private void UCUnits_Load(object sender, EventArgs e)
        {
            BindData();
            BtnControl();
        }
        private void BindData()
        {
            if (!String.IsNullOrEmpty(hdUnitId.Text))
            {
                DataTable dt = unitService.Get(Convert.ToInt32(hdUnitId.Text));

                if (dt.Rows.Count > 0)
                {
                    txtName.Text = dt.Rows[0]["Name"].ToString();
                }
            }
        }

        private void AddorUpdate()
        {
            UnitService unitService = new UnitService();
            UnitEntity unitEntity = CreateData();
            bool success = false;

            if (String.IsNullOrEmpty(hdUnitId.Text))
            {
                success = unitService.Insert(unitEntity);
                if (success)
                {
                    MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK);
                }
            }
            else
            {
                success = unitService.Update(unitEntity);
                if (success)
                {
                    MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK);
                }
            }
            this.Controls.Clear();
            this.Controls.Add(ucUnitsListing);
        }

        private UnitEntity CreateData()
        {
            UnitEntity unitEntity = new UnitEntity(); ;
            if (!String.IsNullOrEmpty(hdUnitId.Text))
            {
                unitEntity.unitId = Convert.ToInt32(hdUnitId.Text);
            }
            unitEntity.name = txtName.Text;
            return unitEntity;
        }
        private void BtnControl()
        {
            if (String.IsNullOrEmpty(hdUnitId.Text))
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(ucUnitsListing);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deleting Unit will also delete some data from Product and UnitConversion table that use this unit!", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                bool success = unitService.Delete(Convert.ToInt32(hdUnitId.Text));
                if (success)
                {
                    MessageBox.Show("Delete Success.", "Success", MessageBoxButtons.OK);
                }
                this.Controls.Clear();
                this.Controls.Add(ucUnitsListing);
            }
        }
    }
}
