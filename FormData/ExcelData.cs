using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OfficeOpenXml;

namespace UnitTestProject.FormData
{
    class ExcelData
    {
        public List<string> GetTestData(string key)
        {
            var testData = new List<string>();

            FileInfo existingFile = new FileInfo(@"D:\BBC\data\testData.xlsx");
            using (ExcelPackage package = new ExcelPackage(existingFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                int colCount = worksheet.Dimension.End.Column;
                for (int col = 1; col <= colCount; col++)
                {
                    testData.Add(worksheet.Cells[int.Parse(key.Last().ToString()), col].Value.ToString());
                }
            }
            return testData;
        }
    }
}