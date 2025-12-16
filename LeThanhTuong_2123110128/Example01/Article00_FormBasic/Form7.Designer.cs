namespace LeThanhTuong_2123110128
{
	partial class Form7
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbYear;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbPhone;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.tbYear = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbPhone = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Year";
			// 
			// tbYear
			// 
			this.tbYear.Location = new System.Drawing.Point(130, 27);
			this.tbYear.Name = "tbYear";
			this.tbYear.Size = new System.Drawing.Size(170, 23);
			this.tbYear.TabIndex = 1;
			this.tbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYear_KeyPress);
			this.tbYear.Validating += new System.ComponentModel.CancelEventHandler(this.tbYear_Validating);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(30, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Phone Number";
			// 
			// tbPhone
			// 
			this.tbPhone.Location = new System.Drawing.Point(130, 67);
			this.tbPhone.Name = "tbPhone";
			this.tbPhone.Size = new System.Drawing.Size(170, 23);
			this.tbPhone.TabIndex = 3;
			this.tbPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPhone_KeyPress);
			// 
			// Form7
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 130);

			// IMPORTANT: Add đủ control để nó hiện
			this.Controls.Add(this.tbPhone);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbYear);
			this.Controls.Add(this.label1);

			this.Name = "Form7";
			this.Text = "Article 07 - TextBox";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
