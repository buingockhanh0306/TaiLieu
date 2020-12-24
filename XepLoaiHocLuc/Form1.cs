using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XepLoaiHocLuc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            tb1.Enabled = true;
            tb2.Enabled = true;
            tb3.Enabled = true;
            tb4.Enabled = true;
            tb5.Enabled = true;
            tb1.Focus();
        }

        private void tbNhap_TextChanged(object sender, EventArgs e)
        {
            string x = tbNhap.Text;
            tbHienThi.Text = x;
        }

        private void tbHienThi_TextChanged(object sender, EventArgs e)
        {
            string x = tbNhap.Text;
            tbHienThi.Text = x;
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            string x1 = tb1.Text;
            double x = Convert.ToDouble(x1);
            string kq = x.ToString();
            tbTbc.Text = kq;
        }
        private void tbTbc_TextChanged(object sender, EventArgs e)
        {
            //double x1 = Convert.ToDouble(tb1.Text);
            //double x2 = Convert.ToDouble(tb2.Text);
            //double x3 = Convert.ToDouble(tb3.Text);
            //double x4 = Convert.ToDouble(tb4.Text);
            //double x5 = Convert.ToDouble(tb5.Text);
            //string x = ;
            //tbTbc.Text = x.ToString();


        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            string x2 = tb2.Text;
            double x = Convert.ToDouble(tbTbc.Text)+Convert.ToDouble(x2);
            string kq = x.ToString();
            tbTbc.Text = kq;
        }
    }
}
