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
    public partial class ManageBook : Form
    {
        QLThuVienEntities db = new QLThuVienEntities();
        bool Them = false;
        bool checkThem = false;
        bool CapNhat = false;
        public ManageBook()
        {
            InitializeComponent();
            LoadData();
            

            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            DisableComponent();
            PutDataInComboBox();
        }
        public void DisableComponent()
        {
            txtTenSach.Enabled = false;
            txtLinhvuc.Enabled = false;
            txtGia.Enabled = false;
            cbViTri.Enabled = false;
            cbMaNXB.Enabled = false;
            cbMaTG.Enabled = false;
            txtTinhTrangMuon.Enabled = false;
            txtSoLuongBiMat.Enabled = false;
            txtTongSoLuong.Enabled = false;
        }
        public void EnableComponent()
        {
            txtTenSach.Enabled = true;
            txtLinhvuc.Enabled = true;
            txtGia.Enabled = true;
            cbViTri.Enabled = true;
            cbMaNXB.Enabled = true;
            cbMaTG.Enabled = true;
            txtTinhTrangMuon.Enabled = true;
            txtSoLuongBiMat.Enabled = true;
            txtTongSoLuong.Enabled = true;
        }
        public void LoadData()
        {
            //User thi xai query nay
            var data = db.SACHes.ToList();
            //Neu la admin thi
            // var data = db.Books.ToList();
            dgvQLSach.DataSource = data;
            dgvQLSach.AutoResizeColumns();
            dgvQLSach.AutoResizeRows();
            ClearClickedData();
            dgvQLSach.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvQLSach.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvQLSach.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvQLSach.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvQLSach.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvQLSach.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvQLSach.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvQLSach.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvQLSach.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvQLSach.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;


            dgvQLSach.Columns[0].HeaderText = "Mã Sách";
            dgvQLSach.Columns[1].HeaderText = "Mã NXB";
            dgvQLSach.Columns[2].HeaderText = "Mã TG";
            dgvQLSach.Columns[3].HeaderText = "Vị Trí";
            dgvQLSach.Columns[4].HeaderText = "Tên sách";
            dgvQLSach.Columns[5].HeaderText = "Đang được mượn";
            dgvQLSach.Columns[6].HeaderText = "Tổng Số Lượng";
            dgvQLSach.Columns[7].HeaderText = "Số Lượng Bị Mất";
            dgvQLSach.Columns[8].HeaderText = "Lĩnh Vực";
            dgvQLSach.Columns[9].HeaderText = "Giá";
            dgvQLSach.Columns[10].Visible = false;
        }
        public void ClearClickedData()
        {
            txtTenSach.Text = "";
            txtLinhvuc.Text = "";
            txtGia.Text = "";
            cbViTri.Text = "";
            cbMaNXB.Text = "";
            cbMaTG.Text = "";
            txtTinhTrangMuon.Text = "";
            txtSoLuongBiMat.Text = "";
            txtTongSoLuong.Text = "";
            
        }
        public void PutDataInComboBox()
        {
            PutDataInComboViTri();
            PutDataInComboMaNXB();
            PutDataInComboMaTG();
        }
        public void PutDataInComboViTri()
        {
            cbViTri.Items.Add("C1");
            cbViTri.Items.Add("C2");
            cbViTri.Items.Add("C3");
            cbViTri.Items.Add("C4");
        }
        public void PutDataInComboMaNXB()
        {
            var data = (from d in db.NXBs select d.MANXB).ToList();
            cbMaNXB.DataSource = data;
            //using (var db = new Model1())
            //{
            //    db.Configuration.LazyLoadingEnabled = false;
            //    var query = (from d in db.NXBs
            //                 select d.MANXB).ToList();
            //    cbMaNXB.DataSource = query;
            //}
        }
        public void PutDataInComboMaTG()
        {
            var data = (from d in db.TACGIAs select d.MATACGIA).ToList();
            cbMaTG.DataSource = data;
            //using (var db = new Model1())
            //{
            //    db.Configuration.LazyLoadingEnabled = false;
            //    var query = (from d in db.TACGIAs
            //                 select d.MATACGIA).ToList();
            //    cbMTG.DataSource = query;
            //}
        }
        private void ManageBook_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvQLSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvQLSach.CurrentCell.RowIndex;

            //Neu user la admin thi hien textbox 
            //this.txtMaSach.Text = dgvQLSach.Rows[r].Cells[0].Value.ToString();
            this.cbMaNXB.Text = dgvQLSach.Rows[r].Cells[1].Value.ToString();
            this.cbMaTG.Text = dgvQLSach.Rows[r].Cells[2].Value.ToString();
            this.cbViTri.Text = dgvQLSach.Rows[r].Cells[3].Value.ToString();
            this.txtTenSach.Text = dgvQLSach.Rows[r].Cells[4].Value.ToString();
            this.txtTinhTrangMuon.Text = dgvQLSach.Rows[r].Cells[5].Value.ToString();
            this.txtTongSoLuong.Text = dgvQLSach.Rows[r].Cells[6].Value.ToString();
            this.txtSoLuongBiMat.Text = dgvQLSach.Rows[r].Cells[7].Value.ToString();
            this.txtLinhvuc.Text = dgvQLSach.Rows[r].Cells[8].Value.ToString();
            this.txtGia.Text = dgvQLSach.Rows[r].Cells[9].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            EnableComponent();
            ClearClickedData();
            Them = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Goi procedure ra o day tuong ung voi CREATE, READ, UPDATE, DELETE
            if (Them)
            {
                try
                {
                    db.Configuration.LazyLoadingEnabled = false;
                    int MaNXB = int.Parse(cbMaNXB.SelectedItem.ToString());
                    int MaTG = int.Parse(cbMaTG.SelectedItem.ToString());
                    string Tensach = txtTenSach.Text;
                    string Linhvuc = txtLinhvuc.Text;
                    int Gia = int.Parse(txtGia.Text);
                    string Vitri = cbViTri.SelectedItem.ToString();
                    int Dangduocmuon = int.Parse(txtTinhTrangMuon.Text);
                    int Soluongsachmat = int.Parse(txtSoLuongBiMat.Text);
                    int Tongsoluong = int.Parse(txtTongSoLuong.Text);
                    db.sp_Create_Book(MaNXB, MaTG, Tensach, Linhvuc, Gia, Vitri, Dangduocmuon, Soluongsachmat, Tongsoluong);
                    db.SaveChanges();
                    LoadData();
                    DisableComponent();
                    MessageBox.Show("Đã thêm xong !!!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
                Them = false;
            }
            else if (CapNhat == true)
            {
                try
                {
                    db.Configuration.LazyLoadingEnabled = false;

                    var s = db.SACHes.Where(x => x.MASACH == 1).ToList().FirstOrDefault();
                    s.MANXB = int.Parse(cbMaNXB.SelectedItem.ToString());
                    s.MATACGIA = int.Parse(cbMaTG.SelectedItem.ToString());
                    s.TENSACH = txtTenSach.Text;
                    s.LINHVUC = txtLinhvuc.Text;
                    s.GIA = int.Parse(txtGia.Text);
                    s.VITRI = cbViTri.SelectedItem.ToString();
                    s.DANGDUOCMUON = int.Parse(txtTinhTrangMuon.Text);
                    s.SOLUONGSACHBIMAT = int.Parse(txtSoLuongBiMat.Text);
                    s.TONGSOLUONG = int.Parse(txtTongSoLuong.Text);

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
            }
            ClearClickedData();


            //if (!txtMaSach.Text.Trim().Equals(""))
            //{
            //    if (Them)
            //    {
            //        try
            //        {
            //            using (var db = new Model1())
            //            {
            //                db.Configuration.LazyLoadingEnabled = false;

            //                SACH sach = new SACH();
            //                sach.MASACH = int.Parse(txtMaSach.Text);
            //                sach.MANXB = int.Parse(cbMaNXB.SelectedItem.ToString());
            //                sach.MATACGIA = int.Parse(cbMTG.SelectedItem.ToString());
            //                sach.VITRI = cbViTri.SelectedItem.ToString();
            //                sach.TENSACH = txtTenSach.Text;
            //                sach.DANGDUOCMUON = 0;
            //                db.SACHes.Add(sach);
            //                db.SaveChanges();
            //            }
            //            LoadData();
            //            DisableComponent();
            //            MessageBox.Show("da them song");
            //        }
            //        catch
            //        {
            //            MessageBox.Show("Không thêm được. Lỗi rồi!");
            //        }
            //    }
            //    else if(CapNhat==true)
            //    {
            //        try
            //        {
            //            using (var db = new Model1())
            //            {
            //                db.Configuration.LazyLoadingEnabled = false;
            //                int tmp = int.Parse(txtMaSach.Text);
            //                var query = from d in db.SACHes
            //                            where d.MASACH == tmp
            //                            select d;
            //                foreach (var Changes in query)
            //                {
            //                    Changes.TENSACH = txtTenSach.Text;
            //                    Changes.VITRI = cbViTri.SelectedItem.ToString();
            //                    Changes.MANXB = int.Parse(cbMaNXB.Text);
            //                    Changes.MATACGIA = int.Parse(cbMTG.Text);
            //                }
            //                db.SaveChanges();
            //            }
            //            LoadData();
            //            DisableComponent();
            //            MessageBox.Show("da cap nhat song");
            //        }
            //        catch
            //        {
            //            MessageBox.Show("Không cap nhat được. Lỗi rồi!");
            //        }
            //    }
            //    btnHuy.Enabled = false;
            //    btnLuu.Enabled = false;
            //    btnThem.Enabled = true;
            //    btnXoa.Enabled = true;
            //    btnCapNhat.Enabled = true;
            //}
            //ClearClickedData();
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
            int r = dgvQLSach.CurrentCell.RowIndex;

            int rSelected = (int)dgvQLSach.Rows[r].Cells[0].Value;
            DialogResult traloi;
            traloi = MessageBox.Show("Ban co muon xoa mau tin nay ko?", "Tra loi"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                db.Configuration.LazyLoadingEnabled = false;
                string Tensach = txtTenSach.Text;
                db.sp_Delete_Book(Tensach);
                //using (var db = new Model1())
                //{
                //    db.Configuration.LazyLoadingEnabled = false;
                //    var query = from d in db.SACHes
                //                where d.MASACH == rSelected
                //                select d;
                //    foreach (var MASACH in query)
                //    {
                //        db.SACHes.Remove(MASACH);
                //    }
                //    db.SaveChanges();
                //}
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Da Xoa Xong!");
            }
            //else
            //{
            //    MessageBox.Show("Ban Da Bam Khong!");
            //}
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DisableComponent();
            ClearClickedData();
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnCapNhat.Enabled = true;
            btnHuy.Enabled = false;
        }
    }
}
