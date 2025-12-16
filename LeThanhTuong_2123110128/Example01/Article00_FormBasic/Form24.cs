using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	public partial class Form24 : Form
	{
		private int _seconds = 0;

		public Form24()
		{
			InitializeComponent();

			// Init UI state
			lblDisplay.Text = "00:00";
			btStop.Enabled = false;

			tmStopwatch.Interval = 1000; // 1 giây
		}

		private void btStart_Click(object sender, EventArgs e)
		{
			tmStopwatch.Start();
			btStart.Enabled = false;
			btStop.Enabled = true;
		}

		private void btStop_Click(object sender, EventArgs e)
		{
			tmStopwatch.Stop();
			btStart.Enabled = true;
			btStop.Enabled = false;
		}

		private void tmStopwatch_Tick(object sender, EventArgs e)
		{
			_seconds++;

			// format mm:ss
			var ts = TimeSpan.FromSeconds(_seconds);
			lblDisplay.Text = ts.ToString(@"mm\:ss");
		}
	}
}
