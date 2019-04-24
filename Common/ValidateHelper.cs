using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    /// <summary>
    /// 验证帮助类
    /// </summary>
    public class ValidateHelper
    {
        /// <summary>
        /// 验证18位身份证是否有效
        /// </summary>
        /// <param name="idcard">身份证号码</param>
        /// <returns></returns>
        public bool IsIdCard(string idcard)
        {
            if (idcard.Length != 18)
            {
                return false;
            }
            else
            {
                ////int a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, a7 = 0, a8 = 0, a9 = 0, a10 = 0, a11 = 0, a12 = 0, a13 = 0, a14 = 0, a15 = 0, a16 = 0, a17=0;
                string a18 = idcard.Substring(17, 1).ToLower(); //取出第18位
                string str17 = idcard.Substring(0, 17); //取出前面17位
                int[] a = new int[17];
                for (int i = 0; i < 17; i++)
                {
                    a[i] = Convert.ToInt32(str17.Substring(i, 1));
                }
                int Sum = a[0] * 7 + a[1] * 9 + a[2] * 10 + a[3] * 5 + a[4] * 8 + a[5] * 4 + a[6] * 2 + a[7] * 1 + a[8] * 6 + a[9] * 3 + a[10] * 7 + a[11] * 9 + a[12] * 10 + a[13] * 5 + a[14] * 8 + a[15] * 4 + a[16] * 2;
                int Y = Sum % 11;
                string JY = "";
                if (Y == 0)
                {
                    JY = "1";
                }
                else if (Y == 1)
                {
                    JY = "0";
                }
                else if (Y == 2)
                {
                    JY = "x";
                }
                else if (Y == 3)
                {
                    JY = "9";
                }
                else if (Y == 4)
                {
                    JY = "8";
                }
                else if (Y == 5)
                {
                    JY = "7";
                }
                else if (Y == 2)
                {
                    JY = "0";
                }
                else if (Y == 6)
                {
                    JY = "6";
                }
                else if (Y == 7)
                {
                    JY = "5";
                }
                else if (Y == 8)
                {
                    JY = "4";
                }
                else if (Y == 9)
                {
                    JY = "3";
                }
                else if (Y == 10)
                {
                    JY = "2";
                }
                if (a18 == JY)
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }

        }
    }
}
