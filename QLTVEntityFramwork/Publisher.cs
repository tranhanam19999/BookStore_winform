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
        bool Them = false;
        bool checkThem = false;
        bool CapNhat = false;
        QLThuVienEntities db = new QLThuVienEntities();
        public Publisher()
        {
            InitializeComponent();
            LoadData();
            DisableComponent();
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
            dgvQLNXB.Columns[3].Visible = false;


            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
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
            txtNXB.Enabled = false;
            txtSDT.Enabled = false;
            txtTenNXB.Enabled = false;
        }
        public void EnableComponent()
        {
            txtNXB.Enabled = true;
            txtSDT.Enabled = true;
            txtTenNXB.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            EnableComponent();
            ClearData();
            Them = true;
            checkThem = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            EnableComponent();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;

            CapNhat = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvQLNXB.CurrentCell.RowIndex;

            int rSelected = (int)dgvQLNXB.Rows[r].Cells[0].Value;
            DialogResult traloi;
            traloi = MessageBox.Show("Ban co muon xoa mau tin nay ko?", "Tra loi"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                db.Configuration.LazyLoadingEnabled = false;
                int MaNXB = int.Parse(txtNXB.Text);
                db.sp_Delete_Publisher(MaNXB);
                //using (var db = new Model1())
                //{
                //    db.Configuration.LazyLoadingEnabled = false;
                //    var query = from d in db.NXBs
                //                where d.MANXB == rSelected
                //                select d;
                //    foreach (var MANXB in query)
                //    {
                //        db.NXBs.Remove(MANXB);
                //    }
                //    db.SaveChanges();
                //}
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Da Xoa Xong!");
            }
            ClearData();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            ClearData();
            LoadData();
        }

        private void dgvQLNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvQLNXB.CurrentCell.RowIndex;

            this.txtNXB.Text = dgvQLNXB.Rows[r].Cells[0].Value.ToString();
            this.txtTenNXB.Text = dgvQLNXB.Rows[r].Cells[1].Value.ToString();
            this.txtSDT.Text = dgvQLNXB.Rows[r].Cells[2].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DisableComponent();
            ClearData();
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnCapNhat.Enabled = true;
            btnHuy.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                foreach (DataGridViewRow row in dgvQLNXB.Rows)
                {
                    if (row.Cells[0].Value == null)
                    {
                        checkThem = true;
                        break;
                    }
                    if (Int32.Parse(row.Cells[0].Value.ToString()) == Int32.Parse(txtNXB.Text))
                    {
                        MessageBox.Show("Trùng Mã NXB Rồi!");
                        btnLuu.Enabled = false;
                        btnCapNhat.Enabled = true;
                        btnXoa.Enabled = true;
                        Them = false;
                        DisableComponent();
                        ClearData();
                        checkThem = false;
                        break;
                    }
                }
                if (checkThem == true)
                {
                    try
                    {
                        db.Configuration.LazyLoadingEnabled = false;
                        int MaNXB = int.Parse(txtNXB.Text);
                        string TenNXB = txtTenNXB.Text;
                        string SDT = txtSDT.Text;
                        db.sp_Create_Publisher(MaNXB, TenNXB, SDT);
                        //using (var db = new Model1())
                        //{
                        //    db.Configuration.LazyLoadingEnabled = false;

                        //    NXB nxb = new NXB();
                        //    nxb.MANXB = int.Parse(txtNXB.Text);
                        //    nxb.TENNXB = txtTenNXB.Text;
                        //    nxb.SDT = txtSDT.Text;

                        //    db.NXBs.Add(nxb);
                        //    db.SaveChanges();
                        //}
                        db.SaveChanges();
                        LoadData();
                        DisableComponent();
                        MessageBox.Show("Đã thêm xong !!!");
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!");
                    }
                }
                LoadData();
                Them = false;
                checkThem = false;
                LoadData();
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;

            }
            else if (CapNhat == true)
            {
                try
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    var s = db.NXBs.Where(x => x.MANXB == 1).ToList().FirstOrDefault();
                    s.MANXB = int.Parse(txtNXB.Text);
                    s.TENNXB = txtTenNXB.Text;
                    s.SDT = txtSDT.Text;
                    db.SaveChanges();
                    LoadData();
                    DisableComponent();
                    MessageBox.Show("Đã cập nhật xong !!!");
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được. Lỗi rồi!");
                }
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnCapNhat.Enabled = true;
                //using (var db = new Model1())
                //{
                //    db.Configuration.LazyLoadingEnabled = false;
                //    int tmp = int.Parse(txtNXB.Text);
                //    var query = from d in db.NXBs
                //                where d.MANXB == tmp
                //                select d;
                //    foreach (var Changes in query)
                //    {
                //        Changes.TENNXB = txtTenNXB.Text;
                //        Changes.SDT = txtSDT.Text;
                //    }
                //    db.SaveChanges();
                //}
            }
            ClearData();
        }

        public void ClearData()
        {
            txtNXB.Text = null;
            txtSDT.Text = null;
            txtTenNXB.Text = null;
        }
    }
}