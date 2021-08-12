using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL
{
    public partial class fQuanLy : Form
    {
     
        Sinhvien sinhvien = new Sinhvien();
        Lop lop = new Lop();

        public fQuanLy()
        {
            
            InitializeComponent();
            Createdtgv();
            loadcbb();
            
        }

       void loadcbb()
        {
            using (QLSVContext ql = new QLSVContext())
            {
                var db = from c in ql.Lops select c;
                cbMalop.DataSource = db.ToList();
                cbMalop.DisplayMember = "Malop";
            }    
        }

        void Clear()
        {
            txtMaSV.Text = txtHoten.Text = txtNgaysinh.Text =
                txtGioitinh.Text = txtDiachi.Text = "";
            btnAdd.Text = "Add";
            btnRemove.Enabled = false;
            btnEdit.Enabled = false;

        }

        /// <summary>
        /// //////////
        /// </summary>
        void Createdtgv()
        {
            dtgvQLSV.AutoGenerateColumns = false;
            using (QLSVContext ql = new QLSVContext())
            {
                dtgvQLSV.DataSource = ql.Sinhviens.ToList<Sinhvien>();
            }    
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
        
            lop.Malop = cbMalop.Text.Trim();
            sinhvien.MaSV = Convert.ToInt32(txtMaSV.Text);
            sinhvien.TenSV = txtHoten.Text.Trim();
            sinhvien.Ngaysinh = txtNgaysinh.Text.Trim();
            sinhvien.Gioitinh = txtGioitinh.Text.Trim();
            sinhvien.Diachi = txtDiachi.Text.Trim();
            sinhvien.Malop = cbMalop.Text.Trim();
            using (QLSVContext ql1 = new QLSVContext())
            {
                ql1.Sinhviens.Add(sinhvien);
                ql1.SaveChanges();
            }
            Clear();
            Createdtgv();
            MessageBox.Show("Thêm thành công!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá thông tin này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (QLSVContext ql = new QLSVContext())
                {
                    var entry = ql.Entry(sinhvien);
                    if (entry.State == EntityState.Detached)
                        ql.Sinhviens.Attach(sinhvien);
                    ql.Sinhviens.Remove(sinhvien);
                    ql.SaveChanges();
                    Createdtgv();
                    Clear();
                    MessageBox.Show("Xoá thành công!");
                }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lop.Malop = cbMalop.Text.Trim();
            sinhvien.MaSV = Convert.ToInt32(txtMaSV.Text);
            sinhvien.TenSV = txtHoten.Text.Trim();
            sinhvien.Ngaysinh = txtNgaysinh.Text.Trim();
            sinhvien.Gioitinh = txtGioitinh.Text.Trim();
            sinhvien.Diachi = txtDiachi.Text.Trim();
            sinhvien.Malop = cbMalop.Text.Trim();
            using (QLSVContext ql1 = new QLSVContext())
            {
                ql1.Entry(sinhvien).State = EntityState.Modified;
                ql1.SaveChanges();
            }
            Clear();
            Createdtgv();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            Createdtgv();
            Clear();
            btnAdd.Enabled = true;
            
        }

        private void fQuanLy_Load(object sender, EventArgs e)
        {
            Clear();
            Createdtgv();
        }

        private void dtgvQLSV_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvQLSV.CurrentRow.Index != -1)
            {
                sinhvien.MaSV = Convert.ToInt32(dtgvQLSV.CurrentRow.Cells["MaSV"].Value);
                using (QLSVContext ql = new QLSVContext())
                {
                    sinhvien = ql.Sinhviens.Where(x => x.MaSV == sinhvien.MaSV).FirstOrDefault();
                    txtMaSV.Text = Convert.ToString(sinhvien.MaSV);
                    txtHoten.Text = sinhvien.TenSV;
                    txtNgaysinh.Text = sinhvien.Ngaysinh;
                    txtGioitinh.Text = sinhvien.Gioitinh;
                    txtDiachi.Text = sinhvien.Diachi;
                    cbMalop.Text = sinhvien.Malop;
                }
                btnEdit.Text = "Edit!";
                btnAdd.Enabled = false;
                btnRemove.Enabled = true;
                btnEdit.Enabled = true;
            }    
        }

        private void lớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLophoc f = new fLophoc();
            //f.MdiParent = this;
            f.ShowDialog();
        }

        private void điểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLDiem f = new fQLDiem();
            //f.MdiParent = this;
            f.ShowDialog();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMonhoc f = new fMonhoc();
            f.ShowDialog();
        }
    }

}
