using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double x, f;
            if(!double.TryParse(txtx.Text, out x))
            {
                MessageBox.Show("Vui lòng nhập số thực cho x", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (x >= 2)
                f = -8 * Math.Pow(x, 3) - 12 * x - 1;
            else if (x > 1 & x < 2)
                f = x * x - 6 * x - 19;
            else
                f = 7 * x;
            txtKQ.Text= f.ToString();
        }
    }
}
