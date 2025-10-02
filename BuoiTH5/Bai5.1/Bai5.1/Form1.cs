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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void txtNhapN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKiemTra_Click_1(object sender, EventArgs e)
        {
            int n = int.Parse(txtNhapN.Text);
            if (IsPrime(n))
                lblKQ.Text = $"{n} là số nguyên tố";
            else
                lblKQ.Text = $"{n} không phải số nguyên tố";

            string ketqua = "";
            for (int i = 2; i < n; i++)
                if (IsPrime(i)) ketqua += i + " ";
            lblSNTNhoHon.Text = ketqua;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhapN.Clear();
            lblKQ.Text = "";
            lblSNTNhoHon.Text = "";
            txtNhapN.Focus();
        }
    }
    }

