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
    public partial class ListAccount : Form
    {
        public ListAccount()
        {
            InitializeComponent();
        }

        void refreshdgv()
        {
            dgvAccount.DataSource = null;
            dgvAccount.DataSource = Database.GetDataBySQL("select Active,AccountID,Mail,[Role] from Account where Role not like 'Admin'"); ;

        }
        private void ListAccount_Load(object sender, EventArgs e)
        {


            refreshdgv();

            List<string> list = new List<string>() { "Teacher", "Student" };
            cbbRole.DataSource = list;
            cbbRole.SelectedIndex = 0;

            label3.Text = "Department:";
            cbbMajor.DataSource = Database.getAllDepart();
            cbbMajor.DisplayMember = "departName";
            cbbMajor.ValueMember = "departid";

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string role = cbbRole.SelectedValue.ToString();
            string major = cbbMajor.SelectedValue.ToString();

            if (role.Equals("Teacher"))
            {
                dgvAccount.DataSource = Teacher.getTeacherbyMajor(major);

            }
            else
            {
                dgvAccount.DataSource = Student.getStudentbyMajor(major);
            }
        }

       

       

        private void btnReset_Click(object sender, EventArgs e)
        {
            refreshdgv();
        }

        private void btnDeactive_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dgvAccount.Rows)
            {
               
                DataGridViewCheckBoxCell boxCell = row.Cells["Active"] as DataGridViewCheckBoxCell;
                if (Convert.ToBoolean(boxCell.Value) == true)
                {
                    int id =Convert.ToInt32( row.Cells["AccountID"].Value);
                    count += Database.DeativeAccount(id);
                }

            }
            if(count > 0)
            {
                refreshdgv();
            }
        }

        private void cbbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbRole.SelectedValue.ToString().Equals("Teacher"))
            {
                label3.Text = "Department:";
                cbbMajor.DataSource = Database.getAllDepart();
                cbbMajor.DisplayMember = "departName";
                cbbMajor.ValueMember = "departid";
            }
            else
            {
                label3.Text = "Major:";
                List<string> major = new List<string>() { "SE", "AI" };
                cbbMajor.DataSource = major;
                cbbMajor.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminManagement ad = new AdminManagement();
            this.Close();
            ad.Show();
        }

        private void btnStu_Click(object sender, EventArgs e)
        {
            frmCreateStudent frmCreateStudent = new frmCreateStudent();

            frmCreateStudent.Show();
            this.Close();
        }
    }
}
