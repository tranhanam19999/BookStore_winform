using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVEntityFramwork
{
    class Program
    {
        //public static void Main(string[] args)
        //{
        //    FormMain form = new FormMain();
        //    form.Show();

        //}
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new LoginForm());
        }
    }
}
