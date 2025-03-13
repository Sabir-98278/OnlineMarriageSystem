using ClosedXML.Excel;

namespace TestProject1_nunit.Framework.Framework_GenericUtility
{
    internal class ExcelFileUtility
    {
        public string ToreadfromExcel(string sheetname, int row, int cell)
        {
            XLWorkbook workbook = new XLWorkbook(IPathConstants.ExcelPath);
            IXLWorksheet sheet = workbook.Worksheet(sheetname);
            string orgname = sheet.Row(row).Cell(cell).GetValue<string>();
            return orgname;
        }

    }
}
