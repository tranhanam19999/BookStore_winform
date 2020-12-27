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
    public partial class More : Form
    {
        string colTacGia;
        string colTT = "HyperLink";
        public More()
        {
            InitializeComponent();
        }

        private void More_Load(object sender, EventArgs e)
        {
            dgvMore.Columns.Add(colTacGia, "Tên Tác Giả");
            dgvMore.Columns.Add("HyperLink", "Thông Tin");

            dgvMore.Rows.Add("Tran Cong Tu", "https://www.facebook.com/tctuvn");
            dgvMore.Rows.Add("Le Van Vinh", "https://www.facebook.com/vinh.levan.1293");
            dgvMore.Rows.Add("Dang Vu Dung", "https://www.facebook.com/dang.dungx.1");
            dgvMore.Rows.Add("Mai Van Luong", "https://www.facebook.com/profile.php?id=100013756633996");
            dgvMore.Rows.Add("Dang Vu Nam", "https://www.facebook.com/profile.php?id=100049089272777");
            dgvMore.Rows.Add("Su Pham Ky Thuat", "https://www.facebook.com/fit.hcmute.edu.vn/");
            SetHyperLinkOnGrid();
            GetHyperLinkStyleForGridCell();
        }
        private DataGridViewCellStyle GetHyperLinkStyleForGridCell()
        {
            // Set the Font and Uderline into the Content of the grid cell .  
            {
                DataGridViewCellStyle l_objDGVCS = new DataGridViewCellStyle();
                System.Drawing.Font l_objFont = new System.Drawing.Font(FontFamily.GenericSansSerif, 8, FontStyle.Underline);
                l_objDGVCS.Font = l_objFont;
                l_objDGVCS.ForeColor = Color.Blue;
                return l_objDGVCS;
            }
        }
        private void SetHyperLinkOnGrid()
        {

            if (dgvMore.Columns.Contains("HyperLink"))
            {
                dgvMore.Columns["HyperLink"].DefaultCellStyle = GetHyperLinkStyleForGridCell();
            }
        }

        private void dgvMore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvMore.Columns[dgvMore.CurrentCell.ColumnIndex].HeaderText.Contains("Thông Tin"))
            {
                if (!String.IsNullOrWhiteSpace(dgvMore.CurrentCell.EditedFormattedValue.ToString()))
                {
                    System.Diagnostics.Process.Start("" + dgvMore.CurrentCell.EditedFormattedValue);
                }
            }
        }
    }
}
