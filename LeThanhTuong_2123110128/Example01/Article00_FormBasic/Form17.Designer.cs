namespace LeThanhTuong_2123110128
{
	partial class Form17
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.lbSong = new System.Windows.Forms.ListBox();
			this.lbFavorite = new System.Windows.Forms.ListBox();
			this.btSelect = new System.Windows.Forms.Button();
			this.btDeselect = new System.Windows.Forms.Button();
			this.btSelectAll = new System.Windows.Forms.Button();
			this.btDeselectAll = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbSong
			// 
			this.lbSong.FormattingEnabled = true;
			this.lbSong.ItemHeight = 15;
			this.lbSong.Location = new System.Drawing.Point(20, 20);
			this.lbSong.Name = "lbSong";
			this.lbSong.Size = new System.Drawing.Size(260, 364);
			this.lbSong.TabIndex = 0;
			this.lbSong.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSong_MouseDoubleClick);
			// 
			// lbFavorite
			// 
			this.lbFavorite.FormattingEnabled = true;
			this.lbFavorite.ItemHeight = 15;
			this.lbFavorite.Location = new System.Drawing.Point(420, 20);
			this.lbFavorite.Name = "lbFavorite";
			this.lbFavorite.Size = new System.Drawing.Size(260, 364);
			this.lbFavorite.TabIndex = 1;
			this.lbFavorite.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFavorite_MouseDoubleClick);
			// 
			// btSelect
			// 
			this.btSelect.Location = new System.Drawing.Point(305, 120);
			this.btSelect.Name = "btSelect";
			this.btSelect.Size = new System.Drawing.Size(90, 35);
			this.btSelect.TabIndex = 2;
			this.btSelect.Text = ">";
			this.btSelect.UseVisualStyleBackColor = true;
			this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
			// 
			// btDeselect
			// 
			this.btDeselect.Location = new System.Drawing.Point(305, 165);
			this.btDeselect.Name = "btDeselect";
			this.btDeselect.Size = new System.Drawing.Size(90, 35);
			this.btDeselect.TabIndex = 3;
			this.btDeselect.Text = "<";
			this.btDeselect.UseVisualStyleBackColor = true;
			this.btDeselect.Click += new System.EventHandler(this.btDeselect_Click);
			// 
			// btSelectAll
			// 
			this.btSelectAll.Location = new System.Drawing.Point(305, 210);
			this.btSelectAll.Name = "btSelectAll";
			this.btSelectAll.Size = new System.Drawing.Size(90, 35);
			this.btSelectAll.TabIndex = 4;
			this.btSelectAll.Text = ">>";
			this.btSelectAll.UseVisualStyleBackColor = true;
			this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);
			// 
			// btDeselectAll
			// 
			this.btDeselectAll.Location = new System.Drawing.Point(305, 255);
			this.btDeselectAll.Name = "btDeselectAll";
			this.btDeselectAll.Size = new System.Drawing.Size(90, 35);
			this.btDeselectAll.TabIndex = 5;
			this.btDeselectAll.Text = "<<";
			this.btDeselectAll.UseVisualStyleBackColor = true;
			this.btDeselectAll.Click += new System.EventHandler(this.btDeselectAll_Click);
			// 
			// Form17
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 410);
			this.Controls.Add(this.btDeselectAll);
			this.Controls.Add(this.btSelectAll);
			this.Controls.Add(this.btDeselect);
			this.Controls.Add(this.btSelect);
			this.Controls.Add(this.lbFavorite);
			this.Controls.Add(this.lbSong);
			this.Name = "Form17";
			this.Text = "Article 17 - ListBox";
			this.ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.ListBox lbSong;
		private System.Windows.Forms.ListBox lbFavorite;
		private System.Windows.Forms.Button btSelect;
		private System.Windows.Forms.Button btDeselect;
		private System.Windows.Forms.Button btSelectAll;
		private System.Windows.Forms.Button btDeselectAll;
	}
}
