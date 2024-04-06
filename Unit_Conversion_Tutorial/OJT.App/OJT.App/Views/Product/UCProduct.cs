
using Entities.Product;
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

namespace OJT.App.Views.Product
{
    public partial class UCProduct : UserControl
    {
        public string ID
        { set { hdProductId.Text = value; } }
        ProductService productService = new ProductService();
        UnitService unitService = new UnitService();
        UCProductList ucProductList = new UCProductList();
        private int selectedBaseUnitId;
        public UCProduct()
        {
            InitializeComponent();
            cboBaseUnitId.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            };
            AddorUpdate();
        }

        private void UCProduct_Load(object sender, EventArgs e)
        {
            BindData();
            BtnControl();
        }

        private void BindData()
        {
            DataTable dtProduct = unitService.GetAll();
            cboBaseUnitId.DataSource = dtProduct;
            cboBaseUnitId.DisplayMember = "Name";
            cboBaseUnitId.ValueMember = "UnitId";
            if (!String.IsNullOrEmpty(hdProductId.Text))
            {
                DataTable dt = productService.Get(Convert.ToInt32(hdProductId.Text));

                if (dt.Rows.Count > 0)
                {
                    txtName.Text = dt.Rows[0]["Name"].ToString();
                    txtBarcode.Text = dt.Rows[0]["Barcode"].ToString();
                    cboBaseUnitId.SelectedValue = dt.Rows[0]["BaseUnitId"].ToString();
                }
            }
        }

        private void AddorUpdate()
        {
            ProductService productService = new ProductService();
            ProductEntity productEntity = CreateData();
            bool success = false;

            if (String.IsNullOrEmpty(hdProductId.Text))
            {
                success = productService.Insert(productEntity);
                if (success)
                {
                    MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK);
                }
            }
            else
            {
                success = productService.Update(productEntity);
                if (success)
                {
                    MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK);
                }
            }
            this.Controls.Clear();
            this.Controls.Add(ucProductList);
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || txtName.Text.Length > 20)
            {
                MessageBox.Show("Please enter a valid name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtBarcode.Text) || txtName.Text.Length > 20)
            {
                MessageBox.Show("Please enter a valid Barcode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBarcode.Focus();
                return false;
            }
            return true;
        }

        private ProductEntity CreateData()
        {
            ProductEntity productEntity = new ProductEntity();

            if (!String.IsNullOrEmpty(hdProductId.Text))
            {
                productEntity.productId = Convert.ToInt32(hdProductId.Text);
            }

            productEntity.name = txtName.Text;
            productEntity.barcode = txtBarcode.Text;
            productEntity.baseUnitId = selectedBaseUnitId;
            return productEntity;
        }


        private void BtnControl()
        {
            if (String.IsNullOrEmpty(hdProductId.Text))
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
            this.Controls.Add(ucProductList);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deleting Product will also delete some data from UnitConversion table!", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                bool success = productService.Delete(Convert.ToInt32(hdProductId.Text));
                if (success)
                {
                    MessageBox.Show("Delete Success.", "Success", MessageBoxButtons.OK);
                }
                this.Controls.Clear();
                this.Controls.Add(ucProductList);
            }


        }

        private void cboBaseUnitId_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = cboBaseUnitId.SelectedItem as DataRowView;
            selectedBaseUnitId = Convert.ToInt32(selectedRow["UnitId"]);
        }
    }
}
