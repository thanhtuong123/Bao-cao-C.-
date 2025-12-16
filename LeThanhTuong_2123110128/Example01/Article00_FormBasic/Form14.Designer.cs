namespace LeThanhTuong_2123110128
{
	partial class Form14
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.tbName = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbFemale = new System.Windows.Forms.RadioButton();
			this.rbMale = new System.Windows.Forms.RadioButton();
			this.ckDiscount = new System.Windows.Forms.CheckBox();
			this.tbDiscount = new System.Windows.Forms.TextBox();
			this.tbResult = new System.Windows.Forms.TextBox();
			this.btRun = new System.Windows.Forms.Button();
			this.btExit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbName
			// 
			this.tbName.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tbName.Location = new System.Drawing.Point(18, 18);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(420, 27);
			this.tbName.TabIndex = 0;
			this.tbName.Text = "Nguyễn Văn A";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbFemale);
			this.groupBox1.Controls.Add(this.rbMale);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.groupBox1.Location = new System.Drawing.Point(18, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(420, 80);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Giới tính";
			// 
			// rbFemale
			// 
			this.rbFemale.AutoSize = true;
			this.rbFemale.Location = new System.Drawing.Point(250, 34);
			this.rbFemale.Name = "rbFemale";
			this.rbFemale.Size = new System.Drawing.Size(43, 23);
			this.rbFemale.TabIndex = 1;
			this.rbFemale.Text = "Nữ";
			this.rbFemale.UseVisualStyleBackColor = true;
			// 
			// rbMale
			// 
			this.rbMale.AutoSize = true;
			this.rbMale.Checked = true;
			this.rbMale.Location = new System.Drawing.Point(120, 34);
			this.rbMale.Name = "rbMale";
			this.rbMale.Size = new System.Drawing.Size(55, 23);
			this.rbMale.TabIndex = 0;
			this.rbMale.TabStop = true;
			this.rbMale.Text = "Nam";
			this.rbMale.UseVisualStyleBackColor = true;
			// 
			// ckDiscount
			// 
			this.ckDiscount.AutoSize = true;
			this.ckDiscount.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.ckDiscount.Location = new System.Drawing.Point(18, 152);
			this.ckDiscount.Name = "ckDiscount";
			this.ckDiscount.Size = new System.Drawing.Size(79, 23);
			this.ckDiscount.TabIndex = 2;
			this.ckDiscount.Text = "Giảm giá";
			this.ckDiscount.UseVisualStyleBackColor = true;
			this.ckDiscount.CheckedChanged += new System.EventHandler(this.CkDiscount_CheckedChanged);
			// 
			// tbDiscount
			// 
			this.tbDiscount.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tbDiscount.Location = new System.Drawing.Point(120, 150);
			this.tbDiscount.Name = "tbDiscount";
			this.tbDiscount.Size = new System.Drawing.Size(80, 27);
			this.tbDiscount.TabIndex = 3;
			this.tbDiscount.Text = "7";
			// 
			// tbResult
			// 
			this.tbResult.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.tbResult.Location = new System.Drawing.Point(18, 190);
			this.tbResult.Multiline = true;
			this.tbResult.Name = "tbResult";
			this.tbResult.ReadOnly = true;
			this.tbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbResult.Size = new System.Drawing.Size(420, 120);
			this.tbResult.TabIndex = 4;
			// 
			// btRun
			// 
			this.btRun.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.btRun.Location = new System.Drawing.Point(180, 325);
			this.btRun.Name = "btRun";
			this.btRun.Size = new System.Drawing.Size(120, 38);
			this.btRun.TabIndex = 5;
			this.btRun.Text = "Tính tiền";
			this.btRun.UseVisualStyleBackColor = true;
			this.btRun.Click += new System.EventHandler(this.BtRun_Click);
			// 
			// btExit
			// 
			this.btExit.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.btExit.Location = new System.Drawing.Point(318, 325);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(120, 38);
			this.btExit.TabIndex = 6;
			this.btExit.Text = "Thoát";
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler(this.BtExit_Click);
			// 
			// Form14
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 382);
			this.Controls.Add(this.btExit);
			this.Controls.Add(this.btRun);
			this.Controls.Add(this.tbResult);
			this.Controls.Add(this.tbDiscount);
			this.Controls.Add(this.ckDiscount);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.tbName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form14";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Article 14 - RadioButton & CheckBox";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbFemale;
		private System.Windows.Forms.RadioButton rbMale;
		private System.Windows.Forms.CheckBox ckDiscount;
		private System.Windows.Forms.TextBox tbDiscount;
		private System.Windows.Forms.TextBox tbResult;
		private System.Windows.Forms.Button btRun;
		private System.Windows.Forms.Button btExit;
	}
}
