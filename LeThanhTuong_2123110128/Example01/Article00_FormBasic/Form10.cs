using System;
using System.Globalization;
using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	public partial class Form10 : Form
	{
		decimal workingMemory = 0;
		string opr = "";

		public Form10()
		{
			InitializeComponent();
			this.Text = "Article 10 - Simple Calculator";
		}

		private void bt0_Click(object sender, EventArgs e) { tbDisplay.Text += bt0.Text; }
		private void bt1_Click(object sender, EventArgs e) { tbDisplay.Text += bt1.Text; }
		private void bt2_Click(object sender, EventArgs e) { tbDisplay.Text += bt2.Text; }
		private void bt3_Click(object sender, EventArgs e) { tbDisplay.Text += bt3.Text; }

		private void btDot_Click(object sender, EventArgs e)
		{
			if (tbDisplay.Text == "")
				tbDisplay.Text = "0.";
			else if (!tbDisplay.Text.Contains("."))
				tbDisplay.Text += ".";
		}

		private void btPlus_Click(object sender, EventArgs e)
		{
			opr = btPlus.Text;
			workingMemory = ParseDisplay();
			tbDisplay.Clear();
		}

		private void btMul_Click(object sender, EventArgs e)
		{
			opr = btMul.Text;
			workingMemory = ParseDisplay();
			tbDisplay.Clear();
		}

		private void btEquals_Click(object sender, EventArgs e)
		{
			decimal secondValue = ParseDisplay();

			if (opr == "+")
				tbDisplay.Text = (workingMemory + secondValue).ToString(CultureInfo.InvariantCulture);

			if (opr == "*")
				tbDisplay.Text = (workingMemory * secondValue).ToString(CultureInfo.InvariantCulture);
		}

		private decimal ParseDisplay()
		{
			if (tbDisplay.Text.Trim() == "")
				return 0;

			decimal.TryParse(tbDisplay.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal val);
			return val;
		}
	}
}
