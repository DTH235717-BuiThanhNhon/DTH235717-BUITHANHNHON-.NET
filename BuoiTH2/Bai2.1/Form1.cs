﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._1
{
    public partial class frmChuongTrinhDonGian : Form
    {
        public frmChuongTrinhDonGian()
        {
            InitializeComponent();
        }

        private void frmChuongTrinhDonGian_Load(object sender, EventArgs e)
        {
            label1.Text = "Xin chao, chuc mot ngay vui ve";
            label1.Font = new Font("Arial", 20, FontStyle.Bold);
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Dock = DockStyle.Fill;
            //can giua
           
        }
    }
}
