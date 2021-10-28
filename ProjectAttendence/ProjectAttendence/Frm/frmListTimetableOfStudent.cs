using ProjectAttendence.DAL;
using ProjectAttendence.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectAttendence.Frm
{
    public partial class frmListTimetableOfStudent : Form
    {
        int AccountID;

        public frmListTimetableOfStudent()
        {
            InitializeComponent();
        }

        public frmListTimetableOfStudent(int accountID) : this()
        {
            AccountID = accountID;
        }

        public string GetStudentbyAccountID()
        {
            string t = "";
            List<Student> teacher = Student.getAllStudent();
            foreach (Student item in teacher)
            {
                if (item.AccountID.Equals(AccountID))
                {
                    t = item.Id;
                }
            }
            return t;
        }
        public static DataTable getCourseAttendenceOfStudent(string stuid)
        {
            return Database.GetDataBySQL("select distinct c.[date] as 'Term',c.Code as 'Class',tt.[ID] as 'Teacher',ti.SubCode as 'Subject'" +
                " from Attendence a join Student st on a.StudentID = st.ID" +
                " join Timetable ti on a.TeachID = ti.ID" +
                " join Class c on c.ClassID = ti.ClassID " +
                " join Room r on r.RoomID = ti.RoomID" +
                " join Teacher tt on tt.ID = ti.TeacherID where st.ID = '"+stuid+"'");
        }

       

        private void frmListTimetableOfStudent_Load(object sender, EventArgs e)
        {
            
            dgvList.AutoGenerateColumns = false;

            string stuid = GetStudentbyAccountID();
            //  dgvList.DataSource = null;

            dgvList.Columns.Add("Term", "Term");
            dgvList.Columns["Term"].DataPropertyName = "Term";

            dgvList.Columns.Add("Class", "Class");
            dgvList.Columns["Class"].DataPropertyName = "Class";

            dgvList.Columns.Add("Teacher", "Teacher");
            dgvList.Columns["Teacher"].DataPropertyName = "Teacher";

            dgvList.Columns.Add("Subject", "Subject");
            dgvList.Columns["Subject"].DataPropertyName = "Subject";

            DataGridViewTextBoxColumn absent = new DataGridViewTextBoxColumn();
            absent.HeaderText = "Absent";
            absent.Name = "Absent";
            dgvList.Columns.Add(absent);

            DataGridViewButtonColumn btndetail = new DataGridViewButtonColumn();
            btndetail.HeaderText = "Detail";
            btndetail.Name = "Detail";
            btndetail.Text = "Detail";
            btndetail.UseColumnTextForButtonValue = true;
            dgvList.Columns.Add(btndetail);


            dgvList.DataSource = getCourseAttendenceOfStudent(stuid);
            string sub = "";
            string classcode = "";
            string datet = DateTime.Now.ToString("yyyy-MM-dd");
            for (int i = 0; i < dgvList.RowCount; i++)
            {
                sub = dgvList.Rows[i].Cells["Subject"].Value.ToString();
                classcode = dgvList.Rows[i].Cells["Class"].Value.ToString();

                double percent = Attendence.GetAbsent(stuid, classcode, sub,datet);
                dgvList.Rows[i].Cells["Absent"].Value =Math.Round((percent / 30) * 100) + " %";
                dgvList.Rows[i].DataGridView.AutoResizeColumn(4,
               DataGridViewAutoSizeColumnMode.DisplayedCells);

            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            label2.Visible = true;
            dgvDetail.Visible = true;
            dgvDetail.DataSource = null;
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                MessageBox.Show("No Course Attendence");
                return;
            }
            else
            {
                if (dgvList.Columns[e.ColumnIndex].Name.Equals("Detail"))
                {
                    

                    string subid = dgvList.Rows[e.RowIndex].Cells["Subject"].Value.ToString();
                    string cla = dgvList.Rows[e.RowIndex].Cells["Class"].Value.ToString();
                    string stuid = GetStudentbyAccountID();
                    string datee = DateTime.Now.ToString("yyyy-MM-dd");
                    dgvDetail.DataSource = Attendence.getDetailAttendOfStudent(stuid, cla, subid,datee);
                    dgvDetail.Columns[0].Visible = false;
                    dgvDetail.ReadOnly = true;
                    for(int i = 0; i < dgvDetail.RowCount; i++)
                    {   DateTime dateTime =Convert.ToDateTime( dgvDetail.Rows[i].Cells[1].Value);
                        if( dateTime <= DateTime.Now)
                        {
                            dgvDetail.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                        }
                        else
                        {
                            dgvDetail.Rows[i].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                    

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Close();
            frm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmProfile frm = new FrmProfile("Student", AccountID);
            this.Hide();
            frm.Show();
        }

       
    }
}
