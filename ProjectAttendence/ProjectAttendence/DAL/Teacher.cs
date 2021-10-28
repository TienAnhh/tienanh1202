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
   public  class Teacher
    {
        private string id;
        private string name;
        private string major;
        private bool gender;
        private int accountID;
        private DateTime dob;
        private string phone;
        private string address;
        

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Major { get => major; set => major = value; }
        public bool Gender { get => gender; set => gender = value; }
        public int AccountID { get => accountID; set => accountID = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }

        public Teacher()
        {
        }

        public Teacher(string id, string name, string major, bool gender, int accountID, DateTime dob, string phone, string address)
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







        //  public string Major { get => major; set => major = value; }


        public static int AddTeacher(ArrayList arrayList)
        {
            string sql = @"insert into Teacher values (@ID,@Name,@Major,@gender,@DOB,@Phone,@City,@acc)";
            SqlParameter[] param = {new SqlParameter("@ID", SqlDbType.NVarChar),
                                    new SqlParameter("@Name", SqlDbType.NVarChar),
                                    new SqlParameter("@Major", SqlDbType.NVarChar),
                                    new SqlParameter("@gender", SqlDbType.NVarChar),
                                    new SqlParameter("@DOB", SqlDbType.DateTime),
                                    new SqlParameter("@Phone", SqlDbType.NVarChar),
                                    new SqlParameter("@City", SqlDbType.NVarChar),
                                    new SqlParameter("@acc", SqlDbType.Int)};
            for (int i = 0; i < arrayList.Count; i++)
            {
                param[i].Value = arrayList[i];
            }
            return Database.ExecuteSQL(sql, param);
        }
        public static DataTable getTeacherbyMajor(string admin)
        {
            return Database.GetDataBySQL("select a.[Active], b.[Name], a.Mail,a.[Role] from Account a join Teacher b on a.AccountID = b.AccountID where b.DepartID like '"+admin+"'");
        }
        public static DataTable getTeacher()
        {
            return Database.GetDataBySQL("select * from  Teacher");
        }

        public static List<Teacher> getAllTeacher()
        {
            List<Teacher> list = new List<Teacher>();
            DataTable acount = getTeacher();
            foreach (DataRow dr in acount.Rows)
            {
                
                       list.Add(new Teacher(
                    dr["ID"].ToString(),
                    dr["Name"].ToString(),
                    dr["DepartID"].ToString(),
                    Convert.ToBoolean( dr["Gender"]),
                   Convert.ToInt32(dr["AccountID"]),
                    Convert.ToDateTime(dr["DOB"]),
                    dr["Phone"].ToString(),
                    dr["City"].ToString()
                   ));

            }
            return list;
        }

        public static int UpdateTeacher(ArrayList array)
        {
            string sql = "Update Teacher set  [Name] = @name ,[DOB] = @dob ,[Phone] = @phone,[City] =@add where AccountID = @id";
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

    }
   
}
