using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LeThanhTuong_2123110128
{
	public partial class Form21 : Form
	{
		private List<Employee> lst;

		public Form21()
		{
			InitializeComponent();
		}

		private List<Employee> GetData()
		{
			var list = new List<Employee>();

			list.Add(new Employee { Id = "53418", Name = "Trần Tiến", Age = 20, Gender = true });
			list.Add(new Employee { Id = "53416", Name = "Nguyễn Cường", Age = 25, Gender = false });
			list.Add(new Employee { Id = "53417", Name = "Nguyễn Hào", Age = 23, Gender = true });

			return list;
		}

		private void Form21_Load(object sender, EventArgs e)
		{
			lst = GetData();

			dgvEmployee.Rows.Clear();
			foreach (Employee em in lst)
			{
				dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
			}
		}

		private void BtAddNew_Click(object sender, EventArgs e)
		{
			string id = tbId.Text.Trim();
			string name = tbName.Text.Trim();
			string ageText = tbAge.Text.Trim();
			bool gender = ckGender.Checked;

			if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ageText))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ Mã, Tên, Tuổi.");
				return;
			}

			if (!int.TryParse(ageText, out int age))
			{
				MessageBox.Show("Tuổi phải là số.");
				return;
			}

			var em = new Employee
			{
				Id = id,
				Name = name,
				Age = age,
				Gender = gender
			};

			lst.Add(em);
			dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
		}

		private void BtDelete_Click(object sender, EventArgs e)
		{
			if (dgvEmployee.CurrentCell == null) return;

			int idx = dgvEmployee.CurrentCell.RowIndex;
			if (idx < 0 || idx >= dgvEmployee.Rows.Count) return;

			// tránh xóa dòng "new row" (nếu AllowUserToAddRows = true)
			if (dgvEmployee.Rows[idx].IsNewRow) return;

			if (idx < lst.Count) lst.RemoveAt(idx);
			dgvEmployee.Rows.RemoveAt(idx);
		}

		private void DgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			int idx = e.RowIndex;
			if (idx < 0 || idx >= dgvEmployee.Rows.Count) return;
			if (dgvEmployee.Rows[idx].IsNewRow) return;

			tbId.Text = dgvEmployee.Rows[idx].Cells[0].Value?.ToString() ?? "";
			tbName.Text = dgvEmployee.Rows[idx].Cells[1].Value?.ToString() ?? "";
			tbAge.Text = dgvEmployee.Rows[idx].Cells[2].Value?.ToString() ?? "";

			object v = dgvEmployee.Rows[idx].Cells[3].Value;
			ckGender.Checked = v != null && bool.TryParse(v.ToString(), out bool b) && b;
		}

		private void BtExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
