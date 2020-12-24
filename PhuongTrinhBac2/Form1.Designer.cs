namespace PhuongTrinhBac2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.btKetQua = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.rdoPtb1 = new System.Windows.Forms.RadioButton();
            this.rdoPtb2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giải phương trình";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(27, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập c:";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(78, 125);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(151, 20);
            this.tbA.TabIndex = 1;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(78, 167);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(151, 20);
            this.tbB.TabIndex = 2;
            // 
            // tbC
            // 
            this.tbC.Enabled = false;
            this.tbC.Location = new System.Drawing.Point(78, 208);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(151, 20);
            this.tbC.TabIndex = 3;
            // 
            // btKetQua
            // 
            this.btKetQua.Location = new System.Drawing.Point(269, 125);
            this.btKetQua.Name = "btKetQua";
            this.btKetQua.Size = new System.Drawing.Size(75, 62);
            this.btKetQua.TabIndex = 4;
            this.btKetQua.Text = "Kết quả";
            this.btKetQua.UseVisualStyleBackColor = true;
            this.btKetQua.Click += new System.EventHandler(this.btKetQua_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(269, 206);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // rdoPtb1
            // 
            this.rdoPtb1.AutoSize = true;
            this.rdoPtb1.Checked = true;
            this.rdoPtb1.Location = new System.Drawing.Point(78, 57);
            this.rdoPtb1.Name = "rdoPtb1";
            this.rdoPtb1.Size = new System.Drawing.Size(135, 17);
            this.rdoPtb1.TabIndex = 7;
            this.rdoPtb1.TabStop = true;
            this.rdoPtb1.Text = "Giải phương trình bậc 1";
            this.rdoPtb1.UseVisualStyleBackColor = true;
            this.rdoPtb1.Click += new System.EventHandler(this.rdoPtb1_Click);
            // 
            // rdoPtb2
            // 
            this.rdoPtb2.AutoSize = true;
            this.rdoPtb2.Location = new System.Drawing.Point(78, 80);
            this.rdoPtb2.Name = "rdoPtb2";
            this.rdoPtb2.Size = new System.Drawing.Size(135, 17);
            this.rdoPtb2.TabIndex = 8;
            this.rdoPtb2.Text = "Giải phương trình bậc 2";
            this.rdoPtb2.UseVisualStyleBackColor = true;
            this.rdoPtb2.Click += new System.EventHandler(this.rdoPtb2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kết quả:";
            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(78, 250);
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.ReadOnly = true;
            this.tbKetQua.Size = new System.Drawing.Size(266, 20);
            this.tbKetQua.TabIndex = 10;
            this.tbKetQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(269, 67);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 23);
            this.btRefresh.TabIndex = 11;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btKetQua;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 321);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdoPtb2);
            this.Controls.Add(this.rdoPtb1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btKetQua);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(500, 360);
            this.MinimumSize = new System.Drawing.Size(500, 360);
            this.Name = "Form1";
            this.Text = "Phương trình";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Button btKetQua;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.RadioButton rdoPtb1;
        private System.Windows.Forms.RadioButton rdoPtb2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKetQua;
        private System.Windows.Forms.Button btRefresh;
    }
}

