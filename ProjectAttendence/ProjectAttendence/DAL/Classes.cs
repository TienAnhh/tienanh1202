using ProjectAttendence.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ProjectAttendence.DAL
{
   public class Classes
    {
        private int classID;
        private string code;

        private bool active;

        private string date;

        public int ClassID { get => classID; set => classID = value; }
        public string Code { get => code; set => code = value; }
       

        public bool Active { get => active; set => active = value; }
        
        public string Date { get => date; set => date = value; }
       
        public Classes(int classID, string code, bool active, string date)
        {
            this.classID = classID;
            this.code = code;
           
            this.active = active;
            this.date = date;
        }

        public Classes()
        {
        }

        public static int AddClass(ArrayList arrayList)
        {
            string sql = @"insert into Class values (@code,@acti,@dat)";
            SqlParameter[] param = {new SqlParameter("@code", SqlDbType.NVarChar),
                                   
                                    new SqlParameter("@acti", SqlDbType.Bit),
                                    new SqlParameter("@dat", SqlDbType.NVarChar)
                                  };
            for (int i = 0; i < arrayList.Count; i++)
            {
                param[i].Value = arrayList[i];
            }
            return Database.ExecuteSQL(sql, param);
        }


        public static List<Classes> getAllClass()
        {
            List<Classes> list = new List<Classes>();
            DataTable classes = Database.GetDataBySQL("select * from [Class]"); ;
            foreach (DataRow dr in classes.Rows)
            {
                list.Add(new Classes(
                    Convert.ToInt32(dr["ClassID"].ToString()),
                    dr["Code"].ToString(),
                 
                   Convert.ToBoolean(dr["Active"].ToString()),
                    dr["date"].ToString()
                    ));
            }
            return list;
        }
        public static List<Classes> SearchClass(string classcode)
        {
            List<Classes> list = new List<Classes>();
            DataTable classes = Database.GetDataBySQL("select * from [Class] where Code like '%"+classcode+"%'");
            foreach (DataRow dr in classes.Rows)
            {
                list.Add(new Classes(
                   Convert.ToInt32(dr["ClassID"].ToString()),
                    dr["Code"].ToString(),
               
                   Convert.ToBoolean(dr["Active"].ToString()),
                    dr["date"].ToString()
                    ));
            }
            return list;
        }

        public static int NumberStudent(int id)
        {
            int num = 0;
            DataTable classes = Database.GetDataBySQL("select count(*) from List_Class_Student where classid =" + id);
            foreach (DataRow dr in classes.Rows)
            {
                num = Convert.ToInt32(dr[0].ToString());
            }
            return num;
        } 
        public static DataTable ShowClass(int id)
        {
           return Database.GetDataBySQL("SELECT [ID] as'Student Code' ,[Name] as 'Student Name' ,a.Mail as 'Email', [Major] as 'Major' ,[Gender] " +
                "  ,[DOB] as 'Date Of Birth',[Phone] ,[City]  FROM [dbo].[Student] s join Account a on a.AccountID = s.AccountID" +
                " join [dbo].[List_Class_Student] l on s.ID = l.stuid where l.classid = " + id);
        }
    }
}
