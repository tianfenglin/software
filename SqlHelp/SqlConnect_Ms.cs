using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlHelp
{
    /// <summary>
    /// SqlServer连接方式
    /// </summary>
    public class SqlConnect_Ms: ISqlContent
    {
        //获取连接字符串
        //private readonly string sqlcon;
        //创建连接实例
        private SqlConnection con;
        public SqlConnect_Ms(string connect)
        {
            con = new SqlConnection(connect);
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
                SqlDataAdapter MySqlDA = new SqlDataAdapter(sql, con);
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
            SqlCommand command = new SqlCommand(sql, con);
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
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            SqlTransaction ts = con.BeginTransaction();
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
