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
    public class Account
    {
        private int id;
        private string mail;
        private string password;
        private string role;
        private bool active;

        public int Id { get => id; set => id = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public bool Active { get => active; set => active = value; }

        public Account()
        {
        }

        public Account(int id, string mail, string password, string role, bool active)
        {
            this.id = id;
            this.mail = mail;
            this.password = password;
            this.role = role;
            this.active = active;
        }

        public static DataTable getAllAccount()
        {
            return Database.GetDataBySQL("select * from Account");
        }


      
        public static List<Account> accounts()
        {
            List<Account> list = new List<Account>();
            DataTable acount = getAllAccount();
            foreach (DataRow dr in acount.Rows)
            {
                list.Add(new Account(
                     Convert.ToInt32(dr["AccountID"].ToString()),
                    dr["Mail"].ToString(),
                    dr["Password"].ToString(),
                    dr["Role"].ToString(),
                    Convert.ToBoolean(dr["Active"])
                   ));
            }
            return list;
        }
      public static int UpdatePassword(string pass1, int id)
        {
            string sql = "Update Account set Password = @pass where AccountID = @id";
            SqlParameter[] sqls = new SqlParameter[]
            {
                new SqlParameter("@pass",SqlDbType.NVarChar),
                new SqlParameter("@id",SqlDbType.Int)
            };
            sqls[0].Value = pass1;
            sqls[1].Value = id;
            return Database.ExecuteSQL(sql, sqls);
        }
       
        public static int getIDforInsert(string mail)
        {
            DataTable data = Database.GetDataBySQL("select * from Account where Mail = '" + mail + "'");
            int id = 0;
            foreach(DataRow dr in data.Rows)
            {
                id =Convert.ToInt32( dr["AccountID"].ToString());
            }
            return id;
        }
        public static int AddAccount(ArrayList arrayList)
        {
            string sql = @"insert into Account values (@Mail,@pass,@ocu,@status)";
            SqlParameter[] param = {new SqlParameter("@Mail", SqlDbType.NVarChar),
                                    new SqlParameter("@pass", SqlDbType.NVarChar),
                                    new SqlParameter("@ocu", SqlDbType.NVarChar),
                                    new SqlParameter("@status",SqlDbType.Bit)};
            for(int i = 0; i < arrayList.Count; i++)
            {
                param[i].Value = arrayList[i];
            }

            return Database.ExecuteSQL(sql, param);
        }

    }
}
