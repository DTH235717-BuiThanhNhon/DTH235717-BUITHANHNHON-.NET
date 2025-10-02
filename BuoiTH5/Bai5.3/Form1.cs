using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int UCLN(int a, int b)
        {
            a = Math.Abs(a); b = Math.Abs(b);
            while (b != 0)
            {
                int t = a % b;
                a = b;
                b = t;
            }
            return a;
        }

        // Hàm rút gọn phân số
        private void RutGon(ref int tu, ref int mau)
        {
            if (mau < 0) { tu = -tu; mau = -mau; }
            int uc = UCLN(tu, mau);
            tu /= uc;
            mau /= uc;
        }
        private void HienKetQua(int tu, int mau)
        {
            RutGon(ref tu, ref mau);
            txtTuKQ.Text = tu.ToString();
            txtMauKQ.Text = mau.ToString();
        }
        private bool DocPhanSo(TextBox txtTu, TextBox txtMau, out int tu, out int mau)
        {
            tu = mau = 0;
            if (!int.TryParse(txtTu.Text.Trim(), out tu))
            {
                MessageBox.Show("Tử số không hợp lệ!");
                txtTu.Focus();
                return false;
            }
            if (!int.TryParse(txtMau.Text.Trim(), out mau) || mau == 0)
            {
                MessageBox.Show("Mẫu số không hợp lệ (không được = 0)!");
                txtMau.Focus();
                return false;
            }
            return true;
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            if (!DocPhanSo(txtTu1, txtMau1, out int tu1, out int mau1)) return;
            if (!DocPhanSo(txtTu2, txtMau2, out int tu2, out int mau2)) return;

            int tu = tu1 * mau2 + tu2 * mau1;
            int mau = mau1 * mau2;
            HienKetQua(tu, mau);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCong_Click_1(object sender, EventArgs e)
        {
            if (!DocPhanSo(txtTu1, txtMau1, out int tu1, out int mau1)) return;
            if (!DocPhanSo(txtTu2, txtMau2, out int tu2, out int mau2)) return;

            int tu = tu1 * mau2 + tu2 * mau1;
            int mau = mau1 * mau2;
            HienKetQua(tu, mau);
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (!DocPhanSo(txtTu1, txtMau1, out int tu1, out int mau1)) return;
            if (!DocPhanSo(txtTu2, txtMau2, out int tu2, out int mau2)) return;

            int tu = tu1 * mau2 - tu2 * mau1;
            int mau = mau1 * mau2;
            HienKetQua(tu, mau);
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (!DocPhanSo(txtTu1, txtMau1, out int tu1, out int mau1)) return;
            if (!DocPhanSo(txtTu2, txtMau2, out int tu2, out int mau2)) return;

            int tu = tu1 * tu2;
            int mau = mau1 * mau2;
            HienKetQua(tu, mau);
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (!DocPhanSo(txtTu1, txtMau1, out int tu1, out int mau1)) return;
            if (!DocPhanSo(txtTu2, txtMau2, out int tu2, out int mau2)) return;
            if (tu2 == 0)
            {
                MessageBox.Show("Không thể chia cho phân số bằng 0!");
                return;
            }

            int tu = tu1 * mau2;
            int mau = mau1 * tu2;
            HienKetQua(tu, mau);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtTu1.Clear(); txtMau1.Clear();
            txtTu2.Clear(); txtMau2.Clear();
            txtTuKQ.Clear(); txtMauKQ.Clear();
            txtTu1.Focus();
        }
    }
}
