using Entities.Product;
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

namespace OJT.App.Views.Convert_Unit
{
    public partial class ConvertUnit : UserControl
    {
        private ProductService productService = new ProductService();
        private UnitService unitService = new UnitService();
        public ConvertUnit()
        {
            InitializeComponent();
        }

        private void ConvertUnit_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        private void BindGrid()
        {
            DataTable dtProduct = productService.GetAll();
            cboProduct.DataSource = dtProduct;
            cboProduct.DisplayMember = "Name";
            cboProduct.ValueMember = "ProductId";

            DataTable dtUnit = unitService.GetAll();
            cboBaseUnit.DataSource = dtUnit;
            cboBaseUnit.DisplayMember= "Name";
            cboBaseUnit.ValueMember = "UnitId";

            cboToUnit.DataSource = dtUnit.Copy();
            cboToUnit.DisplayMember = "Name";
            cboToUnit.ValueMember = "UnitId";

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
         
            UnitConversionService unitConversionService = new UnitConversionService();
            UnitConversionEntity unitConversionEntity = CreateData();
            float multiplier = unitConversionService.Multiplier(unitConversionEntity);
            int value = int.Parse(txtValue.Text);
            float result = multiplier * value;
            MessageBox.Show($"Your result is {result}");
        }

        private UnitConversionEntity CreateData()
        {
            int productId = (int)cboProduct.SelectedValue;
            int baseUintId = (int)cboBaseUnit.SelectedValue;
            int toUnitId = (int)cboToUnit.SelectedValue;
            UnitConversionEntity unitConversionEntity = new UnitConversionEntity(); ;
            unitConversionEntity.productId = productId;
            unitConversionEntity.baseUnitId = baseUintId;
            unitConversionEntity.toUnitId = toUnitId;
            return unitConversionEntity;
        }
    }
}
