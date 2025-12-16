using System.Windows.Forms;

namespace LeThanhTuong_2123110128
{
	partial class Form22
	{
		private System.ComponentModel.IContainer components = null;

		private DataGridView dgvEmployee;
		private TextBox tbId;
		private TextBox tbName;
		private TextBox tbAge;
		private CheckBox ckGender;
		private Button btAddNew;
		private Button btDelete;
		private Button btExit;
		private Label lbId;
		private Label lbName;
		private Label lbAge;

		private DataGridViewTextBoxColumn colId;
		private DataGridViewTextBoxColumn colName;
		private DataGridViewTextBoxColumn colAge;
		private DataGridViewCheckBoxColumn colGender;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();

			this.dgvEmployee = new DataGridView();
			this.tbId = new TextBox();
			this.tbName = new TextBox();
			this.tbAge = new TextBox();
			this.ckGender = new CheckBox();
			this.btAddNew = new Button();
			this.btDelete = new Button();
			this.btExit = new Button();
			this.lbId = new Label();
			this.lbName = new Label();
			this.lbAge = new Label();

			this.colId = new DataGridViewTextBoxColumn();
			this.colName = new DataGridViewTextBoxColumn();
			this.colAge = new DataGridViewTextBoxColumn();
			this.colGender = new DataGridViewCheckBoxColumn();

			((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
			this.SuspendLayout();

			// dgvEmployee
			this.dgvEmployee.AllowUserToAddRows = false;
			this.dgvEmployee.AllowUserToDeleteRows = false;
			this.dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dgvEmployee.MultiSelect = false;
			this.dgvEmployee.ReadOnly = true;
			this.dgvEmployee.RowHeadersWidth = 40;
			this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
			this.dgvEmployee.Size = new System.Drawing.Size(760, 220);
			this.dgvEmployee.RowEnter += new DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);

			// columns
			this.colId.HeaderText = "Mã nhân viên";
			this.colId.DataPropertyName = "Id";
			this.colId.Width = 140;

			this.colName.HeaderText = "Tên nhân viên";
			this.colName.DataPropertyName = "Name";
			this.colName.Width = 260;

			this.colAge.HeaderText = "Tuổi";
			this.colAge.DataPropertyName = "Age";
			this.colAge.Width = 80;

			this.colGender.HeaderText = "Giới tính (Nam)";
			this.colGender.DataPropertyName = "Gender";
			this.colGender.Width = 140;

			this.dgvEmployee.Columns.AddRange(new DataGridViewColumn[]
			{
				this.colId, this.colName, this.colAge, this.colGender
			});

			// Labels + inputs
			this.lbId.Text = "Mã";
			this.lbId.Location = new System.Drawing.Point(12, 250);
			this.lbId.AutoSize = true;

			this.tbId.Location = new System.Drawing.Point(80, 246);
			this.tbId.Size = new System.Drawing.Size(220, 23);

			this.lbName.Text = "Tên";
			this.lbName.Location = new System.Drawing.Point(12, 285);
			this.lbName.AutoSize = true;

			this.tbName.Location = new System.Drawing.Point(80, 281);
			this.tbName.Size = new System.Drawing.Size(420, 23);

			this.lbAge.Text = "Tuổi";
			this.lbAge.Location = new System.Drawing.Point(12, 320);
			this.lbAge.AutoSize = true;

			this.tbAge.Location = new System.Drawing.Point(80, 316);
			this.tbAge.Size = new System.Drawing.Size(120, 23);

			this.ckGender.Text = "Nam";
			this.ckGender.Location = new System.Drawing.Point(80, 350);
			this.ckGender.AutoSize = true;

			// Buttons
			this.btAddNew.Text = "Thêm";
			this.btAddNew.Location = new System.Drawing.Point(420, 390);
			this.btAddNew.Size = new System.Drawing.Size(110, 32);
			this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);

			this.btDelete.Text = "Xóa";
			this.btDelete.Location = new System.Drawing.Point(540, 390);
			this.btDelete.Size = new System.Drawing.Size(110, 32);
			this.btDelete.Click += new System.EventHandler(this.btDelete_Click);

			this.btExit.Text = "Thoát";
			this.btExit.Location = new System.Drawing.Point(660, 390);
			this.btExit.Size = new System.Drawing.Size(110, 32);
			this.btExit.Click += new System.EventHandler(this.btExit_Click);

			// Form22
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 441);
			this.Controls.Add(this.dgvEmployee);
			this.Controls.Add(this.lbId);
			this.Controls.Add(this.tbId);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.lbAge);
			this.Controls.Add(this.tbAge);
			this.Controls.Add(this.ckGender);
			this.Controls.Add(this.btAddNew);
			this.Controls.Add(this.btDelete);
			this.Controls.Add(this.btExit);
			this.Text = "Form22 - BindingSource + DataGridView";
			this.Load += new System.EventHandler(this.Form22_Load);

			((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
