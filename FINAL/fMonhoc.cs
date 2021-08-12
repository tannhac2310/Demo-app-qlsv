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
    public partial class fMonhoc : Form
    {
        Monhoc monhoc = new Monhoc();
        public fMonhoc()
        {
            InitializeComponent();
            Createdtgv();
        }
        void Clear()
        {
            txtMaMHh.Text = txtTenMHh.Text = txtSoTCh.Text = "";
            btnAddh.Text = "Add";
            btnRemoveh.Enabled = false;
            btnEdith.Enabled = false;

        }
        void Createdtgv()
        {
            dtgvMonhoc.AutoGenerateColumns = false;
            using (QLSVContext ql = new QLSVContext())
            {
                dtgvMonhoc.DataSource = ql.Monhocs.ToList<Monhoc>();
            }
        }

        private void fMonhoc_Load(object sender, EventArgs e)
        {
            Createdtgv();
            Clear();
        }

        private void dtgvMonhoc_DoubleClick(object sender, EventArgs e)
        {
            if (dtgvMonhoc.CurrentRow.Index != -1)
            {
                monhoc.MaMH = dtgvMonhoc.CurrentRow.Cells["MaMH"].Value.ToString();
                using (QLSVContext ql = new QLSVContext())
                {
                    monhoc = ql.Monhocs.Where(x => x.MaMH == monhoc.MaMH).FirstOrDefault();
                    txtMaMHh.Text = monhoc.MaMH;
                    txtTenMHh.Text = monhoc.TenMH;
                    txtSoTCh.Text = Convert.ToString(monhoc.SoTC);
                }
                btnEdith.Text = "Cập nhật!";
                btnAddh.Enabled = false;
                btnRemoveh.Enabled = true;
                btnEdith.Enabled = true;
            }
        }

        private void btnXemh_Click(object sender, EventArgs e)
        {
            Createdtgv();
            Clear();
            btnAddh.Enabled = true;
        }

        private void btnEdith_Click(object sender, EventArgs e)
        {
            monhoc.MaMH = txtMaMHh.Text.Trim();
            monhoc.TenMH = txtTenMHh.Text.Trim();
            monhoc.SoTC = Convert.ToInt32(txtSoTCh.Text);
            using (QLSVContext ql1 = new QLSVContext())
            {
                ql1.Entry(monhoc).State = EntityState.Modified;
                ql1.SaveChanges();
            }
            Clear();
            Createdtgv();
            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnAddh_Click(object sender, EventArgs e)
        {
            monhoc.MaMH = txtMaMHh.Text.Trim();
            monhoc.TenMH = txtTenMHh.Text.Trim();
            monhoc.SoTC = Convert.ToInt32(txtSoTCh.Text);
            using (QLSVContext ql = new QLSVContext())
            {
                ql.Monhocs.Add(monhoc);
                ql.SaveChanges();
            }
            Clear();
            Createdtgv();
            MessageBox.Show("Thêm thành công!");
        }

        private void btnRemoveh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá lớp này không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (QLSVContext ql = new QLSVContext())
                {
                    var entry = ql.Entry(monhoc);
                    if (entry.State == EntityState.Detached)
                        ql.Monhocs.Attach(monhoc);
                    ql.Monhocs.Remove(monhoc);
                    ql.SaveChanges();
                    Createdtgv();
                    Clear();
                    MessageBox.Show("Xoá thành công!");
                }
        }
    }
}
