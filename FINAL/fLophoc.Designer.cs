
namespace FINAL
{
    partial class fLophoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLophoc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.dtgvLophoc = new System.Windows.Forms.DataGridView();
            this.Malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddl = new System.Windows.Forms.Button();
            this.btnXoal = new System.Windows.Forms.Button();
            this.btnEditl = new System.Windows.Forms.Button();
            this.btnXeml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLophoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp";
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(82, 46);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(190, 22);
            this.txtmalop.TabIndex = 1;
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(82, 93);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(190, 22);
            this.txttenlop.TabIndex = 2;
            // 
            // dtgvLophoc
            // 
            this.dtgvLophoc.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvLophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLophoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Malop,
            this.Tenlop});
            this.dtgvLophoc.Location = new System.Drawing.Point(298, 46);
            this.dtgvLophoc.Name = "dtgvLophoc";
            this.dtgvLophoc.RowHeadersWidth = 51;
            this.dtgvLophoc.RowTemplate.Height = 24;
            this.dtgvLophoc.Size = new System.Drawing.Size(379, 266);
            this.dtgvLophoc.TabIndex = 7;
            this.dtgvLophoc.DoubleClick += new System.EventHandler(this.dtgvLophoc_DoubleClick);
            // 
            // Malop
            // 
            this.Malop.DataPropertyName = "Malop";
            this.Malop.HeaderText = "Mã lớp";
            this.Malop.MinimumWidth = 6;
            this.Malop.Name = "Malop";
            this.Malop.Width = 125;
            // 
            // Tenlop
            // 
            this.Tenlop.DataPropertyName = "Tenlop";
            this.Tenlop.HeaderText = "Tên lớp";
            this.Tenlop.MinimumWidth = 6;
            this.Tenlop.Name = "Tenlop";
            this.Tenlop.Width = 125;
            // 
            // btnAddl
            // 
            this.btnAddl.Image = global::FINAL.Properties.Resources.add2;
            this.btnAddl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddl.Location = new System.Drawing.Point(6, 209);
            this.btnAddl.Name = "btnAddl";
            this.btnAddl.Size = new System.Drawing.Size(105, 43);
            this.btnAddl.TabIndex = 4;
            this.btnAddl.Text = "Add";
            this.btnAddl.UseVisualStyleBackColor = true;
            this.btnAddl.Click += new System.EventHandler(this.btnAddl_Click);
            // 
            // btnXoal
            // 
            this.btnXoal.Image = global::FINAL.Properties.Resources.delete;
            this.btnXoal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoal.Location = new System.Drawing.Point(82, 269);
            this.btnXoal.Name = "btnXoal";
            this.btnXoal.Size = new System.Drawing.Size(144, 43);
            this.btnXoal.TabIndex = 6;
            this.btnXoal.Text = "Delete";
            this.btnXoal.UseVisualStyleBackColor = true;
            this.btnXoal.Click += new System.EventHandler(this.btnXoal_Click);
            // 
            // btnEditl
            // 
            this.btnEditl.Image = global::FINAL.Properties.Resources.update;
            this.btnEditl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditl.Location = new System.Drawing.Point(173, 205);
            this.btnEditl.Name = "btnEditl";
            this.btnEditl.Size = new System.Drawing.Size(108, 47);
            this.btnEditl.TabIndex = 5;
            this.btnEditl.Text = "Edit";
            this.btnEditl.UseVisualStyleBackColor = true;
            this.btnEditl.Click += new System.EventHandler(this.btnEditl_Click);
            // 
            // btnXeml
            // 
            this.btnXeml.Image = global::FINAL.Properties.Resources.list__1_1;
            this.btnXeml.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXeml.Location = new System.Drawing.Point(82, 147);
            this.btnXeml.Name = "btnXeml";
            this.btnXeml.Size = new System.Drawing.Size(144, 42);
            this.btnXeml.TabIndex = 3;
            this.btnXeml.Text = "Load";
            this.btnXeml.UseVisualStyleBackColor = true;
            this.btnXeml.Click += new System.EventHandler(this.btnXeml_Click);
            // 
            // fLophoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(689, 324);
            this.Controls.Add(this.btnXeml);
            this.Controls.Add(this.btnEditl);
            this.Controls.Add(this.btnXoal);
            this.Controls.Add(this.btnAddl);
            this.Controls.Add(this.dtgvLophoc);
            this.Controls.Add(this.txttenlop);
            this.Controls.Add(this.txtmalop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLophoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách lớp học";
            this.Load += new System.EventHandler(this.fLophoc_Load);
            this.DoubleClick += new System.EventHandler(this.fLophoc_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLophoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.DataGridView dtgvLophoc;
        private System.Windows.Forms.Button btnAddl;
        private System.Windows.Forms.Button btnXoal;
        private System.Windows.Forms.Button btnEditl;
        private System.Windows.Forms.Button btnXeml;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenlop;
    }
}