namespace LeThanhTuong_2123110128
{
	partial class Form20
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.dgvEmployee = new System.Windows.Forms.DataGridView();
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colGender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbId = new System.Windows.Forms.TextBox();
			this.tbName = new System.Windows.Forms.TextBox();
			this.tbAge = new System.Windows.Forms.TextBox();
			this.ckGender = new System.Windows.Forms.CheckBox();
			this.btAddNew = new System.Windows.Forms.Button();
			this.btDelete = new System.Windows.Forms.Button();
			this.btExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvEmployee
			// 
			this.dgvEmployee.AllowUserToAddRows = false;
			this.dgvEmployee.AllowUserToDeleteRows = false;
			this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colId,
			this.colName,
			this.colAge,
			this.colGender});
			this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
			this.dgvEmployee.Name = "dgvEmployee";
			this.dgvEmployee.RowHeadersWidth = 51;
			this.dgvEmployee.RowTemplate.Height = 24;
			this.dgvEmployee.Size = new System.Drawing.Size(760, 210);
			this.dgvEmployee.TabIndex = 0;
			this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);
			// 
			// colId
			// 
			this.colId.HeaderText = "Mã nhân viên";
			this.colId.MinimumWidth = 6;
			this.colId.Name = "colId";
			this.colId.Width = 160;
			// 
			// colName
			// 
			this.colName.HeaderText = "Tên nhân viên";
			this.colName.MinimumWidth = 6;
			this.colName.Name = "colName";
			this.colName.Width = 280;
			// 
			// colAge
			// 
			this.colAge.HeaderText = "Tuổi";
			this.colAge.MinimumWidth = 6;
			this.colAge.Name = "colAge";
			this.colAge.Width = 120;
			// 
			// colGender
			// 
			this.colGender.HeaderText = "Giới tính (Nam)";
			this.colGender.MinimumWidth = 6;
			this.colGender.Name = "colGender";
			this.colGender.Width = 140;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 252);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mã";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 292);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 332);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Tuổi";
			// 
			// tbId
			// 
			this.tbId.Location = new System.Drawing.Point(90, 249);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(220, 22);
			this.tbId.TabIndex = 4;
			// 
			// tbName
			// 
			this.tbName.Location = new System.Drawing.Point(90, 289);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(420, 22);
			this.tbName.TabIndex = 5;
			// 
			// tbAge
			// 
			this.tbAge.Location = new System.Drawing.Point(90, 329);
			this.tbAge.Name = "tbAge";
			this.tbAge.Size = new System.Drawing.Size(220, 22);
			this.tbAge.TabIndex = 6;
			// 
			// ckGender
			// 
			this.ckGender.AutoSize = true;
			this.ckGender.Location = new System.Drawing.Point(90, 369);
			this.ckGender.Name = "ckGender";
			this.ckGender.Size = new System.Drawing.Size(54, 20);
			this.ckGender.TabIndex = 7;
			this.ckGender.Text = "Nam";
			this.ckGender.UseVisualStyleBackColor = true;
			// 
			// btAddNew
			// 
			this.btAddNew.Location = new System.Drawing.Point(370, 400);
			this.btAddNew.Name = "btAddNew";
			this.btAddNew.Size = new System.Drawing.Size(110, 32);
			this.btAddNew.TabIndex = 8;
			this.btAddNew.Text = "Thêm";
			this.btAddNew.UseVisualStyleBackColor = true;
			this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);
			// 
			// btDelete
			// 
			this.btDelete.Location = new System.Drawing.Point(500, 400);
			this.btDelete.Name = "btDelete";
			this.btDelete.Size = new System.Drawing.Size(110, 32);
			this.btDelete.TabIndex = 9;
			this.btDelete.Text = "Xóa";
			this.btDelete.UseVisualStyleBackColor = true;
			this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
			// 
			// btExit
			// 
			this.btExit.Location = new System.Drawing.Point(630, 400);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(110, 32);
			this.btExit.TabIndex = 10;
			this.btExit.Text = "Thoát";
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			// 
			// Form20
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 451);
			this.Controls.Add(this.btExit);
			this.Controls.Add(this.btDelete);
			this.Controls.Add(this.btAddNew);
			this.Controls.Add(this.ckGender);
			this.Controls.Add(this.tbAge);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.tbId);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvEmployee);
			this.Name = "Form20";
			this.Text = "Form20 - DataGridView";
			this.Load += new System.EventHandler(this.Form20_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvEmployee;
		private System.Windows.Forms.DataGridViewTextBoxColumn colId;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colGender;

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbAge;
		private System.Windows.Forms.CheckBox ckGender;
		private System.Windows.Forms.Button btAddNew;
		private System.Windows.Forms.Button btDelete;
		private System.Windows.Forms.Button btExit;
	}
}
