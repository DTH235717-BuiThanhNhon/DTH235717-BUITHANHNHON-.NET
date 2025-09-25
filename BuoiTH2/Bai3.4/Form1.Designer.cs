namespace Bai3._4
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
            this.txtc = new System.Windows.Forms.TextBox();
            this.lbc = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.lbb = new System.Windows.Forms.Label();
            this.lba = new System.Windows.Forms.Label();
            this.lbPhuongTrinh = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.lbKQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(295, 229);
            this.txtc.Margin = new System.Windows.Forms.Padding(4);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(263, 22);
            this.txtc.TabIndex = 33;
            // 
            // lbc
            // 
            this.lbc.AutoSize = true;
            this.lbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbc.Location = new System.Drawing.Point(227, 229);
            this.lbc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbc.Name = "lbc";
            this.lbc.Size = new System.Drawing.Size(25, 20);
            this.lbc.TabIndex = 32;
            this.lbc.Text = "c:";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(295, 185);
            this.txtb.Margin = new System.Windows.Forms.Padding(4);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(263, 22);
            this.txtb.TabIndex = 31;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(295, 138);
            this.txta.Margin = new System.Windows.Forms.Padding(4);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(263, 22);
            this.txta.TabIndex = 30;
            // 
            // lbb
            // 
            this.lbb.AutoSize = true;
            this.lbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbb.Location = new System.Drawing.Point(227, 185);
            this.lbb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(25, 20);
            this.lbb.TabIndex = 29;
            this.lbb.Text = "b:";
            // 
            // lba
            // 
            this.lba.AutoSize = true;
            this.lba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lba.Location = new System.Drawing.Point(227, 138);
            this.lba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lba.Name = "lba";
            this.lba.Size = new System.Drawing.Size(25, 20);
            this.lba.TabIndex = 28;
            this.lba.Text = "a:";
            // 
            // lbPhuongTrinh
            // 
            this.lbPhuongTrinh.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhuongTrinh.Location = new System.Drawing.Point(253, 51);
            this.lbPhuongTrinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhuongTrinh.Name = "lbPhuongTrinh";
            this.lbPhuongTrinh.Size = new System.Drawing.Size(329, 70);
            this.lbPhuongTrinh.TabIndex = 27;
            this.lbPhuongTrinh.Text = "Giai PT";
            this.lbPhuongTrinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btntinh
            // 
            this.btntinh.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntinh.Location = new System.Drawing.Point(308, 317);
            this.btntinh.Margin = new System.Windows.Forms.Padding(4);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(190, 68);
            this.btntinh.TabIndex = 26;
            this.btntinh.Text = "Tinh";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(339, 268);
            this.txtkq.Margin = new System.Windows.Forms.Padding(4);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(170, 22);
            this.txtkq.TabIndex = 35;
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.Location = new System.Drawing.Point(227, 270);
            this.lbKQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(83, 20);
            this.lbKQ.TabIndex = 34;
            this.lbKQ.Text = "Ket Qua:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.lbc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lbb);
            this.Controls.Add(this.lba);
            this.Controls.Add(this.lbPhuongTrinh);
            this.Controls.Add(this.btntinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label lbc;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label lbb;
        private System.Windows.Forms.Label lba;
        private System.Windows.Forms.Label lbPhuongTrinh;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Label lbKQ;
    }
}

