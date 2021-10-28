
using ProjectAttendence.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProjectAttendence.Frm
{
    public partial class FrmAddMoreAccount : Form
    {
        public FrmAddMoreAccount()
        {
            InitializeComponent();
        }

     
        private void btnImportTeacher_Click(object sender, EventArgs e)
        {


            //List<TeacherAccount> userList = new List<TeacherAccount>();
            //try
            //{

            //    // mở file excel
            //    var package = new ExcelPackage(new FileInfo("Book1.xlsx"));

            //    // lấy ra sheet đầu tiên để thao tác
            //    ExcelWorksheet workSheet = package.Workbook.Worksheets[1];

            //    // duyệt tuần tự từ dòng thứ 2 đến dòng cuối cùng của file. lưu ý file excel bắt đầu từ số 1 không phải số 0
            //    for (int i = workSheet.Dimension.Start.Row + 1; i <= workSheet.Dimension.End.Row; i++)
            //    {
            //        try
            //        {
            //            // biến j biểu thị cho một column trong file
            //            int j = 1;

            //            // lấy ra cột họ tên tương ứng giá trị tại vị trí [i, 1]. i lần đầu là 2
            //            // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
            //            string Role = workSheet.Cells[i, j++].Value.ToString();

            //            string ID = workSheet.Cells[i, j++].Value.ToString();

            //            string Name = workSheet.Cells[i, j++].Value.ToString();

            //            string Department = workSheet.Cells[i, j++].Value.ToString();

            //            string Mail = workSheet.Cells[i, j++].Value.ToString();
            //            string Password = workSheet.Cells[i, j++].Value.ToString();

            //            var birthdayTemp = workSheet.Cells[i, j++].Value;

            //            string Address = workSheet.Cells[i, j++].Value.ToString();
            //            string Phone = workSheet.Cells[i, j++].Value.ToString();

            //            bool gender = Convert.ToBoolean(workSheet.Cells[i, j++].Value);
            //            // lấy ra cột ngày sinh tương ứng giá trị tại vị trí [i, 2]. i lần đầu là 2
            //            // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
            //            // lấy ra giá trị ngày tháng và ép kiểu thành DateTime                      

            //            DateTime dob = new DateTime();
            //            if (birthdayTemp != null)
            //            {
            //                dob = (DateTime)birthdayTemp;
            //            }

            //            /*                         

            //            Đừng lười biến mà dùng đoạn code này sẽ gây ra lỗi nếu giá trị value không thỏa kiểu DateTime

            //            DateTime birthday = (DateTime)workSheet.Cells[i, j++].Value;

            //             */


            //            // tạo UserInfo từ dữ liệu đã lấy được
            //            TeacherAccount user = new TeacherAccount(Role, ID, Name, Department, gender, Mail, Password, dob, Phone, Address);

            //            // add UserInfo vào danh sách userList
            //            userList.Add(user);

            //        }
            //        catch (Exception exe)
            //        {
            //            MessageBox.Show("Errosssr!");
            //        }
            //    }
            //}
            //catch (Exception ee)
            //{
            //    MessageBox.Show("Error!");
            //}

            //dgvAccount.DataSource = userList;
        }

        private void btnImportStu_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddMoreAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
