namespace LeThanhTuong_2123110128
{
	partial class Form16
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
			this.lblFullName = new System.Windows.Forms.Label();
			this.tbFullName = new System.Windows.Forms.TextBox();
			this.lblBirth = new System.Windows.Forms.Label();
			this.dtBirth = new System.Windows.Forms.DateTimePicker();
			this.gbGender = new System.Windows.Forms.GroupBox();
			this.rbFemale = new System.Windows.Forms.RadioButton();
			this.rbMale = new System.Windows.Forms.RadioButton();
			this.lblFaculty = new System.Windows.Forms.Label();
			this.cbFaculty = new System.Windows.Forms.ComboBox();
			this.lblStatus = new System.Windows.Forms.Label();
			this.lbStatus = new System.Windows.Forms.ListBox();
			this.btAdd = new System.Windows.Forms.Button();
			this.btExit = new System.Windows.Forms.Button();
			this.gbGender.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblFullName
			// 
			this.lblFullName.AutoSize = true;
			this.lblFullName.Location = new System.Drawing.Point(16, 18);
			this.lblFullName.Name = "lblFullName";
			this.lblFullName.Size = new System.Drawing.Size(62, 15);
			this.lblFullName.TabIndex = 0;
			this.lblFullName.Text = "Họ và tên";
			// 
			// tbFullName
			// 
			this.tbFullName.Location = new System.Drawing.Point(100, 15);
			this.tbFullName.Name = "tbFullName";
			this.tbFullName.Size = new System.Drawing.Size(220, 23);
			this.tbFullName.TabIndex = 1;
			this.tbFullName.Text = "Trần Thị Học Lai";
			// 
			// lblBirth
			// 
			this.lblBirth.AutoSize = true;
			this.lblBirth.Location = new System.Drawing.Point(16, 52);
			this.lblBirth.Name = "lblBirth";
			this.lblBirth.Size = new System.Drawing.Size(58, 15);
			this.lblBirth.TabIndex = 2;
			this.lblBirth.Text = "Ngày Sinh";
			// 
			// dtBirth
			// 
			this.dtBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtBirth.Location = new System.Drawing.Point(100, 49);
			this.dtBirth.Name = "dtBirth";
			this.dtBirth.Size = new System.Drawing.Size(220, 23);
			this.dtBirth.TabIndex = 3;
			// 
			// gbGender
			// 
			this.gbGender.Controls.Add(this.rbFemale);
			this.gbGender.Controls.Add(this.rbMale);
			this.gbGender.Location = new System.Drawing.Point(100, 80);
			this.gbGender.Name = "gbGender";
			this.gbGender.Size = new System.Drawing.Size(220, 55);
			this.gbGender.TabIndex = 4;
			this.gbGender.TabStop = false;
			this.gbGender.Text = "Giới tính";
			// 
			// rbFemale
			// 
			this.rbFemale.AutoSize = true;
			this.rbFemale.Location = new System.Drawing.Point(140, 24);
			this.rbFemale.Name = "rbFemale";
			this.rbFemale.Size = new System.Drawing.Size(41, 19);
			this.rbFemale.TabIndex = 1;
			this.rbFemale.TabStop = true;
			this.rbFemale.Text = "Nữ";
			this.rbFemale.UseVisualStyleBackColor = true;
			// 
			// rbMale
			// 
			this.rbMale.AutoSize = true;
			this.rbMale.Location = new System.Drawing.Point(60, 24);
			this.rbMale.Name = "rbMale";
			this.rbMale.Size = new System.Drawing.Size(51, 19);
			this.rbMale.TabIndex = 0;
			this.rbMale.TabStop = true;
			this.rbMale.Text = "Nam";
			this.rbMale.UseVisualStyleBackColor = true;
			// 
			// lblFaculty
			// 
			this.lblFaculty.AutoSize = true;
			this.lblFaculty.Location = new System.Drawing.Point(16, 148);
			this.lblFaculty.Name = "lblFaculty";
			this.lblFaculty.Size = new System.Drawing.Size(33, 15);
			this.lblFaculty.TabIndex = 5;
			this.lblFaculty.Text = "Khoa";
			// 
			// cbFaculty
			// 
			this.cbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFaculty.FormattingEnabled = true;
			this.cbFaculty.Location = new System.Drawing.Point(100, 145);
			this.cbFaculty.Name = "cbFaculty";
			this.cbFaculty.Size = new System.Drawing.Size(220, 23);
			this.cbFaculty.TabIndex = 6;
			// 
			// lblStatus
			// 
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(16, 181);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(61, 15);
			this.lblStatus.TabIndex = 7;
			this.lblStatus.Text = "Trạng thái";
			// 
			// lbStatus
			// 
			this.lbStatus.FormattingEnabled = true;
			this.lbStatus.ItemHeight = 15;
			this.lbStatus.Location = new System.Drawing.Point(100, 181);
			this.lbStatus.Name = "lbStatus";
			this.lbStatus.Size = new System.Drawing.Size(220, 124);
			this.lbStatus.TabIndex = 8;
			// 
			// btAdd
			// 
			this.btAdd.Location = new System.Drawing.Point(165, 318);
			this.btAdd.Name = "btAdd";
			this.btAdd.Size = new System.Drawing.Size(75, 28);
			this.btAdd.TabIndex = 9;
			this.btAdd.Text = "Thêm";
			this.btAdd.UseVisualStyleBackColor = true;
			this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
			// 
			// btExit
			// 
			this.btExit.Location = new System.Drawing.Point(245, 318);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(75, 28);
			this.btExit.TabIndex = 10;
			this.btExit.Text = "Thoát";
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler(this.BtExit_Click);
			// 
			// Form16
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 362);
			this.Controls.Add(this.btExit);
			this.Controls.Add(this.btAdd);
			this.Controls.Add(this.lbStatus);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.cbFaculty);
			this.Controls.Add(this.lblFaculty);
			this.Controls.Add(this.gbGender);
			this.Controls.Add(this.dtBirth);
			this.Controls.Add(this.lblBirth);
			this.Controls.Add(this.tbFullName);
			this.Controls.Add(this.lblFullName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form16";
			this.Text = "Quản lý sinh viên";
			this.gbGender.ResumeLayout(false);
			this.gbGender.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label lblFullName;
		private System.Windows.Forms.TextBox tbFullName;
		private System.Windows.Forms.Label lblBirth;
		private System.Windows.Forms.DateTimePicker dtBirth;
		private System.Windows.Forms.GroupBox gbGender;
		private System.Windows.Forms.RadioButton rbFemale;
		private System.Windows.Forms.RadioButton rbMale;
		private System.Windows.Forms.Label lblFaculty;
		private System.Windows.Forms.ComboBox cbFaculty;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.ListBox lbStatus;
		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.Button btExit;
	}
}
