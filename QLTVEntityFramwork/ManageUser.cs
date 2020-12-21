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
    public partial class ManageUser : Form
    {
        bool Them, CapNhat;
        bool checkThem = true;
        QLThuVienEntities db = new QLThuVienEntities();
        public ManageUser()
        {
            InitializeComponent();

            txtMaUser.Enabled = false;

            LoadData();
            
            SetDisableComboBox();
            DisableComponent();

        }
        public void AddItemNam(ComboBox a, int b, int c)
        {
            for (int i = c; i >= b; i--)
                a.Items.Add(i);
        }
        public void AddItemMonth(ComboBox a)
        {
            for (int i = 1; i < 13; i++)
                a.Items.Add(i);
        }
        public void AddItemDay(ComboBox a, int b)
        {
            for (int i = 1; i <= b; i++)
                a.Items.Add(i);
        }
        void LoadData()
        {
            db.Configuration.LazyLoadingEnabled = false;

            var listUser = db.USERS.ToList();
            dgvDocGia.DataSource = listUser;

            dgvDocGia.Columns[0].HeaderText = "Mã Đọc Giả";
            dgvDocGia.Columns[1].HeaderText = "USERNAME";
            dgvDocGia.Columns[2].HeaderText = "PASSWORD";
            dgvDocGia.Columns[3].HeaderText = "Địa Chỉ";
            dgvDocGia.Columns[4].HeaderText = "SĐT";
            dgvDocGia.Columns[5].HeaderText = "Chức Vụ";
            dgvDocGia.Columns[6].HeaderText = "Tên Đọc Giả";
            dgvDocGia.Columns[7].Visible = false;
            dgvDocGia.Columns[8].Visible = false;

            db.Configuration.LazyLoadingEnabled = false;

            var listUserBorrowing = db.Borrowing_Details.ToList();
         

            btnOK.Enabled = false;
        }
        public void DisableComponent()
        {
            txtUsername.Enabled = false;
            txtTenUser.Enabled = false;
            txtPassword.Enabled = false;     
            txtDiaChi.Enabled = false;
            txtSDT.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
          
        }
        public void EnableComponent()
        {
            txtUsername.Enabled = true;
            txtTenUser.Enabled = true;
            txtPassword.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
        public void ClearClickedData()
        {
            txtTenUser.Text = "";
            txtMaUser.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";

         
        }
        public void SetDisableComboBox()
        {
         
        }

        public bool checkYear(int year)
        {
            // Nếu số năm chia hết cho 400,
            // đó là 1 năm nhuận
            if (year % 400 == 0)
                return true;

            // Nếu số năm chia hết cho 4 và không chia hết cho 100,
            // đó không là 1 năm nhuận
            if (year % 4 == 0 && year % 100 != 0)
                return true;

            // trường hợp còn lại 
            // không phải năm nhuận
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            ClearClickedData();
            EnableComponent();
            Them = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            EnableComponent();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;

            CapNhat = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //DisableComponent();
            //ClearClickedData();
            //SetDisableComboBox();
            //btnLuu.Enabled = false;
            //btnHuy.Enabled = false;
            //btnXoa.Enabled = true;
            //btnThem.Enabled = true;
            //btnCapNhat.Enabled = true;
            //btnTra.Enabled = true;
            //btnCheck.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                if (checkThem == true)
                {
                    //int MaUser = int.Parse(txtMaUser.Text.ToString());

                    string TenUser = txtTenUser.Text.ToString();
                    string Username = txtUsername.Text.ToString();
                    string Password = txtPassword.Text.ToString();
                    string Diachi = txtDiaChi.Text.ToString();
                    string SDT = txtSDT.Text.ToString();
                    MessageBox.Show(Username);
                    db.sp_Create_User(Username, Password, Diachi, SDT, TenUser);
                    db.SaveChanges();
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

                    var userID = int.Parse(txtMaUser.Text); 
                    var userFounded = db.USERS.Where(x => x.MAUSER == userID).ToList().FirstOrDefault();
                    userFounded.USERNAME = txtUsername.Text.ToString();
                    userFounded.MATKHAU = txtPassword.Text.ToString();
                    userFounded.DIACHI = txtDiaChi.Text.ToString();
                    userFounded.SDT = txtSDT.Text.ToString();
                    userFounded.TEN = txtTenUser.Text.ToString();

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
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            //ClearClickedData();
            //LoadData();
            //btnLuu.Enabled = false;
            //btnHuy.Enabled = false;
            //btnXoa.Enabled = true;
            //btnCapNhat.Enabled = true;
            //btnThem.Enabled = true;
            //btnTra.Enabled = true;
            //btnMuonSach.Enabled = true;
            //SetDisableComboBox();
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvDocGia.CurrentCell.RowIndex;

            this.txtTenUser.Text = dgvDocGia.Rows[r].Cells[6].Value.ToString();
            this.txtMaUser.Text = dgvDocGia.Rows[r].Cells[0].Value.ToString();
            this.txtUsername.Text = dgvDocGia.Rows[r].Cells[1].Value.ToString();
            this.txtPassword.Text = dgvDocGia.Rows[r].Cells[2].Value.ToString();
            this.txtDiaChi.Text = dgvDocGia.Rows[r].Cells[3].Value.ToString();
            this.txtSDT.Text = dgvDocGia.Rows[r].Cells[4].Value.ToString();
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            //cbMaSach.Enabled = true;
            //cbNamMuon.Enabled = true;
            //cbNamTra.Enabled = true;
            //cbThangTra.Enabled = true;
            //cbThangMuon.Enabled = true;
            //btnTra.Enabled = false;
            //btnCheck.Enabled = true;
            //btnHuy.Enabled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //if (txtMaDG.Text.ToString() == "")
            //{
            //    MessageBox.Show("Hãy chọn đọc giả nào cần mượn sách!");
            //}
            //else if (cbNgayMuon.Text.ToString() != "")
            //{
            //    if (cbNgayTra.Text.ToString() != "")
            //    {
            //        btnOK.Enabled = true;

            //    }
            //    else
            //    {
            //        MessageBox.Show("Điền vào thông tin ngày mượn và ngày trả!");
            //    }
            //}
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //string dMuon = cbNamMuon.Text + "-" + cbThangMuon.Text + "-" + cbNgayMuon.Text;
            //string dTra = cbNamTra.Text + "-" + cbThangTra.Text + "-" + cbNgayTra.Text;
            ////blSach.UpdateSachMuon(int.Parse(cbMaSach.Text.ToString()), ref err);

            //using (var db = new Model1())
            //{
            //    db.Configuration.LazyLoadingEnabled = false;
            //    MUONSACH muon = new MUONSACH();
            //    muon.MADG = int.Parse(txtMaDG.Text);
            //    muon.MASACH = int.Parse(cbMaSach.Text);
            //    muon.NGAYMUON = DateTime.Parse(dMuon);
            //    muon.NGAYTRA = DateTime.Parse(dTra);

            //    db.MUONSACHes.Add(muon);

            //    int tmp = int.Parse(cbMaSach.Text);
            //    var query = from d in db.SACHes
            //                where d.MASACH == tmp
            //                select d;
            //    foreach (var Changes in query)
            //    {
            //        Changes.DANGDUOCMUON = 1;
            //    }
            //    db.SaveChanges();
            //}
            //LoadData();
            //DisableComponent();
            //ClearClickedData();
            //SetDisableComboBox();
            //btnTra.Enabled = true;
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            //btnMuonSach.Enabled = false;
            //int r = dgvMuonSach.CurrentCell.RowIndex;
            //int rSelected = (int)dgvMuonSach.Rows[r].Cells[1].Value;

            //DialogResult traloi;
            //traloi = MessageBox.Show("Ban co muon xoa mau tin nay ko?", "Tra loi"
            //    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (traloi == DialogResult.Yes)
            //{               
            //    //Xoa Muon
            //    using (var db = new Model1())
            //    {
            //        db.Configuration.LazyLoadingEnabled = false;

            //        var query = from d in db.MUONSACHes
            //                    where d.MASACH == rSelected
            //                    select d;
            //        foreach (var MA in query)
            //        {
            //            db.MUONSACHes.Remove(MA);
            //        }
            //        db.SaveChanges();
            //    }
            //    //Update lai dang duoc muon = 0
            //    using (var db = new Model1())
            //    {
            //        db.Configuration.LazyLoadingEnabled = false;

            //        int tmp = int.Parse(cbMaSach.Text);
            //        var query = from d in db.SACHes
            //                    where d.MASACH == tmp
            //                    select d;
            //        foreach (var Changes in query)
            //        {
            //            Changes.DANGDUOCMUON = 0;
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
            //btnMuonSach.Enabled = true;
        }

        private void cbNamMuon_SelectedValueChanged(object sender, EventArgs e)
        {
            //cbNgayMuon.Items.Clear();
            //cbNgayMuon.ResetText();
            //cbNamTra.Items.Clear();
            //cbNamTra.ResetText();
            //cbThangMuon.Enabled = true;
            //AddItemNam(cbNamTra, int.Parse(cbNamMuon.Text), int.Parse(cbNamMuon.Text) + 10);
            //if (cbThangMuon.Text != "")
            //{
            //    if (int.Parse(cbThangMuon.Text) == 1 || int.Parse(cbThangMuon.Text) == 3
            //        || int.Parse(cbThangMuon.Text) == 5 || int.Parse(cbThangMuon.Text) == 7
            //        || int.Parse(cbThangMuon.Text) == 8 || int.Parse(cbThangMuon.Text) == 10 ||
            //        int.Parse(cbThangMuon.Text) == 12)
            //        AddItemDay(cbNgayMuon, 31);
            //    else if (int.Parse(cbThangMuon.Text) == 2)
            //    {
            //        if (checkYear(int.Parse(cbNamMuon.Text)) == true)
            //            AddItemDay(cbNgayMuon, 29);
            //        else
            //            AddItemDay(cbNgayMuon, 28);
            //    }
            //    else
            //        AddItemDay(cbNgayMuon, 30);
            //}
        }

        private void cbThangMuon_SelectedValueChanged(object sender, EventArgs e)
        {
            //cbNgayMuon.Enabled = true;
            //cbNgayMuon.Items.Clear();
            //cbNgayMuon.ResetText();
            //if (int.Parse(cbThangMuon.Text) == 1 || int.Parse(cbThangMuon.Text) == 3
            //    || int.Parse(cbThangMuon.Text) == 5 || int.Parse(cbThangMuon.Text) == 7
            //    || int.Parse(cbThangMuon.Text) == 8 || int.Parse(cbThangMuon.Text) == 10 ||
            //    int.Parse(cbThangMuon.Text) == 12)
            //    AddItemDay(cbNgayMuon, 31);
            //else if (int.Parse(cbThangMuon.Text) == 2)
            //{
            //    if (checkYear(int.Parse(cbNamMuon.Text)) == true)
            //        AddItemDay(cbNgayMuon, 29);
            //    else
            //        AddItemDay(cbNgayMuon, 28);
            //}
            //else
            //    AddItemDay(cbNgayMuon, 30);
        }

        private void cbNamTra_SelectedValueChanged(object sender, EventArgs e)
        {
            //cbNgayTra.Items.Clear();
            //cbNgayTra.ResetText();
            //if (cbThangTra.Text != "")
            //{
            //    if (int.Parse(cbThangTra.Text) == 1 || int.Parse(cbThangTra.Text) == 3
            //        || int.Parse(cbThangTra.Text) == 5 || int.Parse(cbThangTra.Text) == 7
            //        || int.Parse(cbThangTra.Text) == 8 || int.Parse(cbThangTra.Text) == 10 ||
            //        int.Parse(cbThangTra.Text) == 12)
            //        AddItemDay(cbNgayTra, 31);
            //    else if (int.Parse(cbThangTra.Text) == 2)
            //    {
            //        if (checkYear(int.Parse(cbNamTra.Text)) == true)
            //            AddItemDay(cbNgayTra, 29);
            //        else
            //            AddItemDay(cbNgayTra, 28);
            //    }
            //    else
            //        AddItemDay(cbNgayTra, 30);
            //}
        }

        private void cbThangTra_SelectedValueChanged(object sender, EventArgs e)
        {
            //cbNgayTra.Enabled = true;
            //cbNgayTra.Items.Clear();
            //cbNgayTra.ResetText();
            //if (int.Parse(cbThangTra.Text) == 1 || int.Parse(cbThangTra.Text) == 3
            //    || int.Parse(cbThangTra.Text) == 5 || int.Parse(cbThangTra.Text) == 7
            //    || int.Parse(cbThangTra.Text) == 8 || int.Parse(cbThangTra.Text) == 10 ||
            //    int.Parse(cbThangTra.Text) == 12)
            //    AddItemDay(cbNgayTra, 31);
            //else if (int.Parse(cbThangTra.Text) == 2)
            //{
            //    if (checkYear(int.Parse(cbNamTra.Text)) == true)
            //        AddItemDay(cbNgayTra, 29);
            //    else
            //        AddItemDay(cbNgayTra, 28);
            //}
            //else
            //    AddItemDay(cbNgayTra, 30);
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgvDocGia.CurrentCell.RowIndex;

            int rSelected = (int)dgvDocGia.Rows[r].Cells[0].Value;
            DialogResult traloi;
            traloi = MessageBox.Show("Ban co muon xoa mau tin nay ko?", "Tra loi"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                int MaUser = int.Parse(txtMaUser.Text);
                db.sp_Delete_User(MaUser);
                LoadData();
                MessageBox.Show("Da Xoa Xong!");
            }
            else
            {
                MessageBox.Show("Ban Da Bam Khong!");
            }
            ClearClickedData();
        }
    }
}
