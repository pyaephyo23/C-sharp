using OJT.Services.product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Data.SqlClient;
using Entities.Product;
using OJT.Services.Unit;
using System.Xml.Linq;

namespace OJT.App.Views.Product
{
    public partial class UCProductList : UserControl
    {
        private ProductService productService = new ProductService();
        private ProductEntity productEntity = new ProductEntity();
        private UnitService unitService = new UnitService();
        public UCProductList()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            UCProduct ucProduct = new UCProduct();
            this.Controls.Clear();
            this.Controls.Add(ucProduct);
        }

        private void ProductListing_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            DataTable dt = productService.GetWithName();
            dgvProductList.DataSource = dt; 
        }


        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int productId = Convert.ToInt32(dgvProductList.Rows[e.RowIndex].Cells["gcProductID"].Value);
                if (e.ColumnIndex == dgvProductList.Columns["gcProductID"].Index)
                {
                    UCProduct ucProduct = new UCProduct();
                    ucProduct.ID = productId.ToString();
                    this.Controls.Clear();
                    this.Controls.Add(ucProduct);
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
                        for (int row = 0; row < dgvProductList.Rows.Count; row++)
                        {
                            for (int column = 0; column < dgvProductList.Columns.Count; column++)
                            {
                                worksheet.Cells[row + 1, column + 1].Value = dgvProductList.Rows[row].Cells[column].Value;
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
                            string productId = worksheet.Cells[row, 1].Value?.ToString();
                            string barcode = worksheet.Cells[row, 2].Value?.ToString();
                            string name = worksheet.Cells[row, 3].Value?.ToString();
                            string baseUnitName = worksheet.Cells[row, 4].Value?.ToString();
                            DataTable baseUnitTable = unitService.GetAll();
                            int baseUnitId = -1;
                            foreach (DataRow dataRow in baseUnitTable.Rows)
                            {
                                if (dataRow["Name"].ToString() == baseUnitName)
                                {
                                    baseUnitId = Convert.ToInt32(dataRow["UnitId"]);
                                    break;
                                }
                            }

                            // Validate data
                            bool isValid = true;
                            string errorMessage = $"Errors in line {row}\n";


                            if (string.IsNullOrWhiteSpace(barcode)|| barcode.Length > 20)
                            {
                                isValid = false;
                                errorMessage += "> Invalid Data in Barcode column\n";
                            }

                            if (string.IsNullOrWhiteSpace(name)|| name.Length > 20)
                            {
                                isValid = false;
                                errorMessage += "> Invalid Data in Name column\n\n";
                            }

                            if (!int.TryParse(productId, out int productID) || productID <= 0)
                            {
                                isValid = false;
                                errorMessage += "> Invalid Product Id number.\n";
                            }

                            if (baseUnitId == -1 )
                            {
                                isValid = false;
                                errorMessage += "> Invalid Base Unit Id number.\n";
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
                                
                                productEntity.productId =Convert.ToInt32(worksheet.Cells[row, 1].Value.ToString());
                                productEntity.barcode = worksheet.Cells[row, 2].Value?.ToString();
                                productEntity.name = worksheet.Cells[row, 3].Value?.ToString();
                                string baseUnitName= worksheet.Cells[row, 4].Value?.ToString();
                                DataTable baseUnitTable = unitService.GetAll();
                                foreach (DataRow dataRow in baseUnitTable.Rows)
                                {
                                    if (dataRow["Name"].ToString() == baseUnitName)
                                    {
                                        productEntity.baseUnitId = Convert.ToInt32(dataRow["UnitId"]);
                                        break;
                                    }
                                }
                                bool isExist = productService.SearchData(productEntity);
                                if (isExist)
                                {
                                    MessageBox.Show($"Data from row {row} is already exist in the database");
                                    break;
                                }
                                else
                                {
                                    productService.Insert(productEntity);
                                }
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