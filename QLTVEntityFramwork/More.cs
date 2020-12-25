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

            dgvMore.Rows.Add("To Hoai", "https://vi.wikipedia.org/wiki/T%C3%B4_Ho%C3%A0i");
            dgvMore.Rows.Add("To Huu", "https://vi.wikipedia.org/wiki/T%E1%BB%91_H%E1%BB%AFu");
            dgvMore.Rows.Add("Xuan Dieu", "https://vi.wikipedia.org/wiki/Xu%C3%A2n_Di%E1%BB%87u");
            dgvMore.Rows.Add("Xuan Quynh", "https://vi.wikipedia.org/wiki/Xu%C3%A2n_Qu%E1%BB%B3nh");
            dgvMore.Rows.Add("Che Lan Vien", "https://vi.wikipedia.org/wiki/Ch%E1%BA%BF_Lan_Vi%C3%AAn");
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
