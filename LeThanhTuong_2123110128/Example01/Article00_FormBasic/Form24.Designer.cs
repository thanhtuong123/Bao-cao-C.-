namespace LeThanhTuong_2123110128
{
	partial class Form24
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblDisplay;
		private System.Windows.Forms.Button btStart;
		private System.Windows.Forms.Button btStop;
		private System.Windows.Forms.Timer tmStopwatch;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lblDisplay = new System.Windows.Forms.Label();
			this.btStart = new System.Windows.Forms.Button();
			this.btStop = new System.Windows.Forms.Button();
			this.tmStopwatch = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lblDisplay
			// 
			this.lblDisplay.AutoSize = false;
			this.lblDisplay.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
			this.lblDisplay.Location = new System.Drawing.Point(40, 25);
			this.lblDisplay.Name = "lblDisplay";
			this.lblDisplay.Size = new System.Drawing.Size(320, 80);
			this.lblDisplay.TabIndex = 0;
			this.lblDisplay.Text = "00:00";
			this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btStart
			// 
			this.btStart.Location = new System.Drawing.Point(90, 130);
			this.btStart.Name = "btStart";
			this.btStart.Size = new System.Drawing.Size(90, 35);
			this.btStart.TabIndex = 1;
			this.btStart.Text = "Start";
			this.btStart.UseVisualStyleBackColor = true;
			this.btStart.Click += new System.EventHandler(this.btStart_Click);
			// 
			// btStop
			// 
			this.btStop.Location = new System.Drawing.Point(220, 130);
			this.btStop.Name = "btStop";
			this.btStop.Size = new System.Drawing.Size(90, 35);
			this.btStop.TabIndex = 2;
			this.btStop.Text = "Stop";
			this.btStop.UseVisualStyleBackColor = true;
			this.btStop.Click += new System.EventHandler(this.btStop_Click);
			// 
			// tmStopwatch
			// 
			this.tmStopwatch.Interval = 1000;
			this.tmStopwatch.Tick += new System.EventHandler(this.tmStopwatch_Tick);
			// 
			// Form24
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 200);
			this.Controls.Add(this.btStop);
			this.Controls.Add(this.btStart);
			this.Controls.Add(this.lblDisplay);
			this.Name = "Form24";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Timer Article 24";
			this.ResumeLayout(false);
		}
	}
}
