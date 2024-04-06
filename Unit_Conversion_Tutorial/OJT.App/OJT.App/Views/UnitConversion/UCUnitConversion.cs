using Entities.Product;
using OJT.App.Views.Product;
using OJT.Entities.UnitConversion;
using OJT.Services.product;
using OJT.Services.Unit;
using OJT.Services.UnitConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OJT.App.Views.UnitConversion
{
    public partial class UCUnitConversion : UserControl
    {
        public int productId
        { set { hdProductId.Text = value.ToString(); } }
        public int baseUnitId
        { set { hdBaseUnitId.Text = value.ToString(); } }
        public int toUnitid
        { set { hdToUnitId.Text = value.ToString(); } }

        private int tempProductID;
        private int tempBaseUnitID;
        private int tempToUnitID;
        UnitConversionService unitConversionService = new UnitConversionService();
        UCUnitConversionList ucUnitConversionList = new UCUnitConversionList();
        private ProductService productService = new ProductService();
        private UnitService unitService = new UnitService();
        private int selectedProductId;
        private int selectedBasenitId;
        private int selectedToUnitId;
        public UCUnitConversion()
        {
            InitializeComponent();
        }

        private void UCUnitConversion_Load(object sender, EventArgs e)
        {
            BindData();
            BtnControl();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(txtMultiplier.Text, out float multiplier) || multiplier <= 0)
            {
                MessageBox.Show("Please enter a valid multiplier.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMultiplier.Focus();
                return;
            }
            if (selectedBasenitId == selectedToUnitId)
            {
                MessageBox.Show("Please select different units .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AddorUpdate();
        }

        private void BindData()
        {
            DataTable dtProduct = productService.GetAll();
            cboProduct.DataSource = dtProduct;
            cboProduct.DisplayMember = "Name";
            cboProduct.ValueMember = "ProductId";

            DataTable dtUnit = unitService.GetAll();
            cboBaseUnit.DataSource = dtUnit;
            cboBaseUnit.DisplayMember = "Name";
            cboBaseUnit.ValueMember = "UnitId";

            cboToUnit.DataSource = dtUnit.Copy();
            cboToUnit.DisplayMember = "Name";
            cboToUnit.ValueMember = "UnitId";

            if (!String.IsNullOrEmpty(hdProductId.Text))
            {
                DataTable dt = unitConversionService.getUnitConversion(Convert.ToInt32(hdProductId.Text), Convert.ToInt32(hdBaseUnitId.Text), Convert.ToInt32(hdToUnitId.Text));

                if (dt.Rows.Count > 0)
                {
                    cboProduct.SelectedValue = dt.Rows[0]["ProductId"].ToString();
                    txtMultiplier.Text = dt.Rows[0]["Multiplier"].ToString();
                    cboBaseUnit.SelectedValue = dt.Rows[0]["BaseUnitId"].ToString();
                    cboToUnit.SelectedValue = dt.Rows[0]["ToUnitId"].ToString();
                    
                }
            }
        }

        private void AddorUpdate()
        {
            UnitConversionService unitConversionService = new UnitConversionService();
            UnitConversionEntity unitConversionEntity = CreateData();
            bool success = false;

            if (String.IsNullOrEmpty(hdProductId.Text))
            {
                success = unitConversionService.Insert(unitConversionEntity);
                if (success)
                {
                    MessageBox.Show("Save Success.", "Success", MessageBoxButtons.OK);
                }
            }
            else
            {
                success = unitConversionService.Update(unitConversionEntity , tempProductID,tempBaseUnitID,tempToUnitID);
                if (success)
                {
                    MessageBox.Show("Update Success.", "Success", MessageBoxButtons.OK);
                }
            }
            this.Controls.Clear();
            this.Controls.Add(ucUnitConversionList);
        }

        private UnitConversionEntity CreateData()
        {
            UnitConversionEntity unitConversionEntity = new UnitConversionEntity(); ;
            if (!String.IsNullOrEmpty(hdProductId.Text))
            {
                tempProductID = Convert.ToInt32(hdProductId.Text);
                tempBaseUnitID = Convert.ToInt32(hdBaseUnitId.Text);
                tempToUnitID = Convert.ToInt32(hdToUnitId.Text);
            }
            unitConversionEntity.productId = selectedProductId;
            unitConversionEntity.baseUnitId =selectedBasenitId;
            unitConversionEntity.toUnitId = selectedToUnitId;
            decimal multiplier = decimal.Parse(txtMultiplier.Text);
            unitConversionEntity.multiplier =(decimal) Math.Round(multiplier, 2);
            return unitConversionEntity;
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
            this.Controls.Add(ucUnitConversionList);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool success = unitConversionService.Delete(Convert.ToInt32(hdProductId.Text), Convert.ToInt32(hdBaseUnitId.Text), Convert.ToInt32(hdToUnitId.Text));
            if (success)
            {
                MessageBox.Show("Delete Success.", "Success", MessageBoxButtons.OK);
            }
            this.Controls.Clear();
            this.Controls.Add(ucUnitConversionList);
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = cboProduct.SelectedItem as DataRowView;
            selectedProductId = Convert.ToInt32(selectedRow["ProductId"]);
        }

        private void cboBaseUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = cboBaseUnit.SelectedItem as DataRowView;
            selectedBasenitId = Convert.ToInt32(selectedRow["UnitId"]);
        }

        private void cboToUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = cboToUnit.SelectedItem as DataRowView;
            selectedToUnitId = Convert.ToInt32(selectedRow["UnitId"]);
        }
    }
}
