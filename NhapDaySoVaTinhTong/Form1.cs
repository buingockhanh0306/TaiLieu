using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhapDaySoVaTinhTong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {    
            tbDay.Text = tbDay.Text + " " + tbNhap.Text;
            int n = Convert.ToInt32(tbNhap.Text);           
            tbTong.Text = ( Convert.ToInt32(tbTong.Text) + n).ToString();
            if (n % 2 == 0)
                tbTongChan.Text = (Convert.ToInt32(tbTongChan.Text) + n).ToString();
            else
                tbTongLe.Text = (Convert.ToInt32(tbTongLe.Text) + n).ToString();
            tbNhap.Clear();
            tbNhap.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbTong.Text = "0";
            tbTongChan.Text = "0";
            tbTongLe.Text = "0";
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            tbNhap.Clear();
            tbDay.Clear();
            tbTong.Clear();
            tbTongChan.Clear();
            tbTongLe.Clear();
            tbNhap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void tbNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar!='-')
                e.Handled = true;
        }
    }
}
