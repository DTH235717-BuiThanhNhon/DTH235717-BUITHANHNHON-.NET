namespace Bai5._1
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhapN = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.TextBox();
            this.lblSNTNhoHon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(424, 214);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(142, 44);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập N:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm SNT nhỏ hơn N:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kiểm tra SNT:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNhapN
            // 
            this.txtNhapN.Location = new System.Drawing.Point(221, 111);
            this.txtNhapN.Name = "txtNhapN";
            this.txtNhapN.Size = new System.Drawing.Size(236, 22);
            this.txtNhapN.TabIndex = 5;
            this.txtNhapN.TextChanged += new System.EventHandler(this.txtNhapN_TextChanged);
            // 
            // lblKQ
            // 
            this.lblKQ.Location = new System.Drawing.Point(221, 137);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(236, 22);
            this.lblKQ.TabIndex = 6;
            // 
            // lblSNTNhoHon
            // 
            this.lblSNTNhoHon.Location = new System.Drawing.Point(221, 165);
            this.lblSNTNhoHon.Name = "lblSNTNhoHon";
            this.lblSNTNhoHon.Size = new System.Drawing.Size(236, 22);
            this.lblSNTNhoHon.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(237, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kiểm Tra Và Tìm SNT";
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(57, 214);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(142, 44);
            this.btnKiemTra.TabIndex = 9;
            this.btnKiemTra.Text = "Kiểm tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click_1);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(243, 214);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(146, 44);
            this.btnLamLai.TabIndex = 10;
            this.btnLamLai.Text = "Lam lai";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSNTNhoHon);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.txtNhapN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Name = "Form1";
            this.Text = "KT SNT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhapN;
        private System.Windows.Forms.TextBox lblKQ;
        private System.Windows.Forms.TextBox lblSNTNhoHon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Button btnLamLai;
    }
}

