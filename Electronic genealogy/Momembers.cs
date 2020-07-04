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
    public partial class Momembers : Form
    {
        public Momembers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = DB.Select("update Members set M_sex='" + Gender.Text + "',M_born='" + Datebirth.Text + "',M_name='" + NameT.Text + "' ,M_dead='" + Datedeath.Text + "',M_brpl='" + Placebirth.Text + "',M_lvpl='" + Wherelive.Text + "', M_rank='" + Ranking.Text + "',M_gnum='" + Algebra.Text + "',Ge_id='" + GenealogyID.Text + "',M_faid='" + FatherID.Text + "'where M_id='" + ID.Text + "'");
            MessageBox.Show("修改成功！");;
        }

        private void Momembers_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“genealogy_DataDataSet.Members”中。您可以根据需要移动或删除它。
            this.membersTableAdapter.Fill(this.genealogy_DataDataSet.Members);

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Momembers momembers = new Momembers();
            this.Close();
            momembers.Show();
        }
    }
}
