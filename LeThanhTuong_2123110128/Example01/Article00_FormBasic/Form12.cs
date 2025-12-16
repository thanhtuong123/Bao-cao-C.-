using System;
using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	public partial class Form12 : Form
	{
		public Form12()
		{
			InitializeComponent();
			Text = "Article 12 - ComboBox";
		}

		private void Form12_Load(object sender, EventArgs e)
		{
			// giống slide: chọn sẵn mục thứ 3 (index = 2)
			if (cbFaculty.Items.Count > 2)
				cbFaculty.SelectedIndex = 2;
		}

		private void cbFaculty_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = cbFaculty.SelectedIndex;
			tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			if (cbFaculty.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn 1 khoa!", "Thông báo",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			string item = cbFaculty.SelectedItem.ToString();
			tbDisplay.Text = "Bạn là sinh viên khoa: " + item;
		}

		private void btClear_Click(object sender, EventArgs e)
		{
			tbDisplay.Clear();
			if (cbFaculty.Items.Count > 0) cbFaculty.SelectedIndex = 0;
		}
	}
}
