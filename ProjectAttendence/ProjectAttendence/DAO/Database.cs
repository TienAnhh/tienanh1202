using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjectAttendence.DAO
{
   public class Database
    {
        public static SqlConnection GetConnection()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["Project"].ToString();
            return new SqlConnection(ConnectionString);
        }

        public static DataTable GetDataBySQL(String sql)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection conn = GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }


        public static DataTable GetDataBySQLInfo(String sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(parameters);
            command.Connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }
        public static int ExecuteSQL(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            command.Parameters.AddRange(parameters);
            command.Connection.Open();
            int count = command.ExecuteNonQuery();
            command.Connection.Close();
            return count;
        }
        public static DataTable getAllDepart()
        {
            return GetDataBySQL("select * from Department");
        }
        public static DataTable getAllSlot()
        {
            return GetDataBySQL("select * from Slot");
        }
        public static DataTable getAllDateClass()
        {
            return GetDataBySQL("select * from DateClass");
        }
        public static int AddToClass(ArrayList arrayList)
        {
            string sql = "INSERT INTO [dbo].[List_Class_Student]([stuid],[classid]) VALUES (@stu,@cls)";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@stu",SqlDbType.NVarChar),
                new SqlParameter("@cls",SqlDbType.Int),
                 

            };
            for (int i = 0; i < arrayList.Count; i++)
            {
                sqlParameter[i].Value = arrayList[i];
            }
            return ExecuteSQL(sql, sqlParameter);
        }
        public static int DeativeAccount(int id)
        {
            string sql = "Update [dbo].[Account] set [Active] = @status where AccountID = @id";
            SqlParameter[] sql1 = new SqlParameter[]
            {
                new SqlParameter("@status",SqlDbType.Bit),
            new SqlParameter("@id", SqlDbType.Int)
        };
            bool c = false;
            sql1[0].Value = c;
            sql1[1].Value = id;
           
            return ExecuteSQL(sql,sql1);
        }
    }
}
