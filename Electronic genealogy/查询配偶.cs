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
    public partial class 查询配偶 : Form
    {
        public 查询配偶()
        {
            InitializeComponent();
        }

        private void M_id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (M_id.Text.Trim() == "")
                {
                    S_name.Text = "";
                    S_sex.Text = "";
                    S_born.Text = "";
                    S_dead.Text = "";
                    S_brpl.Text = "";
                    S_lvpl.Text = "";
                }
                else
                {
                    DB conn = new DB();

                    string sql = "select * from [Spouses] where M_id = '" + M_id.Text.Trim() + "'";
                    DataTable dt = new DataTable();
                    dt.Select(sql);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        S_name.Text = dt.Rows[0]["S_name"].ToString();
                        S_sex.Text = dt.Rows[0]["S_sex"].ToString();
                        S_born.Text = dt.Rows[0]["S_born"].ToString();
                        S_dead.Text = dt.Rows[0]["S_dead"].ToString();
                        S_brpl.Text = dt.Rows[0]["S_brpl"].ToString();
                        S_lvpl.Text = dt.Rows[0]["S_lvpl"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("输入有误");
                    }

                }
            
            }
        }
    }
}
