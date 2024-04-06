using OJT.App.Views.Convert_Unit;
using OJT.App.Views.Employee;
using OJT.App.Views.Product;
using OJT.App.Views.UnitConversion;
using OJT.App.Views.Units;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OJT.App.Views.Menu
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCProductList products = new UCProductList();
            pnUC.Controls.Clear();
            pnUC.Controls.Add(products);
        }

        private void unToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCUnitsListing unitsListing = new UCUnitsListing();
            pnUC.Controls.Clear();
            pnUC.Controls.Add(unitsListing);
        }

        private void ConvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConvertUnit convertUnit = new ConvertUnit();
            //pnUC.Controls.Clear();
            //pnUC.Controls.Add(convertUnit);
        }

        private void unitConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCUnitConversionList ucUnitConversionList = new UCUnitConversionList();
            pnUC.Controls.Clear();
            pnUC.Controls.Add(ucUnitConversionList);
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UCEmployeeList uCEmployeeList = new UCEmployeeList();
            pnUC.Controls.Clear();
            pnUC.Controls.Add(uCEmployeeList);
        }
    }
}
