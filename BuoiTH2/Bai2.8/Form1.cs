using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(txta.Text, out a))
            {
                MessageBox.Show("Vui long nhap so a");
                return;
            }
            if (!int.TryParse(txtb.Text, out b))
            {
                MessageBox.Show("Vui long nhap so b");
                return;
            }
            double tong = a + b;
            txtKQ.Text = "Tong = " + tong;
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(txta.Text, out a))
            {
                MessageBox.Show("Vui long nhap so a");
                return;
            }
            if (!int.TryParse(txtb.Text, out b))
            {
                MessageBox.Show("Vui long nhap so b");
                return;
            }
            double hieu = a - b;
            txtKQ.Text = "Hieu = " + hieu;
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(txta.Text, out a))
            {
                MessageBox.Show("Vui long nhap so a");
                return;
            }
            if (!int.TryParse(txtb.Text, out b))
            {
                MessageBox.Show("Vui long nhap so b");
                return;
            }
            double tich = a * b;
            txtKQ.Text = "Tich = " + tich;
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(txta.Text, out a))
            {
                MessageBox.Show("Vui long nhap so a");
                return;
            }
            if (!int.TryParse(txtb.Text, out b))
            {
                MessageBox.Show("Vui long nhap so b");
                return;
            }
            double thuong = a / b;
            txtKQ.Text = "Thuong = " + thuong;
        }
    }
}
