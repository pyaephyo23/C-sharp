using OfficeOpenXml;
using Tutorial_05;

namespace Tutorial_08
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ApplicationConfiguration.Initialize();
            Application.Run(new frm_Employee());
        }
    }
}