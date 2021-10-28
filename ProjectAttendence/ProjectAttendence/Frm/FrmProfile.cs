using ProjectAttendence.DAL;
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
    public partial class FrmProfile : Form
    {
        string role;
        int AccountID;

        public FrmProfile()
        {
            InitializeComponent();
        }

        public FrmProfile(string v, int accountID):this()
        {
            role = v;
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
        public Student GetStudentbyAccountID()
        {
            Student st = new Student();
            List<Student> teacher = Student.getAllStudent();
            foreach (Student item in teacher)
            {
                if (item.AccountID.Equals(AccountID))
                {
                    st = item;
                }
            }
            return st;
        }
        public Account GetAccountbyID()
        {
            Account a = new Account();
            List<Account> acc= Account.accounts();
            foreach (Account item in acc)
            {
                if (item.Id.Equals(AccountID))
                {
                    a = item;
                }
            }
            return a;
        }
        bool checkPass()
        {
            if(!Regex.IsMatch(txtPass1.Text,"@^[a-zA-Z0-9]{8,31}$") || !Regex.IsMatch(txtPass2.Text, "@^[a-zA-Z0-9]{8,31}$"))
            {
                MessageBox.Show("Password has length from 8 characters to 31 characters");
                return false;
            }
            if (!txtPass1.Text.Equals(txtPass2.Text))
            {
                MessageBox.Show("Please check password");
                return false;
            }
            if (!Regex.IsMatch(txtPhone.Text, @"^0[0-9]{9}$"))
            {
                MessageBox.Show("Phone formats 0xxxxxxxxx ");
            }
            return true;
        }
        
        private void btnChange_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;

            string pass = txtPass1.Text.Trim();
            if (!checkPass())
            {
                return;
            }
            else
            {
                if(Account.UpdatePassword(pass,AccountID) > 0)
                {
                    MessageBox.Show("Update password successed!");
                }
                else
                {
                    MessageBox.Show("Update password failed!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAdd.Text.Trim();
            DateTime date = txtTime.Value;
            ArrayList array = new ArrayList() { name, date, phone, address, id };
            if (role.Equals("Teacher"))
            {
                if(Teacher.UpdateTeacher(array) > 0)
                {
                    MessageBox.Show("Update your profile successed!");
                }
                else
                {
                    MessageBox.Show("Update your profile failed!");
                }
            }
            else
            {
                if(Student.UpdateStudent(array) > 0) 
                {
                    MessageBox.Show("Update your profile successed!");
                }
                else
                {
                    MessageBox.Show("Update your profile failed!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (role.Equals("Teacher"))
            {
                new frmTeacher(AccountID).Show();
                this.Hide();
            }
            else
            {
                new frmListTimetableOfStudent(AccountID).Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            if (role.Equals("Teacher"))
            {
                txtID.Text = GetTeacherbyAccID().Id;
                txtName.Text = GetTeacherbyAccID().Name;
                txtMajor.Text = GetTeacherbyAccID().Major;
                txtPhone.Text = GetTeacherbyAccID().Phone;
                txtAdd.Text = GetTeacherbyAccID().Address;
                txtTime.Value = GetTeacherbyAccID().Dob;
                txtAccount.Text = GetAccountbyID().Mail;

            }
            else
            {
                txtID.Text = GetStudentbyAccountID().Id;
                txtName.Text = GetStudentbyAccountID().Name;
                txtMajor.Text = GetStudentbyAccountID().Major;
                txtPhone.Text = GetStudentbyAccountID().Phone;
                txtAdd.Text = GetStudentbyAccountID().Address;
                txtTime.Value = GetStudentbyAccountID().Dob;
                txtAccount.Text = GetAccountbyID().Mail;
            }
            
        }
    }
}
