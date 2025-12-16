using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LeThanhTuong_2123110128
{
	public partial class Form22 : Form
	{
		private readonly BindingSource bs = new BindingSource();
		private BindingList<Employee> lstEmp;

		public Form22()
		{
			InitializeComponent();
		}

		private BindingList<Employee> GetData()
		{
			return new BindingList<Employee>
			{
				new Employee { Id = "53418", Name = "Trần Tiến",   Age = 20, Gender = true  },
				new Employee { Id = "53416", Name = "Nguyễn Cường",Age = 25, Gender = false },
				new Employee { Id = "53417", Name = "Nguyễn Hào",  Age = 23, Gender = true  },
			};
		}

		private void Form22_Load(object sender, EventArgs e)
		{
			lstEmp = GetData();

			bs.DataSource = lstEmp;
			dgvEmployee.AutoGenerateColumns = false; // vì mình tự tạo cột và map DataPropertyName
			dgvEmployee.DataSource = bs;

			if (dgvEmployee.Rows.Count > 0)
				dgvEmployee.Rows[0].Selected = true;
		}

		private void btAddNew_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tbId.Text) || string.IsNullOrWhiteSpace(tbName.Text))
			{
				MessageBox.Show("Vui lòng nhập Mã và Tên.");
				return;
			}

			if (!int.TryParse(tbAge.Text, out int age))
			{
				MessageBox.Show("Tuổi phải là số.");
				return;
			}

			var em = new Employee
			{
				Id = tbId.Text.Trim(),
				Name = tbName.Text.Trim(),
				Age = age,
				Gender = ckGender.Checked
			};

			// BindingSource sẽ tự cập nhật DataGridView
			bs.Add(em);

			// chọn dòng mới thêm
			int idx = bs.Count - 1;
			if (idx >= 0)
			{
				dgvEmployee.ClearSelection();
				dgvEmployee.Rows[idx].Selected = true;
				dgvEmployee.CurrentCell = dgvEmployee.Rows[idx].Cells[0];
			}
		}

		private void btDelete_Click(object sender, EventArgs e)
		{
			if (bs.Current == null) return;

			int idx = dgvEmployee.CurrentCell?.RowIndex ?? -1;
			if (idx < 0) return;

			// xóa trên BindingSource (lstEmp cũng bị xóa theo vì bs.DataSource = lstEmp)
			bs.RemoveAt(idx);
		}

		private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			var row = dgvEmployee.Rows[e.RowIndex];
			var em = row.DataBoundItem as Employee;
			if (em == null) return;

			tbId.Text = em.Id;
			tbName.Text = em.Name;
			tbAge.Text = em.Age.ToString();
			ckGender.Checked = em.Gender;
		}

		private void btExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
