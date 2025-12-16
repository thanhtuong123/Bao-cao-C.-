using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	public partial class Form13 : Form
	{
		private List<Faculty> _data = new();

		public Form13()
		{
			InitializeComponent();
			this.Text = "Article 13 - ComboBox";
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private List<Faculty> GetData()
		{
			return new List<Faculty>
			{
				new Faculty { Id = "K01", Name = "Công nghệ thông tin", Quantity = 1200 },
				new Faculty { Id = "K02", Name = "Quản trị kinh doanh",  Quantity = 4200 },
				new Faculty { Id = "K03", Name = "Kế toán tài chính",    Quantity = 5200 },
			};
		}

		private void Form13_Load(object sender, EventArgs e)
		{
			_data = GetData();

			cb_Faculty.DataSource = _data;
			cb_Faculty.DisplayMember = "Name";
			cb_Faculty.ValueMember = "Id";

			cb_Faculty.SelectedIndex = 0;
		}

		private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cb_Faculty.SelectedValue == null) return;

			cb_Faculty.ValueMember = "Id";
			string id = cb_Faculty.SelectedValue.ToString();
			tbDisplay.Text = "Bạn đã chọn khoa có mã: " + id;
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			cb_Faculty.ValueMember = "Name";
			string name = cb_Faculty.SelectedValue.ToString();
			tbDisplay.Text = "Bạn đã chọn khoa có tên: " + name;
		}

		private void btClear_Click(object sender, EventArgs e)
		{
			tbDisplay.Clear();
			cb_Faculty.SelectedIndex = 0;
		}
	}
}
