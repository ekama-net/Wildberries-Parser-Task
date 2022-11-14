using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace WildberriesParser
{
    public class ExcelGenerator
    {
        public byte[] Generate(Tag[][] report, string[] bookNames)
        {
            var package = new ExcelPackage();
            for (int i = 0; i < bookNames.Length; i++)
            {
                var sheet = package.Workbook.Worksheets
                    .Add(bookNames[i]);
                sheet.Cells["A1"].Value = "Title";
                sheet.Cells["B1"].Value = "Brand";
                sheet.Cells["C1"].Value = "Id";
                sheet.Cells["D1"].Value = "Feddbacks";
                sheet.Cells["E1"].Value = "Price";

                for (int j = 0; j < report[i].Length; j++)
                {
                    sheet.Cells[$"A{j + 2}"].Value = report[i][j].Title;
                    sheet.Cells[$"B{j + 2}"].Value = report[i][j].Brand;
                    sheet.Cells[$"C{j + 2}"].Value = report[i][j].Id;
                    sheet.Cells[$"D{j + 2}"].Value = report[i][j].Feedbacks;
                    sheet.Cells[$"E{j + 2}"].Value = report[i][j].Price/100;
                }
                sheet.Cells[1, 1, 1, 5].Style.Font.Bold = true;
                sheet.Cells[1, 1, 101, 5].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                sheet.Cells[1, 1, 101, 5].AutoFitColumns();
            }
            return package.GetAsByteArray();
        }
    }
}
