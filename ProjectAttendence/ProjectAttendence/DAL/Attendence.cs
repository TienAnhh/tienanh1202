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
   public class Attendence
    {
        private int id;
        private DateTime date;
        private string name;
        private string studentID;
        private string classcode;
        private string subjectcode;
        private int slot;
        private string room;
        private bool isAttend;
        private string comment;

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Name { get => name; set => name = value; }
        public string StudentID { get => studentID; set => studentID = value; }
        public string Classcode { get => classcode; set => classcode = value; }
        public string Subjectcode { get => subjectcode; set => subjectcode = value; }
        public int Slot { get => slot; set => slot = value; }
        public string Room { get => room; set => room = value; }
        public bool IsAttend { get => isAttend; set => isAttend = value; }
        public string Comment { get => comment; set => comment = value; }
       

        public Attendence()
        {
        }

        public Attendence(int id, DateTime date, string name, string studentID, string classcode, string subjectcode, int slot, string room, bool status, string comment)
        {
            this.id = id;
            this.date = date;
            this.name = name;
            this.studentID = studentID;
            this.classcode = classcode;
            this.subjectcode = subjectcode;
            this.slot = slot;
            this.room = room;
            this.isAttend = status;
            this.comment = comment;
        }

        public static int Insert(ArrayList array)
        {
            string sql = "INSERT INTO [dbo].[Attendence]([TeachID],[StudentID],[isabsent] ,[comment]) VALUES(@ti,@st,@ab,@cmt)";
            SqlParameter[] sqls = new SqlParameter[]
            {
                new SqlParameter("@ti",SqlDbType.Int),
                 new SqlParameter("@st",SqlDbType.NVarChar),
                  new SqlParameter("@ab",SqlDbType.Bit),
                   new SqlParameter("@cmt",SqlDbType.NVarChar),
            };
            for(int i = 0; i < array.Count; i++)
            {
                sqls[i].Value = array[i];
            }
            return Database.ExecuteSQL(sql, sqls);
        }
        public static DataTable getCourseAttendence(string studentid)
        {
            return Database.GetDataBySQL("select c.[date] as 'Term',c.Code as 'Class',tt.[ID] as 'Teacher',ti.SubCode as 'Subject'" +
                " from Attendence a join Student st on a.StudentID = st.ID" +
                "  join Timetable ti on a.TeachID = ti.ID" +
                " join Class c on c.ClassID = ti.ClassID" +
                " join Room r on r.RoomID = ti.RoomID " +
                "join Teacher tt on tt.ID = ti.TeacherID where st.ID=" + studentid + "'");

        }
        public static DataTable getDetailAttendOfStudent(string studentid,string code, string sub,string date)
        {
            return Database.GetDataBySQL("select a.AttendID as 'ID',ti.[Date] as 'Date', tt.[Name] as 'Teacher', st.[Name] as 'Student',st.ID as 'StudentCode',c.Code as 'Class',ti.SubCode as 'Subject' ,ti.SlotID as 'Slot',r.RoomName as 'Room',a.isabsent as 'Attendence'" +
                             " from Attendence a join Student st on a.StudentID = st.ID " +
                             " join Timetable ti on a.TeachID = ti.ID" +
                             " join Class c on c.ClassID = ti.ClassID" +
                             " join Room r on r.RoomID = ti.RoomID" +
                             " join Teacher tt on tt.ID = ti.TeacherID" +
                             " where st.ID = '" + studentid + "' and c.Code ='"+code+"' and ti.SubCode ='"+sub+"'");

        }
      
        public static double GetAbsent(string stuID, string classID, string sub,string date)
        {
            double num = 0;
            DataTable data = Database.GetDataBySQL("select count(*) from Attendence a" +
                " join Student st on a.StudentID = st.ID  " +
                " join Timetable ti on a.TeachID = ti.ID" +
                " join Class c on c.ClassID = ti.ClassID" +
                " join Room r on r.RoomID = ti.RoomID" +
                " join Teacher tt on tt.ID = ti.TeacherID" +
                " where st.ID = '" + stuID + "' and  c.Code ='" + classID + "' and ti.SubCode='" + sub + "'and a.isabsent = 'false' and  ti.[Date] <='"+date+"'");
            foreach(DataRow dr in data.Rows)
            {
                num = Convert.ToDouble(dr[0].ToString());
            }
            return num;
        }

      
        public static DataTable getTimetabletbyTeacherAtCurrent(string teacherID,string date)
        {
            
            return Database.GetDataBySQL("select distinct ti.[Date],c.Code as 'Class'," +
                "r.RoomName as 'Room',ti.SubCode as 'Subject',ti.SlotID as 'Slot' " +
                "from Attendence a join Timetable ti on ti.ID = a.TeachID" +
                " join Teacher te on te.ID = ti.TeacherID" +
                " join Room r on r.RoomID = ti.RoomID" +
                " join Class c on c.ClassID = ti.ClassID" +
                " join Student st on st.ID = a.StudentID" +
                " join [Subject] s on s.SubjectCode = ti.SubCode " +
                "where ti.TeacherID = '"+teacherID+"' and ti.[Date] = '"+date+"'order by SlotID ASC");
        }
        public static DataTable getTimetableatCurrent(string teacherID, string date,int slot)
        {

            return Database.GetDataBySQL("select  a.AttendID as 'ID',st.ID as'Student Code',st.[Name] as 'Student Name', a.isabsent as 'Attend', a.comment as 'Comment'" +
                " from Attendence a join Timetable ti on ti.ID = a.TeachID" +
                " join Teacher te on te.ID = ti.TeacherID" +
                " join Room r on r.RoomID = ti.RoomID" +
                " join Class c on c.ClassID = ti.ClassID" +
                " join Student st on st.ID = a.StudentID" +
                " join [Subject] s on s.SubjectCode = ti.SubCode " +
                "where ti.TeacherID = '" + teacherID + "' and ti.[Date] = '" + date + "'and ti.SlotID = "+slot);
        }


        public static int CheckAttend(ArrayList arrayList)
        {
            string sql = "UPDATE [dbo].[Attendence] SET [isabsent] = @status ,[comment] = @cmt WHERE AttendID = @id";
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@status", SqlDbType.Bit),
                new SqlParameter("@cmt",SqlDbType.NVarChar),
                new SqlParameter("@id",SqlDbType.Int)
            };
            for(int i = 0; i < arrayList.Count; i++)
            {
                parameter[i].Value = arrayList[i];
            }
            return Database.ExecuteSQL(sql, parameter);
        }
        public static DataTable getDetailAttendforTeacher(string code, string sub, string teacher)
        {
            return Database.GetDataBySQL("select distinct st.ID,st.[Name] as 'Name',c.Code,ti.SubCode,r.RoomName,ti.SlotID" +
                " from Attendence a join Timetable ti on ti.ID = a.TeachID join Class c on c.ClassID = ti.ClassID" +
                " join Student st on st.ID = a.StudentID join Room r on r.RoomID = ti.RoomID" +
                " where ti.TeacherID = '" + teacher + "' and c.Code = '" + code + "' and ti.SubCode = '" + sub + "'");


        }




    }
    class ListAttend
    {
        
    }
    
}
