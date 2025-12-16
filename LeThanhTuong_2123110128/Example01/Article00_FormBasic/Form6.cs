using System;
using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	public partial class Form6 : Form
	{
		public Form6()
		{
			InitializeComponent();
		}

		// Sự kiện TextChanged
		private void txtName_TextChanged(object sender, EventArgs e)
		{
			this.Text = "Typing: " + txtName.Text;
		}

		// Sự kiện Click button
		private void bt_OK_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				"Bạn vừa nhập: " + txtName.Text,
				"Article 06 - TextBox"
			);
		}
	}
}
