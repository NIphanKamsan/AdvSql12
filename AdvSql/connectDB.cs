using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AdvSql
{
    internal class connectDB
    {
        public static SqlConnection ConnectMinimart()
        {
            //ประกาศ ชื่อ Server และ DataBase
            string server = @"NIPHANZX7K\SQLEXPRESS";
            string db = "Minimart";

            //command เชื่อมต่อ Connection String
            string strCon = string.Format("Data Source={0};Initial Catalog={1};"
                + "Integrated Security=True;Encrypt=False", server, db);

            //ประกาศตัวแปร class เชื่อมต่อ
            SqlConnection conn = new SqlConnection(strCon);
            //เปิดการเชื่อมต่อ Data Base
            conn.Open();
            return conn;
        }
    }
}
