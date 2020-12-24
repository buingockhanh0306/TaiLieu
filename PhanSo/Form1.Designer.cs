namespace PhanSo
{
    partial class PhanSo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTuso = new System.Windows.Forms.TextBox();
            this.tbMauso = new System.Windows.Forms.TextBox();
            this.lbPhanso = new System.Windows.Forms.Label();
            this.lbPhansotg = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnRf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài tập phân số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập tử số: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập mẫu số: ";
            // 
            // tbTuso
            // 
            this.tbTuso.Location = new System.Drawing.Point(194, 88);
            this.tbTuso.Name = "tbTuso";
            this.tbTuso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbTuso.Size = new System.Drawing.Size(100, 20);
            this.tbTuso.TabIndex = 2;
            this.tbTuso.TextChanged += new System.EventHandler(this.ry35436);
            this.tbTuso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTuso_KeyPress);
            // 
            // tbMauso
            // 
            this.tbMauso.Location = new System.Drawing.Point(194, 130);
            this.tbMauso.Name = "tbMauso";
            this.tbMauso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbMauso.Size = new System.Drawing.Size(100, 20);
            this.tbMauso.TabIndex = 3;
            this.tbMauso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMauso_KeyPress);
            // 
            // lbPhanso
            // 
            this.lbPhanso.AutoSize = true;
            this.lbPhanso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhanso.Location = new System.Drawing.Point(66, 200);
            this.lbPhanso.Name = "lbPhanso";
            this.lbPhanso.Size = new System.Drawing.Size(0, 19);
            this.lbPhanso.TabIndex = 5;
            // 
            // lbPhansotg
            // 
            this.lbPhansotg.AutoSize = true;
            this.lbPhansotg.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhansotg.Location = new System.Drawing.Point(66, 231);
            this.lbPhansotg.Name = "lbPhansotg";
            this.lbPhansotg.Size = new System.Drawing.Size(0, 19);
            this.lbPhansotg.TabIndex = 6;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(245, 296);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 7;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(89, 296);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnRf
            // 
            this.btnRf.Location = new System.Drawing.Point(313, 86);
            this.btnRf.Name = "btnRf";
            this.btnRf.Size = new System.Drawing.Size(75, 23);
            this.btnRf.TabIndex = 9;
            this.btnRf.Text = "Refresh";
            this.btnRf.UseVisualStyleBackColor = true;
            this.btnRf.Click += new System.EventHandler(this.btnRf_Click);
            // 
            // PhanSo
            // 
            this.AcceptButton = this.btnNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(421, 344);
            this.Controls.Add(this.btnRf);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.lbPhansotg);
            this.Controls.Add(this.lbPhanso);
            this.Controls.Add(this.tbMauso);
            this.Controls.Add(this.tbTuso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PhanSo";
            this.Text = "Phân số";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTuso;
        private System.Windows.Forms.TextBox tbMauso;
        private System.Windows.Forms.Label lbPhanso;
        private System.Windows.Forms.Label lbPhansotg;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnRf;
    }
}

