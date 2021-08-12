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
    public partial class fLophoc : Form
    {
        Lop lop = new Lop();
        public fLophoc()
        {
            InitializeComponent();
            Createdtgv();
        }
        void Clear()
        {
            txtmalop.Text = txttenlop.Text = "";
            btnAddl.Text = "Add";
            btnXoal.Enabled = false;
            btnEditl.Enabled = false;

        }
        void Createdtgv()
        {
            dtgvLophoc.AutoGenerateColumns = false;
            using (QLSVContext ql = new QLSVContext())
            {
                dtgvLophoc.DataSource = ql.Lops.ToList<Lop>();
            }
        }

        private void fLophoc_DoubleClick(object sender, EventArgs e)
        {
            //
        }

        private void btnXeml_Click(object sender, EventArgs e)
        {
            Createdtgv();
            Clear();
            btnAddl.Enabled = true;
        }

        private void btnAddl_Click(object sender, EventArgs e)
        {
            lop.Malop = txtmalop.Text.Trim();
            lop.Tenlop = txttenlop.Text.Trim();
            using (QLSVContext ql = new QLSVContext())
            {
                ql.Lops.Add(lop);
                ql.SaveChanges();
            }
            Clear();
            Createdtgv();
            MessageBox.Show("Thêm thành công!");
        }

        private void btnEditl_Click(object sender, EventArgs e)
        {
            lop.Malop = txtmalop.Text.Trim();
            lop.Tenlop = txttenlop.Text.Trim();
            using (QLSVContext ql1 = new QLSVContext())
            {
                ql1.Entry(lop).State = EntityState.Modified;
                ql1.SaveChanges();
            }
            Clear();
            Createdtgv();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnXoal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá lớp này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (QLSVContext ql = new QLSVContext())
                {
                    var entry = ql.Entry(lop);
                    if (entry.State == EntityState.Detached)
                        ql.Lops.Attach(lop);
                    ql.Lops.Remove(lop);
                    ql.SaveChanges();
                    Createdtgv();
                    Clear();
                    MessageBox.Show("Xoá thành công!");
                }
        }

        private void fLophoc_Load(object sender, EventArgs e)
        {
            Clear();
            Createdtgv();
        }

        private void dtgvLophoc_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvLophoc.CurrentRow.Index != -1)
            {
                lop.Malop = dtgvLophoc.CurrentRow.Cells["Malop"].Value.ToString();
                using (QLSVContext ql = new QLSVContext())
                {
                    lop = ql.Lops.Where(x => x.Malop == lop.Malop).FirstOrDefault();
                    txtmalop.Text = lop.Malop;
                    txttenlop.Text = lop.Tenlop;
                }
                btnEditl.Text = "Cập nhật!";
                btnAddl.Enabled = false;
                btnXoal.Enabled = true;
                btnEditl.Enabled = true;
            }
        }
    }

}
