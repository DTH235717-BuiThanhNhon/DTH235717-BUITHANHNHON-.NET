namespace Bai4._6
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
            this.txtn = new System.Windows.Forms.TextBox();
            this.lbn = new System.Windows.Forms.Label();
            this.lbPHETOAN = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(279, 256);
            this.txtKQ.Margin = new System.Windows.Forms.Padding(4);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(263, 22);
            this.txtKQ.TabIndex = 29;
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.Location = new System.Drawing.Point(246, 258);
            this.lbKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(27, 20);
            this.lbKetQua.TabIndex = 28;
            this.lbKetQua.Text = "S:";
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(279, 182);
            this.txtn.Margin = new System.Windows.Forms.Padding(4);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(263, 22);
            this.txtn.TabIndex = 27;
            // 
            // lbn
            // 
            this.lbn.AutoSize = true;
            this.lbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn.Location = new System.Drawing.Point(246, 182);
            this.lbn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbn.Name = "lbn";
            this.lbn.Size = new System.Drawing.Size(25, 20);
            this.lbn.TabIndex = 26;
            this.lbn.Text = "n:";
            // 
            // lbPHETOAN
            // 
            this.lbPHETOAN.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPHETOAN.Location = new System.Drawing.Point(158, 55);
            this.lbPHETOAN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPHETOAN.Name = "lbPHETOAN";
            this.lbPHETOAN.Size = new System.Drawing.Size(485, 70);
            this.lbPHETOAN.TabIndex = 25;
            this.lbPHETOAN.Text = "Cau truc lap";
            this.lbPHETOAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(319, 328);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(167, 68);
            this.btnTinh.TabIndex = 24;
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
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.lbn);
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
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label lbn;
        private System.Windows.Forms.Label lbPHETOAN;
        private System.Windows.Forms.Button btnTinh;
    }
}

