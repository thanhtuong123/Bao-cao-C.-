namespace GameSnake
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.Label lblScore;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
				components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			this.lblScore = new System.Windows.Forms.Label();
			this.SuspendLayout();

			// gameTimer
			this.gameTimer.Interval = 180;
			this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);

			// lblScore
			this.lblScore.AutoSize = true;
			this.lblScore.ForeColor = System.Drawing.Color.White;
			this.lblScore.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lblScore.Location = new System.Drawing.Point(10, 10);
			

			// Form1
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(600, 600);
			this.Controls.Add(this.lblScore);
			this.KeyPreview = true;
			this.Text = "Snake Game";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);

			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
