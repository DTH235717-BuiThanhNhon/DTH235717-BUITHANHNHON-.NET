using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtn.Text);
            double S = 0;
            for (int i = 0; i <= n; i++)
            {
                S += 1.0/(2*i-1);
            }
            txtKQ.Text = S.ToString("0.00");
        }
    }
}
