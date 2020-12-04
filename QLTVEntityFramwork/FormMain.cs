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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (var db = new Model1())
            //{
            //    db.Configuration.LazyLoadingEnabled = false;
            //    var query = from d in db.NXBs
            //                select d;
            //    dgv.DataSource = query.ToList();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //using (var db = new Model1())
            //{
            //    db.Configuration.LazyLoadingEnabled = false;
            //    SACH sa = new SACH();
            //    sa.MASACH = 35;
            //    sa.MANXB = 5;
            //    sa.MATACGIA = 1;
            //    sa.VITRI = "C3";
            //    sa.TENSACH = "Entity Framework";
            //    sa.DANGDUOCMUON = 0;
            //    db.SACHes.Add(sa);
            //    db.SaveChanges();
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //using (var db = new Model1())
            //{
            //    db.Configuration.LazyLoadingEnabled = false;

            //    var query = from d in db.SACHes
            //                where d.MASACH == 35
            //                select d;
            //    foreach (var MA in query)
            //    {
            //        db.SACHes.Remove(MA);
            //    }
            //    db.SaveChanges();
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //using (var db = new Model1())
            //{
            //    db.Configuration.LazyLoadingEnabled = false;
            //    var query = from d in db.SACHes
            //                where d.MASACH == 35
            //                select d;
            //    foreach (var MA in query)
            //    {
            //        MA.TENSACH = "MAI VAN LUONG";
            //    }
            //    db.SaveChanges();
            //}
        }
    }    
}
