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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
    private void btnOk_Click(object sender, EventArgs e)
        {
            DaySo2.DaySo = tbSoNguyen.Text;
            try
            {
                int A = Convert.ToInt32(tbSoNguyen.Text);
                DaySo2.Tong = DaySo2.Tong + A;
                if (A % 2 == 0) DaySo2.TongChan = DaySo2.TongChan + A;
                if (A % 2 != 0) DaySo2.TongLe = DaySo2.TongLe + A;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Nhập dữ liệu sai!","",MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbSoNguyen.Clear();
                tbSoNguyen.Focus();
            }
                
               
        }

        private void tbSoNguyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
