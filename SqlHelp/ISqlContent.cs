using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlHelp
{
    public interface ISqlContent
    {
        /// <summary>
        /// 根据sql语句获取table数据
        /// </summary>
        /// <param name="sql">sql查询语句</param>
        /// <returns>返回一张表</returns>
        DataTable GetTable(string sql);

        /// <summary>
        /// 数据库基础操作
        /// </summary>
        /// <param name="sql">操作语句</param>
        /// <returns></returns>
        bool UpdateSql(string sql);

        /// <summary>
        /// 事务处理
        /// </summary>
        /// <param name="SQLStringList"></param>
        /// <returns></returns>
        bool ExecuteSqlTran(List<String> SQLStringList);
        /// <summary>
        /// 获取数据库所有表名
        /// </summary>
        /// <returns></returns>
        DataTable GetAllTableNames();

        DataTable GetTableBuildByName(string tablename);
    }
}
