using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Common
{
    /// <summary>
    /// 文件排序类
    /// </summary>
    public class FileIComparer
    {
        [System.Runtime.InteropServices.DllImport("Shlwapi.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        private static extern int StrCmpLogicalW(string fileone, string filetwo);
        /// <summary>
        /// 根据文件名顺序排序(windows排序)
        /// </summary>
        /// <param name="files"></param>
        public void FileComparerByNameAsc(ref List<FileInfo>  files)
        {

            files.Sort((one,two)=> { return StrCmpLogicalW(one.Name, two.Name); });
        }
        /// <summary>
        /// 根据文件名倒序排序
        /// </summary>
        /// <param name="files"></param>
        public void FileComparerByNameDesc(ref List<FileInfo> files)
        {
            files.Sort((one, two) => { return StrCmpLogicalW(two.Name, one.Name); });
        }

        /// <summary>
        /// 根据文件大小顺序排序
        /// </summary>
        /// <param name="files"></param>
        public void FileComparerBySizeAsc(ref List<FileInfo> files)
        {
            files.Sort((one, two) => { return two.Length.CompareTo(one.Length); });
        }
        /// <summary>
        /// 根据文件大小倒序排序
        /// </summary>
        /// <param name="files"></param>
        public void FileComparerBySizeDesc(ref List<FileInfo> files)
        {
            files.Sort((one, two) => { return one.Length.CompareTo(two.Length); });
        }

        /// <summary>
        /// 根据文件创建时间顺序排序
        /// </summary>
        /// <param name="files"></param>
        public void FileComparerByCreatTimeAsc(ref List<FileInfo> files)
        {
            files.Sort((one, two) => { return two.CreationTime.CompareTo(one.CreationTime); });
        }
        /// <summary>
        /// 根据文件创建时间倒序排序
        /// </summary>
        /// <param name="files"></param>
        public void FileComparerByCreatTimeDesc(ref List<FileInfo> files)
        {
            files.Sort((one, two) => { return one.CreationTime.CompareTo(two.CreationTime); });
        }
    }
}
