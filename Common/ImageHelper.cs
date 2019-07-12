using ImageMagick;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Common
{
    /// <summary>
    /// 图片操作类
    /// </summary>
    public class ImageHelper
    {
        FileHelper fileHelper = new FileHelper();
        RegexHelper regexHelper = new RegexHelper();
        /// <summary>
        /// 压缩图片
        /// </summary>
        /// <param name="filepath">导入图片的文件路径</param>
        /// <param name="outpath">导出图片的文件夹</param>
        public void CompressImage(string filepath, string outpath)
        {
            MagickImage image = new MagickImage(filepath);//获得一个图片对象
            image.Quality = 75;//进行压缩 100最高
            image.Strip();
            //image.Resize(1000, 1000); //整体进行尺寸调整
            Regex reg = new Regex(@"^(?<fpath>([a-zA-Z]:\\)([\s\.\-\w]+\\)*)(?<fname>[\w]+)(?<namext>(\.[\w]+)*)(?<suffix>\.[\w]+)");
            Match result = reg.Match(image.FileName);
            string path = result.Result("${fname}") + result.Result("${namext}") + result.Result("${suffix}");
            image.Write(outpath + "\\" + path);//以流的方式写入目标路径
            image.Dispose();//对象进行释放
        }
        /// <summary>
        /// 压缩图片
        /// </summary>
        /// <param name="importpath">导入图片的文件夹</param>
        /// <param name="outpath">导出图片的文件夹</param>
        public void CompressImages(string importpath, string outpath)
        {
            MagickImage image = null;
            List<FileInfo> list = fileHelper.GetAllFilesInPath(importpath);
            List<string> error = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                FileInfo fileInfo = list[i];
                if (fileInfo.Length > 0.06 * 1000 * 1024)
                {
                    try
                    {
                        image = new MagickImage(fileInfo);
                        image.Quality = 85;
                        MagickGeometry geometry = new MagickGeometry();
                        geometry.Width = 400;//固定宽度，等比压缩
                        image.Resize(geometry);
                        image.Strip();
                        image.Write(outpath + "\\" + fileInfo.Name);//以流的方式写入目标路径
                        image = null;
                    }
                    catch (Exception ex)
                    {
                        error.Add(ex.Message);
                    }
                }
            }
            if (image != null)
            {
                image.Dispose();//对象进行释放
            }
            if (error.Count > 0)
            {
                string lujing = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "错误信息.txt");
                File.WriteAllLines(lujing, error);
            }
          
        }
    }
}
