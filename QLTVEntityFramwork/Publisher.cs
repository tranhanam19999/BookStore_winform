using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTVEntityFramwork.Model;
namespace QLTVEntityFramwork
{
    public partial class Publisher : Form
    {
        bool Them, CapNhat;
        bool checkThem = true;
        private QLThuVienEntities db = new QLThuVienEntities();
        public Publisher()
        {
            InitializeComponent();
            LoadData();
            //DisableComponent();
        }
        public void LoadData()
        {
            var data = db.NXBs.ToList();

            dgvQLNXB.DataSource = data;
            dgvQLNXB.AutoResizeColumns();
            dgvQLNXB.AutoResizeRows();

            dgvQLNXB.Columns[0].HeaderText = "Mã NXB";
            dgvQLNXB.Columns[1].HeaderText = "Tên NXB";
            dgvQLNXB.Columns[2].HeaderText = "SĐT";


            //btnLuu.Enabled = false;
            //btnHuy.Enabled = false;
            //using (var db = new Model1())
            //{
            //    db.Configuration.LazyLoadingEnabled = false;
            //    var query = from d in db.NXBs
            //                select d;
            //    dgvQLNXB.DataSource = query.ToList();
            //    dgvQLNXB.AutoResizeColumns();
            //    dgvQLNXB.AutoResizeRows();

            //    dgvQLNXB.Columns[0].HeaderText = "Mã NXB";
            //    dgvQLNXB.Columns[1].HeaderText = "Tên NXB";
            //    dgvQLNXB.Columns[2].HeaderText = "SĐT";
            //}
        }
        public void DisableComponent()
        {
            //txtNXB.Enabled = false;
            //txtSDT.Enabled = false;
            //txtTenNXB.Enabled = false;
        }
        public void EnableComponent()
        {
            //txtNXB.Enabled = true;
            //txtSDT.Enabled = true;
            //txtTenNXB.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //btnCapNhat.Enabled = false;
            //btnXoa.Enabled = false;
            //btnLuu.Enabled = true;
            //btnHuy.Enabled = true;
            //ClearData();
            //EnableComponent();
            //Them = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //EnableComponent();

            //txtNXB.Enabled = false;
            //btnThem.Enabled = false;
            //btnXoa.Enabled = false;
            //btnLuu.Enabled = true;
            //btnHuy.Enabled = true;
            //CapNhat = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //int r = dgvQLNXB.CurrentCell.RowIndex;

            //int rSelected = (int)dgvQLNXB.Rows[r].Cells[0].Value;
            //DialogResult traloi;
            //traloi = MessageBox.Show("Ban co muon xoa mau tin nay ko?", "Tra loi"
            //    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (traloi == DialogResult.Yes)
            //{
            //    using (var db = new Model1())
            //    {
            //        db.Configuration.LazyLoadingEnabled = false;
            //        var query = from d in db.NXBs
            //                    where d.MANXB == rSelected
            //                    select d;
            //        foreach (var MANXB in query)
            //        {
            //            db.NXBs.Remove(MANXB);
            //        }
            //        db.SaveChanges();
            //    }
            //    LoadData();
            //    MessageBox.Show("Da Xoa Xong!");
            //}
            //else
            //{
            //    MessageBox.Show("Ban Da Bam Khong!");
            //}
            //ClearData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            //ClearData();
            //LoadData();
        }

        private void dgvQLNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int r = dgvQLNXB.CurrentCell.RowIndex;

            //this.txtNXB.Text = dgvQLNXB.Rows[r].Cells[0].Value.ToString();
            //this.txtTenNXB.Text = dgvQLNXB.Rows[r].Cells[1].Value.ToString();
            //this.txtSDT.Text = dgvQLNXB.Rows[r].Cells[2].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //btnLuu.Enabled = false;
            //ClearData();
            //EnableComponent();
            //btnLuu.Enabled = false;
            //btnHuy.Enabled = false;
            //btnXoa.Enabled = true;
            //btnThem.Enabled = true;
            //btnCapNhat.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //if (Them == true)
            //{
            //    foreach (DataGridViewRow row in dgvQLNXB.Rows)
            //    {
            //        if (row.Cells[0].Value == null)
            //        {
            //            checkThem = true;
            //            break;
            //        }
            //        if (Int32.Parse(row.Cells[0].Value.ToString()) == Int32.Parse(txtNXB.Text))
            //        {
            //            MessageBox.Show("Trùng Mã NXB Rồi!");
            //            btnLuu.Enabled = false;
            //            btnCapNhat.Enabled = true;
            //            btnXoa.Enabled = true;
            //            Them = false;
            //            DisableComponent();
            //            ClearData();
            //            checkThem = false;
            //            break;
            //        }
            //    }
            //    if (checkThem == true)
            //    {
            //        using (var db = new Model1())
            //        {
            //            db.Configuration.LazyLoadingEnabled = false;

            //            NXB nxb = new NXB();
            //            nxb.MANXB = int.Parse(txtNXB.Text);
            //            nxb.TENNXB = txtTenNXB.Text;
            //            nxb.SDT = txtSDT.Text;

            //            db.NXBs.Add(nxb);
            //            db.SaveChanges();
            //        }
            //        LoadData();
            //        MessageBox.Show("Da them xong");
            //        btnLuu.Enabled = false;
            //        btnCapNhat.Enabled = true;
            //        btnXoa.Enabled = true;
            //        Them = false;
            //        DisableComponent();
            //        ClearData();
            //    }

            //}
            //else if (CapNhat == true)
            //{
            //    using (var db = new Model1())
            //    {
            //        db.Configuration.LazyLoadingEnabled = false;
            //        int tmp = int.Parse(txtNXB.Text);
            //        var query = from d in db.NXBs
            //                    where d.MANXB == tmp
            //                    select d;
            //        foreach (var Changes in query)
            //        {
            //            Changes.TENNXB = txtTenNXB.Text;
            //            Changes.SDT = txtSDT.Text;
            //        }
            //        db.SaveChanges();
            //    }
            //    LoadData();
            //    MessageBox.Show("Đã Cập Nhật Xong!");
            //    btnLuu.Enabled = false;
            //    btnThem.Enabled = true;
            //    btnXoa.Enabled = true;
            //    CapNhat = false;
            //    DisableComponent();
            //    ClearData();
            //}
        }

        public void ClearData()
        {
            //txtNXB.Text = null;
            //txtSDT.Text = null;
            //txtTenNXB.Text = null;
        }
    }
}
