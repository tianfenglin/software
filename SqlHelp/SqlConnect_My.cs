using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlHelp
{
    /// <summary>
    /// mysql连接
    /// </summary>
    public class SqlConnect_My: ISqlContent
    {
        //获取连接字符串
        //private readonly string sqlcon;
        //创建连接实例
        private MySqlConnection con;
        public SqlConnect_My(string connect)
        {
            con = new MySqlConnection(connect);
        }
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        private void OpenConnect()
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        private void CloseConnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        /// <summary>
        /// 根据sql语句获取table数据
        /// </summary>
        /// <param name="sql">sql查询语句</param>
        /// <returns>返回一张表</returns>
        public DataTable GetTable(string sql)
        {
            try
            {
                DataTable dt = new DataTable("table");
                OpenConnect();
                MySqlDataAdapter MySqlDA = new MySqlDataAdapter(sql, con);
                MySqlDA.Fill(dt);
                CloseConnect();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 数据库基础操作
        /// </summary>
        /// <param name="sql">操作语句</param>
        /// <returns></returns>
        public bool UpdateSql(string sql)
        {
            bool result = false;
            OpenConnect();
            MySqlCommand command = new MySqlCommand(sql, con);
            try
            {
                command.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ee)
            {
                throw ee;
            }
            finally
            {
                CloseConnect();
            }
            return result;
        }

        /// <summary>
        /// 事务处理
        /// </summary>
        /// <param name="SQLStringList"></param>
        /// <returns></returns>
        public bool ExecuteSqlTran(List<String> SQLStringList)
        {
            bool result = false;
            OpenConnect();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            MySqlTransaction ts = con.BeginTransaction();
            cmd.Transaction = ts;
            try
            {
                for (int i = 0; i < SQLStringList.Count; i++)
                {
                    string strsql = SQLStringList[i];
                    if (strsql.Length > 1)
                    {
                        cmd.CommandText = strsql;
                        cmd.ExecuteNonQuery();
                    }
                }
                ts.Commit();//提交数据库事务
                result = true;
            }
            catch (Exception ee)
            {
                ts.Rollback();//回滚
                throw ee;
            }
            finally
            {
                CloseConnect();
            }
            return result;
        }

        public DataTable GetAllTableNames()
        {

            OpenConnect();
            DataTable dt = con.GetSchema("tables");
            CloseConnect();
            return dt;
        }

        public DataTable GetTableBuildByName(string tablename)
        {
            OpenConnect();
            DataTable dt = con.GetSchema("columns", new string[] { null, null, tablename, null });
            CloseConnect();
            return dt;
        }
    }
}
