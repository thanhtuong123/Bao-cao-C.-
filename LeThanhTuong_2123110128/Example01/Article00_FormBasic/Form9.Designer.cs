namespace LeThanhTuong_2123110128
{
	partial class Form9
	{
		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.TextBox tbSoX;
		private System.Windows.Forms.TextBox tbSoY;
		private System.Windows.Forms.TextBox tbKetQua;

		private System.Windows.Forms.Button btCong;
		private System.Windows.Forms.Button btNhan;
		private System.Windows.Forms.Button btThoat;
		private System.Windows.Forms.Button btLuu;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();

			this.tbSoX = new System.Windows.Forms.TextBox();
			this.tbSoY = new System.Windows.Forms.TextBox();
			this.tbKetQua = new System.Windows.Forms.TextBox();

			this.btCong = new System.Windows.Forms.Button();
			this.btNhan = new System.Windows.Forms.Button();
			this.btThoat = new System.Windows.Forms.Button();
			this.btLuu = new System.Windows.Forms.Button();

			this.SuspendLayout();

			// label1 - Số x
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Số x";

			// tbSoX
			this.tbSoX.Location = new System.Drawing.Point(70, 17);
			this.tbSoX.Name = "tbSoX";
			this.tbSoX.Size = new System.Drawing.Size(340, 23);
			this.tbSoX.TabIndex = 1;

			// label2 - Số y
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Số y";

			// tbSoY
			this.tbSoY.Location = new System.Drawing.Point(70, 52);
			this.tbSoY.Name = "tbSoY";
			this.tbSoY.Size = new System.Drawing.Size(340, 23);
			this.tbSoY.TabIndex = 3;

			// label3 - Kết quả
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "Kết quả";

			// tbKetQua (Multiline)
			this.tbKetQua.Location = new System.Drawing.Point(70, 87);
			this.tbKetQua.Multiline = true;
			this.tbKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbKetQua.Name = "tbKetQua";
			this.tbKetQua.Size = new System.Drawing.Size(340, 260);
			this.tbKetQua.TabIndex = 5;
			this.tbKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top
						| System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));

			// btLuu
			this.btLuu.Location = new System.Drawing.Point(20, 360);
			this.btLuu.Name = "btLuu";
			this.btLuu.Size = new System.Drawing.Size(75, 27);
			this.btLuu.TabIndex = 6;
			this.btLuu.Text = "Lưu";
			this.btLuu.UseVisualStyleBackColor = true;
			this.btLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btLuu.Click += new System.EventHandler(this.btLuu_Click);

			// btCong
			this.btCong.Location = new System.Drawing.Point(170, 360);
			this.btCong.Name = "btCong";
			this.btCong.Size = new System.Drawing.Size(75, 27);
			this.btCong.TabIndex = 7;
			this.btCong.Text = "Cộng";
			this.btCong.UseVisualStyleBackColor = true;
			this.btCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCong.Click += new System.EventHandler(this.btCong_Click);

			// btNhan
			this.btNhan.Location = new System.Drawing.Point(255, 360);
			this.btNhan.Name = "btNhan";
			this.btNhan.Size = new System.Drawing.Size(75, 27);
			this.btNhan.TabIndex = 8;
			this.btNhan.Text = "Nhân";
			this.btNhan.UseVisualStyleBackColor = true;
			this.btNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btNhan.Click += new System.EventHandler(this.btNhan_Click);

			// btThoat
			this.btThoat.Location = new System.Drawing.Point(340, 360);
			this.btThoat.Name = "btThoat";
			this.btThoat.Size = new System.Drawing.Size(75, 27);
			this.btThoat.TabIndex = 9;
			this.btThoat.Text = "Thoát";
			this.btThoat.UseVisualStyleBackColor = true;
			this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btThoat.Click += new System.EventHandler(this.btThoat_Click);

			// Form9
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 405);

			this.Controls.Add(this.btThoat);
			this.Controls.Add(this.btNhan);
			this.Controls.Add(this.btCong);
			this.Controls.Add(this.btLuu);

			this.Controls.Add(this.tbKetQua);
			this.Controls.Add(this.label3);

			this.Controls.Add(this.tbSoY);
			this.Controls.Add(this.label2);

			this.Controls.Add(this.tbSoX);
			this.Controls.Add(this.label1);

			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Name = "Form9";
			this.Text = "Caculator";

			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
