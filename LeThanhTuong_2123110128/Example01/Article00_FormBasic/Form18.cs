using System;
using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	public partial class Form18 : Form
	{
		public Form18()
		{
			InitializeComponent();
		}

		private void btChoose_Click(object sender, EventArgs e)
		{
			using OpenFileDialog ofd = new OpenFileDialog();
			ofd.Title = "Chọn ảnh";
			ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All files|*.*";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				pbPhoto.ImageLocation = ofd.FileName; // đơn giản nhất
													  // hoặc: pbPhoto.Load(ofd.FileName);
			}
		}
	}
}
