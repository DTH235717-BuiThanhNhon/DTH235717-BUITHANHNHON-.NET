namespace Bai2._6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPhepToan = new System.Windows.Forms.Label();
            this.lba = new System.Windows.Forms.Label();
            this.lbb = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnHieu = new System.Windows.Forms.Button();
            this.btnTich = new System.Windows.Forms.Button();
            this.btnThuong = new System.Windows.Forms.Button();
            this.lbThongTin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPhepToan
            // 
            this.lbPhepToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhepToan.Location = new System.Drawing.Point(294, 23);
            this.lbPhepToan.Name = "lbPhepToan";
            this.lbPhepToan.Size = new System.Drawing.Size(203, 46);
            this.lbPhepToan.TabIndex = 0;
            this.lbPhepToan.Text = "Phep Toan";
            this.lbPhepToan.Click += new System.EventHandler(this.label1_Click);
            // 
            // lba
            // 
            this.lba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lba.Location = new System.Drawing.Point(249, 137);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(33, 23);
            this.lba.TabIndex = 1;
            this.lba.Text = "a:";
            // 
            // lbb
            // 
            this.lbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbb.Location = new System.Drawing.Point(249, 174);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(33, 23);
            this.lbb.TabIndex = 2;
            this.lbb.Text = "b:";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(301, 137);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(166, 20);
            this.txta.TabIndex = 3;
            this.txta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(301, 177);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(166, 20);
            this.txtb.TabIndex = 4;
            // 
            // btnTong
            // 
            this.btnTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Location = new System.Drawing.Point(63, 236);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(96, 93);
            this.btnTong.TabIndex = 5;
            this.btnTong.Text = "Tong";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnHieu
            // 
            this.btnHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHieu.Location = new System.Drawing.Point(243, 236);
            this.btnHieu.Name = "btnHieu";
            this.btnHieu.Size = new System.Drawing.Size(96, 93);
            this.btnHieu.TabIndex = 6;
            this.btnHieu.Text = "Hieu";
            this.btnHieu.UseVisualStyleBackColor = true;
            this.btnHieu.Click += new System.EventHandler(this.btnHieu_Click);
            // 
            // btnTich
            // 
            this.btnTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTich.Location = new System.Drawing.Point(435, 236);
            this.btnTich.Name = "btnTich";
            this.btnTich.Size = new System.Drawing.Size(96, 93);
            this.btnTich.TabIndex = 7;
            this.btnTich.Text = "Tich";
            this.btnTich.UseVisualStyleBackColor = true;
            this.btnTich.Click += new System.EventHandler(this.btnTich_Click);
            // 
            // btnThuong
            // 
            this.btnThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuong.Location = new System.Drawing.Point(615, 236);
            this.btnThuong.Name = "btnThuong";
            this.btnThuong.Size = new System.Drawing.Size(99, 93);
            this.btnThuong.TabIndex = 8;
            this.btnThuong.Text = "Thuong";
            this.btnThuong.UseVisualStyleBackColor = true;
            this.btnThuong.Click += new System.EventHandler(this.btnThuong_Click);
            // 
            // lbThongTin
            // 
            this.lbThongTin.Location = new System.Drawing.Point(250, 99);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(100, 23);
            this.lbThongTin.TabIndex = 9;
            this.lbThongTin.Text = "Thong Tin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbThongTin);
            this.Controls.Add(this.btnThuong);
            this.Controls.Add(this.btnTich);
            this.Controls.Add(this.btnHieu);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lbb);
            this.Controls.Add(this.lba);
            this.Controls.Add(this.lbPhepToan);
            this.Name = "Form1";
            this.Text = "Bai2.6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPhepToan;
        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnHieu;
        private System.Windows.Forms.Button btnTich;
        private System.Windows.Forms.Button btnThuong;
        private System.Windows.Forms.Label lbThongTin;
    }
}

