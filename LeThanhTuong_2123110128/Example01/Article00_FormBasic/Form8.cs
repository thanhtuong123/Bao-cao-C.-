using System;
using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	public partial class Form8 : Form
	{
		public Form8()
		{
			InitializeComponent();
		}

		private bool TryGetXY(out int x, out int y)
		{
			x = 0; y = 0;

			if (string.IsNullOrWhiteSpace(tbSoX.Text) || string.IsNullOrWhiteSpace(tbSoY.Text))
			{
				MessageBox.Show("Vui lòng nhập đủ Số x và Số y!", "Thiếu dữ liệu",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			if (!int.TryParse(tbSoX.Text, out x) || !int.TryParse(tbSoY.Text, out y))
			{
				MessageBox.Show("Số x và Số y phải là số nguyên!", "Lỗi nhập liệu",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private void btCong_Click(object sender, EventArgs e)
		{
			if (!TryGetXY(out int x, out int y)) return;
			int kq = x + y;
			tbKetQua.Text = kq.ToString();
		}

		private void btNhan_Click(object sender, EventArgs e)
		{
			if (!TryGetXY(out int x, out int y)) return;
			int kq = x * y;
			tbKetQua.Text = kq.ToString();
		}

		private void btThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
