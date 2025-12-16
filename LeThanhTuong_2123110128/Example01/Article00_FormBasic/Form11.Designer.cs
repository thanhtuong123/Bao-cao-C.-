namespace LeThanhTuong_2123110128
{
	partial class Form11
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtDisplay;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.txtDisplay = new System.Windows.Forms.TextBox();
			this.SuspendLayout();

			// txtDisplay
			this.txtDisplay.Location = new System.Drawing.Point(12, 12);
			this.txtDisplay.Name = "txtDisplay";
			this.txtDisplay.ReadOnly = true;
			this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtDisplay.Size = new System.Drawing.Size(360, 23);

			this.Controls.Add(this.txtDisplay);

			// Tạo nút theo dạng lưới
			// 5 cột x 6 hàng (trừ hàng 0 là display)
			// Hàng 1: MC MR MS M+ M-
			// Hàng 2: ← CE C ± √
			// Hàng 3: 7 8 9 / %
			// Hàng 4: 4 5 6 * 1/x
			// Hàng 5: 1 2 3 - =
			// Hàng 6: 0 (double) . +

			int left = 12, top = 50;
			int w = 68, h = 52, gap = 6;

			// helper tạo button
			System.Windows.Forms.Button Make(string text, int col, int row, int colSpan = 1)
			{
				var b = new System.Windows.Forms.Button();
				b.Text = text;
				b.Name = "bt_" + text.Replace("/", "Div").Replace("*", "Mul").Replace("+", "Plus")
								   .Replace("-", "Minus").Replace("=", "Eq").Replace(".", "Dot")
								   .Replace("←", "Back").Replace("√", "Sqrt").Replace("±", "Sign")
								   .Replace("%", "Percent").Replace("1/x", "Inv");
				b.Size = new System.Drawing.Size(w * colSpan + gap * (colSpan - 1), h);
				b.Location = new System.Drawing.Point(left + col * (w + gap), top + row * (h + gap));
				b.Click += new System.EventHandler(this.Button_Click);
				return b;
			}

			// Row 0 (buttons row index)
			this.Controls.Add(Make("MC", 0, 0));
			this.Controls.Add(Make("MR", 1, 0));
			this.Controls.Add(Make("MS", 2, 0));
			this.Controls.Add(Make("M+", 3, 0));
			this.Controls.Add(Make("M-", 4, 0));

			// Row 1
			this.Controls.Add(Make("←", 0, 1));
			this.Controls.Add(Make("CE", 1, 1));
			this.Controls.Add(Make("C", 2, 1));
			this.Controls.Add(Make("±", 3, 1));
			this.Controls.Add(Make("√", 4, 1));

			// Row 2
			this.Controls.Add(Make("7", 0, 2));
			this.Controls.Add(Make("8", 1, 2));
			this.Controls.Add(Make("9", 2, 2));
			this.Controls.Add(Make("/", 3, 2));
			this.Controls.Add(Make("%", 4, 2));

			// Row 3
			this.Controls.Add(Make("4", 0, 3));
			this.Controls.Add(Make("5", 1, 3));
			this.Controls.Add(Make("6", 2, 3));
			this.Controls.Add(Make("*", 3, 3));
			this.Controls.Add(Make("1/x", 4, 3));

			// Row 4: = cao gấp đôi (row 4 + 5)
			this.Controls.Add(Make("1", 0, 4));
			this.Controls.Add(Make("2", 1, 4));
			this.Controls.Add(Make("3", 2, 4));
			this.Controls.Add(Make("-", 3, 4));

			var btEq = Make("=", 4, 4);
			btEq.Size = new System.Drawing.Size(w, h * 2 + gap);
			this.Controls.Add(btEq);

			// Row 5
			// 0 span 2 cột
			this.Controls.Add(Make("0", 0, 5, 2));
			this.Controls.Add(Make(".", 2, 5));
			this.Controls.Add(Make("+", 3, 5));

			// Form11
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 420);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Name = "Form11";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
