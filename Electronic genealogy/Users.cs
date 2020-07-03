using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_genealogy
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void Qumembers_Click(object sender, EventArgs e)
        {
            check form = new check();
            form.Show();

        }
    }
}
