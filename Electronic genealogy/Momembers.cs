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
        public char M_lvpl { get; private set; }

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

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Momembers momembers = new Momembers();
            this.Close();
            momembers.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = DB.Select("select * from Members where M_id='" + ID.Text + "'");
            Gender.Text  = dt.Rows[0]["M_sex"].ToString();
            Datebirth.Text = dt.Rows[0]["M_born"].ToString();
            NameT.Text = dt.Rows[0]["M_name"].ToString();
            Datedeath.Text = dt.Rows[0]["M_dead"].ToString();
            Wherelive.Text = dt.Rows[0]["M_brpl"].ToString();
            Placebirth.Text = dt.Rows[0]["M_lvpl"].ToString();
            Ranking.Text = dt.Rows[0]["M_rank"].ToString();
            Algebra.Text = dt.Rows[0]["M_gnum"].ToString();
            GenealogyID.Text = dt.Rows[0]["Ge_id"].ToString();
            FatherID.Text = dt.Rows[0]["M_faid"].ToString();
        }
    }
}
