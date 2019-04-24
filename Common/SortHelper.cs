using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    /// <summary>
    /// 排序帮助类
    /// </summary>
    public class SortHelper
    {
        public class SortString:IComparer<string>
        {
            public int Compare(string a, string b)
            {
                string[] str1 = a.Split('\\');
                string[] str2 = b.Split('\\');
                if (int.Parse(str1[str1.Length - 1]) > int.Parse(str2[str2.Length - 1]))
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
