using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace Common
{
    /// <summary>
    /// sql帮助类
    /// </summary>
    public class SqlCreat
    {
        public string GetPathByNet(DataTable table)
        {
            string path = "";
            List<string[]> info = new List<string[]>();
            List<string> result = new List<string>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                List<string> mar = new List<string>();
                string type = table.Rows[i]["type"].ToString();
                string description = (table.Rows[i]["describes"] ?? string.Empty).ToString();
                string name = table.Rows[i]["name"].ToString();
                //首字母大写
                //string names = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name);

                string names = "_" + name;
                mar.Add(string.Format("private {0} {1};", type, names));
                mar.Add("/// <summary>");
                mar.Add("///" + description);
                mar.Add("/// </summary>");
                mar.Add(string.Format("public {0} {1}", type, name));
                mar.Add("{");
                mar.Add("get{return " + names + ";}");
                mar.Add("set{" + names + " = value;}");
                mar.Add("}");
                string[] qwe = mar.ToArray();
                info.Add(qwe);
            }
            for (int i = 0; i < info.Count; i++)
            {
                result.AddRange(info[i]);
            }
            string lujing = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "代码生成.txt");
            File.WriteAllLines(lujing, result);
            path = lujing;
            return path;
        }

        public string GetPathByJava(DataTable table)
        {
            string path = "";
            List<string[]> info = new List<string[]>();
            List<string> result = new List<string>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                List<string> mar = new List<string>();
                string type = table.Rows[i]["type"].ToString();
                string description = (table.Rows[i]["describes"] ?? string.Empty).ToString();
                string name = table.Rows[i]["name"].ToString();
                //首字母大写
                //string names = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(name);
                //首字母小写
                string names = name.Remove(1).ToLower() + name.Remove(0, 1);
                mar.Add(string.Format("private {0} {1};", type, names));
                mar.Add("/**");
                mar.Add("* " + description);
                mar.Add("* @param " + names);
                mar.Add("*/");
                mar.Add(string.Format("public void set{0}({1} {2})", name, type, names));
                mar.Add("{");
                mar.Add(string.Format("this.{0} = {1};", names, names));
                mar.Add("}");
                mar.Add("/**");
                mar.Add("* " + description);
                mar.Add("* @return");
                mar.Add("*/");
                mar.Add(string.Format("public {0} get{1}()", type, name));
                mar.Add("{");
                mar.Add(string.Format("return this.{0};", names));
                mar.Add("}");
                string[] qwe = mar.ToArray();
                info.Add(qwe);
            }
            for (int i = 0; i < info.Count; i++)
            {
                result.AddRange(info[i]);
            }
            string lujing = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "代码生成.txt");
            File.WriteAllLines(lujing, result);
            path = lujing;
            return path;
        }

        /// <summary>
        /// java类型参数
        /// </summary>
        /// <param name="type">数据库字段类型</param>
        /// <returns></returns>
        public string GetFieldTypeByJava(string type)
        {
            string result = "";
            if (type == "int" || type == "char" || type == "varchar" || type == "nvarchar")
            {
                result = "String";
            }
            else if (type == "datetime")
            {
                result = "DateTime";
            }
            else
            {
                result = "String";
            }
            return result;
        }

        /// <summary>
        /// C#类型参数
        /// </summary>
        /// <param name="type">数据库字段类型</param>
        /// <returns></returns>
        public string GetFieldTypeByCSharp(string type)
        {
            string result = "";
            if (type == "int" || type == "char" || type == "varchar" || type == "nvarchar")
            {
                result = "string";
            }
            else if (type == "datetime")
            {
                result = "DateTime";
            }
            else
            {
                result = "string";
            }
            return result;
        }
    }
}
