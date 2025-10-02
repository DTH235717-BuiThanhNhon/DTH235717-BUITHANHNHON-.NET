using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsPerfect(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0) sum += i;
            return sum == n;
        }
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNhapN.Text.Trim(), out int n))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }

            if (IsPerfect(n))
                MessageBox.Show($"{n} là số hoàn hảo");
            else
                MessageBox.Show($"{n} không phải số hoàn hảo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
    }

