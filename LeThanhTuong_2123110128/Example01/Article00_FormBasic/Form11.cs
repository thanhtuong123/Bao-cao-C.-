using System;
using System.Globalization;
using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	public partial class Form11 : Form
	{
		private decimal memory = 0;
		private decimal workingMemory = 0;
		private string opr = "";

		public Form11()
		{
			InitializeComponent();
			Text = "Article 11 - Calculator";
		}

		private void Button_Click(object sender, EventArgs e)
		{
			Button bt = (Button)sender;
			string t = bt.Text.Trim();

			// số & dấu .
			if ((t.Length == 1 && char.IsDigit(t[0])) || t == ".")
			{
				if (t == "." && txtDisplay.Text.Contains(".")) return;
				txtDisplay.Text += t;
				return;
			}

			// toán tử 2 ngôi
			if (t == "+" || t == "-" || t == "*" || t == "/")
			{
				if (TryGetDisplay(out decimal val))
				{
					opr = t;
					workingMemory = val;
					txtDisplay.Clear();
				}
				return;
			}

			// =
			if (t == "=")
			{
				if (!TryGetDisplay(out decimal secondValue)) return;

				try
				{
					decimal result = secondValue;
					switch (opr)
					{
						case "+": result = workingMemory + secondValue; break;
						case "-": result = workingMemory - secondValue; break;
						case "*": result = workingMemory * secondValue; break;
						case "/":
							if (secondValue == 0) { MessageBox.Show("Không thể chia cho 0"); return; }
							result = workingMemory / secondValue;
							break;
					}
					txtDisplay.Text = result.ToString(CultureInfo.InvariantCulture);
				}
				catch
				{
					MessageBox.Show("Lỗi tính toán!");
				}
				return;
			}

			// ± (trong slide đôi khi ghi "+-")
			if (t == "±" || t == "+-")
			{
				if (TryGetDisplay(out decimal currVal))
				{
					currVal = -currVal;
					txtDisplay.Text = currVal.ToString(CultureInfo.InvariantCulture);
				}
				return;
			}

			// √ (trong slide có thể là "v")
			if (t == "√" || t == "v" || t == "V")
			{
				if (TryGetDisplay(out decimal currVal))
				{
					if (currVal < 0) { MessageBox.Show("Không thể căn bậc 2 số âm"); return; }
					decimal kq = (decimal)Math.Sqrt((double)currVal);
					txtDisplay.Text = kq.ToString(CultureInfo.InvariantCulture);
				}
				return;
			}

			// %
			if (t == "%")
			{
				if (TryGetDisplay(out decimal currVal))
				{
					currVal = currVal / 100m;
					txtDisplay.Text = currVal.ToString(CultureInfo.InvariantCulture);
				}
				return;
			}

			// 1/x
			if (t == "1/x")
			{
				if (TryGetDisplay(out decimal currVal))
				{
					if (currVal == 0) { MessageBox.Show("Không thể chia cho 0"); return; }
					currVal = 1m / currVal;
					txtDisplay.Text = currVal.ToString(CultureInfo.InvariantCulture);
				}
				return;
			}

			// Backspace: ←
			if (t == "←")
			{
				if (txtDisplay.TextLength > 0)
					txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.TextLength - 1);
				return;
			}

			// Memory
			if (t == "MC") { memory = 0; return; }
			if (t == "MR") { txtDisplay.Text = memory.ToString(CultureInfo.InvariantCulture); return; }
			if (t == "MS")
			{
				if (TryGetDisplay(out decimal currVal))
				{
					memory = currVal;
					txtDisplay.Clear();
				}
				return;
			}
			if (t == "M+")
			{
				if (TryGetDisplay(out decimal currVal)) memory += currVal;
				return;
			}
			if (t == "M-")
			{
				if (TryGetDisplay(out decimal currVal)) memory -= currVal;
				return;
			}

			// Clear
			if (t == "C")
			{
				workingMemory = 0;
				opr = "";
				txtDisplay.Clear();
				return;
			}
			if (t == "CE")
			{
				txtDisplay.Clear();
				return;
			}
		}

		private bool TryGetDisplay(out decimal val)
		{
			return decimal.TryParse(txtDisplay.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out val);
		}
	}
}
