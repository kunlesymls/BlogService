using OfficeOpenXml;
using System;
using System.Collections;

namespace Blog.Infrastructures.Services
{
    public class ExcelValidation
    {
        public (bool status, string row, string column) ValidateExcel(int noOfRow, ExcelWorksheet workSheet, int noOfRequired)
        {
            int colum = 0;
            for (int row = 2; row <= noOfRow; row++)
            {
                try
                {
                    for (int i = 1; i <= noOfRequired; i++)
                    {
                        new ArrayList().Add(workSheet.Cells[row, i].Value.ToString().Trim());
                        colum = i + 1;
                    }
                }
                catch (Exception e)
                {
                    return (false, row.ToString(), colum.ToString() + " " + e.Message);
                }
            }
            return (true, "", "");
        }
    }
}
