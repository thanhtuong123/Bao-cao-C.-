using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LeThanhTuong_2123110128
{
	public partial class Form1 : Form
	{
		string path = "form.xml";

		public Form1()
		{
			InitializeComponent();
			this.Text = "Article 03 - Save Window Position";
		}

		// ===== GHI FILE =====
		void Write(InfoWindows iw)
		{
			XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
			using (StreamWriter file = new StreamWriter(path))
			{
				writer.Serialize(file, iw);
			}
		}

		// ===== ĐỌC FILE =====
		InfoWindows Read()
		{
			if (!File.Exists(path)) return null;

			XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
			using (StreamReader file = new StreamReader(path))
			{
				return (InfoWindows)reader.Deserialize(file);
			}
		}

		// ===== LOAD FORM =====
		private void Form1_Load(object sender, EventArgs e)
		{
			InfoWindows iw = Read();
			if (iw != null)
			{
				this.StartPosition = FormStartPosition.Manual;
				this.Width = iw.Width;
				this.Height = iw.Height;
				this.Location = iw.Location;
			}
		}

		// ===== ĐÓNG FORM =====
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			InfoWindows iw = new InfoWindows();
			iw.Width = this.Width;
			iw.Height = this.Height;
			iw.Location = this.Location;
			Write(iw);
		}
	}
}
