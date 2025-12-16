namespace LeThanhTuong_2123110128
{
	partial class Form19
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.lbId = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.lbImage = new System.Windows.Forms.Label();
			this.tbId = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.btFile = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
			this.SuspendLayout();
			// 
			// lbId
			// 
			this.lbId.AutoSize = true;
			this.lbId.Location = new System.Drawing.Point(20, 22);
			this.lbId.Name = "lbId";
			this.lbId.Size = new System.Drawing.Size(76, 20);
			this.lbId.TabIndex = 0;
			this.lbId.Text = "Mã nhân viên";
			// 
			// lbName
			// 
			this.lbName.AutoSize = true;
			this.lbName.Location = new System.Drawing.Point(20, 62);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(88, 20);
			this.lbName.TabIndex = 1;
			this.lbName.Text = "Tên nhân viên";
			// 
			// lbImage
			// 
			this.lbImage.AutoSize = true;
			this.lbImage.Location = new System.Drawing.Point(20, 104);
			this.lbImage.Name = "lbImage";
			this.lbImage.Size = new System.Drawing.Size(56, 20);
			this.lbImage.TabIndex = 2;
			this.lbImage.Text = "Ảnh 3 x 4";
			// 
			// tbId
			// 
			this.tbId.Location = new System.Drawing.Point(130, 18);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(210, 27);
			this.tbId.TabIndex = 3;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(130, 58);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(310, 27);
			this.tbName.TabIndex = 4;
			// 
			// pbImage
			// 
			this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbImage.Location = new System.Drawing.Point(130, 104);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size(180, 220);
			this.pbImage.TabIndex = 5;
			this.pbImage.TabStop = false;
			// 
			// btFile
			// 
			this.btFile.Location = new System.Drawing.Point(330, 160);
			this.btFile.Name = "btFile";
			this.btFile.Size = new System.Drawing.Size(120, 40);
			this.btFile.TabIndex = 6;
			this.btFile.Text = "Chọn ảnh...";
			this.btFile.UseVisualStyleBackColor = true;
			this.btFile.Click += new System.EventHandler(this.btFile_Click);
			// 
			// Form19
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 360);
			this.Controls.Add(this.btFile);
			this.Controls.Add(this.pbImage);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.tbId);
			this.Controls.Add(this.lbImage);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.lbId);
			this.Name = "Form19";
			this.Text = "Quản lý nhân sự";
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label lbId;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Label lbImage;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.Button btFile;
	}
}
