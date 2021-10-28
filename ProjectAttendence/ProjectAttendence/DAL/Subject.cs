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
   public class Subject
    {
        private string code;
        private string name;
        private string depart;

        public Subject(string code, string name, string depart)
        {
            this.code = code;
            this.name = name;
            this.depart = depart;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
       
        public string Depart { get => depart; set => depart = value; }

        public static int AddSubject(ArrayList arrayList)
        {
            string sql = @"INSERT INTO [dbo].[Subject] ( [SubjectCode], [SubjectName] , [DepartID])
                VALUES (@code,@name,@depart)";
            SqlParameter[] param = {new SqlParameter("@code", SqlDbType.VarChar),
                                   
                                    new SqlParameter("@name", SqlDbType.VarChar),
                                    new SqlParameter("@depart",SqlDbType.NVarChar)};
            for (int i = 0; i < arrayList.Count; i++)
            {
                param[i].Value = arrayList[i];
            }
            return Database.ExecuteSQL(sql, param);
        }


        public static List<Subject> getAllSubject()
        {
            List<Subject> list = new List<Subject>();
            DataTable classes = Database.GetDataBySQL("select * from [Subject]"); ;
            foreach (DataRow dr in classes.Rows)
            {
                list.Add(new Subject(
                    dr["SubjectCode"].ToString(),
                    dr["SubjectName"].ToString(),
                    dr["DepartID"].ToString()
                    ));
            }
            return list;
        }
    }
}
