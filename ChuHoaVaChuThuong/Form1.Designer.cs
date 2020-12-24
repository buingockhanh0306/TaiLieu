namespace ChuHoaVaChuThuong
{
    partial class ChuHoaVaChuThuong
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
            this.tbNhap = new System.Windows.Forms.TextBox();
            this.tbKetqua = new System.Windows.Forms.TextBox();
            this.rdoChuthuong = new System.Windows.Forms.RadioButton();
            this.rdoChuhoa = new System.Windows.Forms.RadioButton();
            this.btnKetqua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chữ Hoa và Chữ Thường";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mời bạn nhập nội dung";
            // 
            // tbNhap
            // 
            this.tbNhap.Location = new System.Drawing.Point(51, 92);
            this.tbNhap.Name = "tbNhap";
            this.tbNhap.Size = new System.Drawing.Size(233, 20);
            this.tbNhap.TabIndex = 1;
            this.tbNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbKetqua
            // 
            this.tbKetqua.Location = new System.Drawing.Point(12, 223);
            this.tbKetqua.Name = "tbKetqua";
            this.tbKetqua.ReadOnly = true;
            this.tbKetqua.Size = new System.Drawing.Size(315, 20);
            this.tbKetqua.TabIndex = 2;
            this.tbKetqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdoChuthuong
            // 
            this.rdoChuthuong.AutoSize = true;
            this.rdoChuthuong.Checked = true;
            this.rdoChuthuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChuthuong.Location = new System.Drawing.Point(51, 129);
            this.rdoChuthuong.Name = "rdoChuthuong";
            this.rdoChuthuong.Size = new System.Drawing.Size(92, 20);
            this.rdoChuthuong.TabIndex = 3;
            this.rdoChuthuong.TabStop = true;
            this.rdoChuthuong.Text = "Chữ thường";
            this.rdoChuthuong.UseVisualStyleBackColor = true;
            this.rdoChuthuong.CheckedChanged += new System.EventHandler(this.rdoChuthuong_CheckedChanged);
            // 
            // rdoChuhoa
            // 
            this.rdoChuhoa.AutoSize = true;
            this.rdoChuhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChuhoa.Location = new System.Drawing.Point(209, 129);
            this.rdoChuhoa.Name = "rdoChuhoa";
            this.rdoChuhoa.Size = new System.Drawing.Size(75, 20);
            this.rdoChuhoa.TabIndex = 4;
            this.rdoChuhoa.Text = "Chữ hoa";
            this.rdoChuhoa.UseVisualStyleBackColor = true;
            this.rdoChuhoa.CheckedChanged += new System.EventHandler(this.rdoChuhoa_CheckedChanged);
            // 
            // btnKetqua
            // 
            this.btnKetqua.Location = new System.Drawing.Point(28, 172);
            this.btnKetqua.Name = "btnKetqua";
            this.btnKetqua.Size = new System.Drawing.Size(75, 23);
            this.btnKetqua.TabIndex = 5;
            this.btnKetqua.Text = "Kết quả";
            this.btnKetqua.UseVisualStyleBackColor = true;
            this.btnKetqua.Click += new System.EventHandler(this.btnKetqua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(128, 172);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(233, 172);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone: 0981.415.813";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email: buikhanhi2k@gmail.com";
            // 
            // ChuHoaVaChuThuong
            // 
            this.AcceptButton = this.btnKetqua;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 345);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnKetqua);
            this.Controls.Add(this.rdoChuhoa);
            this.Controls.Add(this.rdoChuthuong);
            this.Controls.Add(this.tbKetqua);
            this.Controls.Add(this.tbNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChuHoaVaChuThuong";
            this.Text = "Chữ hoa và chữ thường";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNhap;
        private System.Windows.Forms.TextBox tbKetqua;
        private System.Windows.Forms.RadioButton rdoChuthuong;
        private System.Windows.Forms.RadioButton rdoChuhoa;
        private System.Windows.Forms.Button btnKetqua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

