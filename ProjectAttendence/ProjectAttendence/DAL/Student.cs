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
    public class Student
    {
        private string id;
        private string name;
        private string major;
        private bool gender;
        private int accountID;
        private DateTime dob;
        private string phone;
        private string address;
      //  private bool active;

        public Student()
        {
        }

        public Student(string id, string name, string major, bool gender, int accountID, DateTime dob, string phone, string address)
        {
            this.id = id;
            this.name = name;
            this.major = major;
            this.gender = gender;
            this.accountID = accountID;
            this.dob = dob;
            this.phone = phone;
            this.address = address;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Major { get => major; set => major = value; }
        public bool Gender { get => gender; set => gender = value; }
        public int AccountID { get => accountID; set => accountID = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }



        //   public bool Active { get => active; set => active = value; }

        public static int AddStudent(ArrayList arrayList)
        {
            string sql = @"insert into Student values (@ID,@Name,@Major,@gen,@DOB,@Phone,@City,@acc)";
            SqlParameter[] param = {new SqlParameter("@ID", SqlDbType.NVarChar),
                                    new SqlParameter("@Name", SqlDbType.NVarChar),
                                     new SqlParameter("@Major", SqlDbType.NVarChar),
                                    new SqlParameter("@gen",SqlDbType.Bit),  
                                    new SqlParameter("@DOB", SqlDbType.DateTime),
                                    new SqlParameter("@Phone", SqlDbType.NVarChar),
                                    new SqlParameter("@City", SqlDbType.NVarChar),
                                     new SqlParameter("@acc", SqlDbType.Int),
            };
            for(int i = 0; i < arrayList.Count; i++)
            {
                param[i].Value = arrayList[i];
            }
            return Database.ExecuteSQL(sql, param);
        }

        public static int UpdateStudent(ArrayList array)
        {
            string sql = "Update Student set  [Name] = @name ,[DOB] = @dob ,[Phone] = @phone,[City] =@add where AccountID = @id";
            SqlParameter[] sqls = new SqlParameter[]
            {
                new SqlParameter("@name",SqlDbType.NVarChar),
                new SqlParameter("@dob",SqlDbType.Date),
                new SqlParameter("@phone",SqlDbType.NVarChar),
                new SqlParameter("@add",SqlDbType.NVarChar),
                new SqlParameter("@id",SqlDbType.Int)
            };
            for (int i = 0; i < array.Count; i++)
            {
                sqls[i].Value = array[i];
            }
            return Database.ExecuteSQL(sql, sqls);
        }
        public static DataTable getStudentbyMajor(string admin)
        {
            return Database.GetDataBySQL("select a.[Active], b.[Name],b.ID, a.Mail,a.[Role] from Account a join Student b on a.AccountID = b.AccountID where b.Major like '"+admin+"'");
        }

        //public static int ExistStudentbyID(string id)
        //{
        //    int count = 0;
        //    SqlDataReader check = Database.ExecuteReader("select ID from Student where ID ='" + id + "'");
        //    while (check.Read())
        //    {
        //        if (check[0].ToString() == id)
        //        {
        //            count++;
        //        }

        //    }
        //    return count;
        //}

        public static List<Student> getAllStudent()
        {
            List<Student> list = new List<Student>();
            DataTable acount = Database.GetDataBySQL("select * from Student");
            foreach (DataRow dr in acount.Rows)
            {
                list.Add(new Student(
                      dr["ID"].ToString(),
                    dr["Name"].ToString(),
                    dr["Major"].ToString(),
                    Convert.ToBoolean(dr["Gender"]),
                   Convert.ToInt32(dr["AccountID"]),
                    Convert.ToDateTime(dr["DOB"]),
                    dr["Phone"].ToString(),
                    dr["City"].ToString()
                    ));
            }
            return list;
        }
        public static List<string> getStudentIDinClass(int classid)
        {
            List<string> list = new List<string>();
            DataTable da = Database.GetDataBySQL("select stuid from List_Class_Student where classid = " + classid);
            foreach(DataRow dr in da.Rows)
            {
                list.Add(dr["stuid"].ToString());
            }
            return list;
        }
        public static List<Student> ShowClass(int id)
        {
            List<Student> list = new List<Student>();

            DataTable data = Database.GetDataBySQL("SELECT s.* FROM [dbo].[Student] s join Account a on a.AccountID = s.AccountID" +
                 " join [dbo].[List_Class_Student] l on s.ID = l.stuid where l.classid = " + id);
            foreach(DataRow dr in data.Rows)
            {
                list.Add(new Student(
                     dr["ID"].ToString(),
                   dr["Name"].ToString(),
                   dr["Major"].ToString(),
                   Convert.ToBoolean(dr["Gender"]),
                  Convert.ToInt32(dr["AccountID"]),
                   Convert.ToDateTime(dr["DOB"]),
                   dr["Phone"].ToString(),
                   dr["City"].ToString()
                   ));
            }
            return list;
        }

    }

}
