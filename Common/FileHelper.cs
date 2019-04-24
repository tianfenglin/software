using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Common
{
    /// <summary>
    /// 文件操作
    /// </summary>
    public class FileHelper
    {
        /// <summary>
        /// 获取该文件下的所有文件（包括子文件夹下文件）
        /// </summary>
        /// <param name="path">文件路径</param>
        public List<FileInfo> GetAllFilesInPath(string path)
        {
            List<FileInfo> files = new List<FileInfo>();
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] file = dir.GetFiles();
            files.AddRange(file);
            return files;
        }
        /// <summary>
        /// 获取该文件下的某个类型的所有文件（包括子文件夹下文件）
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <param name="type">文件类型</param>
        public void GetAllFilesInPath(string path, string type)
        {
            List<FileInfo> files = new List<FileInfo>();
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] dirs = dir.GetDirectories();
            for (int i = 0; i < dirs.Length; i++)
            {
                FileInfo[] file = dirs[i].GetFiles();
            }
        }

        /// <summary>
        /// 获取这些路径下的所有文件
        /// </summary>
        /// <param name="paths">路径集合</param>
        /// <returns>文件集合</returns>
        public List<FileInfo> GetAllFilesInPaths(List<DirectoryInfo> paths)
        {
            List<FileInfo> files = new List<FileInfo>();
            foreach (DirectoryInfo item in paths)
            {
                FileInfo[] file = item.GetFiles();
                files.AddRange(file);
            }
            return files;
        }

        /// <summary>
        /// 获取夹文件路径下所有文件夹,包括本身文件夹
        /// </summary>
        /// <param name="path">文件夹路径</param>
        /// <returns>文件夹集合</returns>
        public List<DirectoryInfo> GetAllFoldersInPath(string path)
        {
            List<DirectoryInfo> folders = new List<DirectoryInfo>();
            DirectoryInfo dir = new DirectoryInfo(path);
            folders.Add(dir);
            DirectoryInfo[] dirs = dir.GetDirectories();
            folders.AddRange(dirs);
            for (int i = 0; i < dirs.Length; i++)
            {
                DirectoryInfo dirone = new DirectoryInfo(dirs[i].FullName);
                DirectoryInfo[] dirsone = dirone.GetDirectories();
                if (dirsone.Length > 0)
                {
                    GetFoldersInPath(dirs[i].FullName, ref folders);//
                }
            }
            return folders;
        }

        private void GetFoldersInPath(string path, ref List<DirectoryInfo> folders)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] dirs = dir.GetDirectories();
            if (dirs.Length > 0)
            {
                folders.AddRange(dirs);
                for (int i = 0; i < dirs.Length; i++)
                {
                    DirectoryInfo dirone = new DirectoryInfo(dirs[i].FullName);
                    DirectoryInfo[] dirsone = dirone.GetDirectories();
                    if (dirsone.Length > 0)
                    {
                        GetFoldersInPath(dirs[i].FullName, ref folders);//回调本身获取路径
                    }
                }
            }
        }


        /// <summary>
        /// 判断是否存在该文件名的文件，返回文件数量
        /// </summary>
        /// <param name="filename">文件名称</param>
        /// <param name="folders">文件集合</param>
        /// <returns></returns>
        public int IsExistFile(string filename, List<FileInfo> files)
        {
            List<FileInfo> files_one = files.FindAll(t => t.Name.Contains(filename));
            int count = files_one.Count;
            return count;
        }

        /// <summary>
        /// 判断是否存在该文件名的文件，并重命名及移动文件位置,返回新文件名称
        /// </summary>
        /// <param name="filename">文件名称</param>
        /// <param name="files">文件集合</param>
        /// <param name="defaultname">默认文件名称</param>
        /// <param name="newname">新名称</param>
        /// <param name="newpath">新地址</param>
        /// <returns>文件名称</returns>
        public string IsExistFile(string filename, List<FileInfo> files, string defaultname, string newname, string newpath)
        {
            string name = defaultname;
            //防止文件名中间带有空格
            List<FileInfo> files_one = files.FindAll(t => t.Name.Replace(" ","").Contains(filename));
            if (files_one.Count == 0)
            {
                name = defaultname;
            }
            else if (files_one.Count == 1)
            {
                string[] strs = files_one[0].Name.Split('.');
                string houzhui = strs[strs.Length - 1].ToLower();
                name = filename + "(" + newname + ")." + houzhui;
                //name = filename + "." + houzhui;
                files_one[0].MoveTo(newpath + "\\" + name);
            }
            else
            {
                name = "存在多条数据";
            }
            return name;
        }
        public void SelectSameFileByPaths()
        {
            //计算第一个文件的哈希值
            var hash = System.Security.Cryptography.HashAlgorithm.Create();
            var stream_1 = new System.IO.FileStream("path", System.IO.FileMode.Open);
            byte[] hashByte_1 = hash.ComputeHash(stream_1);
            stream_1.Close();
            //计算第二个文件的哈希值
            var stream_2 = new System.IO.FileStream("path", System.IO.FileMode.Open);
            byte[] hashByte_2 = hash.ComputeHash(stream_2);
            stream_2.Close();

            //比较两个哈希值
            if (BitConverter.ToString(hashByte_1) == BitConverter.ToString(hashByte_2))
                Console.WriteLine("两个文件相等");
            else
                Console.WriteLine("两个文件不等");

        }
    }
}
