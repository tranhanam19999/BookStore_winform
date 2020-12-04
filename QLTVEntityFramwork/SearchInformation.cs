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
            //txtSearch.Text = "";
            //sByTenSach = false;
            //sByMuon = false;
            //sByViTri = false;

            //dgvInfo.Enabled = true;
            //txtSearch.Enabled = true;
            //LoadData();
            //if (cbOptionSearch.Text == "Ten Sach")
            //{
            //    sByTenSach = true;
            //}
            //else if (cbOptionSearch.Text == "Vi Tri")
            //{
            //    sByViTri = true;
            //}
            //else if (cbOptionSearch.Text == "Tinh Trang Sach")
            //{
            //    sByMuon = true;
            //    MessageBox.Show("1 là mượn rồi " +
            //                    "0 là chưa có ai mượn");
            //}
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //if (sByTenSach == true)
            //{
            //    using (var db = new Model1())
            //    {
            //        var query = from d in db.SACHes
            //                    where d.TENSACH.Contains(txtSearch.Text)
            //                    select d;
            //        dgvInfo.DataSource = query.ToList();
            //    }
            //}
            //else if (sByViTri == true)
            //{
            //    using (var db = new Model1())
            //    {
            //        var query = from d in db.SACHes
            //                    where d.VITRI.Contains(txtSearch.Text)
            //                    select d;
            //        dgvInfo.DataSource = query.ToList();
            //    }
            //}
            //else if (sByMuon == true)
            //{
            //    try
            //    {
            //        using (var db = new Model1())
            //        {
            //            int tmp = int.Parse(txtSearch.Text);
            //            var query = from d in db.SACHes
            //                        where d.DANGDUOCMUON == tmp
            //                        select d;
            //            dgvInfo.DataSource = query.ToList();
            //        }
            //    }
            //    catch
            //    { }
            //}
        }

        public SearchInformation()
        {
            InitializeComponent();
            LoadData();
            //cbOptionSearch.Items.Add("Ten Sach");
            //cbOptionSearch.Items.Add("Vi Tri");
            //cbOptionSearch.Items.Add("Tinh Trang Sach");
            //dgvInfo.Enabled = false;
            //txtSearch.Enabled = false;
        }
        public void LoadData()
        {
            var data = db.Book_Info.ToList();
            dgvInfo.DataSource = data;
            //using (var db = new Model1())
            //{
            //    var query = from d in db.SACHes
            //                select d;
            //    dgvInfo.DataSource = query.ToList();
            //}
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
