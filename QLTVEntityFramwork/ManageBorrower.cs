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
    public partial class ManageBorrower : Form
    {
        bool Them, CapNhat;
        bool checkThem = true;
        QLThuVienEntities db = new QLThuVienEntities();
        public ManageBorrower()
        {
            InitializeComponent();

            //txtMaDG.Enabled = false;
            //txtName.Enabled = false;
            //txtDiaChi.Enabled = false;
            //txtSDT.Enabled = false;
            //btnLuu.Enabled = false;
            //btnHuy.Enabled = false;
            LoadData();
            //AddItemNam(cbNamMuon, 1999, 2025);
            //AddItemMouth(cbThangMuon);
            //AddItemMouth(cbThangTra);
            //SetDisableComboBox();
            
        }
        void LoadData()
        {
            db.Configuration.LazyLoadingEnabled = false;
            var data = db.USERS.ToList();
            dgvDocGia.DataSource = data;
            //using (var db = new Model1())
            //{
            //    db.Configuration.LazyLoadingEnabled = false;
            //    var query = from d in db.DOCGIAs
            //                select d;
            //    dgvDocGia.DataSource = query.ToList();
            //}
            //dgvDocGia.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvDocGia.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvDocGia.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvDocGia.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDocGia.Columns[0].HeaderText = "Mã Đọc Giả";
            dgvDocGia.Columns[1].HeaderText = "USERNAME";
            dgvDocGia.Columns[3].HeaderText = "PASSWORD";
            dgvDocGia.Columns[4].HeaderText = "Địa Chỉ";
            dgvDocGia.Columns[5].HeaderText = "SĐT";
            dgvDocGia.Columns[6].HeaderText = "Mã CARD";
            dgvDocGia.Columns[7].HeaderText = "Chức vụ";
            dgvDocGia.Columns[8].HeaderText = "Tên Đọc Giả";
            dgvDocGia.Columns[9].Visible = false;

            db.Configuration.LazyLoadingEnabled = false;
            var data1 = db.Borrowing_Details.ToList();
            dgvMuonSach.DataSource = data1;
            dgvMuonSach.Columns[0].HeaderText = "Tên Đọc giả";
            dgvMuonSach.Columns[1].HeaderText = "Tên Sách";
            dgvMuonSach.Columns[2].HeaderText = "Ngày Mượn";
            dgvMuonSach.Columns[3].HeaderText = "Ngày Trả";
            dgvMuonSach.Columns[4].HeaderText = "Tình trạng";
            //dgvMuonSach.Columns[5].HeaderText = "Số Lượng Trả";
            //dgvMuonSach.Columns[6].HeaderText = "Số Lượng Mất";
            //dgvMuonSach.Columns[7].Visible = false;
            //dgvMuonSach.Columns[8].Visible = false;
            //using (var db = new Model1())
            //{
            //    btnCheck.Enabled = false;
            //    cbMaSach.Enabled = false;
            //    db.Configuration.LazyLoadingEnabled = false;
            //    var query = from d in db.MUONSACHes
            //                select d;
            //    dgvMuonSach.DataSource = query.ToList();
            //}
            //dgvMuonSach.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvMuonSach.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgvMuonSach.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvMuonSach.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //dgvMuonSach.Columns[0].HeaderText = "Mã Đọc Giả";
            //dgvMuonSach.Columns[1].HeaderText = "Mã Sách";
            //dgvMuonSach.Columns[2].HeaderText = "Ngày Mượn";
            //dgvMuonSach.Columns[3].HeaderText = "Ngày Trả";

            //using (var db = new Model1())
            //{
            //    var query = (from d in db.SACHes
            //                 where d.DANGDUOCMUON == 0
            //                 select d.MASACH).ToList();
            //    cbMaSach.DataSource = query;
            //}
            //btnOK.Enabled = false;
        }
        public void DisableComponent()
        {
            //txtMaDG.Enabled = false;
            //txtName.Enabled = false;
            //txtDiaChi.Enabled = false;
            //txtSDT.Enabled = false;
            //btnLuu.Enabled = false;
            //btnHuy.Enabled = false;
            //cbMaSach.Enabled = false;
        }
        public void EnableComponent()
        {
            //txtMaDG.Enabled = true;
            //txtName.Enabled = true;
            //txtDiaChi.Enabled = true;
            //txtSDT.Enabled = true;
            //btnLuu.Enabled = true;
            //btnHuy.Enabled = true;
        }
        public void ClearClickedData()
        {
            //txtMaDG.Text = "";
            //txtDiaChi.Text = "";
            //txtName.Text = "";
            //txtSDT.Text = "";
            //cbNamMuon.Text = "";
            //cbThangMuon.Text = "";
            //cbNgayMuon.Text = "";
            //cbNamTra.Text = "";
            //cbThangTra.Text = "";
            //cbNgayTra.Text = "";
        }
        public void SetDisableComboBox()
        {
            //cbNamMuon.Enabled = false;
            //cbThangMuon.Enabled = false;
            //cbNgayMuon.Enabled = false;
            //cbNamTra.Enabled = false;
            //cbThangTra.Enabled = false;
            //cbNgayTra.Enabled = false;
        }
        public void AddItemNam(ComboBox a, int b, int c)
        {
            //for (int i = c; i >= b; i--)
            //    a.Items.Add(i);
        }
        public void AddItemMouth(ComboBox a)
        {
            //for (int i = 1; i < 13; i++)
            //    a.Items.Add(i);
        }
        public void AddItemDay(ComboBox a, int b)
        {
            //for (int i = 1; i <= b; i++)
            //    a.Items.Add(i);
        }
        //public bool checkYear(int year)
        //{
        //    //// Nếu số năm chia hết cho 400,
        //    //// đó là 1 năm nhuận
        //    //if (year % 400 == 0)
        //    //    return true;

        //    //// Nếu số năm chia hết cho 4 và không chia hết cho 100,
        //    //// đó không là 1 năm nhuận
        //    //if (year % 4 == 0 && year % 100 != 0)
        //    //    return true;

        //    //// trường hợp còn lại 
        //    //// không phải năm nhuận
        //    //return false;
        //}
        private void btnThem_Click(object sender, EventArgs e)
        {
            //btnCapNhat.Enabled = false;
            //btnXoa.Enabled = false;
            //ClearClickedData();
            //EnableComponent();
            //Them = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //EnableComponent();
            //txtMaDG.Enabled = false;
            //btnThem.Enabled = false;
            //btnXoa.Enabled = false;

            //CapNhat = true;
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
            //if (Them == true)
            //{
            //    foreach (DataGridViewRow row in dgvDocGia.Rows)
            //    {
            //        if (row.Cells[0].Value == null)
            //        {
            //            checkThem = true;
            //            break;
            //        }
            //        if (Int32.Parse(row.Cells[0].Value.ToString()) == Int32.Parse(txtMaDG.Text))
            //        {
            //            MessageBox.Show("Trùng Mã Đọc Giả Rồi!");
            //            btnLuu.Enabled = false;
            //            btnCapNhat.Enabled = true;
            //            btnXoa.Enabled = true;
            //            Them = false;
            //            DisableComponent();
            //            ClearClickedData();
            //            checkThem = false;
            //            break;
            //        }
            //    }
            //    if (checkThem == true)
            //    {
            //        using (var db = new Model1())
            //        {
            //            db.Configuration.LazyLoadingEnabled = false;

            //            DOCGIA docgia = new DOCGIA();
            //            docgia.MADG = int.Parse(txtMaDG.Text);
            //            docgia.TENDOCGIA = txtName.Text;
            //            docgia.SDT = txtSDT.Text;
            //            docgia.DIACHI = txtDiaChi.Text;
            //            db.DOCGIAs.Add(docgia);
            //            db.SaveChanges();
            //        }
            //        LoadData();
            //        MessageBox.Show("Da them xong");
            //        btnLuu.Enabled = false;
            //        btnCapNhat.Enabled = true;
            //        btnXoa.Enabled = true;
            //        Them = false;
            //        DisableComponent();
            //        ClearClickedData();
            //    }

            //}
            //else if (CapNhat == true)
            //{
            //    using (var db = new Model1())
            //    {
            //        db.Configuration.LazyLoadingEnabled = false;

            //        int tmp = int.Parse(txtMaDG.Text);
            //        var query = from d in db.DOCGIAs
            //                    where d.MADG == tmp
            //                    select d;
            //        foreach (var Changes in query)
            //        {
            //            Changes.TENDOCGIA = txtName.Text;
            //            Changes.SDT = txtSDT.Text;
            //            Changes.DIACHI = txtDiaChi.Text;
            //        }
            //        db.SaveChanges();
            //        LoadData();
            //        MessageBox.Show("Da Cap Nhat Xong!");
            //        btnLuu.Enabled = false;
            //        btnThem.Enabled = true;
            //        btnXoa.Enabled = true;
            //        CapNhat = false;
            //        DisableComponent();
            //        ClearClickedData();
            //    }
            //}
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
            //int r = dgvDocGia.CurrentCell.RowIndex;

            //this.txtMaDG.Text = dgvDocGia.Rows[r].Cells[0].Value.ToString();
            //this.txtName.Text = dgvDocGia.Rows[r].Cells[1].Value.ToString();
            //this.txtDiaChi.Text = dgvDocGia.Rows[r].Cells[2].Value.ToString();
            //this.txtSDT.Text = dgvDocGia.Rows[r].Cells[3].Value.ToString();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
        //    int r = dgvDocGia.CurrentCell.RowIndex;

        //    int rSelected = (int)dgvDocGia.Rows[r].Cells[0].Value;
        //    DialogResult traloi;
        //    traloi = MessageBox.Show("Ban co muon xoa mau tin nay ko?", "Tra loi"
        //        , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (traloi == DialogResult.Yes)
        //    {
        //        using (var db = new Model1())
        //        {
        //            db.Configuration.LazyLoadingEnabled = false;
        //            int tmp = int.Parse(txtMaDG.Text);
        //            var query = from d in db.DOCGIAs
        //                        where d.MADG == tmp
        //                        select d;
        //            foreach (var MADG in query)
        //            {
        //                db.DOCGIAs.Remove(MADG);
        //            }
        //            db.SaveChanges();
        //        }
        //        LoadData();
        //        MessageBox.Show("Da Xoa Xong!");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Ban Da Bam Khong!");
        //    }
        //    ClearClickedData();
        }
    }
}
