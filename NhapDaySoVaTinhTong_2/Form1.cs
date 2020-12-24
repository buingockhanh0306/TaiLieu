using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhapDaySoVaTinhTong_2
{
    public partial class DaySo2 : Form
    {
        public DaySo2()
        {
            InitializeComponent();
        }
        public static string DaySo;
        public static int Tong;
        public static int TongChan;
        public static int TongLe;

        private void btnNhap_Click(object sender, EventArgs e)
        {
            
            Form2 NhapSoNguyen = new Form2();
            NhapSoNguyen.ShowDialog();
            if (!string.IsNullOrEmpty(DaySo))
            {
                this.tbDaySo.Text = tbDaySo.Text + " " + DaySo;
                this.tbTong.Text = Convert.ToString(Tong);
                this.tbTongChan.Text = Convert.ToString(TongChan);
                this.tbTongLe.Text = Convert.ToString(TongLe);
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbDaySo.Clear();
            tbTong.Clear();
            tbTongChan.Clear();
            tbTongLe.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
   
}
