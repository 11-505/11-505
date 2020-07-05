using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_genealogy
{
    public partial class Systemadmins : Form
    {
        public Systemadmins()
        {
            InitializeComponent();
        }

        internal static void show()
        {
            throw new NotImplementedException();
        }

        private void Newgenealogy_Click(object sender, EventArgs e)
        {
            Newgenealogy newgenealogy = new Newgenealogy();
            newgenealogy.Show();
        }

        private void Momembers_Click(object sender, EventArgs e)
        {
            Checkgenealogy checkgenealogy = new Checkgenealogy();
            checkgenealogy.Show();
        }
    }
}
