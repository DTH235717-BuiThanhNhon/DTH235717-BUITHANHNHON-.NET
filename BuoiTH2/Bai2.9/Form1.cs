using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            double cv = 2 * (a + b);
            txtKQ.Text = "Chu Vi = " + cv.ToString();
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            double dt = a * b;
            txtKQ.Text = "Dien Tich = " + dt.ToString();
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            double dc = Math.Sqrt(a*a+b*b);
            txtKQ.Text = "Duong Cheo = " + dc.ToString();
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
