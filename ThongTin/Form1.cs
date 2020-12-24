using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThongTin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=1; i<=31; i++)
            {
                cboNgay.Items.Add(i.ToString());
            }   
            for(int i=1; i<=12; i++)
            {
                cboThang.Items.Add(i.ToString());
            }    
            for(int i=1950; i<=2020; i++)
            {
                cboNam.Items.Add(i.ToString());
            }    
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            tbHienThi.Text = tbHoTen.Text + "\r\n" + cboNgay.SelectedItem + "/" + cboThang.SelectedItem + "/" + cboNam.SelectedItem + "\r\n" + tbSoThich.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}
