using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool KiemTraNamNhuan(int nam)
        {
            if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                return true;
            return false;
        }   

        private void lbnam_Click(object sender, EventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int d, m, y;
            if(!int .TryParse(txtn.Text, out d) || !int.TryParse(txtt.Text, out m) || !int.TryParse(txty.Text, out y))
            {
                MessageBox.Show("Vui lòng nhập ngày hợp lệ");
                return;
            }   
            if(m<1||m>12||y<=0)
            {
                MessageBox.Show("Ngày KHÔNG hợp lệ");
            }
            int maxday;
            switch(m)
            {
                case 1: case 3: case 5: case 7: case 8: case 10:
                    maxday = 31; break;
                case 4: case 6: case 9: case 11:
                    maxday = 30;break;
                case 2:
                    maxday = KiemTraNamNhuan(y) ? 29 : 28;break;
                default:
                    maxday=0; break;

            }
            if(d<1||d>maxday)
            {
                MessageBox.Show("Ngày KHÔNG hợp lệ");
            }    
            else
            {
                MessageBox.Show("Ngày Hợp lệ");
            }
        }
    }
}
