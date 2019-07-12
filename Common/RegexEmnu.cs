using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class RegexEmnu
    {
        /// <summary>
        /// 文件路径匹配
        /// </summary>
        public enum FilePath
        {
            /// <summary>
            /// 仅文件名
            /// </summary>
            NameOnly = 0,
            /// <summary>
            /// 文件名（包括后缀）
            /// </summary>
            FileName = 1,
            /// <summary>
            /// 仅后缀名（包括.）
            /// </summary>
            FileSuffix = 2,
            /// <summary>
            /// 除文件名之外的路径
            /// </summary>
            PathExceptName = 3,
            /// <summary>
            /// 除后缀之外的路径
            /// </summary>
            PathExceptSuffix = 4
        }
    }
}
