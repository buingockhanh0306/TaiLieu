using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhepTinhPhanSo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int UCLN(int a, int b)
        {
            while(a!=b)
            {
                if (a < b)
                    b = b - a;
                else
                    a = a - b;
            }
            return a;
        }
        public int BCNN(int a, int b)
        {
            return a * b / UCLN(a, b);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (tbMauSo1.Text == "0" || tbMauSo2.Text == "0")
                MessageBox.Show("Vui lòng nhập mẫu số khác 0!");
            else
            {
                int tu1 = Convert.ToInt32(tbTuSo1.Text);
                int mau1 = Convert.ToInt32(tbMauSo1.Text);
                int tu2 = Convert.ToInt32(tbTuSo2.Text);
                int mau2 = Convert.ToInt32(tbMauSo2.Text);
                int tuso = 0;
                int mc = BCNN(mau1, mau2);
                tuso = (mc / mau1) * tu1 + (mc / mau2) * tu2;
                int tu = tuso;
                tuso = tuso / UCLN(Math.Abs(tuso), mc);
                mc = mc / UCLN(Math.Abs(tu), mc);
                tbTuKQ.Text = tuso.ToString();
                tbMauKQ.Text = mc.ToString();
                lbKetQua.Text = "Kết quả của phép cộng:";
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (tbMauSo1.Text == "0" || tbMauSo2.Text == "0")
                MessageBox.Show("Vui lòng nhập mẫu số khác 0!");
            else
            {
                int tu1 = Convert.ToInt32(tbTuSo1.Text);
                int mau1 = Convert.ToInt32(tbMauSo1.Text);
                int tu2 = Convert.ToInt32(tbTuSo2.Text);
                int mau2 = Convert.ToInt32(tbMauSo2.Text);
                int tuso = 0;
                int mc = BCNN(mau1, mau2);
                tuso = (mc / mau1) * tu1 - (mc / mau2) * tu2;
                int tu = tuso;
                tuso = tuso / UCLN(Math.Abs(tuso), mc);
                mc = mc / UCLN(Math.Abs(tu), mc);
                tbTuKQ.Text = tuso.ToString();
                tbMauKQ.Text = mc.ToString();
                lbKetQua.Text = "Kết quả của phép trừ:";
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (tbMauSo1.Text == "0" || tbMauSo2.Text == "0")
                MessageBox.Show("Vui lòng nhập mẫu số khác 0!");
            else
            {
                int tu1 = Convert.ToInt32(tbTuSo1.Text);
                int mau1 = Convert.ToInt32(tbMauSo1.Text);
                int tu2 = Convert.ToInt32(tbTuSo2.Text);
                int mau2 = Convert.ToInt32(tbMauSo2.Text);
                int tuso = tu1 * tu2;
                int mc = mau1 * mau2;
                tbTuKQ.Text = (tuso / UCLN(Math.Abs(tuso), mc)).ToString();
                tbMauKQ.Text = (mc / UCLN(Math.Abs(tuso), mc)).ToString();
                lbKetQua.Text = "Kết quả của phép nhân:";
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (tbMauSo1.Text == "0" || tbMauSo2.Text == "0")
                MessageBox.Show("Vui lòng nhập mẫu số khác 0!");
            else
            {
                int tu1 = Convert.ToInt32(tbTuSo1.Text);
                int mau1 = Convert.ToInt32(tbMauSo1.Text);
                int tu2 = Convert.ToInt32(tbTuSo2.Text);
                int mau2 = Convert.ToInt32(tbMauSo2.Text);
                int tuso = tu1 * mau2;
                int mc = mau1 * tu2;
                tbTuKQ.Text = (tuso / UCLN(tuso, mc)).ToString();
                tbMauKQ.Text = (mc / UCLN(tuso, mc)).ToString();
                lbKetQua.Text = "Kết quả của phép chia:";
            }
        }

        private void tbTuSo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbMauSo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }            
        }

        private void tbTuSo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbMauSo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            tbTuSo1.Clear();
            tbMauSo1.Clear();
            tbTuSo2.Clear();
            tbMauSo2.Clear();
            tbTuKQ.Clear();
            tbMauKQ.Clear();
            tbTuSo1.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}
