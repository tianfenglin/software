using Baidu.Aip.Ocr;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BaiDuApi
{
    public class WordsOrc
    {
        // 设置APPID/AK/SK
        //static string app_id = "10705834";
        static string api_key = "DMR1xQmxm8qpvQzfRFGuO2PI";
        static string secret_key = "2jB85tT2uCbNBrd6MBNFawBIaAaKqwG6";

        Ocr client = new Ocr(api_key, secret_key);

        /// <summary>
        /// 通用文字识别，图片参数为本地图片
        /// </summary>
        /// <param name="path">本地图片路径</param>
        /// <returns>list集合一行一个值</returns>
        public List<string> GeneralBasic(string path)
        {
            List<string> contents = new List<string>();
            byte[] image = File.ReadAllBytes(path);
            // 调用通用文字识别, 图片参数为本地图片，可能会抛出网络等异常，请使用try/catch捕获
            JObject result = client.GeneralBasic(image);
            // 如果有可选参数
            Dictionary<string, object> options = new Dictionary<string, object>();
            options.Add("language_type", "CHN_ENG");
            options.Add("detect_direction", "true");
            options.Add("detect_language", "true");
            options.Add("probability", "true");
            // 带参数调用通用文字识别, 图片参数为本地图片
            result = client.GeneralBasic(image, options);
            string content = result["words_result"].ToString();
            JArray jarray = JArray.Parse(content);
            for (int i = 0; i < jarray.Count; i++)
            {
                JObject jobject = JObject.Parse(jarray[i].ToString());
                string hang = jobject["words"].ToString();
                contents.Add(hang);
            }
            return contents;
        }

        /// <summary>
        /// 调用通用文字识别, 图片参数为远程url图片
        /// </summary>
        /// <param name="url">远程图片路径</param>
        /// <returns>list集合一行一个值</returns>
        public List<string> GeneralBasicUrl(string url)
        {
            List<string> contents = new List<string>();
            // 调用通用文字识别, 图片参数为远程url图片，可能会抛出网络等异常，请使用try/catch捕获
            JObject result = client.GeneralBasicUrl(url);
            // 如果有可选参数
            Dictionary<string, object> options = new Dictionary<string, object>();
            options.Add("language_type", "CHN_ENG");
            options.Add("detect_direction", "true");
            options.Add("detect_language", "true");
            options.Add("probability", "true");
            // 带参数调用通用文字识别, 图片参数为远程url图片
            result = client.GeneralBasicUrl(url, options);
            string content = result["words_result"].ToString();
            JArray jarray = JArray.Parse(content);
            for (int i = 0; i < jarray.Count; i++)
            {
                JObject jobject = JObject.Parse(jarray[i].ToString());
                string hang = jobject["words"].ToString();
                contents.Add(hang);
            }
            return contents;
        }


        /// <summary>
        /// 调用通用文字识别（高精度版）
        /// </summary>
        /// <param name="path">图片路径</param>
        /// <returns>list集合一行一个值</returns>
        public List<string> AccurateBasic(string path)
        {
            List<string> contents = new List<string>();
            // 修改超时时间
            client.Timeout = 60000;
            var image = File.ReadAllBytes(path);
            // 调用通用文字识别（高精度版），可能会抛出网络等异常，请使用try/catch捕获
            JObject result = client.AccurateBasic(image);
            // 如果有可选参数
            Dictionary<string, object> options = new Dictionary<string, object>();
            options.Add("detect_direction", "true");
            options.Add("probability", "true");
            // 带参数调用通用文字识别（高精度版）
            result = client.AccurateBasic(image, options);
            string content = result["words_result"].ToString();
            JArray jarray = JArray.Parse(content);
            for (int i = 0; i < jarray.Count; i++)
            {
                JObject jobject = JObject.Parse(jarray[i].ToString());
                string hang = jobject["words"].ToString();
                contents.Add(hang);
            }
            return contents;
        }


        /// <summary>
        /// 调用通用文字识别（含位置信息版）, 图片参数为本地图片
        /// </summary>
        /// <param name="path">图片路径</param>
        /// <returns>list集合一行一个值</returns>
        public List<string> General(string path)
        {
            List<string> contents = new List<string>();
            byte[] image = File.ReadAllBytes(path);
            // 调用通用文字识别（含位置信息版）, 图片参数为本地图片，可能会抛出网络等异常，请使用try/catch捕获
            JObject result = client.General(image);
            // 如果有可选参数
            Dictionary<string, object> options = new Dictionary<string, object>();
            options.Add("recognize_granularity", "big");
            options.Add("language_type", "CHN_ENG");
            options.Add("detect_direction", "true");
            options.Add("detect_language", "true");
            options.Add("vertexes_location", "true");
            options.Add("probability", "true");
            // 带参数调用通用文字识别（含位置信息版）, 图片参数为本地图片
            result = client.General(image, options);
            string content = result["words_result"].ToString();
            JArray jarray = JArray.Parse(content);
            for (int i = 0; i < jarray.Count; i++)
            {
                JObject jobject = JObject.Parse(jarray[i].ToString());
                string hang = jobject["words"].ToString();
                contents.Add(hang);
            }
            return contents;
        }

        /// <summary>
        /// 调用通用文字识别（含位置信息版）, 图片参数为远程url图片
        /// </summary>
        /// <param name="url">远程图片路径</param>
        /// <returns>list集合一行一个值</returns>
        public List<string> GeneralUrl(string url)
        {
            List<string> contents = new List<string>();
            // 调用通用文字识别（含位置信息版）, 图片参数为远程url图片，可能会抛出网络等异常，请使用try/catch捕获
            JObject result = client.GeneralUrl(url);
            // 如果有可选参数
            Dictionary<string, object> options = new Dictionary<string, object>();
            options.Add("recognize_granularity", "big");
            options.Add("language_type", "CHN_ENG");
            options.Add("detect_direction", "true");
            options.Add("detect_language", "true");
            options.Add("vertexes_location", "true");
            options.Add("probability", "true");
            // 带参数调用通用文字识别（含位置信息版）, 图片参数为远程url图片
            result = client.GeneralUrl(url, options);
            string content = result["words_result"].ToString();
            JArray jarray = JArray.Parse(content);
            for (int i = 0; i < jarray.Count; i++)
            {
                JObject jobject = JObject.Parse(jarray[i].ToString());
                string hang = jobject["words"].ToString();
                contents.Add(hang);
            }
            return contents;
        }

        /// <summary>
        /// 调用通用文字识别（含位置高精度版）,图片参数为本地图片
        /// </summary>
        /// <param name="path">图片路径</param>
        /// <returns>list集合一行一个值</returns>
        public List<string> Accurate(string path)
        {
            List<string> contents = new List<string>();
            byte[] image = File.ReadAllBytes("图片文件路径");
            // 调用通用文字识别（含位置高精度版），可能会抛出网络等异常，请使用try/catch捕获
            JObject result = client.Accurate(image);
            // 如果有可选参数
            Dictionary<string, object> options = new Dictionary<string, object>();
            options.Add("recognize_granularity", "big");
            options.Add("detect_direction", "true");
            options.Add("vertexes_location", "true");
            options.Add("probability", "true");
            // 带参数调用通用文字识别（含位置高精度版）
            result = client.Accurate(image, options);
            string content = result["words_result"].ToString();
            JArray jarray = JArray.Parse(content);
            for (int i = 0; i < jarray.Count; i++)
            {
                JObject jobject = JObject.Parse(jarray[i].ToString());
                string hang = jobject["words"].ToString();
                contents.Add(hang);
            }
            return contents;
        }


        /// <summary>
        /// 调用通用文字识别（含生僻字版）, 图片参数为本地图片
        /// </summary>
        /// <param name="path">图片路径</param>
        /// <returns>list集合一行一个值</returns>
        public List<string> GeneralEnhanced(string path)
        {
            List<string> contents = new List<string>();
            byte[] image = File.ReadAllBytes(path);
            // 调用通用文字识别（含生僻字版）, 图片参数为本地图片，可能会抛出网络等异常，请使用try/catch捕获
            JObject result = client.GeneralEnhanced(image);
            // 如果有可选参数
            Dictionary<string, object> options = new Dictionary<string, object>();
            options.Add("language_type", "CHN_ENG");
            options.Add("detect_direction", "true");
            options.Add("detect_language", "true");
            options.Add("probability", "true");
            // 带参数调用通用文字识别（含生僻字版）, 图片参数为本地图片
            result = client.GeneralEnhanced(image, options);
            string content = result["words_result"].ToString();
            JArray jarray = JArray.Parse(content);
            for (int i = 0; i < jarray.Count; i++)
            {
                JObject jobject = JObject.Parse(jarray[i].ToString());
                string hang = jobject["words"].ToString();
                contents.Add(hang);
            }
            return contents;
        }

        /// <summary>
        /// 调用通用文字识别（含生僻字版）, 图片参数为远程url图片
        /// </summary>
        /// <param name="url">远程图片路径</param>
        /// <returns>list集合一行一个值</returns>
        public List<string> GeneralEnhancedUrl(string url)
        {
            List<string> contents = new List<string>();
            // 调用通用文字识别（含生僻字版）, 图片参数为远程url图片，可能会抛出网络等异常，请使用try/catch捕获
            JObject result = client.GeneralEnhancedUrl(url);
            // 如果有可选参数
            Dictionary<string, object> options = new Dictionary<string, object>();
            options.Add("language_type", "CHN_ENG");
            options.Add("detect_direction", "true");
            options.Add("detect_language", "true");
            options.Add("probability", "true");
            // 带参数调用通用文字识别（含生僻字版）, 图片参数为远程url图片
            result = client.GeneralEnhancedUrl(url, options);
            string content = result["words_result"].ToString();
            JArray jarray = JArray.Parse(content);
            for (int i = 0; i < jarray.Count; i++)
            {
                JObject jobject = JObject.Parse(jarray[i].ToString());
                string hang = jobject["words"].ToString();
                contents.Add(hang);
            }
            return contents;
        }

        /// <summary>
        /// 调用网络图片文字识别, 图片参数为本地图片
        /// </summary>
        /// <param name="path">图片路径</param>
        /// <returns>list集合一行一个值</returns>
        public List<string> WebImage(string path)
        {
            List<string> contents = new List<string>();
            var image = File.ReadAllBytes(path);
            // 调用网络图片文字识别, 图片参数为本地图片，可能会抛出网络等异常，请使用try/catch捕获
            var result = client.WebImage(image);
            // 如果有可选参数
            Dictionary<string, object> options = new Dictionary<string, object>();
            options.Add("detect_direction", "true");
            options.Add("detect_language", "true");
            // 带参数调用网络图片文字识别, 图片参数为本地图片
            result = client.WebImage(image, options);
            string content = result["words_result"].ToString();
            JArray jarray = JArray.Parse(content);
            for (int i = 0; i < jarray.Count; i++)
            {
                JObject jobject = JObject.Parse(jarray[i].ToString());
                string hang = jobject["words"].ToString();
                contents.Add(hang);
            }
            return contents;
        }

        /// <summary>
        /// 调用网络图片文字识别, 图片参数为远程url图片
        /// </summary>
        /// <param name="url">远程图片路径</param>
        /// <returns>list集合一行一个值</returns>
        public List<string> WebImageUrl(string url)
        {
            List<string> contents = new List<string>();
            // 调用网络图片文字识别, 图片参数为远程url图片，可能会抛出网络等异常，请使用try/catch捕获
            var result = client.WebImageUrl(url);
            // 如果有可选参数
            Dictionary<string, object> options = new Dictionary<string, object>();
            options.Add("detect_direction", "true");
            options.Add("detect_language", "true");
            // 带参数调用网络图片文字识别, 图片参数为远程url图片
            result = client.WebImageUrl(url, options);
            string content = result["words_result"].ToString();
            JArray jarray = JArray.Parse(content);
            for (int i = 0; i < jarray.Count; i++)
            {
                JObject jobject = JObject.Parse(jarray[i].ToString());
                string hang = jobject["words"].ToString();
                contents.Add(hang);
            }
            return contents;
        }
    }
}
