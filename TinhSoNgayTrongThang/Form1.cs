using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhSoNgayTrongThang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string HienThi(int n, int t)
        {
            string A;
            A = "Số ngày của tháng " + t + " trong năm " + n + " là: ";
            return A;
        }
        private void btnThucHien_Click(object sender, EventArgs e)
        {          
            int nam = Convert.ToInt32(tbNam.Text);
            int thang = Convert.ToInt32(tbThang.Text);
            if (thang <= 0 || thang > 12) MessageBox.Show("Bạn đã nhập sai tháng!");
            else
            {
                if (nam % 4 == 0 && thang == 2) tbHienThi.Text = HienThi(nam, thang) + "29";
                else
                {
                    switch (thang)
                    {
                        case 1:
                            tbHienThi.Text = HienThi(nam, thang) + "31";
                            break;
                        case 2:
                            tbHienThi.Text = HienThi(nam, thang) + "28";
                            break;
                        case 3:
                            tbHienThi.Text = HienThi(nam, thang) + "31";
                            break;
                        case 4:
                            tbHienThi.Text = HienThi(nam, thang) + "30";
                            break;
                        case 5:
                            tbHienThi.Text = HienThi(nam, thang) + "31";
                            break;
                        case 6:
                            tbHienThi.Text = HienThi(nam, thang) + "30";
                            break;
                        case 7:
                            tbHienThi.Text = HienThi(nam, thang) + "31";
                            break;
                        case 8:
                            tbHienThi.Text = HienThi(nam, thang) + "31";
                            break;
                        case 9:
                            tbHienThi.Text = HienThi(nam, thang) + "30";
                            break;
                        case 10:
                            tbHienThi.Text = HienThi(nam, thang) + "31";
                            break;
                        case 11:
                            tbHienThi.Text = HienThi(nam, thang) + "30";
                            break;
                        case 12:
                            tbHienThi.Text = HienThi(nam, thang) + "31";
                            break;
                    }
                }
            }
              
        }

        private void tbNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            tbHienThi.Clear();
            tbNam.Clear();
            tbThang.Clear();
            tbNam.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
   
}
