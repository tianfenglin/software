using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Common
{
    public class IniHelper
    {
        public string inipath;
        public IniHelper(string path)
        {
            inipath = path;
        }
        //声明API函数
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        /// <summary>
        /// 获取ini信息
        /// </summary>
        /// <param name="Section">名称</param>
        /// <param name="Key">键</param>
        /// <returns></returns>
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(500);
            int i = GetPrivateProfileString(Section, Key, "", temp, 500, inipath);
            return temp.ToString();
        }
    }
}
