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
    public partial class frmAddtoClass : Form
    {
        int id;

        public frmAddtoClass()
        {
            InitializeComponent();
        }

        public frmAddtoClass(int Id):this()
        {
            id = Id;
        }

        private void frmAddtoClass_Load(object sender, EventArgs e)
        {
          
            cbbStudent.DataSource = Database.GetDataBySQL("select ID from Student except select stuid from List_Class_Student");
            cbbStudent.DisplayMember = "ID";
            cbbStudent.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string stuid = cbbStudent.SelectedValue.ToString();
            ArrayList array = new ArrayList() { stuid, id };
            if(Database.AddToClass(array) > 0)
            {
                MessageBox.Show("Add student to class successed");
                return;
               
            }
            else
            {
                MessageBox.Show("Add student to class failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmClass frm = new frmClass();
            this.Close();
            frm.Show();
        }
    }
}
