using ProjectAttendence.DAL;
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
    public partial class frmTeacher : Form
    {
         int AccountID;

        public frmTeacher()
        {
            InitializeComponent();
        }

        public frmTeacher(int accountID):this()
        {
            AccountID = accountID;
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

        private void frmTeacher_Load(object sender, EventArgs e)
        {
           
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string teacher = GetTeacherbyAccID().Id;
            lblmail.Text = teacher + "@fpt.edu.vn";
            dgvTeacher.DataSource = Attendence.getTimetabletbyTeacherAtCurrent(teacher, date);

            DataGridViewButtonColumn select = new DataGridViewButtonColumn();
            select.Width = 150;
            select.Name = "check_attendance";
            select.Text = "Check attendance";
            select.HeaderText = "Check attendance";
            select.UseColumnTextForButtonValue = true;
            dgvTeacher.Columns.Add(select);

            // bổ sung button View attendance vào bên phải
            DataGridViewButtonColumn selectview = new DataGridViewButtonColumn();
            selectview.Width = 150;
            selectview.Name = "view_attendance";
            selectview.Text = "View attendance";
            selectview.HeaderText = "View attendance";
            selectview.UseColumnTextForButtonValue = true;
            dgvTeacher.Columns.Add(selectview);
            // nêu click vào button thì hiển thị frmListStudentForClass
            //dgvTeacher.CellClick += dgvTeacher_CellClick;

        }

        private void dgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvTeacher.Columns["check_attendance"].Index)
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                int slot = Convert.ToInt32(dgvTeacher.Rows[e.RowIndex].Cells["Slot"].Value.ToString());
                string classCode = dgvTeacher.Rows[e.RowIndex].Cells["Class"].Value.ToString();
                string sub = dgvTeacher.Rows[e.RowIndex].Cells["Subject"].Value.ToString();
                frmAttendence frm = new frmAttendence("check",AccountID, date,slot,classCode,sub);
                frm.FormClosed += frm_FormClosed;
                this.Hide();
                frm.Show();
            }
            if (e.ColumnIndex == dgvTeacher.Columns["view_attendance"].Index)
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                int slot = Convert.ToInt32(dgvTeacher.Rows[e.RowIndex].Cells["Slot"].Value.ToString());
                string classCode = dgvTeacher.Rows[e.RowIndex].Cells["Class"].Value.ToString();
                string sub = dgvTeacher.Rows[e.RowIndex].Cells["Subject"].Value.ToString();
                frmAttendence frm = new frmAttendence("view", AccountID, date, slot,classCode,sub);
                frm.FormClosed += frm_FormClosed;
                this.Hide();
                frm.Show();
            }
        }

        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Close();
            frm.Show();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmProfile frm = new FrmProfile("Teacher", AccountID);
            this.Hide();
            frm.Show();
        }
    }
}
