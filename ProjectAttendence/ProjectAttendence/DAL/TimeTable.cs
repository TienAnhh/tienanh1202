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
   public class TimeTable
    {
       
        private int slot;
        private DateTime date;
        private int roomID;
        private int ClassID;
        private string subCode;
        private string teacherID;

        public TimeTable( int slot, DateTime date, int roomID, int classID, string subCode, string teacherID)
        {
           
            this.slot = slot;
            this.date = date;
            this.roomID = roomID;
            ClassID = classID;
            this.subCode = subCode;
            this.teacherID = teacherID;
        }

        public int Slot { get => slot; set => slot = value; }
        public DateTime Date { get => date; set => date = value; }
        public int RoomID { get => roomID; set => roomID = value; }
        public int ClassID1 { get => ClassID; set => ClassID = value; }
        public string SubCode { get => subCode; set => subCode = value; }
        public string TeacherID { get => teacherID; set => teacherID = value; }

        public static int AddTimetable(ArrayList arrayList)
        {
            string sql = "INSERT INTO [dbo].[Timetable]([SlotID],[Date],[RoomID],[ClassID],[SubCode],[TeacherID]) " +
                "VALUES (@slot,@date,@room,@class,@sub,@tea)";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@slot",SqlDbType.Int),
                 new SqlParameter("@date",SqlDbType.DateTime),
                  new SqlParameter("@room",SqlDbType.Int),
                   new SqlParameter("@class",SqlDbType.Int),
                    new SqlParameter("@sub",SqlDbType.NVarChar),
                     new SqlParameter("@tea",SqlDbType.NVarChar)

            };
            for (int i = 0; i < arrayList.Count; i++)
            {
                sqlParameter[i].Value = arrayList[i];
            }
            return Database.ExecuteSQL(sql, sqlParameter);
        }

        public static DataTable getCourseAttendenceOfStudent(string stuid)
        {
            return Database.GetDataBySQL("select c.[date] as 'Term',c.Code as 'Class',tt.[ID] as 'Teacher',ti.SubCode as 'Subject'" +
                "  from Attendence a join Student st on a.StudentID = st.ID " +
                " join Timetable ti on a.TeachID = ti.ID join Class c on c.ClassID = ti.ClassID " +
                " join Room r on r.RoomID = ti.RoomID join Teacher tt on tt.ID = ti.TeacherID where st.ID='" + stuid + "'");
        }
        public static int getTimeID(int slot,DateTime date, int room, int classid,string sub, string teacher)
        {
            int id = 0;
            DataTable da = Database.GetDataBySQL("select ID from Timetable " +
                                                  "where SlotID =" + slot + " and [Date] = '" + date + "' " +
                                                  " and RoomID = " + room + " and ClassID = " + classid + "" +
                                                  " and SubCode = '" + sub + "' and TeacherID ='" + teacher + "'");
            foreach(DataRow dr in da.Rows)
            {
                id = Convert.ToInt32(dr["ID"].ToString());
            }
            return id;
        }
        public static bool checkTimetable(int slot, string date,int room, int code,string sub, string teacher)
        {
           
                string sql = "select * from Timetable where SlotID = " + slot + " and [Date] = '" + date + "'" +
                "and RoomID = " + room + " and ClassID = " + code + " and SubCode = '" + sub + "' and TeacherID= '" + teacher + "'";
                DataTable data = Database.GetDataBySQL(sql);
                if (data.Rows.Count > 0)
                {
                    return false;
                }
            
           
            
            return true;
        }
    }
}
