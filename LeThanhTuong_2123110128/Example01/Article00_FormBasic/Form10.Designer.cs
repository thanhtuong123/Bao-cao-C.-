namespace LeThanhTuong_2123110128
{
	partial class Form10
	{
		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.TextBox tbDisplay;

		private System.Windows.Forms.Button bt0;
		private System.Windows.Forms.Button bt1;
		private System.Windows.Forms.Button bt2;
		private System.Windows.Forms.Button bt3;

		private System.Windows.Forms.Button btPlus;
		private System.Windows.Forms.Button btMul;
		private System.Windows.Forms.Button btDot;
		private System.Windows.Forms.Button btEquals;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.tbDisplay = new System.Windows.Forms.TextBox();

			this.bt0 = new System.Windows.Forms.Button();
			this.bt1 = new System.Windows.Forms.Button();
			this.bt2 = new System.Windows.Forms.Button();
			this.bt3 = new System.Windows.Forms.Button();

			this.btPlus = new System.Windows.Forms.Button();
			this.btMul = new System.Windows.Forms.Button();
			this.btDot = new System.Windows.Forms.Button();
			this.btEquals = new System.Windows.Forms.Button();

			this.SuspendLayout();
			// 
			// tbDisplay
			// 
			this.tbDisplay.Font = new System.Drawing.Font("Segoe UI", 18F);
			this.tbDisplay.Location = new System.Drawing.Point(20, 15);
			this.tbDisplay.Name = "tbDisplay";
			this.tbDisplay.Size = new System.Drawing.Size(300, 39);
			this.tbDisplay.TabIndex = 0;
			this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// bt0
			// 
			this.bt0.Location = new System.Drawing.Point(20, 70);
			this.bt0.Name = "bt0";
			this.bt0.Size = new System.Drawing.Size(70, 60);
			this.bt0.TabIndex = 1;
			this.bt0.Text = "0";
			this.bt0.UseVisualStyleBackColor = true;
			this.bt0.Click += new System.EventHandler(this.bt0_Click);
			// 
			// bt1
			// 
			this.bt1.Location = new System.Drawing.Point(100, 70);
			this.bt1.Name = "bt1";
			this.bt1.Size = new System.Drawing.Size(70, 60);
			this.bt1.TabIndex = 2;
			this.bt1.Text = "1";
			this.bt1.UseVisualStyleBackColor = true;
			this.bt1.Click += new System.EventHandler(this.bt1_Click);
			// 
			// bt2
			// 
			this.bt2.Location = new System.Drawing.Point(180, 70);
			this.bt2.Name = "bt2";
			this.bt2.Size = new System.Drawing.Size(70, 60);
			this.bt2.TabIndex = 3;
			this.bt2.Text = "2";
			this.bt2.UseVisualStyleBackColor = true;
			this.bt2.Click += new System.EventHandler(this.bt2_Click);
			// 
			// bt3
			// 
			this.bt3.Location = new System.Drawing.Point(260, 70);
			this.bt3.Name = "bt3";
			this.bt3.Size = new System.Drawing.Size(70, 60);
			this.bt3.TabIndex = 4;
			this.bt3.Text = "3";
			this.bt3.UseVisualStyleBackColor = true;
			this.bt3.Click += new System.EventHandler(this.bt3_Click);
			// 
			// btPlus
			// 
			this.btPlus.Location = new System.Drawing.Point(20, 140);
			this.btPlus.Name = "btPlus";
			this.btPlus.Size = new System.Drawing.Size(70, 60);
			this.btPlus.TabIndex = 5;
			this.btPlus.Text = "+";
			this.btPlus.UseVisualStyleBackColor = true;
			this.btPlus.Click += new System.EventHandler(this.btPlus_Click);
			// 
			// btMul
			// 
			this.btMul.Location = new System.Drawing.Point(100, 140);
			this.btMul.Name = "btMul";
			this.btMul.Size = new System.Drawing.Size(70, 60);
			this.btMul.TabIndex = 6;
			this.btMul.Text = "*";
			this.btMul.UseVisualStyleBackColor = true;
			this.btMul.Click += new System.EventHandler(this.btMul_Click);
			// 
			// btDot
			// 
			this.btDot.Location = new System.Drawing.Point(180, 140);
			this.btDot.Name = "btDot";
			this.btDot.Size = new System.Drawing.Size(70, 60);
			this.btDot.TabIndex = 7;
			this.btDot.Text = ".";
			this.btDot.UseVisualStyleBackColor = true;
			this.btDot.Click += new System.EventHandler(this.btDot_Click);
			// 
			// btEquals
			// 
			this.btEquals.Location = new System.Drawing.Point(260, 140);
			this.btEquals.Name = "btEquals";
			this.btEquals.Size = new System.Drawing.Size(70, 60);
			this.btEquals.TabIndex = 8;
			this.btEquals.Text = "=";
			this.btEquals.UseVisualStyleBackColor = true;
			this.btEquals.Click += new System.EventHandler(this.btEquals_Click);
			// 
			// Form10
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 220);
			this.Controls.Add(this.btEquals);
			this.Controls.Add(this.btDot);
			this.Controls.Add(this.btMul);
			this.Controls.Add(this.btPlus);
			this.Controls.Add(this.bt3);
			this.Controls.Add(this.bt2);
			this.Controls.Add(this.bt1);
			this.Controls.Add(this.bt0);
			this.Controls.Add(this.tbDisplay);
			this.Name = "Form10";
			this.Text = "Simple Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
