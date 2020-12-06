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
    public partial class SearchInformation : Form
    {
        bool sByTenSach = false, sByMuon = false, sByViTri = false;
        QLThuVienEntities db = new QLThuVienEntities();
        private void cbOptionSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            sByTenSach = false;
            sByMuon = false;
            sByViTri = false;

            dgvInfo.Enabled = true;
            txtSearch.Enabled = true;
            LoadData();

            if (cbOptionSearch.Text == "Ten Sach")
            {
                sByTenSach = true;
            }
            else if (cbOptionSearch.Text == "Vi Tri")
            {
                sByViTri = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (sByTenSach == true)
            {
                string Tensach = txtSearch.Text;
                var query = db.SEARCH_TENSACH(Tensach);
                dgvInfo.DataSource = query.ToList();
            }
            else if (sByViTri == true)
            {
                string Vitri = txtSearch.Text;
                var query = db.SEARCH_VITRI(Vitri);
                dgvInfo.DataSource = query.ToList();
            }
        }

        public SearchInformation()
        {
            InitializeComponent();
            LoadData();
            cbOptionSearch.Items.Add("Ten Sach");
            cbOptionSearch.Items.Add("Vi Tri");
            dgvInfo.Enabled = false;
            txtSearch.Enabled = false;
        }
        public void LoadData()
        {
            var data = db.Book_Info.ToList();
            dgvInfo.DataSource = data;
            dgvInfo.AutoResizeColumns();
            txtSearch.Focus();
            dgvInfo.Columns[0].HeaderText = "Tên Sách";
            dgvInfo.Columns[1].HeaderText = "Lĩnh Vực";
            dgvInfo.Columns[2].HeaderText = "Giá";
            dgvInfo.Columns[3].HeaderText = "Vị Trí";
            dgvInfo.Columns[4].HeaderText = "Tình Trạng Mượn";
            dgvInfo.Columns[5].HeaderText = "Số Lượng Bị Mất";
            dgvInfo.Columns[6].HeaderText = "Tổng Số Lượng";  
        }
    }
}
