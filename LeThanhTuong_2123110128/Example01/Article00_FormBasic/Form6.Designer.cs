namespace LeThanhTuong_2123110128
{
	partial class Form6
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Button bt_OK;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
			this.txtName = new System.Windows.Forms.TextBox();
			this.bt_OK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(30, 30);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(220, 22);
			this.txtName.TabIndex = 0;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// bt_OK
			// 
			this.bt_OK.Location = new System.Drawing.Point(175, 70);
			this.bt_OK.Name = "bt_OK";
			this.bt_OK.Size = new System.Drawing.Size(75, 28);
			this.bt_OK.TabIndex = 1;
			this.bt_OK.Text = "OK";
			this.bt_OK.UseVisualStyleBackColor = true;
			this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
			// 
			// Form6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 130);
			this.Controls.Add(this.bt_OK);
			this.Controls.Add(this.txtName);
			this.Name = "Form6";
			this.Text = "Article 06 - TextBox";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		#endregion
	}
}
