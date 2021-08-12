
namespace FINAL
{
    partial class fQLDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLDiem));
            this.btnXemd = new System.Windows.Forms.Button();
            this.btnEditd = new System.Windows.Forms.Button();
            this.btnRemoved = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDiem = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHotend = new System.Windows.Forms.ComboBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.cbTenMHd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMHd = new System.Windows.Forms.TextBox();
            this.diemHPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemHPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXemd
            // 
            this.btnXemd.Image = global::FINAL.Properties.Resources.list__1_1;
            this.btnXemd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemd.Location = new System.Drawing.Point(139, 249);
            this.btnXemd.Name = "btnXemd";
            this.btnXemd.Size = new System.Drawing.Size(130, 45);
            this.btnXemd.TabIndex = 6;
            this.btnXemd.Text = "Load";
            this.btnXemd.UseVisualStyleBackColor = true;
            this.btnXemd.Click += new System.EventHandler(this.btnXemd_Click);
            // 
            // btnEditd
            // 
            this.btnEditd.Image = global::FINAL.Properties.Resources.update;
            this.btnEditd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditd.Location = new System.Drawing.Point(139, 344);
            this.btnEditd.Name = "btnEditd";
            this.btnEditd.Size = new System.Drawing.Size(130, 45);
            this.btnEditd.TabIndex = 9;
            this.btnEditd.Text = "Update";
            this.btnEditd.UseVisualStyleBackColor = true;
            this.btnEditd.Click += new System.EventHandler(this.btnEditd_Click);
            // 
            // btnRemoved
            // 
            this.btnRemoved.Image = global::FINAL.Properties.Resources.cancel__1_;
            this.btnRemoved.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoved.Location = new System.Drawing.Point(268, 292);
            this.btnRemoved.Name = "btnRemoved";
            this.btnRemoved.Size = new System.Drawing.Size(115, 46);
            this.btnRemoved.TabIndex = 8;
            this.btnRemoved.Text = "Delete";
            this.btnRemoved.UseVisualStyleBackColor = true;
            this.btnRemoved.Click += new System.EventHandler(this.btnRemoved_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Họ tên";
            // 
            // btnAddd
            // 
            this.btnAddd.Image = global::FINAL.Properties.Resources.add2;
            this.btnAddd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddd.Location = new System.Drawing.Point(32, 292);
            this.btnAddd.Name = "btnAddd";
            this.btnAddd.Size = new System.Drawing.Size(108, 45);
            this.btnAddd.TabIndex = 7;
            this.btnAddd.Text = "Add";
            this.btnAddd.UseVisualStyleBackColor = true;
            this.btnAddd.Click += new System.EventHandler(this.btnAddd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã sinh viên";
            // 
            // dtgvDiem
            // 
            this.dtgvDiem.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV,
            this.MaMH,
            this.TenMH,
            this.Diem});
            this.dtgvDiem.Location = new System.Drawing.Point(429, 40);
            this.dtgvDiem.Name = "dtgvDiem";
            this.dtgvDiem.RowHeadersWidth = 51;
            this.dtgvDiem.RowTemplate.Height = 24;
            this.dtgvDiem.Size = new System.Drawing.Size(535, 336);
            this.dtgvDiem.TabIndex = 10;
            this.dtgvDiem.DoubleClick += new System.EventHandler(this.dtgvDiem_DoubleClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.DataSource = this.diemHPBindingSource;
            this.MaSV.DisplayMember = "MaSV";
            this.MaSV.HeaderText = "Mã số sinh viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaSV.Width = 125;
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "Họ tên";
            this.TenSV.MinimumWidth = 6;
            this.TenSV.Name = "TenSV";
            this.TenSV.Width = 125;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã môn học";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            this.MaMH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaMH.Width = 125;
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.DataSource = this.monhocBindingSource;
            this.TenMH.DisplayMember = "TenMH";
            this.TenMH.HeaderText = "Tên môn học";
            this.TenMH.MinimumWidth = 6;
            this.TenMH.Name = "TenMH";
            this.TenMH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenMH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TenMH.Width = 125;
            // 
            // Diem
            // 
            this.Diem.DataPropertyName = "Diem";
            this.Diem.HeaderText = "Điểm";
            this.Diem.MinimumWidth = 6;
            this.Diem.Name = "Diem";
            this.Diem.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Mã môn học";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(146, 221);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(218, 22);
            this.txtDiem.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Điểm";
            // 
            // cbHotend
            // 
            this.cbHotend.FormattingEnabled = true;
            this.cbHotend.Location = new System.Drawing.Point(146, 89);
            this.cbHotend.Name = "cbHotend";
            this.cbHotend.Size = new System.Drawing.Size(218, 24);
            this.cbHotend.TabIndex = 2;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Enabled = false;
            this.txtMaSV.Location = new System.Drawing.Point(146, 40);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(218, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // cbTenMHd
            // 
            this.cbTenMHd.FormattingEnabled = true;
            this.cbTenMHd.Location = new System.Drawing.Point(146, 176);
            this.cbTenMHd.Name = "cbTenMHd";
            this.cbTenMHd.Size = new System.Drawing.Size(218, 24);
            this.cbTenMHd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 53;
            this.label3.Text = "Tên môn học";
            // 
            // txtMaMHd
            // 
            this.txtMaMHd.Enabled = false;
            this.txtMaMHd.Location = new System.Drawing.Point(146, 139);
            this.txtMaMHd.Name = "txtMaMHd";
            this.txtMaMHd.Size = new System.Drawing.Size(218, 22);
            this.txtMaMHd.TabIndex = 3;
            // 
            // diemHPBindingSource
            // 
            this.diemHPBindingSource.DataSource = typeof(FINAL.DiemHP);
            // 
            // monhocBindingSource
            // 
            this.monhocBindingSource.DataSource = typeof(FINAL.Monhoc);
            // 
            // sinhvienBindingSource
            // 
            this.sinhvienBindingSource.DataSource = typeof(FINAL.Sinhvien);
            // 
            // fQLDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(976, 401);
            this.Controls.Add(this.txtMaMHd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTenMHd);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.cbHotend);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgvDiem);
            this.Controls.Add(this.btnXemd);
            this.Controls.Add(this.btnEditd);
            this.Controls.Add(this.btnRemoved);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddd);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fQLDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Điểm";
            this.Load += new System.EventHandler(this.fQLDiem_Load);
            this.DoubleClick += new System.EventHandler(this.fQLDiem_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemHPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemd;
        private System.Windows.Forms.Button btnEditd;
        private System.Windows.Forms.Button btnRemoved;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbHotend;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox cbTenMHd;
        private System.Windows.Forms.BindingSource sinhvienBindingSource;
        private System.Windows.Forms.BindingSource diemHPBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewComboBoxColumn TenMH;
        private System.Windows.Forms.BindingSource monhocBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
        private System.Windows.Forms.TextBox txtMaMHd;
    }
}