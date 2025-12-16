using System;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LeThanhTuong_2123110128
{
	public partial class Form14 : Form
	{
		public Form14()
		{
			InitializeComponent();
			tbDiscount.Enabled = ckDiscount.Checked;
			tbDiscount.Text = "0";
		}

		private void CkDiscount_CheckedChanged(object sender, EventArgs e)
		{
			tbDiscount.Enabled = ckDiscount.Checked;
			if (!ckDiscount.Checked)
			{
				tbDiscount.Text = "0";
			}
			tbDiscount.Focus();
			tbDiscount.SelectAll();
		}

		private void BtRun_Click(object sender, EventArgs e)
		{
			string prefix = "";
			if (rbMale.Checked) prefix = "Ông ";
			else if (rbFemale.Checked) prefix = "Bà ";

			string name = tbName.Text.Trim();
			if (string.IsNullOrWhiteSpace(name))
			{
				MessageBox.Show("Vui lòng nhập tên!", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				tbName.Focus();
				return;
			}

			int disc = 0;
			if (ckDiscount.Checked)
			{
				if (!int.TryParse(tbDiscount.Text.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out disc))
				{
					MessageBox.Show("Giảm giá phải là số nguyên (vd: 5, 7, 10)!", "Lỗi",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					tbDiscount.Focus();
					tbDiscount.SelectAll();
					return;
				}

				if (disc < 0) disc = 0;
				if (disc > 100) disc = 100;
			}

			tbResult.Text = $"{prefix}{name} được giảm {disc}%\r\n";
		}

		private void BtExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
