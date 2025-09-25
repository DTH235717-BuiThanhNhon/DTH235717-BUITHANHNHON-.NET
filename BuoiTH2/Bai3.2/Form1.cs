using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnThongBao_Click(object sender, EventArgs e)
        {
            int thang;
            if (!int.TryParse(txtThang.Text, out thang) || thang < 1 || thang > 12)
            {
                MessageBox.Show("Vui lòn nhập tháng hợp lệ!");
                return;
            }
            string mua;
            if (thang == 12 || thang == 1 || thang == 2) mua = "Mùa Đông";
            else if (thang >= 3 && thang <= 5) mua = "Mùa Xuan";
            else if (thang >= 6 && thang <= 8) mua = "Mùa Hè";
            else mua = "Mùa Thu";

            MessageBox.Show(mua, "Thông báo");
        }
    }
}
