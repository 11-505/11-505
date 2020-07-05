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
    public partial class Addmember : Form
    {
        public Addmember()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            DataTable dt = DB.Select("insert into Members values('" + this.id.Text + "','" + this.name.Text + "','" + this.sex.Text + "','" + this.born.Text + "','" + this.dead.Text + "','" + this.brpl.Text + "','" + this.lvpl.Text + "','" + this.rank.Text + "','" + this.gnum.Text + "','" + this.geid.Text + "','" + this.faid.Text + "')");
            MessageBox.Show("增加成功");
        }
    }
}
