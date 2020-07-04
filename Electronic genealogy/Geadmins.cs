using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_genealogy
{
    public partial class Geadmins : Form
    {
        public Geadmins()
        {
            InitializeComponent();
        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void Newmembers_Click(object sender, EventArgs e)
        {
            Addmember a = new Addmember();
            a.Show();
        }
    }
}
