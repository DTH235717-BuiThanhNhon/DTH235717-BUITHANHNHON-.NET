namespace Bai2._7
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
            this.btnTong = new System.Windows.Forms.Button();
            this.lbPHETOAN = new System.Windows.Forms.Label();
            this.lba = new System.Windows.Forms.Label();
            this.lbb = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTong
            // 
            this.btnTong.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Location = new System.Drawing.Point(327, 283);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(125, 55);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tong";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // lbPHETOAN
            // 
            this.lbPHETOAN.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPHETOAN.Location = new System.Drawing.Point(264, 26);
            this.lbPHETOAN.Name = "lbPHETOAN";
            this.lbPHETOAN.Size = new System.Drawing.Size(247, 57);
            this.lbPHETOAN.TabIndex = 1;
            this.lbPHETOAN.Text = "PHEP TOAN";
            this.lbPHETOAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbPHETOAN.Click += new System.EventHandler(this.label1_Click);
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lba.Location = new System.Drawing.Point(245, 124);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(20, 16);
            this.lba.TabIndex = 2;
            this.lba.Text = "a:";
            // 
            // lbb
            // 
            this.lbb.AutoSize = true;
            this.lbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbb.Location = new System.Drawing.Point(245, 174);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(20, 16);
            this.lbb.TabIndex = 3;
            this.lbb.Text = "b:";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(296, 124);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(198, 20);
            this.txta.TabIndex = 4;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(296, 174);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(198, 20);
            this.txtb.TabIndex = 5;
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(277, 234);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(65, 16);
            this.lbKetQua.TabIndex = 6;
            this.lbKetQua.Text = "Ket Qua:";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(352, 234);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(120, 20);
            this.txtKQ.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lbb);
            this.Controls.Add(this.lba);
            this.Controls.Add(this.lbPHETOAN);
            this.Controls.Add(this.btnTong);
            this.Name = "Form1";
            this.Text = "Bai2.7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Label lbPHETOAN;
        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.TextBox txtKQ;
    }
}

