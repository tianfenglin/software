using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelHelp
{
    /// <summary>
    /// Excel 2007以上 .xlsx文件 较优选择Epplus
    /// </summary>
    public static class EpplusHelper
    {
        public static void DataTableToExcel(DataTable table, string sheetname, string filepath)
        {
            FileInfo newFile = new FileInfo(filepath);
            ExcelPackage package = new ExcelPackage();
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(sheetname);//创建worksheet
            //先设置列名称
            for (int i = 0; i < table.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1].Value = table.Columns[i].ColumnName;
            }
            //数据样式设置
            ExcelRange rangeone = worksheet.Cells[1, 1, 1, table.Columns.Count];
            //对齐方式
            rangeone.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            //边框
            rangeone.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            rangeone.Style.Border.Top.Style = ExcelBorderStyle.Thin;
            rangeone.Style.Border.Left.Style = ExcelBorderStyle.Thin;
            rangeone.Style.Border.Right.Style = ExcelBorderStyle.Thin;
            //加粗
            rangeone.Style.Font.Bold = true;
            //然后设置excel数据
            for (int i = 0; i < table.Rows.Count; i++)
            {
                //遍历列值，及填充excel
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1].Value = table.Rows[i][table.Columns[j].ToString()].ToString();
                }

            }
            //数据样式设置
            ExcelRange rangetwo = worksheet.Cells[2, 1, table.Rows.Count + 1, table.Columns.Count];
            //对齐方式
            rangetwo.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            //边框
            rangetwo.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            rangetwo.Style.Border.Top.Style = ExcelBorderStyle.Thin;
            rangetwo.Style.Border.Left.Style = ExcelBorderStyle.Thin;
            rangetwo.Style.Border.Right.Style = ExcelBorderStyle.Thin;

            package.SaveAs(newFile);
            worksheet.Dispose();
            package.Dispose();
        }

    }
}
