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
        //bool Them = false;
        //bool checkThem = false;
        //bool CapNhat = false;
        public ManageBook()
        {
            InitializeComponent();
            LoadData();
            

            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            DisableComponent();
            //PutDataInComboBox();
        }
        public void DisableComponent()
        {
            txtMaSach.Enabled = false;
            txtTenSach.Enabled = false;
            cbMaNXB.Enabled = false;
            cbMTG.Enabled = false;
            cbViTri.Enabled = false;
        }
        public void EnableComponent()
        {
            //txtMaSach.Enabled = true;
            //txtTenSach.Enabled = true;
            //cbMaNXB.Enabled = true;
            //cbMTG.Enabled = true;
            //cbViTri.Enabled = true;
        }
        public void LoadData()
        {
            //User thi xai query nay
            var data = db.Book_Info.ToList();
            //Neu la admin thi
            // var data = db.Books.ToList();
            dgvQLSach.DataSource = data;
            dgvQLSach.AutoResizeColumns();
            dgvQLSach.AutoResizeRows();
            ClearClickedData();
            dgvQLSach.AutoResizeColumns();
            dgvQLSach.Columns[0].HeaderText = "Tên Sách";
            dgvQLSach.Columns[1].HeaderText = "Lĩnh Vực";
            dgvQLSach.Columns[2].HeaderText = "Giá";
            dgvQLSach.Columns[3].HeaderText = "Vị Trí";
            dgvQLSach.Columns[4].HeaderText = "Tình Trạng Mượn";
            dgvQLSach.Columns[5].HeaderText = "Số Lượng Bị Mất";
            dgvQLSach.Columns[6].HeaderText = "Tổng Số Lượng";
        }
        public void ClearClickedData()
        {
            txtMaSach.Text = "";
            cbViTri.Text = "";
            txtTenSach.Text = "";
            cbMaNXB.Text = "";
            cbMTG.Text = "";
        }
        public void PutDataInComboBox()
        {
            //PutDataInComboViTri();
            //PutDataInComboMaNXB();
            //PutDataInComboMaTG();
        }
        public void PutDataInComboViTri()
        {
            //cbViTri.Items.Add("C1");
            //cbViTri.Items.Add("C2");
            //cbViTri.Items.Add("C3");
            //cbViTri.Items.Add("C4");
        }
        public void PutDataInComboMaNXB()
        {
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
            //LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void dgvQLSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvQLSach.CurrentCell.RowIndex;

            //Neu user la admin thi hien textbox 
            //this.txtMaSach.Text = dgvQLSach.Rows[r].Cells[0].Value.ToString();

            this.cbMaNXB.Text = dgvQLSach.Rows[r].Cells[1].Value.ToString();
            this.cbMTG.Text = dgvQLSach.Rows[r].Cells[2].Value.ToString();
            this.cbViTri.Text = dgvQLSach.Rows[r].Cells[3].Value.ToString();
            this.txtTenSach.Text = dgvQLSach.Rows[r].Cells[0].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //btnLuu.Enabled = true;
            //btnHuy.Enabled = true;
            //btnCapNhat.Enabled = false;
            //btnXoa.Enabled = false;
            //EnableComponent();
            //ClearClickedData();
            //Them = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Goi procedure ra o day tuong ung voi CREATE, READ, UPDATE, DELETE



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
            //btnLuu.Enabled = true;
            //btnHuy.Enabled = true;
            //EnableComponent();
            //txtMaSach.Enabled = false;
            //btnThem.Enabled = false;
            //btnXoa.Enabled = false;

            //CapNhat = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //int r = dgvQLSach.CurrentCell.RowIndex;

            //int rSelected = (int)dgvQLSach.Rows[r].Cells[0].Value;
            //DialogResult traloi;
            //traloi = MessageBox.Show("Ban co muon xoa mau tin nay ko?", "Tra loi"
            //    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (traloi == DialogResult.Yes)
            //{
            //    using (var db = new Model1())
            //    {
            //        db.Configuration.LazyLoadingEnabled = false;
            //        var query = from d in db.SACHes
            //                    where d.MASACH == rSelected
            //                    select d;
            //        foreach (var MASACH in query)
            //        {
            //            db.SACHes.Remove(MASACH);
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
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //DisableComponent();
            //ClearClickedData();
            //btnLuu.Enabled = false;
            //btnHuy.Enabled = true;
            //btnXoa.Enabled = true;
            //btnThem.Enabled = true;
            //btnCapNhat.Enabled = true;
            //btnHuy.Enabled = false;
        }
    }
}
