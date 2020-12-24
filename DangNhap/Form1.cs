using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DangNhap
{
    public partial class DangNhap : Form
    {
        string strConnection = @"Data Source=DESKTOP-P4E3NTN\BUIKHANH1;Initial Catalog=login;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string username = "khanh";
            string password = "12345678";
            if (tbTen.Text == username && tbMatkhau.Text == password)
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Bạn đã nhập sai tên người dùng hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //conn = new SqlConnection(strConnection);
            //conn.Open();
            //string sql = "Select Count(*) from [login].[dbo].[Table_1] where user=@acc And password=@pass";
            //command = new SqlCommand(sql, conn);
            //command.Parameters.Add(new SqlParameter("@acc", tbTen.Text));
            //command.Parameters.Add(new SqlParameter("@pass", tbMatkhau.Text));
            ////int x = (int)command.ExecuteScalar();
            //SqlDataReader dta = command.ExecuteReader();
            //if(dta.Read()==true)
            //{
            //    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Bạn đã nhập sai tên người dùng hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if
            (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
            
        }

        private void cbxMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMatKhau.Checked == true)
                tbMatkhau.UseSystemPasswordChar = false;
            else
                tbMatkhau.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxMatKhau.Checked = false;
            tbMatkhau.UseSystemPasswordChar = true; 
        }
    }
}
