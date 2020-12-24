using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuViVaDienTich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void HienThi(double cv, double dt)
        {
            tbChuVi.Text = Convert.ToString(cv);
            tbDienTich.Text = Convert.ToString(dt);
        }
        public void HinhChuNhat(double a, double b)
        {
            double cv, dt;
            cv = (a + b) * 2;
            dt = a * b;
            HienThi(cv, dt);
        }
        public void HinhVuong(double a)
        {
            double cv, dt;
            cv = a * 4;
            dt = a * a;
            HienThi(cv, dt);
        }
        public void HinhTron(double r)
        {
            double cv, dt;
            cv = 3.14 * 2 * r;
            dt = 3.14 * r * r;
            HienThi(cv, dt);
        }
        public void HinhTamGiac(double a, double b, double c)
        {
            if ((a > b + c || a < Math.Abs(b - c))) tbTamGiac.Text = "Nhập dữ liệu sai";
            else
            {                
                double cv, dt;
                cv = a + b + c;
                double p = cv / 2;
                dt = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                HienThi(cv, dt);
                KiemTraTamGiac(a, b, c);
            }
        }
        private void rdbHinhVuong_CheckedChanged(object sender, EventArgs e)
        {
            tbA.Focus();
            lbHienThi.Text = "Hình Vuông";
            tbB.Enabled = false;
            tbC.Enabled = false;
        }
        private void rdbHinhTron_CheckedChanged(object sender, EventArgs e)
        {
            tbA.Focus();
            lbHienThi.Text = "Hình tròn";
            tbB.Enabled = false;
            tbC.Enabled = false;
            
        }

        private void rdbHinhChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            tbA.Focus();
            lbHienThi.Text = "Hình Chữ Nhật";
            tbC.Enabled = false;
            tbB.Enabled = true;
        }
        private void rdbHinhTamGiac_CheckedChanged(object sender, EventArgs e)
        {
            tbA.Focus();
            lbHienThi.Text = "Hình tam giác";
            tbB.Enabled = true;
            tbC.Enabled = true;
        }

        public void Reset()
        {
            tbA.Clear();
            tbB.Clear();
            tbC.Clear();
            tbChuVi.Clear();
            tbDienTich.Clear();
            tbTamGiac.Clear();
            tbA.Focus();
        }
        public void KiemTraTamGiac(double a, double b, double c)
        {    
         if (a == b && a == c) tbTamGiac.Text = "Đây là tam giác đều";
         else
                {
         if (a == b || a == b || b == c) tbTamGiac.Text = "Đây là tam giác cân";
                    else
                    {
                        if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                            tbTamGiac.Text = "Đây là tam giác vuông";
                        else tbTamGiac.Text = "Đây là tam giác thường";
                    }
                }
        }
        private void btnThucHien_Click(object sender, EventArgs e)
        {          
            if (rdbHinhVuong.Checked == true)
            {
                double a = Convert.ToInt32(tbA.Text);
                HinhVuong(a);
            }
            if(rdbHinhChuNhat.Checked==true)
            {
                double a = Convert.ToInt32(tbA.Text);
                double b = Convert.ToInt32(tbB.Text);
                HinhChuNhat(a, b);
            }
            if(rdbHinhTamGiac.Checked==true)
            {
                double a = Convert.ToInt32(tbA.Text);
                double b = Convert.ToInt32(tbB.Text);
                double c = Convert.ToInt32(tbC.Text);
                HinhTamGiac(a, b, c);
            }   
            if(rdbHinhTron.Checked==true)
            {
                double a = Convert.ToInt32(tbA.Text);
                HinhTron(a);
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbHinhVuong.Checked = true;
            lbHienThi.Text = "Hình vuông";
        }

        private void tbA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
        }

        private void tbB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
        }

        private void tbC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}
