using OfficeOpenXml;
using System;
using System.IO;
using System.Linq;

namespace StudentDetailsCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string path = @"D:\Training\ExcelRead.xlsx";
            var fi = new FileInfo(path);

            using (var excelPackage = new ExcelPackage(fi))
            {
                //Get a WorkSheet by name. If the worksheet doesn't exist, throw an exeption
                var firstWorksheet = excelPackage.Workbook.Worksheets["Marksheet"];
                var secondWorksheet = excelPackage.Workbook.Worksheets["Output"];
                //Get the content from cells B2 as string
                //string valA1 = firstWorksheet.Cells[2,2].Value.ToString();
                int rowsMarksheet = firstWorksheet.Dimension.Rows; // 10
                int columnsMarksheet = firstWorksheet.Dimension.Columns;
                int rowsOutput = secondWorksheet.Dimension.Rows; 
                int columnsOutput = secondWorksheet.Dimension.Columns;

                firstWorksheet.Cells[1, 3].Value = "Percentage";

                for (int i=2;i<= rowsMarksheet; i++)
                {
                    firstWorksheet.Cells[i, 3].Value = (Convert.ToInt32(firstWorksheet.Cells[i, 2].Value) * 100) / 1000;  
                }
                secondWorksheet.Cells[1, 1].Value = "Student Name";
                secondWorksheet.Cells[1, 2].Value = "Student Marks";
                secondWorksheet.Cells[1, 3].Value = "Percentage";
                for (int i = 2; i <= rowsMarksheet; i++)
                {
                        if (Convert.ToInt32(firstWorksheet.Cells[i, 3].Value) > 35)
                    {
                        secondWorksheet.Cells[i, 3].Value = Convert.ToInt32(firstWorksheet.Cells[i, 3].Value);
                        secondWorksheet.Cells[i, 1].Value = firstWorksheet.Cells[i, 1].Value.ToString();
                        secondWorksheet.Cells[i, 2].Value = Convert.ToInt32(firstWorksheet.Cells[i, 2].Value);
                    }
                }
                //Save your file
                excelPackage.Save();
            }
        }
    }
}
