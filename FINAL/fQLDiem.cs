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
    public partial class fQLDiem : Form
    {
        Sinhvien sinhvien = new Sinhvien();
        DiemHP diemhp = new DiemHP();
        Monhoc monhoc = new Monhoc();

        public fQLDiem()
        {
            InitializeComponent();
            Createdtgv();
            loadcbbmasv();
            loadcbbtenmh();
        }

        void Createdtgv()
        {
            dtgvDiem.AutoGenerateColumns = false;
            using (QLSVContext ql = new QLSVContext())
            {
                var db = from sinhvien in ql.DiemHPs
                         join hoten in ql.Sinhviens on sinhvien.MaSV equals hoten.MaSV
                         join monhoc in ql.Monhocs on sinhvien.MaMH equals monhoc.MaMH
                         select new
                         {
                             MaSV = sinhvien.MaSV,
                             TenSV = hoten.TenSV,
                             MaMH = sinhvien.MaMH,
                             TenMH = monhoc.TenMH,
                             Diem = sinhvien.Diem
                         };
                diemHPBindingSource.DataSource = db.ToList();
                monhocBindingSource.DataSource = db.ToList();
                dtgvDiem.DataSource = db.ToList();
                //diemHPBindingSource.DataSource = ql.DiemHPs.ToList<DiemHP>();
                //dtgvDiem.DataSource = ql.Sinhviens.ToList<Sinhvien>();
                //dtgvDiem.DataSource = ql.Monhocs.ToList<Monhoc>();
                //dtgvDiem.DataSource = ql.DiemHPs.ToList<DiemHP>();
                //dtgvDiem.DataSource = ql.Monhocs.ToList<Monhoc>();
            }
        }

        void loadcbbmasv()
        {
            using (QLSVContext ql = new QLSVContext())
            {
                var db = from c in ql.Sinhviens select c;
                cbHotend.DataSource = db.ToList();
                cbHotend.DisplayMember = "TenSV";
            }
        }
        void loadcbbtenmh()
        {
            using (QLSVContext ql = new QLSVContext())
            {
                var qb = from d in ql.Monhocs select d;
                cbTenMHd.DataSource = qb.ToList();
                cbTenMHd.DisplayMember = "TenMH";
            }
        }

        void Clear()
        {
            cbHotend.Text = txtMaSV.Text = 
                cbTenMHd.Text = txtDiem.Text = txtMaMHd.Text = "";
            btnAddd.Text = "Add";
            btnRemoved.Enabled = false;
            btnEditd.Enabled = false;

        }

        private void fQLDiem_Load(object sender, EventArgs e)
        {
            Clear();
            Createdtgv();
            
        }

        private void fQLDiem_DoubleClick(object sender, EventArgs e)
        {
            //
        }

        private void dtgvDiem_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvDiem.CurrentRow.Index != -1)
            {
                sinhvien.MaSV = Convert.ToInt32(dtgvDiem.CurrentRow.Cells["MaSV"].Value);
                diemhp.MaSV = Convert.ToInt32(dtgvDiem.CurrentRow.Cells["MaSV"].Value);
                monhoc.MaMH = dtgvDiem.CurrentRow.Cells["MaMH"].Value.ToString();
                using (QLSVContext ql = new QLSVContext())
                {
                    sinhvien = ql.Sinhviens.Where(x => x.MaSV == sinhvien.MaSV).FirstOrDefault();
                    cbHotend.Text = sinhvien.TenSV;
                    txtMaSV.Text = Convert.ToString(sinhvien.MaSV);
                    monhoc = ql.Monhocs.Where(x => x.MaMH == monhoc.MaMH).FirstOrDefault();
                    txtMaMHd.Text = monhoc.MaMH;
                    diemhp = ql.DiemHPs.Where(x => x.MaSV == diemhp.MaSV).FirstOrDefault();
                    cbTenMHd.Text = monhoc.TenMH;
                    txtDiem.Text = Convert.ToString(diemhp.Diem);
                }
                btnEditd.Text = "Cập nhật!";
                btnAddd.Enabled = false;
                btnRemoved.Enabled = true;
                btnEditd.Enabled = true;
            }
        }

        private void btnAddd_Click(object sender, EventArgs e)
        {
            string k = cbTenMHd.Text.Trim();
            string t = cbHotend.Text.Trim();
            using (QLSVContext ql = new QLSVContext())
            {
                
                monhoc = ql.Monhocs.Where(c => c.TenMH == k).FirstOrDefault();
                diemhp.MaMH = monhoc.MaMH;
            }
            using (QLSVContext ql2 = new QLSVContext())
            {

                sinhvien = ql2.Sinhviens.Where(c => c.TenSV == t).FirstOrDefault();
                diemhp.MaSV = sinhvien.MaSV;
            }         
            if (diemhp.Diem is null)
                diemhp.Diem = 0;
            else diemhp.Diem = Convert.ToInt32(txtDiem.Text);
            
            using (QLSVContext ql1 = new QLSVContext())
            {
                ql1.DiemHPs.Add(diemhp);
                ql1.SaveChanges();
            }
            Clear();
            Createdtgv();
            MessageBox.Show("Thêm thành công!");

        }

        private void btnRemoved_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá thông tin này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (QLSVContext ql = new QLSVContext())
                {
                    var entry = ql.Entry(diemhp);
                    if (entry.State == EntityState.Detached)
                        ql.DiemHPs.Attach(diemhp);
                    ql.DiemHPs.Remove(diemhp);
                    ql.SaveChanges();
                    Createdtgv();
                    Clear();
                    MessageBox.Show("Xoá thành công!");
                }
        }

        private void btnEditd_Click(object sender, EventArgs e)
        {
            string k = cbTenMHd.Text.Trim();
            string t = cbHotend.Text.Trim();
            using (QLSVContext ql = new QLSVContext())
            {

                monhoc = ql.Monhocs.Where(c => c.TenMH == k).FirstOrDefault();
                diemhp.MaMH = monhoc.MaMH;
            }
            using (QLSVContext ql2 = new QLSVContext())
            {

                sinhvien = ql2.Sinhviens.Where(c => c.TenSV == t).FirstOrDefault();
                diemhp.MaSV = sinhvien.MaSV;
            }
            if (diemhp.Diem is null)
                diemhp.Diem = 0;
            else diemhp.Diem = Convert.ToInt32(txtDiem.Text);
            using (QLSVContext ql1 = new QLSVContext())
            {
                ql1.Entry(diemhp).State = EntityState.Modified;
                ql1.SaveChanges();
            }
            Clear();
            Createdtgv();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXemd_Click(object sender, EventArgs e)
        {
            Createdtgv();
            btnAddd.Enabled = true;
            Clear();
        }
    }
}
