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
    public partial class AdminManagement : Form
    {
        public AdminManagement()
        {
            InitializeComponent();
        }

        private void AdminManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            frmClass frmClass = new frmClass();
            frmClass.Show();
            this.Close();
        }



        private void btnSubject_Click(object sender, EventArgs e)
        {
            frmAddSubject frmAdd = new frmAddSubject();
            frmAdd.Show();
            this.Close();
        }

        private void btnStu_Click(object sender, EventArgs e)
        {
            frmCreateStudent frmCreateStudent = new frmCreateStudent();

            frmCreateStudent.Show();
            this.Close();
        }

       

        private void btnListAccount_Click(object sender, EventArgs e)
        {
            ListAccount listAccount = new ListAccount();
            listAccount.Show();
            this.Close();
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            frmAddTimetable frmAdd = new frmAddTimetable();
            frmAdd.Show();
            this.Close();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmLogin().Show();
        }
    }
}
