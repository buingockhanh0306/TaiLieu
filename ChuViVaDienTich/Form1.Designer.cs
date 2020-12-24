namespace ChuViVaDienTich
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbHinhTamGiac = new System.Windows.Forms.RadioButton();
            this.rdbHinhTron = new System.Windows.Forms.RadioButton();
            this.rdbHinhChuNhat = new System.Windows.Forms.RadioButton();
            this.rdbHinhVuong = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbTamGiac = new System.Windows.Forms.TextBox();
            this.tbDienTich = new System.Windows.Forms.TextBox();
            this.tbChuVi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelr = new System.Windows.Forms.Label();
            this.lbHienThi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(61, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chu Vi và Diện Tích";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbHinhTamGiac);
            this.groupBox1.Controls.Add(this.rdbHinhTron);
            this.groupBox1.Controls.Add(this.rdbHinhChuNhat);
            this.groupBox1.Controls.Add(this.rdbHinhVuong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(49, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rdbHinhTamGiac
            // 
            this.rdbHinhTamGiac.AutoSize = true;
            this.rdbHinhTamGiac.Location = new System.Drawing.Point(141, 69);
            this.rdbHinhTamGiac.Name = "rdbHinhTamGiac";
            this.rdbHinhTamGiac.Size = new System.Drawing.Size(90, 17);
            this.rdbHinhTamGiac.TabIndex = 4;
            this.rdbHinhTamGiac.TabStop = true;
            this.rdbHinhTamGiac.Text = "Hình tam giác";
            this.rdbHinhTamGiac.UseVisualStyleBackColor = true;
            this.rdbHinhTamGiac.CheckedChanged += new System.EventHandler(this.rdbHinhTamGiac_CheckedChanged);
            // 
            // rdbHinhTron
            // 
            this.rdbHinhTron.AutoSize = true;
            this.rdbHinhTron.Location = new System.Drawing.Point(141, 33);
            this.rdbHinhTron.Name = "rdbHinhTron";
            this.rdbHinhTron.Size = new System.Drawing.Size(68, 17);
            this.rdbHinhTron.TabIndex = 3;
            this.rdbHinhTron.TabStop = true;
            this.rdbHinhTron.Text = "Hình tròn";
            this.rdbHinhTron.UseVisualStyleBackColor = true;
            this.rdbHinhTron.CheckedChanged += new System.EventHandler(this.rdbHinhTron_CheckedChanged);
            // 
            // rdbHinhChuNhat
            // 
            this.rdbHinhChuNhat.AutoSize = true;
            this.rdbHinhChuNhat.Location = new System.Drawing.Point(19, 69);
            this.rdbHinhChuNhat.Name = "rdbHinhChuNhat";
            this.rdbHinhChuNhat.Size = new System.Drawing.Size(92, 17);
            this.rdbHinhChuNhat.TabIndex = 2;
            this.rdbHinhChuNhat.TabStop = true;
            this.rdbHinhChuNhat.Text = "Hình chữ nhật";
            this.rdbHinhChuNhat.UseVisualStyleBackColor = true;
            this.rdbHinhChuNhat.CheckedChanged += new System.EventHandler(this.rdbHinhChuNhat_CheckedChanged);
            // 
            // rdbHinhVuong
            // 
            this.rdbHinhVuong.AutoSize = true;
            this.rdbHinhVuong.Location = new System.Drawing.Point(19, 33);
            this.rdbHinhVuong.Name = "rdbHinhVuong";
            this.rdbHinhVuong.Size = new System.Drawing.Size(80, 17);
            this.rdbHinhVuong.TabIndex = 1;
            this.rdbHinhVuong.TabStop = true;
            this.rdbHinhVuong.Text = "Hình vuông";
            this.rdbHinhVuong.UseVisualStyleBackColor = true;
            this.rdbHinhVuong.CheckedChanged += new System.EventHandler(this.rdbHinhVuong_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mời bạn lựa chọn:";
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(31, 202);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(75, 23);
            this.btnThucHien.TabIndex = 2;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(133, 202);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(245, 202);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbC);
            this.groupBox2.Controls.Add(this.tbB);
            this.groupBox2.Controls.Add(this.tbA);
            this.groupBox2.Controls.Add(this.tbTamGiac);
            this.groupBox2.Controls.Add(this.tbDienTich);
            this.groupBox2.Controls.Add(this.tbChuVi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.labelr);
            this.groupBox2.Controls.Add(this.lbHienThi);
            this.groupBox2.Location = new System.Drawing.Point(32, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 173);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(191, 42);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(57, 20);
            this.tbC.TabIndex = 6;
            this.tbC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbC_KeyPress);
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(106, 42);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(57, 20);
            this.tbB.TabIndex = 5;
            this.tbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbB_KeyPress);
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(18, 42);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(57, 20);
            this.tbA.TabIndex = 4;
            this.tbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyPress);
            // 
            // tbTamGiac
            // 
            this.tbTamGiac.Enabled = false;
            this.tbTamGiac.ForeColor = System.Drawing.Color.Red;
            this.tbTamGiac.Location = new System.Drawing.Point(18, 139);
            this.tbTamGiac.Name = "tbTamGiac";
            this.tbTamGiac.ReadOnly = true;
            this.tbTamGiac.Size = new System.Drawing.Size(227, 20);
            this.tbTamGiac.TabIndex = 3;
            // 
            // tbDienTich
            // 
            this.tbDienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDienTich.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbDienTich.Location = new System.Drawing.Point(90, 101);
            this.tbDienTich.Name = "tbDienTich";
            this.tbDienTich.ReadOnly = true;
            this.tbDienTich.Size = new System.Drawing.Size(158, 20);
            this.tbDienTich.TabIndex = 2;
            // 
            // tbChuVi
            // 
            this.tbChuVi.Location = new System.Drawing.Point(90, 71);
            this.tbChuVi.Name = "tbChuVi";
            this.tbChuVi.ReadOnly = true;
            this.tbChuVi.Size = new System.Drawing.Size(158, 20);
            this.tbChuVi.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Diện tích:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chu vi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhập C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập B:";
            // 
            // labelr
            // 
            this.labelr.AutoSize = true;
            this.labelr.Location = new System.Drawing.Point(15, 26);
            this.labelr.Name = "labelr";
            this.labelr.Size = new System.Drawing.Size(46, 13);
            this.labelr.TabIndex = 0;
            this.labelr.Text = "Nhập A:";
            // 
            // lbHienThi
            // 
            this.lbHienThi.AutoSize = true;
            this.lbHienThi.Location = new System.Drawing.Point(15, 0);
            this.lbHienThi.Name = "lbHienThi";
            this.lbHienThi.Size = new System.Drawing.Size(0, 13);
            this.lbHienThi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnThucHien;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Chu Vi và Diện Tích";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbHinhTamGiac;
        private System.Windows.Forms.RadioButton rdbHinhTron;
        private System.Windows.Forms.RadioButton rdbHinhChuNhat;
        private System.Windows.Forms.RadioButton rdbHinhVuong;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbTamGiac;
        private System.Windows.Forms.TextBox tbDienTich;
        private System.Windows.Forms.TextBox tbChuVi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelr;
        private System.Windows.Forms.Label lbHienThi;
    }
}

