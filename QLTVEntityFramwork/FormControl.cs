using System.Windows.Forms;

namespace QLTVEntityFramwork
{
    public partial class FormControl : Form
    {
        public FormControl()
        {
            InitializeComponent();
        }

        private void pcbManageBook_Click(object sender, System.EventArgs e)
        {
            ManageBook manage_Book = new ManageBook();
            manage_Book.ShowDialog();
        }

        private void pcbSearchInformation_Click(object sender, System.EventArgs e)
        {
            SearchInformation searchInformation = new SearchInformation();
            searchInformation.ShowDialog();
        }

        private void pcbWriter_Click(object sender, System.EventArgs e)
        {
            Writer writer = new Writer();
            writer.ShowDialog();
        }

        private void pcbManageBorrower_Click(object sender, System.EventArgs e)
        {
            ManageBorrower manageBorrower = new ManageBorrower();
            manageBorrower.ShowDialog();
        }

        private void pcbPublisher_Click(object sender, System.EventArgs e)
        {
            Publisher publisher = new Publisher();
            publisher.ShowDialog();
        }

        private void pcbMore_Click(object sender, System.EventArgs e)
        {
            More more = new More();
            more.ShowDialog();
        }

        private void pcbAboutUs_Click(object sender, System.EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }

        private void btnReport_Click(object sender, System.EventArgs e)
        {
            FormReport report = new FormReport();
            report.ShowDialog();
        }
    }
}
