using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if(!double.TryParse(txta.Text, out a) || !double.TryParse(txtb.Text, out b) || !double.TryParse(txtc.Text, out c))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ.");
                return;
            }
            if(Math.Abs(a)<1e-10)
            {
                if (Math.Abs(b)<1e-10)
                {
                    txtkq.Text = Math.Abs(c) < 1e-10 ? "PT VSN" : "PT VN";
                }
                else
                {
                    txtkq.Text = "PT co 1 nghiem" + (-c / b);
                }
                return;
            }
            double delta = b * b - 4 * a * c;
            if(delta<0)
            {
                txtkq.Text = "PT VN";
            }
            else if(Math.Abs(delta)<1e-10)
            {
                txtkq.Text = "PT co nghiem kep: " + (-b / (2 * a));
            }
            else if(delta>0)
            {
                double D = Math.Sqrt(delta);
                double x1 = (-b + D) / (2 * a);
                double x2 = (-b - D) / (2 * a);
                txtkq.Text = "x1= " + x1 + " va x2= " + x2;
            }
        }
    }
}
