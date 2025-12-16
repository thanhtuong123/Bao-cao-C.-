using System;
using System.Drawing;
using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	public partial class Form23 : Form
	{
		private PictureBox pb;
		private Button btLeft;
		private Button btRight;
		private Button btFile;

		// vị trí ảnh
		private int x = 30;
		private int y = 20;

		public Form23()
		{
			Text = "Simple Game - Article 23";
			StartPosition = FormStartPosition.CenterScreen;
			ClientSize = new Size(520, 260);

			InitUI();
		}

		private void InitUI()
		{
			// PictureBox
			pb = new PictureBox();
			pb.Name = "pb";
			pb.Size = new Size(140, 140);
			pb.Location = new Point(x, y);
			pb.SizeMode = PictureBoxSizeMode.StretchImage;
			pb.BorderStyle = BorderStyle.FixedSingle;
			Controls.Add(pb);

			// Button Left
			btLeft = new Button();
			btLeft.Name = "btLeft";
			btLeft.Text = "<-";
			btLeft.Size = new Size(70, 35);
			btLeft.Location = new Point(140, 180);
			btLeft.Click += BtLeft_Click;
			Controls.Add(btLeft);

			// Button Right
			btRight = new Button();
			btRight.Name = "btRight";
			btRight.Text = "->";
			btRight.Size = new Size(70, 35);
			btRight.Location = new Point(220, 180);
			btRight.Click += BtRight_Click;
			Controls.Add(btRight);

			// Button File
			btFile = new Button();
			btFile.Name = "btFile";
			btFile.Text = "File...";
			btFile.Size = new Size(100, 35);
			btFile.Location = new Point(320, 180);
			btFile.Click += BtFile_Click;
			Controls.Add(btFile);
		}

		private void BtFile_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dlg = new OpenFileDialog())
			{
				dlg.Title = "Open Image";
				dlg.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All files (*.*)|*.*";

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					// tránh khóa file: copy ảnh ra memory
					using (var temp = Image.FromFile(dlg.FileName))
					{
						pb.Image?.Dispose();
						pb.Image = new Bitmap(temp);
					}
				}
			}
		}

		private void BtLeft_Click(object sender, EventArgs e)
		{
			if (pb.Image == null) return;

			x -= 10;

			// chặn biên trái
			if (x < 0) x = 0;

			pb.Location = new Point(x, y);
		}

		private void BtRight_Click(object sender, EventArgs e)
		{
			if (pb.Image == null) return;

			x += 10;

			// chặn biên phải
			int maxX = ClientSize.Width - pb.Width;
			if (x > maxX) x = maxX;

			pb.Location = new Point(x, y);
		}
	}
}
