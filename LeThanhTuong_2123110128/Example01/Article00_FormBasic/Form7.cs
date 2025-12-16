using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	public partial class Form7 : Form
	{
		public Form7()
		{
			InitializeComponent();
			this.Text = "Article 07 - TextBox";
		}

		// Chỉ cho nhập số + phím điều khiển (Backspace, Delete, mũi tên...)
		private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
				e.Handled = true;
		}

		// Kiểm tra Year khi rời textbox
		private void tbYear_Validating(object sender, CancelEventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbYear.Text))
				return;

			if (!int.TryParse(tbYear.Text, out int year))
			{
				MessageBox.Show("Year phải là số!", "Lỗi nhập liệu",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Cancel = true;
				return;
			}

			if (year > 2000)
			{
				MessageBox.Show("Year phải <= 2000", "Lỗi nhập liệu",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				e.Cancel = true; // KHÔNG cho rời textbox
			}
		}

		// Phone: chỉ cho nhập số + phím điều khiển
		private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
				e.Handled = true;
		}
	}
}
