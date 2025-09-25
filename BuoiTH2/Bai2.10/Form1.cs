using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._10
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
            MessageBox.Show( "Chu Vi = " + cv.ToString(),"Ket Qua");
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            double dt =  (a * b);
            MessageBox.Show("Chu Vi = " + dt.ToString(), "Ket Qua");
        }

        private void btnDC_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            double dc = Math.Sqrt (a*a + b*b);
            MessageBox.Show("Chu Vi = " + dc.ToString(), "Ket Qua");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
