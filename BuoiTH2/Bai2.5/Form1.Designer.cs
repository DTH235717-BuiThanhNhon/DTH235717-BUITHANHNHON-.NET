namespace Bai2._5
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
            this.lbPHEPTOAN = new System.Windows.Forms.Label();
            this.lbThongTin = new System.Windows.Forms.Label();
            this.lba = new System.Windows.Forms.Label();
            this.lbb = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(307, 299);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(149, 59);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tong";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbPHEPTOAN
            // 
            this.lbPHEPTOAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPHEPTOAN.Location = new System.Drawing.Point(276, 47);
            this.lbPHEPTOAN.Name = "lbPHEPTOAN";
            this.lbPHEPTOAN.Size = new System.Drawing.Size(192, 44);
            this.lbPHEPTOAN.TabIndex = 1;
            this.lbPHEPTOAN.Text = "PHEP TOAN";
            // 
            // lbThongTin
            // 
            this.lbThongTin.Location = new System.Drawing.Point(279, 112);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(69, 20);
            this.lbThongTin.TabIndex = 2;
            this.lbThongTin.Text = "Thong Tin";
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.Location = new System.Drawing.Point(290, 166);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(13, 13);
            this.lba.TabIndex = 3;
            this.lba.Text = "a";
            this.lba.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbb
            // 
            this.lbb.AutoSize = true;
            this.lbb.Location = new System.Drawing.Point(290, 201);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(13, 13);
            this.lbb.TabIndex = 4;
            this.lbb.Text = "b";
            this.lbb.Click += new System.EventHandler(this.label2_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(333, 166);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 5;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(333, 201);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lbb);
            this.Controls.Add(this.lba);
            this.Controls.Add(this.lbThongTin);
            this.Controls.Add(this.lbPHEPTOAN);
            this.Controls.Add(this.btnTong);
            this.Name = "Form1";
            this.Text = "Bai2.5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Label lbPHEPTOAN;
        private System.Windows.Forms.Label lbThongTin;
        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
    }
}

