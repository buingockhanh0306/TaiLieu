using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanSo
{
    public partial class PhanSo : Form
    {
        public PhanSo()
        {
            InitializeComponent();
        }
        public int UCLN(int a, int b)
        {
            if (a == 0 || b == 0)
                return a + b;
            else
            {
                while (a!=b)
                {
                    if (a >= b)
                        a = a - b;
                    else b = b - a;
                };
                return a;
                
            }
        }
        public bool check()
        {
            if(string.IsNullOrEmpty(tbTuso.Text))
            {
                MessageBox.Show("Bạn chưa nhập tử số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTuso.Focus();
                return false;
            } 
            if(string.IsNullOrEmpty(tbMauso.Text))
            {
                MessageBox.Show("Bạn chưa nhập mẫu số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbMauso.Focus();
                return false;
            }
            return true;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (check())
            {
                 int tuso= Convert.ToInt32(tbTuso.Text);
                 int mauso = Convert.ToInt32(tbMauso.Text);
                if (mauso == 0)
                {
                    MessageBox.Show("Không tồn tại phân số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbMauso.Clear();
                    tbMauso.Focus();
                }
                else
                {
                    lbPhanso.Text = ("Phân số đó là:  " + tuso + "/" + mauso);
                    int tusotg = tuso / UCLN(tuso, mauso);
                    int mausotg = mauso / UCLN(tuso, mauso);
                    if (tusotg == mausotg) lbPhansotg.Text = ("Phân số đã tối giản là: 1 ");
                    else
                    {
                        if (mausotg == 1) lbPhansotg.Text = ("Phân số đã tối giản là:  " + tusotg);
                        else
                        lbPhansotg.Text = ("Phân số đã tối giản là:  " + tusotg + "/" + mausotg);
                    }
                }
            }
        }

        private void btnRf_Click(object sender, EventArgs e)
        {
            tbTuso.Clear();
            tbMauso.Clear();
            lbPhanso.Text = null;
            lbPhansotg.Text = null;
            tbTuso.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if 
           ( MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();

        }

        private void tbTuso_TextChanged(object sender, EventArgs e)
        {
           
        }

        //Chỉ cho nhập số và dùng các phím di chuyển//
        private void tbTuso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ry35436(object sender, EventArgs e)
        {

        }

        private void tbMauso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
