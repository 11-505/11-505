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

        private void Momembers_Click(object sender, EventArgs e)
        {
            Momembers momembers = new Momembers();
            momembers.Show();
        }
    }
}
