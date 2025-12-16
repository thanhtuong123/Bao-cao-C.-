using System;
using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	public partial class Form20 : Form
	{
		public Form20()
		{
			InitializeComponent();
		}

		private void Form20_Load(object sender, EventArgs e)
		{
			// Chọn nguyên dòng cho giống hình
			dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dgvEmployee.MultiSelect = false;

			// Thêm dữ liệu mẫu (em có thể bỏ nếu không cần)
			dgvEmployee.Rows.Add("53418", "Trần Tiến", "20", true);
			dgvEmployee.Rows.Add("53416", "Nguyễn Cường", "25", false);
			dgvEmployee.Rows.Add("53417", "Nguyễn Hào", "23", true);
		}

		private void btAddNew_Click(object sender, EventArgs e)
		{
			dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked);
		}

		private void btDelete_Click(object sender, EventArgs e)
		{
			if (dgvEmployee.CurrentCell == null) return;

			int idx = dgvEmployee.CurrentCell.RowIndex;
			if (idx >= 0 && idx < dgvEmployee.Rows.Count)
			{
				// Nếu đang chọn dòng "new row" (dòng trống cuối) thì tránh xóa lỗi
				if (dgvEmployee.Rows[idx].IsNewRow) return;

				dgvEmployee.Rows.RemoveAt(idx);
			}
		}

		private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			int idx = e.RowIndex;
			if (idx < 0 || idx >= dgvEmployee.Rows.Count) return;
			if (dgvEmployee.Rows[idx].IsNewRow) return;

			tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value?.ToString() ?? "";
			tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value?.ToString() ?? "";
			tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value?.ToString() ?? "";

			bool gender = false;
			bool.TryParse(dgvEmployee.Rows[idx].Cells[3].Value?.ToString() ?? "False", out gender);
			ckGender.Checked = gender;
		}

		private void btExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
