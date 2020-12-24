using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BieuThuc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public int SoMu(int n, int x)
        {
            int S = 0;
            for (int i=1; i<=n; i++)
            {
                int sh = 1;
                for(int z=1; z<=i; z++)
                {
                    sh =sh *  x;
                }
                S = S + sh;
            }
            return S + 2014;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbNhapN.Text);
            int x = Convert.ToInt32(tbNhapX.Text);
            tbKetQua.Text = Convert.ToString(SoMu(n, x));
        }
    }
}
