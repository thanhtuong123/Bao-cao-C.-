using System;
using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	public partial class Form16 : Form
	{
		private int _stt = 0;

		public Form16()
		{
			InitializeComponent();

			rbMale.Checked = true;

			cbFaculty.Items.AddRange(new object[]
			{
				"Công nghệ thông tin",
				"Ngoại ngữ",
				"Quản trị kinh doanh",
				"Cơ khí",
				"Điện",
				"Cơ khí động lực"
			});
			cbFaculty.SelectedIndex = 0;
		}

		private void BtAdd_Click(object sender, EventArgs e)
		{
			_stt++;

			string gender = rbMale.Checked ? "Nam" : "Nữ";
			string dob = dtBirth.Value.ToString("dd/MM/yyyy");
			string faculty = cbFaculty.SelectedItem?.ToString() ?? "";

			lbStatus.Items.Add($"{_stt}. {tbFullName.Text}");
			lbStatus.Items.Add($"-Giới tính: {gender}");
			lbStatus.Items.Add($"-Ngày Sinh:{dob}");
			lbStatus.Items.Add($"-Khoa: {faculty}");
			lbStatus.Items.Add(""); // dòng trống
		}

		private void BtExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
