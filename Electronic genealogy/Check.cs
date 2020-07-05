using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace Electronic_genealogy
{
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data Source = .; Initial Catalog = Genealogy Data; User ID = sa; Password = 123456";
            SqlConnection connection = new SqlConnection(connString);
            string m_id = textBox1.Text;
            {
                connection.Open();
               string sql = @"SELECT * FROM Members WHERE [M_id]='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (!dr.Read())
                {
                    MessageBox.Show("fail");
                }
                else
                {
                    textBox2.Text = dr["M_name"].ToString();
                    textBox3.Text = dr["M_sex"].ToString();
                    textBox4.Text = dr["M_born"].ToString();
                    textBox5.Text = dr["M_dead"].ToString();
                    textBox6.Text = dr["M_brpl"].ToString();
                    textBox7.Text = dr["M_lvpl"].ToString();
                    textBox8.Text = dr["M_rank"].ToString();
                    textBox9.Text = dr["M_gnum"].ToString();
                    textBox10.Text = dr["Ge_id"].ToString();
                    textBox11.Text = dr["M_faid"].ToString();
                  
                }

                
            }
        }
    }
}
