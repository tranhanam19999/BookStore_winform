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
    public partial class ManagerCard : Form
    {
        bool Them, CapNhat;
        bool checkThem = true;
        Model.QLThuVienEntities db = new Model.QLThuVienEntities();
        public ManagerCard()
        {
            InitializeComponent();
            LoadData();
            DisableComponent();
        }

        private void txtNgayHetHan_Click(object sender, EventArgs e)
        {

        }
        public void EnableComponent()
        {
            txtMaCart.Enabled = true;
            txtMaUser.Enabled = true;
            txtNumberCard.Enabled = true;
            txtNgayMo.Enabled = true;
            txtNgayHetHan.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void FormCart_Load(object sender, EventArgs e)
        {


        }

        private void dgvCard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCard.CurrentCell.RowIndex;
            //   var MasachClick = db.GetMaSach(dgvDocGia.Rows[r].Cells[1].Value.ToString());


            //this.txtMaSach.Text = MasachClick;
            this.txtMaCart.Text = dgvCard.Rows[r].Cells[0].Value.ToString();
            this.txtMaUser.Text = dgvCard.Rows[r].Cells[1].Value.ToString();
            this.txtNumberCard.Text = dgvCard.Rows[r].Cells[2].Value.ToString();
            this.txtNgayMo.Text = dgvCard.Rows[r].Cells[3].Value.ToString();
            this.txtNgayHetHan.Text = dgvCard.Rows[r].Cells[4].Value.ToString();
        }
        public void ClearClickedData()
        {
            txtMaCart.Text = "";
            txtMaUser.Text = "";
            txtNumberCard.Text = "";
            txtNgayMo.Text = "";
            txtNgayHetHan.Text = "";

        }
        public void DisableComponent()
        {
            txtMaCart.Enabled = false;
            txtMaUser.Enabled = false;
            txtNumberCard.Enabled = false;
            txtNgayMo.Enabled = false;
            txtNgayHetHan.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

        }

        private void dgvCard_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string macard = txtMaCart.Text.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Ban co muon xoa mau tin nay ko?", "Tra loi"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {

                db.Delete_Cards(Int32.Parse(macard));
                LoadData();
                MessageBox.Show("Da Xoa Xong!");
            }
            else
            {
                MessageBox.Show("Ban Da Bam Khong!");
            }
            ClearClickedData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            EnableComponent();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;

            CapNhat = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them == true)
            {
                if (checkThem == true)
                {
                    //int MaUser = int.Parse(txtMaUser.Text.ToString());

                    string macard = txtMaCart.Text.ToString();
                    string mauser = txtMaUser.Text.ToString();
                    string socard = txtNumberCard.Text.ToString();
                    string ngaymo = txtNgayMo.Text.ToString();
                    string ngayhethan = txtNgayHetHan.Text.ToString();
                    MessageBox.Show(socard);

                    db.Add_Cards(Int32.Parse(macard), Int32.Parse(mauser), socard, ngaymo, ngayhethan);

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

                    string macard = txtMaCart.Text.ToString();
                    string mauser = txtMaUser.Text.ToString();
                    string socard = txtNumberCard.Text.ToString();
                    string ngaymo = txtNgayMo.Text.ToString();
                    string ngayhethan = txtNgayHetHan.Text.ToString();
                    MessageBox.Show(socard);

                    db.update_Cards(Int32.Parse(macard), Int32.Parse(mauser), socard, ngaymo, ngayhethan);



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

        private void searchMuonSach_Click(object sender, EventArgs e)
        {
            db.Configuration.LazyLoadingEnabled = false;

            string macard = txtMaCardSearch.Text.ToString();

            var listcard = db.Search_Cards(Int32.Parse(macard));
            dgvCard.DataSource = listcard;

            dgvCard.Columns[0].HeaderText = "Mã Cart";
            dgvCard.Columns[1].HeaderText = "Mã User";
            dgvCard.Columns[2].HeaderText = "Số Card";
            dgvCard.Columns[3].HeaderText = "Ngày đăng ký";
            dgvCard.Columns[4].HeaderText = "Ngày hết hạn";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvCard_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCard.CurrentCell.RowIndex;
            //   var MasachClick = db.GetMaSach(dgvDocGia.Rows[r].Cells[1].Value.ToString());


            //this.txtMaSach.Text = MasachClick;
            this.txtMaCart.Text = dgvCard.Rows[r].Cells[0].Value.ToString();
            this.txtMaUser.Text = dgvCard.Rows[r].Cells[1].Value.ToString();
            this.txtNumberCard.Text = dgvCard.Rows[r].Cells[2].Value.ToString();
            this.txtNgayMo.Text = dgvCard.Rows[r].Cells[3].Value.ToString();
            this.txtNgayHetHan.Text = dgvCard.Rows[r].Cells[4].Value.ToString();
        }

        private void searchMuonSach_Click_1(object sender, EventArgs e)
        {
            db.Configuration.LazyLoadingEnabled = false;

            string macard = txtMaCardSearch.Text.ToString();

            var listcard = db.Search_Cards(Int32.Parse(macard));
            dgvCard.DataSource = listcard;

            dgvCard.Columns[0].HeaderText = "Mã Cart";
            dgvCard.Columns[1].HeaderText = "Mã User";
            dgvCard.Columns[2].HeaderText = "Số Card";
            dgvCard.Columns[3].HeaderText = "Ngày đăng ký";
            dgvCard.Columns[4].HeaderText = "Ngày hết hạn";

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            ClearClickedData();
            EnableComponent();
            Them = true;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string macard = txtMaCart.Text.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Ban co muon xoa mau tin nay ko?", "Tra loi"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {

                db.Delete_Cards(Int32.Parse(macard));
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

                    string macard = txtMaCart.Text.ToString();
                    string mauser = txtMaUser.Text.ToString();
                    string socard = txtNumberCard.Text.ToString();
                    string ngaymo = txtNgayMo.Text.ToString();
                    string ngayhethan = txtNgayHetHan.Text.ToString();
                    MessageBox.Show(socard);

                    db.Add_Cards(Int32.Parse(macard), Int32.Parse(mauser), socard, ngaymo, ngayhethan);

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

                    string macard = txtMaCart.Text.ToString();
                    string mauser = txtMaUser.Text.ToString();
                    string socard = txtNumberCard.Text.ToString();
                    string ngaymo = txtNgayMo.Text.ToString();
                    string ngayhethan = txtNgayHetHan.Text.ToString();
                    MessageBox.Show(socard);

                    db.update_Cards(Int32.Parse(macard), Int32.Parse(mauser), socard, ngaymo, ngayhethan);

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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ManagerCard_Load(object sender, EventArgs e)
        {

        }

        void LoadData()
        {
            db.Configuration.LazyLoadingEnabled = false;

            var listcard = db.Get_Cards();
            dgvCard.DataSource = listcard;

            dgvCard.Columns[0].HeaderText = "Mã Cart";
            dgvCard.Columns[1].HeaderText = "Mã User";
            dgvCard.Columns[2].HeaderText = "Số Card";
            dgvCard.Columns[3].HeaderText = "Ngày đăng ký";
            dgvCard.Columns[4].HeaderText = "Ngày hết hạn";
        }

    }
}
