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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjectAttendence.Frm
{
    public partial class frmAddSubject : Form
    {
        public frmAddSubject()
        {
            InitializeComponent();
        }

         void refreshes()
        {
            dgvSubject.DataSource = null;
            cbbDepart.DataSource = Database.getAllDepart();
            cbbDepart.DisplayMember = "departName";
            cbbDepart.ValueMember = "departid";
            dgvSubject.DataSource = Subject.getAllSubject();

        }
        bool check()
        {
            if (txtName.Text.Length == 0 || txtCode.Text.Length == 0)
            {
                MessageBox.Show("Please fill all ");
                return false;
            }
            return true;
        }
        private void frmAddSubject_Load(object sender, EventArgs e)
        {
            refreshes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text.Trim();
            string name = txtName.Text.Trim();
            string depart = cbbDepart.SelectedValue.ToString();
            ArrayList arrayList = new ArrayList() { code, name,depart };
            if (!check())
            {
                return;
            }
            else if (Subject.AddSubject(arrayList) > 0)
            {
                MessageBox.Show("Add subject successed");

            }
            else
            {
                MessageBox.Show("Add subject failed");
            }
            refreshes();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminManagement ad = new AdminManagement();
            this.Close();
            ad.Show();
        }
    }
}
