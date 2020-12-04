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
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            //PutDataInComboMaDG();
            //// TODO: This line of code loads data into the 'DataSetQLTV.Report' table. You can move, or remove it, as needed.
            //this.ReportTableAdapter.Fill(this.DataSetQLTV.Report, Convert.ToInt32(cbMaDocGia.Text));
            //this.reportViewer1.RefreshReport();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.ReportTableAdapter.Fill(this.DataSetQLTV.Report, Convert.ToInt32(cbMaDocGia.Text));
            //}
            //catch
            //{
            //    MessageBox.Show("nhập kiêu int");
            //}
            //this.reportViewer1.RefreshReport();
        }
        public void PutDataInComboMaDG()
        {
            //using (var db = new Model1())
            //{
            //    db.Configuration.LazyLoadingEnabled = false;
            //    var query = (from d in db.DOCGIAs
            //                 select d.MADG).ToList();
            //    cbMaDocGia.DataSource = query;
            //}
        }
    }
}
