using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ProjectAttendence.DAL;
using ProjectAttendence.Frm;

namespace ProjectAttendence
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

      

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            List<string> list = new List<string>() { "Admin", "Teacher", "Student" };
            cbbRole.DataSource = list;
            cbbRole.SelectedIndex = 0;
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Mail = txtMail.Text.ToString() + "@fpt.edu.vn";
            List<Account> accounts = Account.accounts();

            int AccountID = 0;
                bool flag = false;
                foreach (Account a in accounts)
                {
                    if (a.Mail.Equals(Mail) && a.Password.Equals(txtPass.Text) && a.Role.Equals(cbbRole.SelectedValue))
                    {
                        flag = true;
                    AccountID = a.Id;
                    }
                }
                if (flag == true)
                {
                    if (cbbRole.SelectedValue.Equals("Admin"))
                    {
                    
                    AdminManagement newForm = new AdminManagement();
                    newForm.FormClosed += NewForm_FormClosed;
                    newForm.Show();
                    this.Hide();

                }
                    else if (cbbRole.SelectedValue.Equals("Teacher"))
                    {
                    frmTeacher newForm = new frmTeacher(AccountID);
                    newForm.FormClosed += NewForm_FormClosed;
                    newForm.Show();
                    this.Hide();

                }
                    else
                    {

                    frmListTimetableOfStudent newForm = new frmListTimetableOfStudent(AccountID);
                    newForm.FormClosed += NewForm_FormClosed;
                    newForm.Show();
                    this.Hide();
                    //MessageBox.Show("vvv");
                   
                }
            }
                else
                {
                    MessageBox.Show("Please check your account");
                }

        }

        private void NewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
