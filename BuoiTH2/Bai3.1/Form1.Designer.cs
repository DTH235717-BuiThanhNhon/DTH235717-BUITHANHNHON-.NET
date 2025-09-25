namespace Bai3._1
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
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.txtf = new System.Windows.Forms.TextBox();
            this.txtx = new System.Windows.Forms.TextBox();
            this.lbf = new System.Windows.Forms.Label();
            this.lbx = new System.Windows.Forms.Label();
            this.lbPHETOAN = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(365, 289);
            this.txtKQ.Margin = new System.Windows.Forms.Padding(4);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(159, 22);
            this.txtKQ.TabIndex = 15;
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(265, 289);
            this.lbKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(83, 20);
            this.lbKetQua.TabIndex = 14;
            this.lbKetQua.Text = "Ket Qua:";
            // 
            // txtf
            // 
            this.txtf.Location = new System.Drawing.Point(291, 215);
            this.txtf.Margin = new System.Windows.Forms.Padding(4);
            this.txtf.Name = "txtf";
            this.txtf.Size = new System.Drawing.Size(263, 22);
            this.txtf.TabIndex = 13;
            // 
            // txtx
            // 
            this.txtx.Location = new System.Drawing.Point(291, 154);
            this.txtx.Margin = new System.Windows.Forms.Padding(4);
            this.txtx.Name = "txtx";
            this.txtx.Size = new System.Drawing.Size(263, 22);
            this.txtx.TabIndex = 12;
            // 
            // lbf
            // 
            this.lbf.AutoSize = true;
            this.lbf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbf.Location = new System.Drawing.Point(223, 215);
            this.lbf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbf.Name = "lbf";
            this.lbf.Size = new System.Drawing.Size(26, 20);
            this.lbf.TabIndex = 11;
            this.lbf.Text = "F:";
            // 
            // lbx
            // 
            this.lbx.AutoSize = true;
            this.lbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx.Location = new System.Drawing.Point(223, 154);
            this.lbx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(27, 20);
            this.lbx.TabIndex = 10;
            this.lbx.Text = "X:";
            // 
            // lbPHETOAN
            // 
            this.lbPHETOAN.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPHETOAN.Location = new System.Drawing.Point(170, 27);
            this.lbPHETOAN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPHETOAN.Name = "lbPHETOAN";
            this.lbPHETOAN.Size = new System.Drawing.Size(485, 70);
            this.lbPHETOAN.TabIndex = 9;
            this.lbPHETOAN.Text = "TINH GIA TRI HAM SO";
            this.lbPHETOAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(332, 349);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(167, 68);
            this.btnTinh.TabIndex = 8;
            this.btnTinh.Text = "Tinh";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.txtf);
            this.Controls.Add(this.txtx);
            this.Controls.Add(this.lbf);
            this.Controls.Add(this.lbx);
            this.Controls.Add(this.lbPHETOAN);
            this.Controls.Add(this.btnTinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.TextBox txtf;
        private System.Windows.Forms.TextBox txtx;
        private System.Windows.Forms.Label lbf;
        private System.Windows.Forms.Label lbx;
        private System.Windows.Forms.Label lbPHETOAN;
        private System.Windows.Forms.Button btnTinh;
    }
}

