using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LeThanhTuong_2123110128
{
	public partial class Form3 : Form
	{
		private readonly string path = Path.Combine(Application.StartupPath, "form.xml");

		public Form3()
		{
			InitializeComponent();
			Text = "Article 03 - Save Window Position";
		}

		private void Write(InfoWindows iw)
		{
			try
			{
				var writer = new XmlSerializer(typeof(InfoWindows));
				using var file = new StreamWriter(path);
				writer.Serialize(file, iw);
			}
			catch { }
		}

		private InfoWindows Read()
		{
			if (!File.Exists(path)) return null;

			try
			{
				var reader = new XmlSerializer(typeof(InfoWindows));
				using var file = new StreamReader(path);
				return (InfoWindows)reader.Deserialize(file);
			}
			catch
			{
				return null;
			}
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			var iw = Read();
			if (iw == null) return;

			StartPosition = FormStartPosition.Manual;

			Width = iw.Width;
			Height = iw.Height;
			Location = iw.Location; // ✅ dùng wrapper Location

			var state = (FormWindowState)iw.WindowState;
			if (state == FormWindowState.Maximized || state == FormWindowState.Normal)
				WindowState = state;
		}

		private void Form3_FormClosing(object sender, FormClosingEventArgs e)
		{
			Rectangle bounds = (WindowState == FormWindowState.Normal) ? Bounds : RestoreBounds;

			var iw = new InfoWindows
			{
				Width = bounds.Width,
				Height = bounds.Height,
				X = bounds.X,
				Y = bounds.Y,
				WindowState = (int)WindowState
			};

			Write(iw);
		}
	}
}
