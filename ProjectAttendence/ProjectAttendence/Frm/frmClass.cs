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
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();
        }

        public bool validate()
        {
            if (!Regex.IsMatch(txtCode.Text.Trim(), @"^[A-Z]{2,3}[0-9]{4}$"))
            {
                MessageBox.Show("Class code must be followed SE1428");
                txtCode.Focus();
                return false;
            }
          
            return true;
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
                txtCode.Enabled = true;                    
                btnSave.Enabled = true;
                cbbTime.Enabled = true;

        }
        public void refresh()
        {
            dgvShow.Visible = false;

            dgvClass.DataSource = null;

            dgvClass.DataSource = Classes.getAllClass();
            cbbTime.DataSource = Database.getAllDateClass();
            cbbTime.DisplayMember = "dateID";
            cbbTime.ValueMember = "dateID";

            dgvClass.DataSource = Classes.getAllClass();



        }
      
        private void frmClass_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Action";
            btn.Name = "Show";
            btn.Text = "Show";
            btn.UseColumnTextForButtonValue = true;
            dgvClass.Columns.AddRange(btn);

            DataGridViewButtonColumn btnadd = new DataGridViewButtonColumn();
            btnadd.HeaderText = "Add To Class";
            btnadd.Name = "Add";
            btnadd.Text = "Add";
            btnadd.UseColumnTextForButtonValue = true;
            dgvClass.Columns.AddRange(btnadd);

            refresh();

          

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
     
            string code =  txtCode.Text.Trim();
            string time = cbbTime.SelectedValue.ToString();
            int ac = 1;
            ArrayList arrayList = new ArrayList() { code, ac , time };
            if (!validate())
            {
                return;
            }
            else if (Classes.AddClass(arrayList) > 0)
            {
                MessageBox.Show("Add new class sucessed");
            }
            else
            {
                MessageBox.Show("Add new class failed");

            }
            refresh();


        }

        private void btnSearchClass_Click(object sender, EventArgs e)
        {
            string code = txtClassCode.Text.ToString();
            if(code == "")
            {
                MessageBox.Show("Please enter word you want to search");
                txtClassCode.Focus();
            }
           else
            if (Classes.SearchClass(code).Count > 0)
            {
                dgvClass.DataSource = null;
                dgvClass.DataSource = Classes.SearchClass(code);
            }
            else
            {
                MessageBox.Show("Not found the classes");
                refresh();
            }
        }


        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            if (e.ColumnIndex == dgvClass.Columns["Show"].Index)
            {
                dgvShow.Visible = true;
                label4.Visible = true;
                int id = Convert.ToInt32( dgvClass.Rows[e.RowIndex].Cells[2].Value);
                string code = dgvClass.Rows[e.RowIndex].Cells[3].Value.ToString();
                label4.Text = "List Student in Class " + code;

                dgvShow.DataSource = Student.ShowClass(id);
                dgvShow.Columns["AccountID"].Visible = false;


            }
            else if (e.ColumnIndex == dgvClass.Columns["Add"].Index)
            {
                int id = Convert.ToInt32(dgvClass.Rows[e.RowIndex].Cells[2].Value);
                int num = Classes.NumberStudent(id);
                if(num >= 30)
                {
                    MessageBox.Show("This class is full");
                    refresh();
                }
                else
                {
                    frmAddtoClass frm = new frmAddtoClass(id);
                    this.Hide();
                    frm.Show();
                }
              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new AdminManagement().Show();

        }
    }
}
