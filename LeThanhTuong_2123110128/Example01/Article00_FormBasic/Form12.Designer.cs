namespace LeThanhTuong_2123110128
{
	partial class Form12
	{
		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.ComboBox cbFaculty;
		private System.Windows.Forms.TextBox tbDisplay;
		private System.Windows.Forms.Button btClear;
		private System.Windows.Forms.Button btOK;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.cbFaculty = new System.Windows.Forms.ComboBox();
			this.tbDisplay = new System.Windows.Forms.TextBox();
			this.btClear = new System.Windows.Forms.Button();
			this.btOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cbFaculty
			// 
			this.cbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFaculty.FormattingEnabled = true;
			this.cbFaculty.Items.AddRange(new object[] {
			"Công nghệ thông tin",
			"Ngoại ngữ",
			"Quản trị kinh doanh",
			"Cơ khí",
			"Điện",
			"Cơ khí động lực"});
			this.cbFaculty.Location = new System.Drawing.Point(20, 20);
			this.cbFaculty.Name = "cbFaculty";
			this.cbFaculty.Size = new System.Drawing.Size(300, 23);
			this.cbFaculty.TabIndex = 0;
			this.cbFaculty.SelectedIndexChanged += new System.EventHandler(this.cbFaculty_SelectedIndexChanged);
			// 
			// tbDisplay
			// 
			this.tbDisplay.Location = new System.Drawing.Point(20, 60);
			this.tbDisplay.Multiline = true;
			this.tbDisplay.Name = "tbDisplay";
			this.tbDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbDisplay.Size = new System.Drawing.Size(300, 120);
			this.tbDisplay.TabIndex = 1;
			// 
			// btClear
			// 
			this.btClear.Location = new System.Drawing.Point(164, 195);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(75, 27);
			this.btClear.TabIndex = 2;
			this.btClear.Text = "Clear";
			this.btClear.UseVisualStyleBackColor = true;
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			// 
			// btOK
			// 
			this.btOK.Location = new System.Drawing.Point(245, 195);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(75, 27);
			this.btOK.TabIndex = 3;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// Form12
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 245);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.btClear);
			this.Controls.Add(this.tbDisplay);
			this.Controls.Add(this.cbFaculty);
			this.Name = "Form12";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Form12_Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
