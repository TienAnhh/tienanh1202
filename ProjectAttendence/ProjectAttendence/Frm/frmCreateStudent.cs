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
    public partial class frmCreateStudent : Form
    {
        public frmCreateStudent()
        {
            InitializeComponent();
        }

        private void frmCreateStudent_Load(object sender, EventArgs e)
        {
            List<string> roles = new List<string>() { "Teacher", "Student" };
            cbbrole.DataSource = roles;
            cbbrole.SelectedIndex = 0;
            label4.Text = "Department:";


            cbbMajor.DataSource = Database.getAllDepart();
            cbbMajor.DisplayMember = "departName";
            cbbMajor.ValueMember = "departid";

        }
        bool checke()
        {
            List<Account> accounts = Account.accounts();
            int count = 0;
            foreach(Account a in accounts)
            {
                if (txtMail.Text.Equals(a.Mail))
                {
                    count++;
                   
                }
            }
            if(count > 0)
            {
                txtID.Focus();
                MessageBox.Show("Account is exist");

                return false;
            }
            if (txtID.Text.Equals("") || txtName.Text.Equals("") || txtMail.Text.Equals(""))
            {
                MessageBox.Show("ID, Name, Password, Address is not null");
                return false;
            }
            
            if(txtPass.Text.Length< 8) {
                txtPass.Focus();
                MessageBox.Show("Password must have at least 8 characters");
                return false;
            }
            if (!txtPass.Text.Equals(txtPass2.Text.Trim()))
            {
                txtPass2.Focus();
                MessageBox.Show("Password is wrong!");
                
                return false;
            }
            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^0[1-9]{9}$"))
            {
                txtPhone.Focus();
                MessageBox.Show("Phone must folow fomat 0xxxxxxxxx");
                return false;
            }
            return true;

        }
        void refreshChoice()
        {
            txtID.Text = "";
            txtMail.Text = "";
            txtName.Text = "";
            txtPass.Text = "";
            txtPass2.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            dtpdob.Value = DateTime.Now;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string role = cbbrole.SelectedValue.ToString();
            string id = txtID.Text.Trim();
            string name = txtName.Text.Trim();
            string major = cbbMajor.SelectedValue.ToString();
            string mail = txtMail.Text.Trim() ;
            string pass = txtPass.Text.Trim();
            DateTime dob = dtpdob.Value;
            string address = txtAddress.Text.Trim();
            string phone = txtPhone.Text.Trim();
            bool gender = cbbGender.Checked;
            bool status = true;
           
            ArrayList array = new ArrayList() { mail, pass, role, status };
            int accid = 0;
            if (!checke())
            {
                return;
            }
            else if (role.Equals("Teacher"))
            {
                if (Account.AddAccount(array) > 0)
                {
                    accid = Account.getIDforInsert(mail);
                   if(accid > 0)
                    {
                        ArrayList arrayList = new ArrayList() { id, name, major, gender, dob, phone, address,accid };
                        if (Teacher.AddTeacher(arrayList) > 0)
                        {
                            refreshChoice();
                            MessageBox.Show("Add Teacher successed");
                            
                        }
                        else
                        {
                            MessageBox.Show("Add Teacher failed");
                        }
                    }
                    
                   
                }

            }
            else
            {

                if (Account.AddAccount(array) > 0)
                {
                    accid = Account.getIDforInsert(mail);
                    if (accid > 0)
                    {
                        ArrayList arrayList = new ArrayList() { id, name, major, gender, dob, phone, address, accid };
                        if (Student.AddStudent(arrayList) > 0)
                        {
                            refreshChoice();
                            MessageBox.Show("Add Student successed");
                            
                        }
                        else
                        {
                            MessageBox.Show("Add Student failed");
                        }
                    }
                    

                }

             
            }

        }

        private void cbbrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbrole.SelectedValue.ToString().Equals("Teacher"))
            {
                label4.Text = "Department:";
                cbbMajor.DataSource = Database.getAllDepart();
                cbbMajor.DisplayMember = "departName";
                cbbMajor.ValueMember = "departid";
            }
            else
            {

                label4.Text = "Major:";
                List<string> major = new List<string>() { "SE", "AI" };
                cbbMajor.DataSource = major;
                cbbMajor.SelectedIndex = 0;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            string id = txtID.Text;
            txtMail.Text = id + "@fpt.edu.vn";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminManagement ad = new AdminManagement();
            this.Close();
            ad.Show();
        }

        private void btnAddMore_Click(object sender, EventArgs e)
        {
            
            FrmAddMoreAccount frmAdd = new FrmAddMoreAccount();
            frmAdd.Show();
            this.Close();
        }
    }
}
