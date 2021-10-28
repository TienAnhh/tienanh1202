
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

//khai báo thư viện để xuất Excel
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace ProjectAttendence.Frm
{
    public partial class frmAttendence : Form
    {
        string V;
        int AccountID;
        string date;
        int slot;
        string classCode;
        string sub;
        public frmAttendence()
        {
            InitializeComponent();
        }

        public frmAttendence(string v,int accountID,string Date,int Slot,  string ClassCode,string Sub):this()
        {
            V = v;
            AccountID = accountID;
            date = Date;
            slot = Slot;
            classCode = ClassCode;
            sub = Sub;
        }
        public Teacher GetTeacherbyAccID()
        {
            Teacher a = new Teacher();
            List<Teacher> teacher = Teacher.getAllTeacher();
            foreach (Teacher item in teacher)
            {
                if (item.AccountID.Equals(AccountID))
                {
                    a = item;
                }
            }
            return a;
        }
        public Classes GetClassbyCode()
        {
            Classes cla = new Classes();
            List<Classes> c = Classes.getAllClass();
            foreach (Classes item in c)
            {
                if (item.Code.Equals(classCode))
                {
                    cla = item;
                }
            }
            return cla;
        }

        static List<DateTime> getList()
        {
            List<DateTime> list = new List<DateTime>();
            System.Data.DataTable data = Database.GetDataBySQL("select distinct [Date] from Timetable where [Date] <= (select GETDATE() as Date)  order by [Date] DESC");
            foreach(DataRow dr in data.Rows)
            {
                DateTime t =Convert.ToDateTime( dr[0].ToString());
                list.Add(t);
            }
            return list;
        }
        void refreshdgvAtt()
        {
            string tea = GetTeacherbyAccID().Id;

            if (V.Equals("check"))
            {
                lbl2.Visible = true;
                btnReset.Visible = true;
                cbbDate.Visible = true;
                
                cbbDate.DataSource = getList();
               
                

                btnSubmit.Visible = true;
                dgvListAtt.DataSource = Attendence.getTimetableatCurrent(tea, date, slot);
                dgvListAtt.Columns["ID"].Visible = false;
            }
            else
            {
                btnExport.Visible = true;
                dgvListAtt.AutoGenerateColumns = false;
               
                string datenow = DateTime.Now.ToString("yyyy-MM-dd");
                int classid = GetClassbyCode().ClassID;

                List<string> list = Student.getStudentIDinClass(classid);



                dgvListAtt.Columns.Add("id", "ID");
                dgvListAtt.Columns["id"].DataPropertyName = "ID";

                dgvListAtt.Columns.Add("name", "Full Name");
                dgvListAtt.Columns["name"].DataPropertyName = "Name";

                dgvListAtt.Columns.Add("cla", "Class");
                dgvListAtt.Columns["cla"].DataPropertyName = "Code";

                dgvListAtt.Columns.Add("sub", "Subject");
                dgvListAtt.Columns["sub"].DataPropertyName = "SubCode";

                dgvListAtt.Columns.Add("room", "Room");
                dgvListAtt.Columns["room"].DataPropertyName = "RoomName";

                dgvListAtt.Columns.Add("slot", "Slot");
                dgvListAtt.Columns["slot"].DataPropertyName = "SlotID";


                DataGridViewTextBoxColumn absent = new DataGridViewTextBoxColumn();
                absent.HeaderText = "Absent Percent";
                absent.Name = "AbsentPercent";
                dgvListAtt.Columns.Add(absent);

                dgvListAtt.DataSource = Attendence.getDetailAttendforTeacher(classCode, sub, tea);

               
                for (int i = 0;i<dgvListAtt.RowCount;i++)
                {
                   
                   string stu = list[i];
                 
                    double percent = Attendence.GetAbsent(stu, classCode, sub, datenow);
                    dgvListAtt.Rows[i].Cells[6].Value = Math.Round((percent / 30) * 100) + " %";
                    //
                    dgvListAtt.Rows[i].DataGridView.AutoResizeColumn(6, DataGridViewAutoSizeColumnMode.DisplayedCells);
                }

            }

        }
        public static System.Data.DataTable getTimetablebyDate(string teacherID, string tid, int slott)
        {

            return Database.GetDataBySQL("select  a.AttendID as 'ID',st.ID as'Student Code',st.[Name] as 'Student Name', a.isabsent as 'Attend'" +
                " from Attendence a join Timetable ti on ti.ID = a.TeachID" +
                " join Teacher te on te.ID = ti.TeacherID" +
                " join Room r on r.RoomID = ti.RoomID" +
                " join Class c on c.ClassID = ti.ClassID" +
                " join Student st on st.ID = a.StudentID" +
                " join [Subject] s on s.SubjectCode = ti.SubCode " +
                "where ti.TeacherID = '" + teacherID + "' and ti.Date= '" + tid + "' and ti.SlotID = " + slott);
        }
        private void cbbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tea = GetTeacherbyAccID().Id;
            DateTime datett = DateTime.Now;
            try
            {
                datett=Convert.ToDateTime (cbbDate.SelectedValue);
            }
            catch
            {

            }
            string tiID = datett.ToString("yyyy-MM-dd");

            dgvListAtt.DataSource = null;
                
            dgvListAtt.DataSource = getTimetablebyDate(tea,tiID,slot);
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            refreshdgvAtt();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (DataGridViewRow row in dgvListAtt.Rows)
            {

                bool c = Convert.ToBoolean(row.Cells["Attend"].Value);
                int Id =Convert.ToInt32( row.Cells[0].Value);
                string cmt = "";
                ArrayList array = new ArrayList() { c,cmt, Id };
                count += Attendence.CheckAttend(array);
            }
            if (count > 0)
            {
                MessageBox.Show("Check Attendence successfully");
                
            }
            refreshdgvAtt();
            
           
        }

        private void frmAttendence_Load(object sender, EventArgs e)
        {
            refreshdgvAtt();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            export2Excel(dgvListAtt, @"D:\", "List_Attendance_Student");

        }

        private void export2Excel(DataGridView g, string v1, string v2)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 20;
            int count = 0;
            //duyệt header của grivew
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            //duyệt từng bản ghi
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                        count++;
                    }
                }

            }
            if(count > 0)
            {
                MessageBox.Show("Export success");
            }
            else
            {
                MessageBox.Show("Export Failed");
            }
           
            obj.ActiveWorkbook.SaveCopyAs(v1 + v2 + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmTeacher frm = new frmTeacher(AccountID);
            this.Close();
            frm.Show();

        }

       
    }
   
}
