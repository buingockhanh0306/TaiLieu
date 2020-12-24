using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiemTraSoNguyenTo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool KiemTra(int n)
        {
            int dem = 0;
            if (n == 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) dem = dem + 1;
            }
            if (dem == 0) return true;
            else return false;
        }
        public void TimKiem(int n)
        {
            if (n <= 2) tbTimKiem.Text = "Không có SNT nào nhỏ hơn";
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (KiemTra(i)) tbTimKiem.Text = tbTimKiem.Text + " " + Convert.ToString(i);
                }
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {       
            tbKiemTra.Clear();
            tbTimKiem.Clear();
            int n = Convert.ToInt32(tbNhap.Text);
            if (KiemTra(n)) tbKiemTra.Text = "Đây là số nguyên tố";
            else tbKiemTra.Text = "Đây không phải là số nguyên tố";
            TimKiem(n);
        }

        private void tbNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            tbNhap.Clear();
            tbKiemTra.Clear();
            tbTimKiem.Clear();
            tbNhap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}

