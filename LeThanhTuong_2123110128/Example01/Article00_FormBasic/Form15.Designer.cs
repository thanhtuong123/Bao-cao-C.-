namespace LeThanhTuong_2123110128
{
	partial class Form15
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.Button btExit;
		private System.Windows.Forms.TextBox tbShow;
		private System.Windows.Forms.Label label1;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.btOK = new System.Windows.Forms.Button();
			this.btExit = new System.Windows.Forms.Button();
			this.tbShow = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Chọn ngày:";
			// 
			// dtpDate
			// 
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDate.Location = new System.Drawing.Point(105, 14);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(200, 23);
			this.dtpDate.TabIndex = 1;
			this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
			// 
			// tbShow
			// 
			this.tbShow.Location = new System.Drawing.Point(18, 55);
			this.tbShow.Multiline = true;
			this.tbShow.Name = "tbShow";
			this.tbShow.ReadOnly = true;
			this.tbShow.Size = new System.Drawing.Size(287, 70);
			this.tbShow.TabIndex = 2;
			// 
			// btOK
			// 
			this.btOK.Location = new System.Drawing.Point(105, 140);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(95, 30);
			this.btOK.TabIndex = 3;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// btExit
			// 
			this.btExit.Location = new System.Drawing.Point(210, 140);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(95, 30);
			this.btExit.TabIndex = 4;
			this.btExit.Text = "Thoát";
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			// 
			// Form15
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 190);
			this.Controls.Add(this.btExit);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.tbShow);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form15";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Article 15 - DateTimePicker";
			this.Load += new System.EventHandler(this.Form15_Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
