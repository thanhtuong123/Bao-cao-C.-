using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace LeThanhTuong_2123110128
{
	public partial class Form15 : Form
	{
		public Form15()
		{
			InitializeComponent();
			Text = "Article 15 - DateTimePicker";
		}

		private void Form15_Load(object sender, EventArgs e)
		{
			// giống slide: hiển thị tiêu đề theo ngày đang chọn
			this.Text = dtpDate.Value.ToShortDateString();
		}

		private void dtpDate_ValueChanged(object sender, EventArgs e)
		{
			this.Text = dtpDate.Value.ToShortDateString();
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			this.Text = dtpDate.Value.ToLongDateString();
			tbShow.Text = dtpDate.Value.ToLongDateString();
		}

		private void btExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
