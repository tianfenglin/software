using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Common
{
    public class TableHelper
    {
        public DataTable ReplaceData(DataTable table, string column)
        {
            // Dictionary<string, string> condition
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string value = table.Rows[i][column].ToString();
                if (value == "")
                {
                    table.Rows[i][column] = "2";
                }
                else if (value == "是")
                {
                    table.Rows[i][column] = "1";
                }
                else if (value == "否")
                {
                    table.Rows[i][column] = "0";
                }
            }
            return table;
        }
    }
}
