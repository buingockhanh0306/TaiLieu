using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangSoNguyen
{
    public partial class MangSoNguyen : Form
    {
        public MangSoNguyen()
        {
            InitializeComponent();
        }

        public void NhapMang(int[] Nhap, int a)
        {
            int i = 0;
            while(true)
            {
                Nhap[i] = a;
                i++;
            }    

        }
        private void button1_Click(object sender, EventArgs e)
        {          
            tbNhap.Text = tbNhap.Text + " ";
        }
    }
}
