
namespace FINAL
{
    partial class fMonhoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMonhoc));
            this.btnXemh = new System.Windows.Forms.Button();
            this.btnEdith = new System.Windows.Forms.Button();
            this.btnRemoveh = new System.Windows.Forms.Button();
            this.btnAddh = new System.Windows.Forms.Button();
            this.dtgvMonhoc = new System.Windows.Forms.DataGridView();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenMHh = new System.Windows.Forms.TextBox();
            this.txtMaMHh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoTCh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXemh
            // 
            this.btnXemh.Image = global::FINAL.Properties.Resources.list__1_;
            this.btnXemh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemh.Location = new System.Drawing.Point(90, 195);
            this.btnXemh.Name = "btnXemh";
            this.btnXemh.Size = new System.Drawing.Size(143, 45);
            this.btnXemh.TabIndex = 4;
            this.btnXemh.Text = "Load";
            this.btnXemh.UseVisualStyleBackColor = true;
            this.btnXemh.Click += new System.EventHandler(this.btnXemh_Click);
            // 
            // btnEdith
            // 
            this.btnEdith.Image = global::FINAL.Properties.Resources.edit;
            this.btnEdith.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdith.Location = new System.Drawing.Point(186, 255);
            this.btnEdith.Name = "btnEdith";
            this.btnEdith.Size = new System.Drawing.Size(114, 45);
            this.btnEdith.TabIndex = 6;
            this.btnEdith.Text = "Edit";
            this.btnEdith.UseVisualStyleBackColor = true;
            this.btnEdith.Click += new System.EventHandler(this.btnEdith_Click);
            // 
            // btnRemoveh
            // 
            this.btnRemoveh.Image = global::FINAL.Properties.Resources.delete1;
            this.btnRemoveh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveh.Location = new System.Drawing.Point(90, 317);
            this.btnRemoveh.Name = "btnRemoveh";
            this.btnRemoveh.Size = new System.Drawing.Size(143, 45);
            this.btnRemoveh.TabIndex = 7;
            this.btnRemoveh.Text = "Delete";
            this.btnRemoveh.UseVisualStyleBackColor = true;
            this.btnRemoveh.Click += new System.EventHandler(this.btnRemoveh_Click);
            // 
            // btnAddh
            // 
            this.btnAddh.Image = global::FINAL.Properties.Resources.add2;
            this.btnAddh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddh.Location = new System.Drawing.Point(18, 255);
            this.btnAddh.Name = "btnAddh";
            this.btnAddh.Size = new System.Drawing.Size(110, 45);
            this.btnAddh.TabIndex = 5;
            this.btnAddh.Text = "Add";
            this.btnAddh.UseVisualStyleBackColor = true;
            this.btnAddh.Click += new System.EventHandler(this.btnAddh_Click);
            // 
            // dtgvMonhoc
            // 
            this.dtgvMonhoc.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgvMonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.SoTC});
            this.dtgvMonhoc.Location = new System.Drawing.Point(326, 39);
            this.dtgvMonhoc.Name = "dtgvMonhoc";
            this.dtgvMonhoc.RowHeadersWidth = 51;
            this.dtgvMonhoc.RowTemplate.Height = 24;
            this.dtgvMonhoc.Size = new System.Drawing.Size(457, 323);
            this.dtgvMonhoc.TabIndex = 33;
            this.dtgvMonhoc.DoubleClick += new System.EventHandler(this.dtgvMonhoc_DoubleClick);
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã môn học";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            this.MaMH.Width = 125;
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên môn học";
            this.TenMH.MinimumWidth = 6;
            this.TenMH.Name = "TenMH";
            this.TenMH.Width = 125;
            // 
            // SoTC
            // 
            this.SoTC.DataPropertyName = "SoTC";
            this.SoTC.HeaderText = "Số tín chỉ";
            this.SoTC.MinimumWidth = 6;
            this.SoTC.Name = "SoTC";
            this.SoTC.Width = 125;
            // 
            // txtTenMHh
            // 
            this.txtTenMHh.Location = new System.Drawing.Point(106, 104);
            this.txtTenMHh.Name = "txtTenMHh";
            this.txtTenMHh.Size = new System.Drawing.Size(194, 22);
            this.txtTenMHh.TabIndex = 2;
            // 
            // txtMaMHh
            // 
            this.txtMaMHh.Location = new System.Drawing.Point(106, 57);
            this.txtMaMHh.Name = "txtMaMHh";
            this.txtMaMHh.Size = new System.Drawing.Size(194, 22);
            this.txtMaMHh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tên môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã môn học";
            // 
            // txtSoTCh
            // 
            this.txtSoTCh.Location = new System.Drawing.Point(106, 155);
            this.txtSoTCh.Name = "txtSoTCh";
            this.txtSoTCh.Size = new System.Drawing.Size(194, 22);
            this.txtSoTCh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Số tín chỉ";
            // 
            // fMonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 382);
            this.Controls.Add(this.txtSoTCh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenMHh);
            this.Controls.Add(this.txtMaMHh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvMonhoc);
            this.Controls.Add(this.btnXemh);
            this.Controls.Add(this.btnEdith);
            this.Controls.Add(this.btnRemoveh);
            this.Controls.Add(this.btnAddh);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMonhoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý môn học";
            this.Load += new System.EventHandler(this.fMonhoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMonhoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemh;
        private System.Windows.Forms.Button btnEdith;
        private System.Windows.Forms.Button btnRemoveh;
        private System.Windows.Forms.Button btnAddh;
        private System.Windows.Forms.DataGridView dtgvMonhoc;
        private System.Windows.Forms.TextBox txtTenMHh;
        private System.Windows.Forms.TextBox txtMaMHh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoTCh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTC;
    }
}