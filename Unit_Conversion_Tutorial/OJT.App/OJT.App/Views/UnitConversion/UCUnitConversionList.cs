using Entities.Product;
using OfficeOpenXml;
using OJT.App.Views.Product;
using OJT.DAO.Product;
using OJT.Entities.UnitConversion;
using OJT.Services.product;
using OJT.Services.Unit;
using OJT.Services.UnitConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT.App.Views.UnitConversion
{
    public partial class UCUnitConversionList : UserControl
    {
        private UnitConversionService unitConversionService = new UnitConversionService();
        private ProductService productService = new ProductService();
        private UnitService unitService = new UnitService();
        private UnitConversionEntity unitConversionEntity = new UnitConversionEntity();
        private int productId;
        private int unitId;

        public UCUnitConversionList()
        {
            InitializeComponent();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            UCUnitConversion ucUnitConversion = new UCUnitConversion();
            this.Controls.Clear();
            this.Controls.Add(ucUnitConversion);
        }

        private void UCUnitConversionList_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {

            DataTable dt = unitConversionService.GetWithName();
            dgvUnitConversionList.DataSource = dt;


        }

        private int GetProductId(string name)
        {
            DataTable productDt = productService.GetAll();
            foreach (DataRow row in productDt.Rows)
            {
                if (row["Name"].ToString() == name)
                {
                    productId = Convert.ToInt32(row["ProductId"]);
                }
            }
            return productId;
        }
        private int GetUnitId(string name)
        {
            DataTable unitDt = unitService.GetAll();
            foreach (DataRow row in unitDt.Rows)
            {
                if (row["Name"].ToString() == name)
                {
                    unitId = Convert.ToInt32(row["UnitId"]);
                }
            }
            return unitId;
        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {

                // int toUnitId = Convert.ToInt32(dgvUnitConversionList.Rows[e.RowIndex].Cells["gcToUnitId"].Value);
                //  int productId = Convert.ToInt32(dgvUnitConversionList.Rows[e.RowIndex].Cells["gcProductID"].Value);
                if (e.ColumnIndex == dgvUnitConversionList.Columns["gcProductName"].Index)
                {
                    int productId = GetProductId(dgvUnitConversionList.Rows[e.RowIndex].Cells["gcProductName"].Value.ToString());
                    int baseUnitId = GetUnitId(dgvUnitConversionList.Rows[e.RowIndex].Cells["gcBaseUnitName"].Value.ToString());
                    int toUnitId = GetUnitId(dgvUnitConversionList.Rows[e.RowIndex].Cells["gcToUnitName"].Value.ToString());


                    UCUnitConversion ucUnitConversion = new UCUnitConversion();
                    ucUnitConversion.productId = productId;
                    ucUnitConversion.baseUnitId = baseUnitId;
                    ucUnitConversion.toUnitid = toUnitId;
                    this.Controls.Clear();
                    this.Controls.Add(ucUnitConversion);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                        for (int row = 0; row < dgvUnitConversionList.Rows.Count; row++)
                        {
                            for (int column = 0; column < dgvUnitConversionList.Columns.Count; column++)
                            {
                                worksheet.Cells[row + 1, column + 1].Value = dgvUnitConversionList.Rows[row].Cells[column].Value;
                            }
                        }
                        FileInfo excelFile = new FileInfo(saveFileDialog.FileName);
                        excelPackage.SaveAs(excelFile);
                    }
                    MessageBox.Show("Save successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
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
                        for (int row = worksheet.Dimension.Start.Row; row <= worksheet.Dimension.End.Row; row++)
                        {
                            string productName = worksheet.Cells[row, 1].Value?.ToString();
                            string baseUnitName = worksheet.Cells[row, 2].Value?.ToString();
                            string multiplier = worksheet.Cells[row, 3].Value?.ToString();
                            string toUnitName = worksheet.Cells[row, 4].Value?.ToString();


                            DataTable productTable = productService.GetAll();
                            int productId = -1;
                            foreach (DataRow dataRow in productTable.Rows)
                            {
                                if (dataRow["Name"].ToString() == productName)
                                {
                                    productId = Convert.ToInt32(dataRow["ProductId"]);
                                    break;
                                }
                            }

                            DataTable UnitTable = unitService.GetAll();
                            int baseUnitId = -1;
                            foreach (DataRow dataRow in UnitTable.Rows)
                            {
                                if (dataRow["Name"].ToString() == baseUnitName)
                                {
                                    baseUnitId = Convert.ToInt32(dataRow["UnitId"]);
                                    break;
                                }
                            }

                            int toUnitId = -1;
                            foreach (DataRow dataRow in UnitTable.Rows)
                            {
                                if (dataRow["Name"].ToString() == toUnitName)
                                {
                                    toUnitId = Convert.ToInt32(dataRow["UnitId"]);
                                    break;
                                }
                            }

                            // Validate data
                            bool isValid = true;
                            string errorMessage = $"Errors in line {row}\n";

                            if (!decimal.TryParse(multiplier, out decimal Multiplier) || Multiplier <= 0)
                            {
                                isValid = false;
                                errorMessage += "> Invalid Multiplier number.\n";
                            }

                            if (productId == -1)
                            {
                                isValid = false;
                                errorMessage += "> Invalid Product Id number.\n";
                            }
                            if (baseUnitId == -1)
                            {
                                isValid = false;
                                errorMessage += "> Invalid Base Unit Id number.\n";
                            }
                            if (toUnitId == -1)
                            {
                                isValid = false;
                                errorMessage += "> Invalid To Unit Id number.\n";
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
                            for (int row = worksheet.Dimension.Start.Row; row <= worksheet.Dimension.End.Row; row++)
                            {

                                string productName = worksheet.Cells[row, 1].Value?.ToString();
                                string baseUnitName = worksheet.Cells[row, 2].Value?.ToString();
                                unitConversionEntity.multiplier =Convert.ToDecimal(worksheet.Cells[row, 3].Value?.ToString());
                                string toUnitName = worksheet.Cells[row, 4].Value?.ToString();

                                DataTable productTable = productService.GetAll();
                                foreach (DataRow dataRow in productTable.Rows)
                                {
                                    if (dataRow["Name"].ToString() == productName)
                                    {
                                        unitConversionEntity.productId = Convert.ToInt32(dataRow["ProductId"]);
                                        break;
                                    }
                                }

                                DataTable UnitTable = unitService.GetAll();
                                foreach (DataRow dataRow in UnitTable.Rows)
                                {
                                    if (dataRow["Name"].ToString() == baseUnitName)
                                    {
                                        unitConversionEntity.baseUnitId = Convert.ToInt32(dataRow["UnitId"]);
                                        break;
                                    }
                                }

                                foreach (DataRow dataRow in UnitTable.Rows)
                                {
                                    if (dataRow["Name"].ToString() == toUnitName)
                                    {
                                        unitConversionEntity.toUnitId = Convert.ToInt32(dataRow["UnitId"]);
                                        break;
                                    }
                                }
                             
                                unitConversionService.Insert(unitConversionEntity);
                            }

                            MessageBox.Show("Uploaded successfully!");
                            BindGrid();
                        }
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


