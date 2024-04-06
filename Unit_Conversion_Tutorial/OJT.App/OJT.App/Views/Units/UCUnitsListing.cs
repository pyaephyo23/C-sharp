using Entities.Product;
using OfficeOpenXml;
using OJT.App.Views.Product;
using OJT.Services.product;
using OJT.Services.Unit;
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
using System.Xml.Linq;

namespace OJT.App.Views.Units
{
    public partial class UCUnitsListing : UserControl
    {
        private UnitService unitService = new UnitService();
        private UnitEntity unitEntity = new UnitEntity();
        public UCUnitsListing()
        {
            InitializeComponent();
        }
        private void BindGrid()
        {
            DataTable dt = unitService.GetAll();
            dgvUnitList.DataSource = dt;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            UCUnits ucUnit = new UCUnits();
            this.Controls.Clear();
            this.Controls.Add(ucUnit);
        }

        private void UCUnitsListing_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dgvUnitList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int productId = Convert.ToInt32(dgvUnitList.Rows[e.RowIndex].Cells["gcUnitID"].Value);
                if (e.ColumnIndex == dgvUnitList.Columns["gcUnitID"].Index)
                {
                    UCUnits ucUnits = new UCUnits();
                    ucUnits.ID = productId.ToString();
                    this.Controls.Clear();
                    this.Controls.Add(ucUnits);

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
                        for (int row = 0; row < dgvUnitList.Rows.Count; row++)
                        {
                            for (int column = 0; column < dgvUnitList.Columns.Count; column++)
                            {
                                worksheet.Cells[row + 1, column + 1].Value = dgvUnitList.Rows[row].Cells[column].Value;
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
                            string unitId = worksheet.Cells[row, 1].Value?.ToString();
                            string name = worksheet.Cells[row, 2].Value?.ToString();

                            bool isValid = true;
                            string errorMessage = $"Errors in line {row}\n";

                            if (string.IsNullOrWhiteSpace(name)|| name.Length > 20)
                            {
                                isValid = false;
                                errorMessage += "> There is no Data in Name column\n";
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

                                unitEntity.name =worksheet.Cells[row, 2].Value.ToString();
                                unitService.Insert(unitEntity);
                                
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
