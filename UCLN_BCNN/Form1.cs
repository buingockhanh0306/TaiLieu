using System;
using System.Windows.Forms;

namespace UCLN_BCNN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int UCLN(int a, int b)
        {
            while (a != b)
            {
                if (a < b)
                    b = b - a;
                else
                    a = a-b;
            }
            return a;
        }
        public int BCNN(int x, int y)
        {
            return (x * y) / UCLN(x, y);
        }
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            int tu = Convert.ToInt32(tbA.Text);
            int mau = Convert.ToInt32(tbB.Text);
            tbUCLN.Text = Convert.ToString(UCLN(tu, mau));
            tbBCNN.Text = Convert.ToString(BCNN(tu, mau));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            tbA.Clear();
            tbB.Clear();
            tbBCNN.Clear();
            tbUCLN.Clear();
            tbA.Focus();
        }
    }
}
