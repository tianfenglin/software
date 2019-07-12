using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Common
{
    /// <summary>
    /// 正则帮助类
    /// </summary>
    public class RegexHelper
    {
        /// <summary>
        /// 从文件路径中匹配内容不能包含符号：()
        /// </summary>
        /// <param name="filepath">文件路径</param>
        /// <param name="filetype">匹配规则</param>
        /// <returns>匹配结果</returns>
        public string RegexFilPath(string filepath, RegexEmnu.FilePath filetype)
        {
            string result = string.Empty;
            Regex regex = new Regex(@"^(?<fpath>([a-zA-Z]:\\)([\s\.\-\w]+\\)*)(?<fname>[\w]+)(?<namext>(\.[\w]+)*)(?<suffix>\.[\w]+)");
            Match match = regex.Match(filepath);
            switch (filetype)
            {
                case RegexEmnu.FilePath.NameOnly:
                    result = match.Result("${fname}") + match.Result("${namext}");
                    break;
                case RegexEmnu.FilePath.FileName:
                    result = match.Result("${fname}") + match.Result("${namext}") + match.Result("${suffix}");
                    break;
                case RegexEmnu.FilePath.FileSuffix:
                    result = match.Result("${suffix}");
                    break;
                case RegexEmnu.FilePath.PathExceptName:
                    result = match.Result("${fpath}");
                    break;
                case RegexEmnu.FilePath.PathExceptSuffix:
                    result = match.Result("${fpath}") + match.Result("${fname}") + match.Result("${namext}");
                    break;
                default:
                    result = filepath;
                    break;
            }
            return result;
        }
    }
}
