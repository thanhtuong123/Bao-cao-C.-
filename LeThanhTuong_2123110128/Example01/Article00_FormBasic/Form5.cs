using System;
using System.IO;
using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	public partial class Form5 : Form
	{
		string logPath = "Key_Logger.txt";

		public Form5()
		{
			InitializeComponent();
			this.Text = "Article 05 - Key Logger";
		}

		private void Form5_KeyUp(object sender, KeyEventArgs e)
		{
			using (StreamWriter sw = new StreamWriter(logPath, true))
			{
				sw.WriteLine(
					DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")
					+ " : " + e.KeyCode
				);
			}
		}

		private void bt_OK_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Đã ghi phím vào file log", "Article 05");
		}
	}
}
