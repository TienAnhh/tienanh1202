using ProjectAttendence.DAL;
using ProjectAttendence.DAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectAttendence.Frm
{
    public partial class frmAddTimetable : Form
    {
        public frmAddTimetable()
        {
            InitializeComponent();
        }

        private void frmAddTimetable_Load(object sender, EventArgs e)
        {
            cbbClass.DataSource = Classes.getAllClass();
            cbbClass.DisplayMember = "Code";
            cbbClass.ValueMember = "ClassID";

            cbbTeacher.DataSource = Teacher.getAllTeacher();
            cbbTeacher.DisplayMember = "Name";
            cbbTeacher.ValueMember = "ID";

            cbbSubject.DataSource = Subject.getAllSubject();
            cbbSubject.DisplayMember = "Code";
            cbbSubject.ValueMember = "Code";

            cbbSlot.DataSource = Database.getAllSlot();
            cbbSlot.DisplayMember = "ID";
            cbbSlot.ValueMember = "ID";

            cbbRoom.DataSource = Database.GetDataBySQL("select * from Room");
            cbbRoom.DisplayMember = "RoomName";
            cbbRoom.ValueMember = "RoomID";
        }


        bool checkTimetable()
        {
            int slot = Convert.ToInt32(cbbSlot.SelectedValue.ToString());
            int code = Convert.ToInt32(cbbClass.SelectedValue.ToString());
            int room = Convert.ToInt32(cbbRoom.SelectedValue.ToString());
            string sub = cbbSubject.SelectedValue.ToString();
            string tea = cbbTeacher.SelectedValue.ToString();
            string day = dtpDate.Value.ToString("yyyy-MM-dd");
            if (dtpDate.Value.DayOfWeek.ToString().Equals("Sunday") )
            {
                MessageBox.Show("Timetable is not on Sunday ");
                return false;
            }

            if (!checkTimetableRoom(slot, day, room))
            {
                MessageBox.Show("This room has class in this time");
                return false;
            }
            if (!checkTimetableClass(slot, day, code))
            {
                MessageBox.Show("This  class has timetable in this time");
                return false;
            }
            if (!checkTimetableTeacher(slot, day, tea))
            {
                MessageBox.Show("This teacher has timetable in this time");
                return false;
            }
            //if (TimeTable.checkTimetable(slot, day, room, code, sub, tea, 3))
            //{
            //    MessageBox.Show("This room has class in this time");
            //    return false;
            //}
            if (!TimeTable.checkTimetable(slot, day, room, code, sub, tea))
            {
                MessageBox.Show("This timetable is exist");
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            int classid = Convert.ToInt32(cbbClass.SelectedValue.ToString());
            string teacher = cbbTeacher.SelectedValue.ToString();
            string subject = cbbSubject.SelectedValue.ToString();
            int slot = Convert.ToInt32(cbbSlot.SelectedValue);
            DateTime date = dtpDate.Value;
            int room = Convert.ToInt32(cbbRoom.SelectedValue.ToString());
            ArrayList arrayList = new ArrayList() { slot, date, room, classid, subject, teacher };
            List<string> list = Student.getStudentIDinClass(classid);
            if (!checkTimetable())
            {
                return;
            }
            else if (TimeTable.AddTimetable(arrayList) > 0)
            {
                int id = TimeTable.getTimeID(slot, date, room, classid, subject, teacher);
                bool attend = true;
                string cmt = "";
                if (id > 0)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        string stu = list[i];
                        ArrayList a = new ArrayList() { id, stu, attend, cmt };
                        if (Attendence.Insert(a) > 0)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Add Attendence of "+stu+"failed");
                            break;
                        }
                    }
                }



            }
            else MessageBox.Show("Add failed");
            //  this.Close();   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminManagement ad = new AdminManagement();
            this.Close();
            ad.Show();
        }
        static bool checkTimetableRoom(int slot, string date, int room)
        {
            // kiểm tra phòng trong 1 slot và 1 ngày

            string sql = "select * from Timetable where SlotID = " + slot + " and [Date] = '" + date + "'" +
            " and RoomID = " + room;
            DataTable data = Database.GetDataBySQL(sql);
            if (data.Rows.Count > 0)
            {
                return false;
            }
            return true;

        }
        static bool checkTimetableClass(int slot, string date, int code)
        {
            // kiểm tra Class trong 1 slot và 1 ngày

            string sql = "select * from Timetable where SlotID = " + slot + " and [Date] = '" + date + "'" +
            " and ClassID = " +code ;
            DataTable data = Database.GetDataBySQL(sql);
            if (data.Rows.Count > 0)
            {
                return false;
            }
            return true;

        }
        static bool checkTimetableTeacher(int slot, string date,string tea)
        {
            // kiểm tra Teacher trong 1 slot và 1 ngày

            string sql = "select * from Timetable where SlotID = " + slot + " and [Date] = '" + date + "'" +
            " and TeacherID = '" + tea+"'";
            DataTable data = Database.GetDataBySQL(sql);
            if (data.Rows.Count > 0)
            {
                return false;
            }
            return true;

        }
       
    }
}
