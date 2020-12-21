using QLTVEntityFramwork.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVEntityFramwork
{
    public partial class ManagerBorrower : Form
    {
        bool Them, CapNhat;
        bool checkThem = true;
        QLThuVienEntities db = new QLThuVienEntities();
        public ManagerBorrower()
        {
            InitializeComponent();
            LoadData();
        }
        public void EnableComponent()
        {
            txtTenDocGia.Enabled = true;
            txtTenSach.Enabled = true;
            txtNgayMuon.Enabled = true;
            txtNgayTra.Enabled = true;
            txtTinhTrang.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
        public void ClearClickedData()
        {
            txtTenDocGia.Text = "";
            txtTenSach.Text = "";
            txtNgayMuon.Text = "";
            txtNgayTra.Text = "";
            txtTinhTrang.Text = "";

        }
        public void DisableComponent()
        {
            txtTenDocGia.Enabled = false;
            txtTenSach.Enabled = false;
            txtNgayMuon.Enabled = false;
            txtNgayTra.Enabled = false;
            txtTinhTrang.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

        }

        private void ManageBorrower_Load(object sender, EventArgs e)
        {


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayMuon_TextChanged(object sender, EventArgs e)
        {

        }

        private void MuonSachEv(object sender, DataGridViewCellEventArgs e)
        {

            int r = dgvMuonSach.CurrentCell.RowIndex;
            //   var MasachClick = db.GetMaSach(dgvDocGia.Rows[r].Cells[1].Value.ToString());


            //this.txtMaSach.Text = MasachClick;
            this.txtTenDocGia.Text = dgvMuonSach.Rows[r].Cells[0].Value.ToString();
            this.txtTenSach.Text = dgvMuonSach.Rows[r].Cells[1].Value.ToString();
            this.txtNgayMuon.Text = dgvMuonSach.Rows[r].Cells[2].Value.ToString();
            this.txtNgayTra.Text = dgvMuonSach.Rows[r].Cells[3].Value.ToString();
            this.txtTinhTrang.Text = dgvMuonSach.Rows[r].Cells[4].Value.ToString();


        }

        private void dgvMuonSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            ClearClickedData();
            EnableComponent();
            Them = true;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
          
        }

        private void searchMuonSach_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ManagerBorrower_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string tendocgia = txtTenDocGia.Text.ToString();
            string tensach = txtTenSach.Text.ToString();
            string ngaymuon = txtNgayMuon.Text.ToString();
            string ngaygtra = txtNgayTra.Text.ToString();
            string tinhtrang = txtTinhTrang.Text.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Ban co muon xoa mau tin nay ko?", "Tra loi"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {

                db.borrower_delete(tendocgia, tensach, ngaymuon, ngaygtra, tinhtrang);
                LoadData();
                MessageBox.Show("Da Xoa Xong!");
            }
            else
            {
                MessageBox.Show("Ban Da Bam Khong!");
            }
            ClearClickedData();
        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            EnableComponent();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            CapNhat = true;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (Them == true)
            {
                if (checkThem == true)
                {
                    //int MaUser = int.Parse(txtMaUser.Text.ToString());

                    string tendocgia = txtTenDocGia.Text.ToString();
                    string tensach = txtTenSach.Text.ToString();
                    string ngaymuon = txtNgayMuon.Text.ToString();
                    string ngaytra = txtNgayTra.Text.ToString();
                    string tinhtrang = txtTinhTrang.Text.ToString();
                    MessageBox.Show(ngaymuon);

                    db.borrower_insert(tendocgia, tensach, ngaymuon, ngaytra, tinhtrang);
                    LoadData();
                    MessageBox.Show("Da them xong");
                    btnLuu.Enabled = false;
                    btnCapNhat.Enabled = true;
                    btnXoa.Enabled = true;
                    Them = false;
                    DisableComponent();
                    ClearClickedData();

                }

            }
            else if (CapNhat == true)
            {
                try
                {
                    db.Configuration.LazyLoadingEnabled = false;

                    string tendocgia = txtTenDocGia.Text.ToString();
                    string tensach = txtTenSach.Text.ToString();
                    string ngaymuon = txtNgayMuon.Text.ToString();
                    string ngaygtra = txtNgayTra.Text.ToString();
                    string tinhtrang = txtTinhTrang.Text.ToString();
                    MessageBox.Show(tendocgia);

                    db.borrower_update(tendocgia, tensach, ngaymuon, ngaygtra, tinhtrang);
                    LoadData();
                    DisableComponent();
                    MessageBox.Show("Đã cập nhật xong !!!");
                    
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được. Lỗi rồi!");
                    LoadData();
                }

                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnCapNhat.Enabled = true;
            }
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            EnableComponent();

            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
        }

        private void searchMuonSach_Click_1(object sender, EventArgs e)
        {
            db.Configuration.LazyLoadingEnabled = false;

            string tendocgia = txtSearchMuonSach.Text.ToString();
            var listmuonsach = db.search_borrower(tendocgia);
            dgvMuonSach.DataSource = listmuonsach;

            dgvMuonSach.Columns[0].HeaderText = "Tên Đọc giả";
            dgvMuonSach.Columns[1].HeaderText = "Tên Sách";
            dgvMuonSach.Columns[2].HeaderText = "Ngày Mượn";
            dgvMuonSach.Columns[3].HeaderText = "Ngày Trả";
            dgvMuonSach.Columns[4].HeaderText = "Tình trạng";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvMuonSach_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvMuonSach.CurrentCell.RowIndex;
            //   var MasachClick = db.GetMaSach(dgvDocGia.Rows[r].Cells[1].Value.ToString());


            //this.txtMaSach.Text = MasachClick;
            this.txtTenDocGia.Text = dgvMuonSach.Rows[r].Cells[0].Value.ToString();
            this.txtTenSach.Text = dgvMuonSach.Rows[r].Cells[1].Value.ToString();
            this.txtNgayMuon.Text = dgvMuonSach.Rows[r].Cells[2].Value.ToString();
            this.txtNgayTra.Text = dgvMuonSach.Rows[r].Cells[3].Value.ToString();
            this.txtTinhTrang.Text = dgvMuonSach.Rows[r].Cells[4].Value.ToString();
        }

        private void dgvMuonSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        void LoadData()
        {
            db.Configuration.LazyLoadingEnabled = false;
            var listUserBorrowing = db.Borrowing_Details.ToList();
            dgvMuonSach.DataSource = listUserBorrowing;

            dgvMuonSach.Columns[0].HeaderText = "Tên Đọc giả";
            dgvMuonSach.Columns[1].HeaderText = "Tên Sách";
            dgvMuonSach.Columns[2].HeaderText = "Ngày Mượn";
            dgvMuonSach.Columns[3].HeaderText = "Ngày Trả";
            dgvMuonSach.Columns[4].HeaderText = "Tình trạng";


        }
    }
}
