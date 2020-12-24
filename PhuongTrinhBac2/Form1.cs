using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhuongTrinhBac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double delta(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
        public void ketqua(double a, double b, double c)
        {
            if (a == 0) tbKetQua.Text = ("Phương trình có nghiệm x=" + -c / b);
            else
            {
                double dt = delta(a, b, c);
                if (dt == 0) tbKetQua.Text = ("Phương trình có nghiệm kép x= " + -b / 2 * a);
                else
                {
                    if (dt < 0) tbKetQua.Text = "Phương trình vô nghiệm";
                    else
                    {
                        if (dt > 0)
                            tbKetQua.Text = ("Phương trình có 2 nghiệm phân biệt x1=" + (-b + Math.Sqrt(dt)) / (2 * a) + " và x2= " + (-b - Math.Sqrt(dt)) / (2 * a));
                    }
                }
            }
        }
        private void btKetQua_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tbA.Text);
            double b = Convert.ToDouble(tbB.Text);
            
            if (rdoPtb1.Checked == true)
            {                
                tbKetQua.Text = "Phương trình có nghiệm x=" + -b / a;
            }    
            if (rdoPtb2.Checked == true)
            {                
                double c = Convert.ToDouble(tbC.Text);
                ketqua(a, b, c);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
                if
                  (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           
        }

        private void rdoPtb2_Click(object sender, EventArgs e)
        {            
                tbC.Enabled = true;
            tbA.Clear();
            tbB.Clear();
            tbC.Clear();
            tbKetQua.Clear();
            tbA.Focus();
        }

        private void rdoPtb1_Click(object sender, EventArgs e)
        {
                tbC.Enabled = false;
            tbA.Clear();
            tbB.Clear();
            tbC.Clear();
            tbKetQua.Clear();
            tbA.Focus();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            tbA.Clear();
            tbB.Clear();
            tbC.Clear();
            tbKetQua.Clear();
        }
    }
}
