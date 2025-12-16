namespace LeThanhTuong_2123110128
{
	partial class Form18
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbId = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.pbPhoto = new System.Windows.Forms.PictureBox();
			this.btChoose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã nhân viên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên nhân viên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ảnh 3x4";
			// 
			// tbId
			// 
			this.tbId.Location = new System.Drawing.Point(120, 16);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(200, 23);
			this.tbId.TabIndex = 3;
			this.tbId.Text = "03152482001";
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(120, 56);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(200, 23);
			this.tbName.TabIndex = 4;
			this.tbName.Text = "Nguyễn Văn Hùng";
			// 
			// pbPhoto
			// 
			this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbPhoto.Location = new System.Drawing.Point(120, 100);
			this.pbPhoto.Name = "pbPhoto";
			this.pbPhoto.Size = new System.Drawing.Size(160, 200);
			this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbPhoto.TabIndex = 5;
			this.pbPhoto.TabStop = false;
			// 
			// btChoose
			// 
			this.btChoose.Location = new System.Drawing.Point(300, 190);
			this.btChoose.Name = "btChoose";
			this.btChoose.Size = new System.Drawing.Size(110, 35);
			this.btChoose.TabIndex = 6;
			this.btChoose.Text = "Chọn ảnh...";
			this.btChoose.UseVisualStyleBackColor = true;
			this.btChoose.Click += new System.EventHandler(this.btChoose_Click);
			// 
			// Form18
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 330);
			this.Controls.Add(this.btChoose);
			this.Controls.Add(this.pbPhoto);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.tbId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form18";
			this.Text = "Form18 - PictureBox";
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.PictureBox pbPhoto;
		private System.Windows.Forms.Button btChoose;
	}
}
