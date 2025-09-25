namespace Bai3._3
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
            this.txty = new System.Windows.Forms.TextBox();
            this.lbnam = new System.Windows.Forms.Label();
            this.txtt = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.TextBox();
            this.lbthang = new System.Windows.Forms.Label();
            this.lbngay = new System.Windows.Forms.Label();
            this.lbPHETOAN = new System.Windows.Forms.Label();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txty
            // 
            this.txty.Location = new System.Drawing.Point(291, 261);
            this.txty.Margin = new System.Windows.Forms.Padding(4);
            this.txty.Name = "txty";
            this.txty.Size = new System.Drawing.Size(263, 22);
            this.txty.TabIndex = 25;
            // 
            // lbnam
            // 
            this.lbnam.AutoSize = true;
            this.lbnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnam.Location = new System.Drawing.Point(223, 261);
            this.lbnam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnam.Name = "lbnam";
            this.lbnam.Size = new System.Drawing.Size(53, 20);
            this.lbnam.TabIndex = 24;
            this.lbnam.Text = "Nam:";
            this.lbnam.Click += new System.EventHandler(this.lbnam_Click);
            // 
            // txtt
            // 
            this.txtt.Location = new System.Drawing.Point(291, 217);
            this.txtt.Margin = new System.Windows.Forms.Padding(4);
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(263, 22);
            this.txtt.TabIndex = 23;
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(291, 170);
            this.txtn.Margin = new System.Windows.Forms.Padding(4);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(263, 22);
            this.txtn.TabIndex = 22;
            // 
            // lbthang
            // 
            this.lbthang.AutoSize = true;
            this.lbthang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthang.Location = new System.Drawing.Point(214, 217);
            this.lbthang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbthang.Name = "lbthang";
            this.lbthang.Size = new System.Drawing.Size(66, 20);
            this.lbthang.TabIndex = 21;
            this.lbthang.Text = "Thang:";
            // 
            // lbngay
            // 
            this.lbngay.AutoSize = true;
            this.lbngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngay.Location = new System.Drawing.Point(223, 170);
            this.lbngay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbngay.Name = "lbngay";
            this.lbngay.Size = new System.Drawing.Size(57, 20);
            this.lbngay.TabIndex = 20;
            this.lbngay.Text = "Ngay:";
            // 
            // lbPHETOAN
            // 
            this.lbPHETOAN.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPHETOAN.Location = new System.Drawing.Point(248, 49);
            this.lbPHETOAN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPHETOAN.Name = "lbPHETOAN";
            this.lbPHETOAN.Size = new System.Drawing.Size(329, 70);
            this.lbPHETOAN.TabIndex = 19;
            this.lbPHETOAN.Text = "Kiem Tra";
            this.lbPHETOAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTra.Location = new System.Drawing.Point(314, 330);
            this.btnKiemTra.Margin = new System.Windows.Forms.Padding(4);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(190, 68);
            this.btnKiemTra.TabIndex = 18;
            this.btnKiemTra.Text = "Kiem Tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txty);
            this.Controls.Add(this.lbnam);
            this.Controls.Add(this.txtt);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.lbthang);
            this.Controls.Add(this.lbngay);
            this.Controls.Add(this.lbPHETOAN);
            this.Controls.Add(this.btnKiemTra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txty;
        private System.Windows.Forms.Label lbnam;
        private System.Windows.Forms.TextBox txtt;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label lbthang;
        private System.Windows.Forms.Label lbngay;
        private System.Windows.Forms.Label lbPHETOAN;
        private System.Windows.Forms.Button btnKiemTra;
    }
}

