using System;
using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			Application.Run(new Form14());
		}
	}
}
