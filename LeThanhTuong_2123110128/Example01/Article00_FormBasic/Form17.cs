using System;
using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	public partial class Form17 : Form
	{
		public Form17()
		{
			InitializeComponent();

			lbSong.Items.AddRange(new object[]
			{
		"Giấc mơ Chapi",
		"Đôi mắt Pleiku",
		"Em muốn sống bên anh trọn đời",
		"H'Zen Lên Rẫy",
		"Còn thương nhau thì về Buôn Mê Thuột",
		"Ly cà phê Ban Mê",
		"Đi tìm lời ru mặt trời"
			});
		}
		

		private void MoveSelected(ListBox from, ListBox to)
		{
			if (from.SelectedItem == null) return;
			var item = from.SelectedItem;
			to.Items.Add(item);
			from.Items.Remove(item);
		}

		private void MoveAll(ListBox from, ListBox to)
		{
			for (int i = from.Items.Count - 1; i >= 0; i--)
			{
				var item = from.Items[i];
				to.Items.Add(item);
				from.Items.RemoveAt(i);
			}
		}

		private void btSelect_Click(object sender, EventArgs e) => MoveSelected(lbSong, lbFavorite);
		private void btDeselect_Click(object sender, EventArgs e) => MoveSelected(lbFavorite, lbSong);
		private void btSelectAll_Click(object sender, EventArgs e) => MoveAll(lbSong, lbFavorite);
		private void btDeselectAll_Click(object sender, EventArgs e) => MoveAll(lbFavorite, lbSong);

		private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			int index = lbSong.IndexFromPoint(e.Location);
			if (index == ListBox.NoMatches) return;
			lbSong.SelectedIndex = index;
			MoveSelected(lbSong, lbFavorite);
		}

		private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			int index = lbFavorite.IndexFromPoint(e.Location);
			if (index == ListBox.NoMatches) return;
			lbFavorite.SelectedIndex = index;
			MoveSelected(lbFavorite, lbSong);
		}
	}
}
