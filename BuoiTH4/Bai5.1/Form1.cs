using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        // Hàm tìm các số nguyên tố nhỏ hơn n
        private List<int> PrimesLessThanN(int n)
        {
            List<int> primes = new List<int>();
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                    primes.Add(i);
            }
            return primes;
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            lblKetQua.Text = "";
            lblSNTNhoHon.Text = "";

            if (int.TryParse(txtNhap.Text, out int n))
            {
                // Kiểm tra số nguyên tố
                if (IsPrime(n))
                    lblKetQua.Text = $"{n} là số nguyên tố.";
                else
                    lblKetQua.Text = $"{n} không phải là số nguyên tố.";

                // Tìm các số nguyên tố nhỏ hơn n
                var primes = PrimesLessThanN(n);
                lblSNTNhoHon.Text = "Số nguyên tố nhỏ hơn n: " + string.Join(", ", primes);
            }
            else
            {
                if (txtNhap.Text != "")
                    lblKetQua.Text = "Vui lòng nhập số nguyên hợp lệ.";
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();
            lblKetQua.Text = "";
            lblSNTNhoHon.Text = "";
            txtNhap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

