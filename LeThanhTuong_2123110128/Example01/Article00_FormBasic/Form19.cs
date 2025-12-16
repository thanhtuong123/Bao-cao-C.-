using System;
using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	public partial class Form19 : Form
	{
		public Form19()
		{
			InitializeComponent();
		}

		private void btFile_Click(object sender, EventArgs e)
		{
			pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

			using (OpenFileDialog dlg = new OpenFileDialog())
			{
				dlg.Title = "Open Image";
				dlg.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All files (*.*)|*.*";

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					pbImage.ImageLocation = dlg.FileName; // hoặc: pbImage.Image = Image.FromFile(dlg.FileName);
				}
			}
		}
	}
}
