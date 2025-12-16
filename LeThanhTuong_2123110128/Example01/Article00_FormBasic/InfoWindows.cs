using System;
using System.Drawing;
using System.Xml.Serialization;

namespace LeThanhTuong_2123110128
{
	[Serializable]
	public class InfoWindows
	{
		public int Width { get; set; }
		public int Height { get; set; }

		public int X { get; set; }
		public int Y { get; set; }

		// Lưu trạng thái cửa sổ (0 Normal, 1 Min, 2 Max)
		public int WindowState { get; set; }

		// Dùng cho code cho tiện, KHÔNG serialize Point trực tiếp
		[XmlIgnore]
		public Point Location
		{
			get => new Point(X, Y);
			set { X = value.X; Y = value.Y; }
		}
	}
}
