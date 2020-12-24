using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuHoaVaChuThuong
{
    public partial class ChuHoaVaChuThuong : Form
    {
        public ChuHoaVaChuThuong()
        {
            InitializeComponent();
        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            if (rdoChuthuong.Checked == true)
                tbKetqua.Text = tbNhap.Text.ToLower();
            else if (rdoChuhoa.Checked == true)
                tbKetqua.Text = tbNhap.Text.ToUpper();
        }

        private void rdoChuthuong_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChuthuong.Checked == true)
                tbKetqua.Text = tbNhap.Text.ToLower();
        }

        private void rdoChuhoa_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChuhoa.Checked == true)
                tbKetqua.Text = tbNhap.Text.ToUpper();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbNhap.Clear();
            tbKetqua.Clear();
            tbNhap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}
