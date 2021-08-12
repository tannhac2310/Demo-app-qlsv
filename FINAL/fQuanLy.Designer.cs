
namespace FINAL
{
    partial class fQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLy));
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGioitinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNgaysinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvQLSV = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMalop = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLSV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(182, 272);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(218, 22);
            this.txtDiachi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Địa chỉ";
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Location = new System.Drawing.Point(182, 208);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(218, 22);
            this.txtGioitinh.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Giới tính";
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.Location = new System.Drawing.Point(182, 157);
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.Size = new System.Drawing.Size(218, 22);
            this.txtNgaysinh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ngày sinh";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(182, 102);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(218, 22);
            this.txtHoten.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Họ tên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(182, 50);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(218, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã sinh viên";
            // 
            // dtgvQLSV
            // 
            this.dtgvQLSV.AllowUserToResizeColumns = false;
            this.dtgvQLSV.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgvQLSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQLSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV,
            this.Ngaysinh,
            this.Gioitinh,
            this.Diachi,
            this.Malop});
            this.dtgvQLSV.Location = new System.Drawing.Point(469, 31);
            this.dtgvQLSV.Name = "dtgvQLSV";
            this.dtgvQLSV.ReadOnly = true;
            this.dtgvQLSV.RowHeadersWidth = 51;
            this.dtgvQLSV.RowTemplate.Height = 24;
            this.dtgvQLSV.Size = new System.Drawing.Size(539, 395);
            this.dtgvQLSV.TabIndex = 11;
            this.dtgvQLSV.DoubleClick += new System.EventHandler(this.dtgvQLSV_DoubleClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã số sinh viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            this.MaSV.Width = 125;
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "TenSV";
            this.TenSV.HeaderText = "Họ tên";
            this.TenSV.MinimumWidth = 6;
            this.TenSV.Name = "TenSV";
            this.TenSV.ReadOnly = true;
            this.TenSV.Width = 140;
            // 
            // Ngaysinh
            // 
            this.Ngaysinh.DataPropertyName = "Ngaysinh";
            this.Ngaysinh.HeaderText = "Ngày sinh";
            this.Ngaysinh.MinimumWidth = 6;
            this.Ngaysinh.Name = "Ngaysinh";
            this.Ngaysinh.ReadOnly = true;
            this.Ngaysinh.Width = 125;
            // 
            // Gioitinh
            // 
            this.Gioitinh.DataPropertyName = "Gioitinh";
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.MinimumWidth = 6;
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.ReadOnly = true;
            this.Gioitinh.Width = 125;
            // 
            // Diachi
            // 
            this.Diachi.DataPropertyName = "Diachi";
            this.Diachi.HeaderText = "Địa chỉ";
            this.Diachi.MinimumWidth = 6;
            this.Diachi.Name = "Diachi";
            this.Diachi.ReadOnly = true;
            this.Diachi.Width = 125;
            // 
            // Malop
            // 
            this.Malop.DataPropertyName = "Malop";
            this.Malop.HeaderText = "Mã lớp";
            this.Malop.MinimumWidth = 6;
            this.Malop.Name = "Malop";
            this.Malop.ReadOnly = true;
            this.Malop.Width = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mã lớp";
            // 
            // cbMalop
            // 
            this.cbMalop.FormattingEnabled = true;
            this.cbMalop.Location = new System.Drawing.Point(182, 324);
            this.cbMalop.Name = "cbMalop";
            this.cbMalop.Size = new System.Drawing.Size(218, 24);
            this.cbMalop.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnXem
            // 
            this.btnXem.Image = global::FINAL.Properties.Resources.list__1_;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(343, 368);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(120, 45);
            this.btnXem.TabIndex = 10;
            this.btnXem.Text = "Load";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::FINAL.Properties.Resources.edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(222, 368);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 45);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::FINAL.Properties.Resources.delete1;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(117, 368);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 45);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::FINAL.Properties.Resources.add2;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(12, 368);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 45);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lớpHọcToolStripMenuItem,
            this.điểmToolStripMenuItem,
            this.mônHọcToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Image = global::FINAL.Properties.Resources.administrator;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // lớpHọcToolStripMenuItem
            // 
            this.lớpHọcToolStripMenuItem.Image = global::FINAL.Properties.Resources.guard;
            this.lớpHọcToolStripMenuItem.Name = "lớpHọcToolStripMenuItem";
            this.lớpHọcToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lớpHọcToolStripMenuItem.Text = "Lớp học";
            this.lớpHọcToolStripMenuItem.Click += new System.EventHandler(this.lớpHọcToolStripMenuItem_Click);
            // 
            // điểmToolStripMenuItem
            // 
            this.điểmToolStripMenuItem.Image = global::FINAL.Properties.Resources.code_repository;
            this.điểmToolStripMenuItem.Name = "điểmToolStripMenuItem";
            this.điểmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.điểmToolStripMenuItem.Text = "Điểm";
            this.điểmToolStripMenuItem.Click += new System.EventHandler(this.điểmToolStripMenuItem_Click);
            // 
            // mônHọcToolStripMenuItem
            // 
            this.mônHọcToolStripMenuItem.Image = global::FINAL.Properties.Resources.vulnerability;
            this.mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
            this.mônHọcToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mônHọcToolStripMenuItem.Text = "Môn học";
            this.mônHọcToolStripMenuItem.Click += new System.EventHandler(this.mônHọcToolStripMenuItem_Click);
            // 
            // fQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbMalop);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGioitinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNgaysinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvQLSV);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý SV";
            this.Load += new System.EventHandler(this.fQuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQLSV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGioitinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNgaysinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvQLSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMalop;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem điểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem;
    }
}

